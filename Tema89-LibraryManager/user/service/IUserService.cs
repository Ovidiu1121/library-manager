using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema89_LibraryManager.models;

namespace Tema89_LibraryManager.user.service
{
    public interface IUserService
    {
        void addUser(User user);
        void updateUser(User user);
        void deleteUser(int id);
        User getUserById(int id);
        List<User> getAllUsers();
        bool isUser(User user);
        User getUserByNumeParola(string nume, string parola);

    }
}
