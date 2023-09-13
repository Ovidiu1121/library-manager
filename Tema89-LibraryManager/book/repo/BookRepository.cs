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
    public class BookRepository:IBookRepository
    {
        private string connectionString;
        private DataAccess dataAccess;

        public BookRepository()
        {
            this.dataAccess = new DataAccess();
            this.connectionString =GetConnection();
        }

        public void addBook(Book book)
        {
            string sql = "insert into book(title,author,genre) values(@title,@author,@genre)";

            this.dataAccess.SaveData(sql, new { book.Title, book.Author, book.Genre }, connectionString);
        }

        public void deleteBook(int id)
        {
            string sql = "delete from book where id=@id";

            this.dataAccess.SaveData(sql, new { id }, connectionString);
        }

        public void updateBook(Book book)
        {
            string sql = "update book set title=@title,author=@author,genre=@genre where id=@id";

            this.dataAccess.SaveData(sql, new { book.Title,book.Author,book.Genre, book.Id}, connectionString);
        }

        public List<Book> getAllBooks()
        {
            string sql = "select *from book";

            return dataAccess.LoadData<Book, dynamic>(sql, new { }, connectionString);
        }

        public Book getBookById(int id)
        {
            string sql = "select * from book where id=@id";

            return this.dataAccess.LoadData<Book, dynamic>(sql, new { id }, connectionString)[0];
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
