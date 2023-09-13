using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema89_LibraryManager.exceptions
{
    internal class AutentificareException:Exception
    {
        public AutentificareException() { }

        public AutentificareException(string message) : base(message) { }

        public AutentificareException(string message, Exception innerException) : base(message, innerException) { }
    }
}
