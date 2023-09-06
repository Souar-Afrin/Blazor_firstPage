using Blazor_firstPage.Server.MockData;
using Blazor_firstPage.Shared;

namespace Blazor_firstPage.Server.Service.UserService
{
    public class UserService
    {
        public List<User> Users { get; set; }

        public UserService()
        {
            Users = MockData.MockUser.GetMockUser();
        }

        public List<User> GetUsers()
        {
            return Users;
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void DeleteUser(int id)
        {
            Users.Remove(Users.Find(u => u.Id == id));
        }

        internal List<User> AddUser()
        {
            throw new NotImplementedException();
        }
    }
}