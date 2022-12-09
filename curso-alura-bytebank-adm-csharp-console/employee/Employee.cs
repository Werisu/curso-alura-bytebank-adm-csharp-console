using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_alura_bytebank_adm_csharp_console.employee
{
    public abstract class Employee
    {
        public Employee(string name, string cpf, double salary)
        {
            this.name = name;
            this.cpf = cpf;
            this.salary = salary;
            totalEmployees++;
        }

        public string name { get; private set; }
        public string cpf { get; private set; }
        public double salary { get; protected set; }
        public static int totalEmployees { get; private set; }

        public abstract double GetBonus();

        public abstract void IncreaseSalary();
    }
}
