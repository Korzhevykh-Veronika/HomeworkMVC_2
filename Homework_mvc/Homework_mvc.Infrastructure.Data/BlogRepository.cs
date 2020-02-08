using Homework_mvc.Entity.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_mvc.Infrastructure.Data
{
    public class BookRepository : IRepository<>
    {
        private BlogContext db;

        public BookRepository(BlogContext context)
        {
            this.db = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return db.Books;
        }

        public Book Get(int id)
        {
            return db.Books.Find(id);
        }

        public void Create(Book book)
        {
            db.Books.Add(book);
        }

        public void Update(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Book book = db.Books.Find(id);
            if (book != null)
                db.Books.Remove(book);
        }
    }

}

