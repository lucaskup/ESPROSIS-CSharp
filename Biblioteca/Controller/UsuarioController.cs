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
                           select user).FirstOrDefault(); ;

        }
    }
}
