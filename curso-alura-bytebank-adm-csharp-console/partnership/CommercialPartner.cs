using curso_alura_bytebank_adm_csharp_console.internalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_alura_bytebank_adm_csharp_console.partnership
{
    public class CommercialPartner : IAuthenticable
    {
        public string password { get; set; }

        public bool Authenticate(string password)
        {
            return this.password == password;
        }
    }
}
