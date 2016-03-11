namespace Biblioteca.Controller
{
    class AutorController
    {
        public void persist(AUTOR autor)
        {
            var db = new bibliotecaEntities();
            if(autor.id != 0)
            {
                db.Entry(autor).State = System.Data.Entity.EntityState.Modified;
            }
            else
                db.AUTOR.Add(autor);

            db.SaveChanges();
        }

        internal void delete(int id)
        {
            var db = new bibliotecaEntities();
            var autor = new AUTOR();
            autor.id = id;
            db.Entry(autor).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
