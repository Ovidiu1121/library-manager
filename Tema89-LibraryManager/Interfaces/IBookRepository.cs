using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema89_LibraryManager.models;

namespace Tema89_LibraryManager.Interfaces
{
    public interface IBookRepository
    {
        void addBook(Book book);
        void updateBook(Book book);
        void deleteBook(int id);
        Book getBookById(int id);
        List<Book> getAllBooks();

    }
}
