using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema89_LibraryManager.models;

namespace Tema89_LibraryManager.Interfaces
{
    public interface IUserRepository
    {
        void addUser(User user);
        void updateUser(User user);
        void deleteUser(int id);
        User getUserById(int id);
        List<User> getAllUsers();

    }
}
