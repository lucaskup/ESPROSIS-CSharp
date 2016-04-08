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
                throw new UsuarioNaoLogadoException("Usuário não está logado no sistema.");
            }
                
            //recarrega dados do usuário
            usuario = c.getByID(usuario.id);

            if (exemplarDigitando.tipo == TipoExemplar.ConsultaInterna)
            {
                throw new ConsultaInternaException("Exemplar apenas para consulta interna.");
            }
            if (exemplarEmprestado(exemplarDigitando))
            {
                throw new ExemplarEmprestadoException("Exemplar emprestado");
            }
            if (possuiReserva(exemplarDigitando, usuario))
            {
                throw new LivroComReservaException("Livro com reserva.");
            }
            if (c.limiteEmprestimosAtingido(usuario))
            {
                throw new MaximoEmprestimosException("Usuário excedeu limite de empréstimos");
            }
            if (c.possuiAtrasos(usuario))
            {
                throw new PossuiAtrasosException("Usuário possui atrasos.");
            }
            if (c.possuiMulta(usuario))
            {
                throw new PossuiMultaException("Usuário possui multas em aberto.");
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
            emprestimo.dtDevolucao = DateTime.Now.Date;
            
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
    internal class UsuarioNaoLogadoException : Exception
    {
        public UsuarioNaoLogadoException()
        {
        }

        public UsuarioNaoLogadoException(string message) : base(message)
        {
        }

        public UsuarioNaoLogadoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UsuarioNaoLogadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class ExemplarEmprestadoException : Exception
    {
        public ExemplarEmprestadoException()
        {
        }

        public ExemplarEmprestadoException(string message) : base(message)
        {
        }

        public ExemplarEmprestadoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExemplarEmprestadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class PossuiMultaException : Exception
    {
        public PossuiMultaException()
        {
        }

        public PossuiMultaException(string message) : base(message)
        {
        }

        public PossuiMultaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PossuiMultaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class PossuiAtrasosException : Exception
    {
        public PossuiAtrasosException()
        {
        }

        public PossuiAtrasosException(string message) : base(message)
        {
        }

        public PossuiAtrasosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PossuiAtrasosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class MaximoEmprestimosException : Exception
    {
        public MaximoEmprestimosException()
        {
        }

        public MaximoEmprestimosException(string message) : base(message)
        {
        }

        public MaximoEmprestimosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MaximoEmprestimosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class LivroComReservaException : Exception
    {
        public LivroComReservaException()
        {
        }

        public LivroComReservaException(string message) : base(message)
        {
        }

        public LivroComReservaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LivroComReservaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class ConsultaInternaException : Exception
    {
        public ConsultaInternaException()
        {

        }

        public ConsultaInternaException(string message) : base(message)
        {
        }

        public ConsultaInternaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConsultaInternaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
