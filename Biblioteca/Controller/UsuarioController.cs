using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    class UsuarioController
    {
        internal void persist(USUARIO usuario)
        {
            var db = new bibliotecaEntities();
            if (usuario.id != 0)
            {
                db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            }
            else
                db.USUARIO.Add(usuario);

            db.SaveChanges();
        }

        internal void delete(int id)
        {
            var db = new bibliotecaEntities();
            var usuario = new USUARIO();
            usuario.id = id;
            db.Entry(usuario).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
        internal USUARIO getByID(int id)
        {
            var db = new bibliotecaEntities();
            return (from user in db.USUARIO
                           where user.id == id
                           select user).FirstOrDefault();

        }
        internal USUARIO login(String nome, String senha)
        {
            var db = new bibliotecaEntities();
            return (from user in db.USUARIO
                    where user.nome == nome
                    & user.senha == senha
                    select user).FirstOrDefault();
        }
        internal bool possuiAtrasos(USUARIO usuario)
        {
            return usuario.EMPRESTIMO.Any(emp => emp.dtPrazoDevolucao < DateTime.Now.Date 
                                                                & emp.dtDevolucao == null);
        }

        internal bool possuiMulta(USUARIO usuario)
        {
            return (from e in usuario.EMPRESTIMO
                    where e.MULTA != null 
                    select e).Any();
        }

        internal bool limiteEmprestimosAtingido(USUARIO usuario)
        {
            return usuario.EMPRESTIMO != null && usuario.EMPRESTIMO.Count(e=>e.dtDevolucao==null) >= usuario.PERFIL.qtLivros;
        }
    }
}
