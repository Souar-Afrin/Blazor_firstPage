using Blazor_firstPage.Server.Model;

namespace Blazor_firstPage.Server.MockData
{
    public class MockUser
    {
        private static List<User> users = new List<User>
        {
             new User(1, "John", ""),
             new User(2, "Mary", ""),
             new User(3, "Mike", "")
        };
        public static List<User> GetMockUser()
        {
            return users;
        }

    };
}

