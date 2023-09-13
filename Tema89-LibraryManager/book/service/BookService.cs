using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema89_LibraryManager.book.model;
using Tema89_LibraryManager.exceptions;
using Tema89_LibraryManager.models;
using Tema89_LibraryManager.Repository;
using Tema89_LibraryManager.utils;

namespace Tema89_LibraryManager.book.service
{
    public class BookService : IBookService
    {
        private BookRepository bookrepo;

        public BookService()
        {
            bookrepo = new BookRepository();
        }

        public void addBook(Book book)
        {
            List<Book> books = this.bookrepo.getAllBooks();

            foreach (Book b in books)
            {
                if (b.Equals(book))
                {
                    throw new CarteExistentaException(Constants.CARTE_EXISTENTA_EXCEPTION);
                }
            }

            this.bookrepo.addBook(book);    
        }

        public void deleteBook(int id)
        {
            List<Book> books = this.bookrepo.getAllBooks();
            bool flag = false;
            Book book=this.bookrepo.getBookById(id);

            foreach (Book b in books)
            {
                if (b.Equals(book))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new CarteInexistentException(Constants.CARTE_INEXISTENTA_EXCEPTION);
            }

            this.bookrepo.deleteBook(id);
        }

        public List<Book> getAllBooks()
        {
           List<Book>lista=this.bookrepo.getAllBooks();

            return lista;
        }

        public Book getBookById(int id)
        {
            List<Book> books = this.bookrepo.getAllBooks();
            bool flag = false;
            Book book = this.bookrepo.getBookById(id);

            foreach (Book b in books)
            {
                if (b.Equals(book))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new CarteInexistentException(Constants.CARTE_INEXISTENTA_EXCEPTION);
            }

            return book;
        }

        public void updateBook(Book book)
        {
            List<Book> books = this.bookrepo.getAllBooks();
            bool flag = false;

            foreach (Book b in books)
            {
                if (b.Equals(book))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new CarteInexistentException(Constants.CARTE_INEXISTENTA_EXCEPTION);
            }

            this.bookrepo.updateBook(book);
        }

    }
}
