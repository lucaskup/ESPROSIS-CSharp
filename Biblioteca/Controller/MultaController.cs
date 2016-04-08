using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    class MultaController
    {
        public void persist(MULTA multa)
        {
            var db = new bibliotecaEntities();
            if (multa.id != 0)
            {
                db.Entry(multa).State = System.Data.Entity.EntityState.Modified;
            }
            else
                db.MULTA.Add(multa);

            db.SaveChanges();
        }
        internal MULTA getMultaByID(int idMulta)
        {
            var db = new bibliotecaEntities();

            return (from mu in db.MULTA.AsNoTracking()
                    where mu.id == idMulta
                    select mu).FirstOrDefault();

        }
        internal void abonar(int idMulta)
        {
            var multa = getMultaByID(idMulta);
            multa.abonado = true;
            persist(multa);
        }

        internal void pagar(int idMulta)
        {
            deletar(idMulta);
        }

        internal void deletar (int id)
        {
            var db = new bibliotecaEntities();
            var multa = new MULTA();
            multa.id = id;
            db.Entry(multa).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

    }
}
