using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        [InverseProperty(nameof(Department.Manager))]
        public Department Department { get; set; } // Navigation Property
        // one to one relationship

        //public int WorkForId { get; set; } // Foreign Key
        [InverseProperty(nameof(Department.Employees))]
        public Department? WorkFor { get; set; } // Navigation Property


    }
}
