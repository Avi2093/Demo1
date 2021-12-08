using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Models
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        [ForeignKey("DepartmentId")]
        public Department department { get; set; }




    }
}
