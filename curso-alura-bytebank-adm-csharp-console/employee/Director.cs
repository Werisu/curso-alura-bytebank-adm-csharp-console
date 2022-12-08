using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_alura_bytebank_adm_csharp_console.employee
{
    public class Director : Employee
    {
        public Director(string name, string cpf, double salary, int type) : base(name, cpf, salary, type)
        {
        }
    }
}
