namespace TASK_4.Models
{
    public class User
    {
        private User(Guid id, string name, string email, DateTime lastSeen, bool isActive, string password) {
            Id = id;
            Name = name;
            Email = email;
            LastSeen = lastSeen;
            IsActive = isActive;
            Password = password;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime LastSeen { get; set; }

        public bool IsActive { get; set; }

        public string Password { get; set; }

        public static User Create(Guid id, string name, string email, DateTime lastSeen, bool isActive, string password)
        {
            return new User(id, name, email, lastSeen, isActive, password);
        }
    }
}
