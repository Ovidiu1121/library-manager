using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema89_LibraryManager.data;
using Tema89_LibraryManager.Interfaces;
using Tema89_LibraryManager.models;

namespace Tema89_LibraryManager.Repository
{
    public class UserRepository : IUserRepository
    {
        private string connectionString;
        private DataAccess dataAccess;

        public UserRepository()
        {
            this.dataAccess = new DataAccess();
            this.connectionString =GetConnection();
        }

        public void addUser(User user)
        {
            string sql = "insert into user(name,email,password,role) values(@name,@email,@password,@role)";

            this.dataAccess.SaveData(sql, new { user.Name,user.Email,user.Password,user.Role }, connectionString);
        }

        public void deleteUser(int id)
        {
            string sql = "delete from user where id=@id";

            this.dataAccess.SaveData(sql, new { id }, connectionString);
        }

        public List<User> getAllUsers()
        {
            string sql = "select *from user";

            return dataAccess.LoadData<User, dynamic>(sql, new { }, connectionString);
        }

        public User getUserById(int id)
        {
            string sql = "select * from user where id=@id";

            return this.dataAccess.LoadData<User, dynamic>(sql, new { id }, connectionString)[0];
        }

        public void updateUser(User user)
        {
            string sql = "update user set name=@name,email=@email,password=@password,rolee=@role";

            this.dataAccess.SaveData(sql, new { user.Name, user.Email, user.Password, user.Role }, connectionString);
        }

        public string GetConnection()
        {
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            string connectionStringIs = configuration.GetConnectionString("Default");
            return connectionStringIs;
        }
    }
}
