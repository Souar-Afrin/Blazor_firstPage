using Blazor_firstPage.Shared;

namespace Blazor_firstPage.Server.MockData
{
    public class MockUser
    {
        private static List<User> users = new List<User>
        {
             new User(1, "John", "test1@"),
             new User(2, "Mary", "test2@"),
             new User(3, "Mike", "test3@")
        };
        public static List<User> GetMockUser()
        {
            return users;
        }

    };
}

