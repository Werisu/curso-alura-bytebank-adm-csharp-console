using curso_alura_bytebank_adm_csharp_console.internalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_alura_bytebank_adm_csharp_console.employee
{
    public class AccountManager : AuthenticatedEmployee
    {
        public AccountManager(string name, string cpf) : base(name, cpf, 4000)
        {
        }

        public override double GetBonus()
        {
            return this.salary * 0.25;
        }

        public override void IncreaseSalary()
        {
            this.salary *= 1.05;
        }
    }
}
