using Okulova_CourseWork.entities;
using System.Data.Linq;
using System.Linq;

namespace Okulova_CourseWork.dbHelper
{
    class DB
    {
        private static string _connectionString =
           @"Data Source=.\SQLEXPRESS;Initial Catalog=OKULOVA_KURSACH;Integrated Security=True";
        private readonly DataContext Dc = new DataContext(_connectionString);

        public Table<Authors> GetAuthorsTable()
        {
            return Dc.GetTable<Authors>();
        }
        public Table<Users> GetUsersTable()
        {
            return Dc.GetTable<Users>();
        }
        public Table<Staff> GetStaffTable()
        {
            return Dc.GetTable<Staff>();
        }
        public Table<Books> GetBooksTable()
        {
            return Dc.GetTable<Books>();
        }        
        public Table<Rent> GetRentTable()
        {
            return Dc.GetTable<Rent>();
        }     
        public Table<Author_Book> GetAuthor_BooksTable()
        {
            return Dc.GetTable<Author_Book>();
        }
        public IQueryable GetBooksWithAuthorsTable()
        {
            return
                from c in GetBooksTable()
                join Author_Book in GetAuthor_BooksTable()
                on c.Id equals Author_Book.IdBooks
                join Author in GetAuthorsTable()
                on Author_Book.IdAuthors equals Author.Id
                select new { c.Id, c.Title, c.Genre, c.Release, c.Count, Author.FirstName, Author.LastName };
        }
        public IQueryable GetPassword(string Pass)
        {
            return
                from staff in GetStaffTable() where staff.Passport == Pass
                select new { staff.Password };
        }
    }
}
