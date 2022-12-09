using curso_alura_bytebank_adm_csharp_console.internalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_alura_bytebank_adm_csharp_console.employee
{
    public abstract class AuthenticatedEmployee : Employee, IAuthenticable
    {
        protected AuthenticatedEmployee(string name, string cpf, double salary) : base(name, cpf, salary)
        {
        }

        public string password { get; set; }

        public bool Authenticate(string password)
        {
            return this.password == password;
        }
    }
}
