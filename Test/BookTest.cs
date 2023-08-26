using Tema89_LibraryManager.models;
using Xunit;

namespace Test
{
    public class BookTest
    {
        [Fact]
        public void creareBook()
        {

            Book book = new Book().setId(1)
                .setTitle("titlu")
                .setAuthor("autor")
                .setGenre("gen");

            Assert.NotNull(book);

        }

        [Fact]
        public void compareTo()
        {

            Book book=new Book(4,"titlu","autor","gen");
            Book book2 = new Book(4, "titlu", "autor", "gen");

            int test=book.CompareTo(book2);
            int expected = 0;

            Assert.Equal(expected, test);

        }

        [Fact]
        public void toString()
        {
            Book book = new Book(4, "titlu", "autor", "gen");

            string text=book.ToString();
            string expected = "titlu";

            Assert.Equal(expected, text);
        }

        [Fact]
        public void equals()
        {
            Book book = new Book(4, "titlu", "autor", "gen");
            Book book2 = new Book(7, "titlu", "autor", "gen");

            bool test=book.Equals(book2);
            bool expected = true;

            Assert.Equal(expected, test);

        }


    }
}