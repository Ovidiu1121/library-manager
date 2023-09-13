using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema89_LibraryManager.exceptions
{
    internal class UserExistentException:Exception
    {
        public UserExistentException() { }

        public UserExistentException(string message) : base(message) { }

        public UserExistentException(string message, Exception innerException) : base(message, innerException) { }

    }
}
