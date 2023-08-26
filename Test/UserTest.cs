using Tema89_LibraryManager.models;
using Xunit;

namespace Test
{
    public class UserTest
    {

        [Fact]
        public void creareUser()
        {

            User user=new User().setId(2)
                .setName("nume")
                .setEmail("mail")
                .setPassword("parola")
                .setRole("rol");

            Assert.NotNull(user);
        }

        [Fact]
        public void compareTo()
        {

            User user = new User(4, "nume", "mail", "parola","rol");
            User user2 = new User(4, "nume", "mail", "parola", "rol");

            int test = user.CompareTo(user2);
            int expected = 0;

            Assert.Equal(expected, test);

        }

        [Fact]
        public void toString()
        {
            User user = new User(4, "nume", "mail", "parola", "rol");

            string text = user.ToString();
            string expected = "nume";

            Assert.Equal(expected, text);
        }

        [Fact]
        public void equals()
        {
            User user = new User(4, "nume", "mail", "parola", "rol");
            User user2 = new User(4, "nume", "mail", "parola", "rol");

            bool test = user.Equals(user2);
            bool expected = true;

            Assert.Equal(expected, test);

        }


    }
}
