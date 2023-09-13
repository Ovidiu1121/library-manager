using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema89_LibraryManager.book.service
{
    public class BookServiceSingleton
    {

        private static readonly Lazy<BookService> _instance = new Lazy<BookService>(() => new BookService());

        public static BookService Instance => _instance.Value;

        private BookServiceSingleton()
        {
            // Private constructor to prevent external instantiation
        }

    }
}
