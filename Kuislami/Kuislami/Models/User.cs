namespace Quiz.Models
{
    class user
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public int Skor { get; set; } = 0;
    }
}
