﻿using System;
using System.Data.Linq.Mapping;

namespace Okulova_CourseWork.entities
{
    [Table(Name = "Аренда")]
    class Rent
    {
        [Column(Name = "idСотрудник")]
        public int IdStaff { get; set; }

        [Column(Name = "idПользователь", IsPrimaryKey = true)]
        public int IdUsers { get; set; }

        [Column(Name = "idКнига", IsPrimaryKey = true)]
        public int IdBooks { get; set; }      // 

        [Column(Name = "Дата Выдачи", IsPrimaryKey = true)]
        public DateTime Issue { get; set; }

        [Column(Name = "Дата Возврата", CanBeNull = true)]
        public DateTime? Return { get; set; }        

        [Column(Name = "Количество", CanBeNull = false)]
        public int? Count { get; set; }
    }
}
