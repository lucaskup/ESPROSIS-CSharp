using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    class EmprestimoController
    {
        public void persist(EMPRESTIMO emprestimo)
        {
            using (var db = new bibliotecaEntities())
            {
                if (emprestimo.id != 0)
                {
                    db.Entry(emprestimo).State = System.Data.Entity.EntityState.Modified;                  
                }
                else
                {
                    db.EMPRESTIMO.Add(emprestimo);
                }
                    
                db.SaveChanges();
            }
            
           
        }
        internal bool permiteEmprestimo(EXEMPLAR exemplarDigitando, USUARIO usuario)
        {

            UsuarioController c = new UsuarioController();

            if(usuario == null)
            {
                throw new EmprestimoFalhouException("Usuário não está logado no sistema.");
            }
                
            //recarrega dados do usuário
            usuario = c.getByID(usuario.id);

            if(exemplarDigitando == null)
            {
                throw new EmprestimoFalhouException("Exemplar inválido");
            }
            if (exemplarDigitando.tipo == TipoExemplar.ConsultaInterna)
            {
                throw new EmprestimoFalhouException("Exemplar apenas para consulta interna.");
            }
            if (exemplarEmprestado(exemplarDigitando))
            {
                throw new EmprestimoFalhouException("Exemplar emprestado");
            }
            if (possuiReserva(exemplarDigitando, usuario))
            {
                throw new EmprestimoFalhouException("Livro com reserva.");
            }
            if (c.limiteEmprestimosAtingido(usuario))
            {
                throw new EmprestimoFalhouException("Usuário excedeu limite de empréstimos");
            }
            if (c.possuiAtrasos(usuario))
            {
                throw new EmprestimoFalhouException("Usuário possui atrasos.");
            }
            if (c.possuiMulta(usuario))
            {
                throw new EmprestimoFalhouException("Usuário possui multas em aberto.");
            }
            return true;
        }

        private bool exemplarEmprestado(EXEMPLAR exemplarDigitando)
        {
            using(var db = new bibliotecaEntities())
            {
                return (from e in db.EMPRESTIMO
                        where e.EXEMPLAR.id == exemplarDigitando.id
                        & e.dtDevolucao == null
                        select e).Any();

            }
        }

        internal void registrarEmprestimo(EXEMPLAR exemplarDigitando, USUARIO usuarioLogado)
        {
            if (permiteEmprestimo(exemplarDigitando, usuarioLogado))
            {

                EMPRESTIMO e = new EMPRESTIMO();
                e.fkExemplar = exemplarDigitando.id;
                e.dtEmprestimo = DateTime.Now.Date;
                e.dtPrazoDevolucao = e.dtEmprestimo.AddDays(usuarioLogado.PERFIL.diasParaEmprestimo);
                e.fkUsuario = usuarioLogado.id;

                persist(e);

            }

        }

        private bool possuiReserva(EXEMPLAR exemplarDigitando, USUARIO usuario)
        {
            var reserva = (from r in exemplarDigitando.LIVRO.RESERVA
                           orderby r.id
                           select r).FirstOrDefault();
            //retorna verdadeiro se possuir uma reserva para outro usuário
            return reserva != null && !reserva.USUARIO.Equals(usuario);

        }

        internal EMPRESTIMO getEmprestimo(int idExemplar)
        {
            var db = new bibliotecaEntities();
            
                
            return (from em in db.EMPRESTIMO.AsNoTracking()
                    where em.dtDevolucao == null
                    && em.fkExemplar == idExemplar
                    select em).FirstOrDefault();
                

            
        }

        internal void devolver(EMPRESTIMO emprestimo)
        {
            if (emprestimo == null)
                throw new DevolucaoFalhouException("Exemplar não está emprestado");
            emprestimo.dtDevolucao = DateTime.Now.Date;
            //Se está devolvendo depois do prazo de devolução deve gerar multa
            if (emprestimo.dtDevolucao > emprestimo.dtPrazoDevolucao)
            {
                MULTA m = new MULTA();
                m.vencimento = DateTime.Now.AddDays(emprestimo.USUARIO.PERFIL.diasParaEmprestimo);
                m.valor = emprestimo.USUARIO.PERFIL.valorMulta * (int)(DateTime.Now.Date - emprestimo.dtPrazoDevolucao).TotalDays;

                Controller.MultaController mc = new Controller.MultaController();
                mc.persist(m);
                emprestimo.fkMulta = m.id;
            }
            persist(emprestimo);

        }
    }

    [Serializable]
    internal class DevolucaoFalhouException : Exception
    {
        public DevolucaoFalhouException()
        {
        }

        public DevolucaoFalhouException(string message) : base(message)
        {
        }

        public DevolucaoFalhouException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DevolucaoFalhouException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class EmprestimoFalhouException : Exception
    {
        public EmprestimoFalhouException()
        {
        }

        public EmprestimoFalhouException(string message) : base(message)
        {
        }

        public EmprestimoFalhouException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmprestimoFalhouException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
