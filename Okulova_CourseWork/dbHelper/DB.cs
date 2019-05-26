using Okulova_CourseWork.entities;
using System.Data.Linq;
using System.Linq;
using System;
using System.Windows.Forms;

namespace Okulova_CourseWork.dbHelper
{
    class DB
    {
        private static readonly string _connectionString =
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
                select new
                {
                    c.Id,
                    c.Title,
                    c.Genre,
                    c.Release,
                    c.Count,
                    Author.FirstName,
                    Author.LastName,
                    Current_Count = c.Count - (from rent in GetRentTable()
                                                  //where c.Id == good.IdBooks
                                                  select rent.Count).Sum()
                };
        }

        public IQueryable GetPassword(string Pass)
        {
            return
                from staff in GetStaffTable() where staff.Passport == Pass
                select new { staff.Password};
        }

        public void Addbook(Books book1)
        {
            GetBooksTable().InsertOnSubmit(book1);
            Dc.SubmitChanges();
        }

        public void AddAuthor_Book(int idBook, int idAuthor)
        {
            Author_Book authbook = new Author_Book
            {
                IdAuthors = idAuthor,
                IdBooks = idBook,
            };
            GetAuthor_BooksTable().InsertOnSubmit(authbook);
            Dc.SubmitChanges();
        }

        public void AddAuthor(string LastName, string FirstName, string Patronymic, string Country)
        {
            Authors author = new Authors
            {
                LastName = LastName,
                FirstName = FirstName,
                Patronymic = Patronymic,
                Country = Country
            };
            GetAuthorsTable().InsertOnSubmit(author);
            Dc.SubmitChanges();
        }

        public void AddUser(string FirstName, string LastName, string PhoneNumber, string Adress, DateTime Birthday)
        {
            Users user = new Users
            {
                FirstName = FirstName,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                Adress = Adress,
                Birthday = Birthday
            };
            GetUsersTable().InsertOnSubmit(user);
            Dc.SubmitChanges();
        }

        public void AddStaff(string FirstName, string LastName, string PhoneNumber, DateTime Birthday, string Passport)
        {
            Staff staff = new Staff
            {
                FirstName = FirstName,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                Birthday = Birthday,
                Passport = Passport,
                Password = Passport
            };
            GetStaffTable().InsertOnSubmit(staff);
            Dc.SubmitChanges();
        }

        public void AddRent(int IdStaff, int IdUser, int IdBook, DateTime Issue, DateTime Return, int Count)
        {
            Rent rent = new Rent
            {
                Count = Count,
                IdBooks = IdBook,
                IdStaff = IdStaff,
                IdUsers = IdUser,
                Issue = Issue,
                Return = Return,
            };
            GetRentTable().InsertOnSubmit(rent);
            Dc.SubmitChanges();
        }

        public void DeleteBook(int idBook)
        {
            // deleting from Author_Book table
            var query = from c in GetAuthor_BooksTable()
                        where c.IdBooks == idBook
                        select c;
            foreach (var detail in query)
            {
                GetAuthor_BooksTable().DeleteOnSubmit(detail);
            }
            Dc.SubmitChanges();
            // deleting from Rent table
            var query1 = from q in GetRentTable()
                        where q.IdBooks == idBook
                        select q;
            foreach(var detail in query1)
            {
                GetRentTable().DeleteOnSubmit(detail);
            }
            Dc.SubmitChanges();
            // deleting from Books table
            var query2 = from q in GetBooksTable()
                         where q.Id == idBook
                         select q;
            GetBooksTable().DeleteOnSubmit(query2.FirstOrDefault());            
            Dc.SubmitChanges();
        }

        public void DeleteAuthor(int IdAuthor)
        {
            var query = from c in GetAuthor_BooksTable()
                        where c.IdAuthors == IdAuthor
                        select c;
            foreach (var detail in query)
            {
                GetAuthor_BooksTable().DeleteOnSubmit(detail);
            }
            Dc.SubmitChanges();
            ////////////////////////////////////
            var query1 = from c in GetAuthorsTable()
                         where c.Id == IdAuthor
                         select c;
            GetAuthorsTable().DeleteOnSubmit(query1.FirstOrDefault());
            Dc.SubmitChanges();
        }

        public void DeleteUser(int IdUser)
        {
            // deleting from Rent table
            var query1 = from q in GetRentTable()
                         where q.IdUsers == IdUser
                         select q;
            foreach (var detail in query1)
            {
                GetRentTable().DeleteOnSubmit(detail);
            }
            Dc.SubmitChanges();
            // deleting from Users table
            var query2 = from q in GetUsersTable()
                         where q.Id == IdUser
                         select q;
            GetUsersTable().DeleteOnSubmit(query2.FirstOrDefault());
            Dc.SubmitChanges();
        }

        public void DeleteStaff(int IdStaff)
        {
            // deleting from Rent table
            var query1 = from q in GetRentTable()
                         where q.IdStaff == IdStaff
                         select q;
            foreach (var detail in query1)
            {
                GetRentTable().DeleteOnSubmit(detail);
            }
            Dc.SubmitChanges();
            // deleting from Staff table
            var query2 = from q in GetStaffTable()
                         where q.Id == IdStaff
                         select q;
            GetStaffTable().DeleteOnSubmit(query2.FirstOrDefault());
            Dc.SubmitChanges();
        }

        public void DeleteRent(int IdUser, int idBook)
        {
            // deleting from Rent table
            var query1 = from q in GetRentTable()
                         where q.IdUsers == IdUser && q.IdBooks == idBook
                         select q;
            foreach (var detail in query1)
            {
                GetRentTable().DeleteOnSubmit(detail);
            }
            Dc.SubmitChanges();
        }

        public void Changebook(int ID, string Title, string Genre, int? Release, int Count)
        {
            var query = from c in GetBooksTable()
                        where c.Id == ID
                        select c;
            foreach (Books book in query)
            {
                if (Title != null) book.Title = Title;
                if (Genre != null) book.Genre = Genre;
                if (Release != null) book.Release = Release;
                if (Count != 0) book.Count = Count;
                book.Id = ID;
            }            
            Dc.SubmitChanges();
        }

        public void ChangeAuthor(int ID, string LastName, string FirstName, string Patronymic, string Country)
        {
            var query = from c in GetAuthorsTable()
                        where c.Id == ID
                        select c;
            foreach (Authors author in query)
            {
                if (LastName != null) author.LastName = LastName;
                if (FirstName != null) author.FirstName = FirstName;
                if (Patronymic != null) author.Patronymic = Patronymic;
                if (Country != null) author.Country = Country;
                author.Id = ID;
            }
            Dc.SubmitChanges();
        }

        public void ChangeUser(int ID, string FirstName, string LastName, string PhoneNumber, string Adress, DateTime Birthday)
        {
            var query = from c in GetUsersTable()
                        where c.Id == ID
                        select c;
            foreach (Users user in query)
            {
                if (LastName != null) user.LastName = LastName;
                if (FirstName != null) user.FirstName = FirstName;
                if (PhoneNumber != null) user.PhoneNumber = PhoneNumber;
                if (Adress != null) user.Adress = Adress;
                if (Birthday != null) user.Birthday = Birthday;
                user.Id = ID;
            }
            Dc.SubmitChanges();
        }

        public void ChangeStaff(int ID, string FirstName, string LastName, string PhoneNumber, DateTime Birthday, string Passport)
        {
            var query = from c in GetStaffTable()
                        where c.Id == ID
                        select c;
            foreach (Staff staff in query)
            {
                if (LastName != null) staff.LastName = LastName;
                if (FirstName != null) staff.FirstName = FirstName;
                if (PhoneNumber != null) staff.PhoneNumber = PhoneNumber;
                if (Passport != null) staff.Passport = Passport;
                if (Birthday != null) staff.Birthday = Birthday;
                staff.Id = ID;
            }
            Dc.SubmitChanges();
        }

        public void ChangePassword(int b, string s)
        {
            var query = from c in GetStaffTable()
                        where c.Id == b
                        select c;
            foreach (Staff staff in query)
            {
                staff.Birthday = query.FirstOrDefault().Birthday;
                staff.FirstName = query.FirstOrDefault().FirstName;
                staff.LastName = query.FirstOrDefault().LastName;
                staff.Passport = query.FirstOrDefault().Passport;
                staff.PhoneNumber = query.FirstOrDefault().PhoneNumber;
                staff.Id = b;
            }
            Dc.SubmitChanges();
        }
    }
}
