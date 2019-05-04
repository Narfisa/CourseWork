using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
