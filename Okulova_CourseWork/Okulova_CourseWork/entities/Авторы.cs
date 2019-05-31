using System.Data.Linq.Mapping;

namespace Okulova_CourseWork.entities
{
    [Table(Name = "Авторы")]
    public class Authors
    {     
        [Column(Name = "idАвтор", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Фамилия")]
        public string LastName { get; set; }

        [Column(Name = "Имя")]
        public string FirstName { get; set; }

        [Column(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Column(Name = "Страна")]
        public string Country { get; set; }       
    }
}
