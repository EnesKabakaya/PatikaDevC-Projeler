namespace voting
{
    internal class Person
    {
        private string username;
        private string password;

        public Person(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get; internal set; }
        public string Password { get; internal set; }
    }
}