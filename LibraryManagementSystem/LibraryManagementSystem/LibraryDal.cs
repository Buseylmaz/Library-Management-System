using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace LibraryManagementSystem
{
    class LibraryDal
    {
        //Ekleme güncelleme silme listeleme

        //List
        public List<Library> GetAll()
        {
            using (LibrariesContext context = new LibrariesContext())
            {
                return context.Library.ToList();
            }
        }


        //Search
        public List<Library> GetByName(string key) //direk veri tabanına sorgu atılıyor.
        {
            using (LibrariesContext context = new LibrariesContext())
            {
                return context.Library.Where(p => p.BookName.Contains(key)).ToList(); //context.Products demek direk bizim tablomuz
            }
        }

        //Add
        public void Add(Library library)
        {
            using (LibrariesContext context = new LibrariesContext())
            {

                context.Library.Add(library);
                context.SaveChanges();
            }
        }

        //Update
        public void Update(Library library)
        {
            using (LibrariesContext context = new LibrariesContext())
            {
                var entity = context.Entry(library); //context abone ol ürün için demek. Göndermiş oldugumuz productı veri tabanında ki product ile eşliyor
                entity.State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        //Delete
        public void Delete(Library library)
        {
            using (LibrariesContext context = new LibrariesContext())
            {
                var entity = context.Entry(library);
                entity.State = EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}
