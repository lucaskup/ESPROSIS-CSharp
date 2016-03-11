using System;

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
    }
}