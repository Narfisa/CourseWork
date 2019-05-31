using System;
using System.Data.Linq.Mapping;

namespace Okulova_CourseWork.entities
{
    [Table(Name = "Сотрудники")]
    class Staff
    {
        [Column(Name = "idСотрудник", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Имя")]
        public string FirstName { get; set; }

        [Column(Name = "Фамилия")]
        public string LastName { get; set; }

        [Column(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        [Column(Name = "ДатаРождения")]
        public DateTime Birthday { get; set; }

        [Column(Name = "Паспорт")]
        public string Passport { get; set; }

        [Column(Name = "Пароль")]
        public string Password { get; set; }
    } 
}
