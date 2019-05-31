using System.Data.Linq.Mapping;

namespace Okulova_CourseWork.entities
{
    [Table(Name = "Автор-книга")]
    public class Author_Book
    {
        [Column(Name = "idАвтор", IsPrimaryKey = true)]
        public int IdAuthors { get; set; }

        [Column(Name = "idКнига", IsPrimaryKey = true)]
        public int IdBooks { get; set; }
    }
}
