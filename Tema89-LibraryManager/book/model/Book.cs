using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema89_LibraryManager.Interfaces;

namespace Tema89_LibraryManager.models
{
    public class Book:IComparable<Book>,IBookBuilder
    {
        private int id;
        private string title;
        private string author;
        private string genre;

        public Book() {
        
        }
        public Book(string title,string author,string genre)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
        }
        public Book(int id,string title, string author, string genre)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.genre = genre;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public string Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }

        public int CompareTo(Book other)
        {
            return this.id.CompareTo(other.id);
        }
        public override string ToString()
        {
            return this.title;
        }
        public override bool Equals(object obj)
        {
            Book book = obj as Book;

            return book.title.Equals(this.title);
        }

        public Book setAuthor(string author)
        {
           this.author=author;
            return this;
        }
        public Book setGenre(string genre)
        {
            this.genre=genre;
            return this;
        }
        public Book setId(int id)
        {
            this.id = id;
            return this;
        }
        public Book setTitle(string title)
        {
            this.title = title;
            return this;
        }
    }
}
