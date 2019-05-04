using System.Data.Linq.Mapping;

namespace Okulova_CourseWork.entities
{
    [Table(Name = "Книга")]
    public class Books
    {
        [Column(Name = "idКнига", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Название")]
        public string Title { get; set; }
        
        [Column(Name = "Жанр")]
        public string Genre { get; set; }
        
        [Column(Name = "Год Выпуска")]
        public int? Release { get; set; }
        
        [Column(Name = "Общее количество")]
        public int Count { get; set; }
    }
}
