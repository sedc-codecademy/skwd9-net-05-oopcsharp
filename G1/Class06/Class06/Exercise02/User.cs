namespace Exercise02
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; } = new string[3];

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;

            Messages = new[]
            {
                $"{Username}: First message",
                $"{Username}: Second message",
                $"{Username}: Third message"
            };
        }
    }
}
