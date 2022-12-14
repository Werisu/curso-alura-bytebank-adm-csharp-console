using curso_alura_bytebank_adm_csharp_console.internalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_alura_bytebank_adm_csharp_console.employee
{
    public class Director : AuthenticatedEmployee
    {
        public Director(string name, string cpf) : base(name, cpf, 5000)
        {
        }

        public override double GetBonus()
        {
            return this.salary * 0.5;
        }

        public override void IncreaseSalary()
        {
            this.salary *= 1.15;
        }
    }
}
