using curso_alura_bytebank_adm_csharp_console.employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_alura_bytebank_adm_csharp_console.utility
{
    public class BonusManager
    {
        public double totalBonus { get; private set; }

        public void Register(Employee employee)
        {
            this.totalBonus += employee.GetBonus();
        }
    }
}
