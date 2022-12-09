using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_alura_bytebank_adm_csharp_console.employee
{
    public class Assistant : Employee
    {
        public Assistant(string name, string cpf) : base(name, cpf, 2000)
        {
        }

        public override double GetBonus()
        {
            return this.salary * 0.2;
        }

        public override void IncreaseSalary()
        {
            this.salary *= 1.1;
        }
    }
}
