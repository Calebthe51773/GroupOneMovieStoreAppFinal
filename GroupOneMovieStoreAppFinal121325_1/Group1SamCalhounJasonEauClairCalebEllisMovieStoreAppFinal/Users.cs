namespace GroupOneMovieStoreAppFinal
{
    public class User
    {
        public string Username { get; set; }
        public bool IsAdmin { get; set; }

        public User(string username, bool isAdmin)
        {
            Username = username;
            IsAdmin = isAdmin;
        }
    }
}
