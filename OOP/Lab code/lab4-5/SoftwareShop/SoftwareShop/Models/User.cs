namespace SoftwareShop.Models
{
    public class User
    {
        private int Id { get; set; }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
           set { _password = value; }
        }
        private bool _isAdmin;

        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }

        public string Role { get; set; }


        public User(int id, string name, string email, string password, bool isAdmin)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }
        public User() { }
    }
}
