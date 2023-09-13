using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema89_LibraryManager.exceptions
{
    public class CarteExistentaException:Exception
    {
        public CarteExistentaException() { }

        public CarteExistentaException(string message) : base(message) { }

        public CarteExistentaException(string message, Exception innerException) : base(message, innerException) { }

    }
}
