namespace GroupOneMovieStoreAppFinal
{
    public class User
    {
        public string Username { get; set; }
        public bool IsAdmin { get; set; }

        public User() { }

        public User(string username, bool isAdmin)
        {
            Username = username;
            IsAdmin = isAdmin;
        }

        public override string ToString() => Username;
    }
}
