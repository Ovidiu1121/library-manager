using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema89_LibraryManager.Interfaces;

namespace Tema89_LibraryManager.models
{
    public class User:IComparable<User>,IUserBuilder
    {
        private int id;
        private string name;
        private string email;
        private string password;
        private string role;

        public User()
        {

        }
        public User(string name, string email,string password, string role)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }
        public User(int id,string name, string email, string password, string role)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        public int CompareTo(User other)
        {
           return this.id.CompareTo(other.id);
        }
        public override string ToString()
        {
            return this.name;
        }
        public override bool Equals(object obj)
        {

            User user=obj as User;

            return user.name.Equals(this.name);

        }

        public User setEmail(string email)
        {
            this.email=email;
            return this;
        }
        public User setId(int id)
        {
           this.id = id;
            return this;
        }
        public User setName(string name)
        {
            this.name = name;
            return this;
        }
        public User setPassword(string password)
        {
            this.password = password;
            return this;
        }
        public User setRole(string role)
        {
            this.role = role;
            return this;
        }
    }
}
