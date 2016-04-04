using System;
using System.Linq;
using System.Runtime.Serialization;

namespace Biblioteca.Controller
{
    class ExemplarController
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

    }

}