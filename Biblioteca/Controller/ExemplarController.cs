using System;
using System.Linq;
using System.Runtime.Serialization;

namespace Biblioteca.Controller
{
    internal class ExemplarController
    {
        internal void persist(EXEMPLAR exemplar)
        {
            var db = new bibliotecaEntities();
            if (exemplar.id != 0)
            {
                db.Entry(exemplar).State = System.Data.Entity.EntityState.Modified;
            }
            else
                db.EXEMPLAR.Add(exemplar);

            db.SaveChanges();
        }

        internal void delete(int id)
        {
            var db = new bibliotecaEntities();
            var exemplar = new EXEMPLAR();
            exemplar.id = id;
            db.Entry(exemplar).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        internal EXEMPLAR getByID(int id)
        {
            var db = new bibliotecaEntities();
            return (from e in db.EXEMPLAR
                     where e.id == id
                     select e).FirstOrDefault();
        }


        internal bool permiteEmprestimo(EXEMPLAR exemplarDigitando, USUARIO usuario) 
        {
            
            UsuarioController c = new UsuarioController();
            //recarrega dados do usuário
            usuario = c.getByID(usuario.id);

            if (exemplarDigitando.tipo == TipoExemplar.ConsultaInterna)
                throw new ConsultaInternaException("Exemplar apenas para consulta interna.");
            if (exemplarEmprestado(exemplarDigitando))
                throw new ExemplarEmprestadoException("Exemplar emprestado");
            if (possuiReserva(exemplarDigitando, usuario))
                throw new LivroComReservaException("Livro com reserva.");
            if (c.limiteEmprestimosAtingido(usuario))
                throw new MaximoEmprestimosException("Usuário excedeu limite de empréstimos");
            if (c.possuiAtrasos(usuario))
                throw new PossuiAtrasosException("Usuário possui atrasos.");
            if (c.possuiMulta(usuario))
                throw new PossuiMultaException("Usuário possui multas em aberto.");
            return true;
        }

        private bool exemplarEmprestado(EXEMPLAR exemplarDigitando)
        {
            var db = new bibliotecaEntities();
            return (from e in db.EMPRESTIMO
                    where e.EXEMPLAR.id == exemplarDigitando.id
                    & e.dtDevolucao == null
                    select e).Any();
        }

        internal void registrarEmprestimo(EXEMPLAR exemplarDigitando, USUARIO usuarioLogado)
        {
           if(permiteEmprestimo(exemplarDigitando, usuarioLogado))
            {
                
                EMPRESTIMO e = new EMPRESTIMO();
                e.fkExemplar = exemplarDigitando.id;
                e.dtEmprestimo = DateTime.Now.Date;
                e.dtPrazoDevolucao = e.dtEmprestimo.AddDays(usuarioLogado.PERFIL.diasParaEmprestimo);
                e.fkUsuario = usuarioLogado.id;

                var db = new bibliotecaEntities();
                db.EMPRESTIMO.Add(e);
                db.SaveChanges();

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