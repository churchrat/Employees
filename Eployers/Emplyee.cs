using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eployers
{
    public class Emplyee
    {
        private string name;
        private double salary;
        private string ocupation;
        private string department;
        public string Name { get { return name; } set { name = value; } }
        public double Salary { get {  return salary; } set {  salary = value; } }
        public string Ocupation { get {  return ocupation; } set {  ocupation = value; } }
        public string Department { get {  return department; } set {  department = value; } }

        public void Print()
        {
            Console.WriteLine($"{this.Name} {this.Salary} {this.Ocupation} {this.Department}");
        }
    }
}
