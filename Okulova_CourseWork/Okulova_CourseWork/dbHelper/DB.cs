using Okulova_CourseWork.entities;
using System.Data.Linq;
using System.Linq;
using System;

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
                    IDКНИГИ = c.Id, c.Title, c.Genre,
                    c.Release, c.Count, Author.FirstName, Author.LastName,
                    Current_Count = c.Count - ((from rent in GetRentTable()                                               
                                               where c.Id == rent.IdBooks
                                               select rent.Count).Sum() ?? 0)
                };
        }

        public IQueryable GetFullRentTable()
        {
            return
                from rent in GetRentTable()
                join book in GetBooksTable()
                on rent.IdBooks equals book.Id
                join staff in GetStaffTable()
                on rent.IdStaff equals staff.Id
                join user in GetUsersTable()
                on rent.IdUsers equals user.Id
                select new
                {
                    IdBook = book.Id, book.Title,
                    IdUser = user.Id,  UserName = user.LastName + " " + user.FirstName,
                    IDStaff = staff.Id, StaffName = staff.LastName + " " + staff.FirstName,
                    RentCount = rent.Count, IssueDate = rent.Issue,
                };
        }

        public int Login(string Passport, string Password)
        {
            var query = from c in GetStaffTable()
                        where c.Password == Password && c.Password == Password && c.Password == c.Passport
                        select c.Id;
            int idStaff = query.FirstOrDefault();
            if (idStaff != 0)
                return 0; // You can change your password....
            else
            {
                query = from c in GetStaffTable()
                        where c.Password == Password && c.Passport == Passport
                        select c.Id;
                idStaff = query.FirstOrDefault();
                if (idStaff == 0)
                    return -1; //Wrong passport or password
                else
                    return 1; // Found
            }
        }

        public int GetIdStaff(string Passport, string Password)
        {
           var query = from c in GetStaffTable()
                       where c.Password == Password && c.Passport == Passport
                       select c.Id;
            return query.FirstOrDefault();
        }

        public IQueryable Search(int Table, string s)
        {
            // 0 - books with authors and the current_count table
            // 1 - authors table
            // 2 - users table
            // 3 - staff's table
            // 4 - Rent with staff, book and users table
            switch(Table)
            {
                case 0:
                    return
                    from c in GetBooksTable()
                    join Author_Book in GetAuthor_BooksTable()
                    on c.Id equals Author_Book.IdBooks
                    join Author in GetAuthorsTable()
                    on Author_Book.IdAuthors equals Author.Id
                    where c.Title.StartsWith(s) || c.Genre.StartsWith(s) || Convert.ToString(c.Release).StartsWith(s)
                    || Convert.ToString(c.Count).StartsWith(s) || Author.FirstName.StartsWith(s) || Author.LastName.StartsWith(s)
                    select new { c.Id, c.Title, c.Genre, c.Release, c.Count, Author.FirstName, Author.LastName,
                        Current_Count = c.Count - ((from rent in GetRentTable()
                                                    where c.Id == rent.IdBooks
                                                    select rent.Count).Sum() ?? 0)
                    };                    
                case 1:
                    return
                    from c in GetAuthorsTable()
                    where c.LastName.StartsWith(s) || c.FirstName.StartsWith(s)
                    || c.Patronymic.StartsWith(s) || c.Country.StartsWith(s)
                    select c;
                case 2:
                    return
                    from c in GetUsersTable()
                    where c.LastName.StartsWith(s) || c.FirstName.StartsWith(s)
                    || c.PhoneNumber.StartsWith(s) || c.Adress.StartsWith(s) || Convert.ToString(c.Birthday).StartsWith(s)
                    select c;
                case 3:
                    return
                    from c in GetStaffTable()
                    where c.LastName.StartsWith(s) || c.FirstName.StartsWith(s)
                    || c.PhoneNumber.StartsWith(s)
                    select c;
                default:
                    return
                        from rent in GetRentTable()
                        join book in GetBooksTable()
                        on rent.IdBooks equals book.Id
                        join staff in GetStaffTable()
                        on rent.IdStaff equals staff.Id
                        join user in GetUsersTable()
                        on rent.IdUsers equals user.Id
                        where book.Title.StartsWith(s) || user.LastName.StartsWith(s) || user.FirstName.StartsWith(s)
                        || Convert.ToString(rent.Count).StartsWith(s) || Convert.ToString(rent.Issue).StartsWith(s)
                        select new
                        {
                            IdBook = book.Id, book.Title, IdUser = user.Id,
                            UserName = user.LastName + " " + user.FirstName,
                            IDStaff = staff.Id, StaffName = staff.LastName + " " + staff.FirstName,
                            RentCount = rent.Count, IssueDate = rent.Issue,
                        };
            }
        }

        public void Addbook(string Title, string Genre, int? Release, int Count)
        {
            Books book1 = new Books
            {
                Title = Title,
                Genre = Genre,
                Release = Release,
                Count = Count,
            };
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

        public void DeleteRent(int IdUser, int idBook, int count)
        {
            // Тут есть два случая:
            // 1. Мы возвращаем не все книги, в таком случае нужно изменить count
            // 2. Мы возвращаем все книги,  в таком случае нужно удалить всю запись.
            // deleting from Rent table
            var query = from q in GetRentTable()
                         where q.IdUsers == IdUser && q.IdBooks == idBook
                         select q.Count;
            // 2
            if (query.FirstOrDefault() == count)
            {
                var query1 = from q in GetRentTable()
                            where q.IdUsers == IdUser && q.IdBooks == idBook
                            select q;
                foreach (var detail in query1)
                {
                    GetRentTable().DeleteOnSubmit(detail);
                }
                Dc.SubmitChanges();
            }
            else
            {
                var query1 = from q in GetRentTable()
                             where q.IdUsers == IdUser && q.IdBooks == idBook
                             select q;
                if (query.FirstOrDefault() < count)
                    foreach(Rent rent in query1)
                    {
                        rent.Count = rent.Count - count;
                    }
            }

        }

        public void ChangeAuthorForBook(int IdBook, int IdAuthor)
        {
            var query = from c in GetAuthor_BooksTable()
                         where c.IdBooks == IdBook
                         select c;
            foreach (Author_Book a_b in query)
            {
                a_b.IdBooks = IdBook;
                a_b.IdAuthors = IdAuthor;
            }
            Dc.SubmitChanges();
        }

        public void Changebook(int ID, string Title, string Genre, int Release, int Count)
        {
            var query = from c in GetBooksTable()
                        where c.Id == ID
                        select c;
            foreach (Books book in query)
            {
                if (Title != "") book.Title = Title;
                if (Genre != "") book.Genre = Genre;
                if (Release != 0) book.Release = Release;
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
                if (LastName != "") author.LastName = LastName;
                if (FirstName != "") author.FirstName = FirstName;
                if (Patronymic != "") author.Patronymic = Patronymic;
                if (Country != "") author.Country = Country;
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
                if (LastName != "") user.LastName = LastName;
                if (FirstName != "") user.FirstName = FirstName;
                if (PhoneNumber != "") user.PhoneNumber = PhoneNumber;
                if (Adress != "") user.Adress = Adress;
                user.Birthday = Birthday;
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
                if (LastName != "") staff.LastName = LastName;
                if (FirstName != "") staff.FirstName = FirstName;
                if (PhoneNumber != "") staff.PhoneNumber = PhoneNumber;
                if (Passport != "") staff.Passport = Passport;
                staff.Birthday = Birthday;
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
