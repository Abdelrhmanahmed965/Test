using System;
using System.Collections.Generic;

#nullable disable

namespace API_.Net5.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DeptId { get; set; }

        public virtual Department Dept { get; set; }
    }
}
