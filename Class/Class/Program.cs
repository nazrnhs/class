using Class.DAL;
using Class.Models;
using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InsertBook();

            DeleteBook(1);
        }

        static void InsertBook()
        {
            AppObContext db = new AppObContext();
            db.Books.Add(new Book { Name="Elantris", Janre="fantastik", PageNumber=638, Price=21.5});
            db.SaveChanges();
        }


        static bool DeleteBook(int id)
        {
            AppObContext db = new AppObContext();
            Book? book = db.Books.Find(id);
            db.Books.Remove(book);
            var result = db.SaveChanges() > 0;
            return result;
        }

    }
}
