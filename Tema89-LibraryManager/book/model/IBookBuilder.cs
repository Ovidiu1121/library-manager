using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema89_LibraryManager.models;

namespace Tema89_LibraryManager.Interfaces
{
    public interface IBookBuilder
    {
        Book setId(int id);
        Book setTitle(string title);
        Book setAuthor(string author);
        Book setGenre(string genre);

    }
}
