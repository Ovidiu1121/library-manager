using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema89_LibraryManager.models;

namespace Tema89_LibraryManager.Interfaces
{
    public interface IUserBuilder
    {
        User setId(int id);
        User setName(string name);
        User setEmail(string email);
        User setPassword(string password);
        User setRole(string role);

    }
}
