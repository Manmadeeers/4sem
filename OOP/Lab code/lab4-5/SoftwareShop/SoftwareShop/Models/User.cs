

namespace SoftwareShop.Models
{
    public class User
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private bool IsAdmin { get; set; }


        public User(int id, string name, string email, string password, bool isAdmin)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}
