using curso_alura_bytebank_adm_csharp_console.employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_alura_bytebank_adm_csharp_console.internalSystem
{
    public interface IAuthenticable
    {

        public string password { get; set; }

        public abstract bool Authenticate(string password);
    }
}
