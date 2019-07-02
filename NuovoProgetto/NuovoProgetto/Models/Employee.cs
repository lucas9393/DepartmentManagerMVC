using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuovoProgetto.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }  //EF ti tira su Department
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}