using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    class PerfilController
    {
        internal void persist(PERFIL perfil)
        {
            var db = new bibliotecaEntities();
            if (perfil.id != 0)
            {
                db.Entry(perfil).State = System.Data.Entity.EntityState.Modified;
            }
            else
                db.PERFIL.Add(perfil);

            db.SaveChanges();
        }

        internal void delete(int id)
        {
            var db = new bibliotecaEntities();
            var perfil = new PERFIL();
            perfil.id = id;
            db.Entry(perfil).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
