using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Bonus { get; set; }
        public double Salary { get; set; }
        public double HourlyRate { get; set; }
        public int DepartmentId { get; set; }
    }
}
