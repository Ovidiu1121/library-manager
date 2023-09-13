using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema89_LibraryManager.exceptions
{
    public class CarteInexistentException:Exception
    {
        public CarteInexistentException() { }

        public CarteInexistentException(string message) : base(message) { }

        public CarteInexistentException(string message, Exception innerException) : base(message, innerException) { }


    }
}
