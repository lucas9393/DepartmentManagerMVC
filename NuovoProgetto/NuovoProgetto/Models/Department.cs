using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuovoProgetto.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Director { get; set; }
        public decimal Budget { get; set; }
        public bool IsCommercial { get; set; }
        public ICollection<Employee> Employees { get; set; }    //tutti gli impiegati di department
    }
}
