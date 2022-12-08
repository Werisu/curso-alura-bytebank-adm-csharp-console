using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_alura_bytebank_adm_csharp_console.employee
{
    public class Employee
    {
        public Employee(string name, string cpf, double salary, int type)
        {
            this.name = name;
            this.cpf = cpf;
            this.salary = salary;
            this.type = type;
        }

        public string name { get; private set; }
        public string cpf { get; private set; }
        public double salary { get; private set; }
        public int type { get; private set; }

        public double GetBonus()
        {
            if(this.type == 1)
            {
                return this.salary;
            }
            return this.salary * 0.10;
        }
    }
}
