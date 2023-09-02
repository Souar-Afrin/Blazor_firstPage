namespace Blazor_firstPage.Server.Model
{
    public class User
    {
        //private static int nextId;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public User()
        {
            
        }
        public User(int id, string name, string email)
        {
            //Id = nextId++;
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
