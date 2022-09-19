using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
  public enum Posada
    {
        manager = 1,
        teacher
    } 
    public class Employee
    {
        private string name;
        private string surname;
        private double workPeriod;
        private Posada posada;
        private const int baseSalary = 5050;

        public Employee(string name, string surname, double workPeriod, Posada posada)
        {
            Name = name;
            Surname = surname;
            this.workPeriod = workPeriod;
            this.posada = posada;    
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public double Salary => baseSalary * (int)posada * 0.5 * (workPeriod / 1.5 + 1);
        public double Tax => Salary * 0.2;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Vlad", "Sidorchuk", 3.5, Posada.manager);
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine($"Tax: {employee.Tax}");
        }
    }
}
