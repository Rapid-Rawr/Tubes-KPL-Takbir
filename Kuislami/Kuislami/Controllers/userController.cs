using Quiz.Models;
using System.Text.Json;

namespace Quiz.Controllers
{
    class userController
    {
        private readonly string filePath = "users.json";
        private List<user> Users = new();
        private user? currentUser = null;

        private void LoadUsers()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                //Console.WriteLine("ISI JSON: " + json); // DEBUG
                var data = JsonSerializer.Deserialize<List<user>>(json);
                if (data != null)
                    Users = data;
                //Console.WriteLine("Jumlah user yang dimuat: " + Users.Count); // DEBUG
            }
            //else
            //{
            //    Console.WriteLine("File users.json tidak ditemukan!"); // DEBUG
            //}
        }

        public userController()
        {
            LoadUsers();
        }

        public void Register()
        {
            Console.Write("Masukkan username: ");
            string username = Console.ReadLine()!;
            Console.Write("Masukkan password: ");
            string password = Console.ReadLine()!;

            Users.Add(new user { Username = username, Password = password, IsAdmin = false });
            SaveUsers(); 
            Console.WriteLine("Registrasi berhasil!");
        }


        public bool Login()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine()!;
            Console.Write("Password: ");
            string password = Console.ReadLine()!;

            var user = Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                currentUser = user;
                return true;
            }

            Console.WriteLine("Login gagal.");
            return false;
        }

        public List<user> GetTopUsers(int jumlah)
        {
            return Users
                .Where(u => !u.IsAdmin) // filter non-admin
                .OrderByDescending(u => u.Skor)
                .Take(jumlah)
                .ToList();
        }


        private void SaveUsers()
        {
            string json = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void UpdateCurrentUserSkor(int skorBaru)
        {
            if (currentUser != null)
            {
                currentUser.Skor = skorBaru;
                SaveUsers();
            }
        }

        public void Logout() => currentUser = null;

        public user? GetCurrentUser() => currentUser;
    }
}
