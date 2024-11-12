using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[ForeignKey("Manager")]
        [ForeignKey(nameof(Department.Manager))] // another way to write it
        public int EmpId { get; set; } // Foreign Key
        public Employee Manager { get; set; } // Navigation Property                              
        // must be ManagerId or EmployeeId to be recognized as foreign key by convention
        public List<Employee> Employees { get; set; } // Navigation Property

    }
}
