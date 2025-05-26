

namespace SoftwareShop.Models
{
    public class User
    {
        public int Id { get;set; }
        public string Name { get; set; }

        public string Email { get; set; } 
        public string Password { get; set; }
        public bool IsAdmin { get;set; }

        public string Role { get; set; }


        public User(int Id, string Name, string Email, string Password, bool IsAdmin)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.IsAdmin = IsAdmin;
        }
        public User() { }
    }
}
