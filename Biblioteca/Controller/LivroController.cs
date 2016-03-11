using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    class LivroController
    {
        internal void persist(LIVRO livro)
        {
            var db = new bibliotecaEntities();
            if (livro.id != 0)
            {
                db.Entry(livro).State = System.Data.Entity.EntityState.Modified;
            }
            else
                db.LIVRO.Add(livro);

            db.SaveChanges();
        }

        internal void delete(int id)
        {
            var db = new bibliotecaEntities();
            var livro = new LIVRO();
            livro.id = id;
            db.Entry(livro).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
