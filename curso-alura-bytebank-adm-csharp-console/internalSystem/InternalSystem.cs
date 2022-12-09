using curso_alura_bytebank_adm_csharp_console.employee;
using curso_alura_bytebank_adm_csharp_console.partnership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_alura_bytebank_adm_csharp_console.internalSystem
{
    public class InternalSystem
    {
        public bool Logar(IAuthenticable employee, string senha)
        {
            bool authenticatedUser = employee.Authenticate(senha);
            if (authenticatedUser)
            {
                Console.WriteLine("Boas vindas ao nosso sistema.");
                return true;
            } else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
