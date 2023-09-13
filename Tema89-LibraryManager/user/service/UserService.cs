using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema89_LibraryManager.exceptions;
using Tema89_LibraryManager.models;
using Tema89_LibraryManager.Repository;
using Tema89_LibraryManager.utils;

namespace Tema89_LibraryManager.user.service
{
    public class UserService : IUserService
    {

        public UserRepository userRepo;

        public UserService()
        {
            userRepo = new UserRepository();
        }

        public void addUser(User user)
        {
            List<User> users = this.userRepo.getAllUsers();

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    throw new UserExistentException(Constants.USER_EXISTENT_EXCEPTION);
                }
            }

            this.userRepo.addUser(user);
        }

        public void deleteUser(int id)
        {
            List<User> users = this.userRepo.getAllUsers();
            bool flag = false;
            User user = this.userRepo.getUserById(id);

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new UserInexistentException(Constants.USER_INEXISTENT_EXCEPTION);
            }

            this.userRepo.deleteUser(id);
        }

        public List<User> getAllUsers()
        {
            List<User> users = this.userRepo.getAllUsers();

            return users;
        }

        public User getUserById(int id)
        {
            List<User> users = this.userRepo.getAllUsers();
            bool flag = false;
            User user = this.userRepo.getUserById(id);

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new UserInexistentException(Constants.USER_INEXISTENT_EXCEPTION);
            }

            return user;
        }

        public void updateUser(User user)
        {
            List<User> users = this.userRepo.getAllUsers();
            bool flag = false;

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new UserInexistentException(Constants.USER_INEXISTENT_EXCEPTION);
            }

            this.userRepo.updateUser(user);
        }

        public bool isUser(User user)
        {
            List<User> users = this.userRepo.getAllUsers();
            bool flag = false;

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new UserInexistentException(Constants.USER_INEXISTENT_EXCEPTION);
            }

            return flag;
        }

        public User getUserByNumeParola(string nume, string parola)
        {
            List<User> users = this.userRepo.getAllUsers();
            bool flag = false;
            User user = this.userRepo.getUserByNumeParola(nume,parola);

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new UserInexistentException(Constants.USER_INEXISTENT_EXCEPTION);
            }

            return user;
        }
    }
}
