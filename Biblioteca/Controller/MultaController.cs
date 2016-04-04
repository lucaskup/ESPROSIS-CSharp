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
    }
}
