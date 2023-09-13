using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema89_LibraryManager.user.service
{
    public class UserServiceSingleton
    {
        private static readonly Lazy<UserService> _instance = new Lazy<UserService>(() => new UserService());

        public static UserService Instance => _instance.Value;

        private UserServiceSingleton()
        {

        }
    }
}
