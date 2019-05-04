using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulova_CourseWork.entities
{
    [Table(Name = "Аренда")]
    class Rent
    {
        [Column(Name = "idСотрудник", IsPrimaryKey = true)]
        public int IdStaff { get; set; }
        private EntityRef<Staff> _staff;
        [Association(ThisKey = "idСотрудник", Storage = "_staff")]
        public Staff Staff
        {
            get => _staff.Entity;
            internal set
            {
                _staff.Entity = value;
                IdStaff = value.Id;
            }
        }

        [Column(Name = "idПользователь", IsPrimaryKey = true)]
        public int IdUsers { get; set; }
        private EntityRef<Users> _users;
        [Association(ThisKey = "idПользователь", Storage = "_users")]
        public Users Users
        {
            get => _users.Entity;
            internal set
            {
                _users.Entity = value;
                IdUsers = value.Id;
            }
        }

        [Column(Name = "idКнига", IsPrimaryKey = true)]
        public int IdBooks { get; set; }
        private EntityRef<Books> _books;
        [Association(ThisKey = "idКнига", Storage = "_books")]
        public Books Books
        {
            get => _books.Entity;
            internal set
            {
                _books.Entity = value;
                IdBooks = value.Id;
            }
        }

        [Column(Name = "Дата Выдачи", IsPrimaryKey = true)]
        public DateTime Issue { get; set; }

        [Column(Name = "Дата Возврата")]
        public DateTime? Return { get; set; }

        [Column(Name = "Количество")]
        public int Count { get; set; }
    }
}
