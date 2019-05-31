using System;
using System.Data.Linq.Mapping;

namespace Okulova_CourseWork.entities
{
    [Table(Name = "Пользователи")]
    class Users
    {
        [Column(Name = "idПользователь", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Имя")]
        public string FirstName { get; set; }

        [Column(Name = "Фамилия")]
        public string LastName { get; set; }

        [Column(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        [Column(Name = "Адрес")]
        public string Adress { get; set; }

        [Column(Name = "ДатаРождения")]
        public DateTime Birthday { get; set; }
    }
}
