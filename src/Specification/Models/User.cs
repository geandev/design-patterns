namespace Specification.Models
{
    public class User
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public bool Archived { get; private set; }

        public User(string userName, string password, string email, bool archived)
        {
            UserName = userName;
            Password = password;
            Email = email;
            Archived = archived;
        }

        public void Archive()
        {
            Archived = true;
        }
    }
}
