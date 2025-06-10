using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Models;  

namespace Quiz.Controllers
{
    class userController
    {
        private List<user> Users = new();
        private user? currentUser = null;

        public void Register()
        {
            Console.Write("Masukkan username: ");
            string username = Console.ReadLine()!;
            Console.Write("Masukkan password: ");
            string password = Console.ReadLine()!;
            Users.Add(new user { Username = username, Password = password, IsAdmin = false });
            Console.WriteLine("Registrasi berhasil!");
        }

        public bool Login()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine()!;
            Console.Write("Password: ");
            string password = Console.ReadLine()!;

            if (username == "admin" && password == "admin")
            {
                currentUser = new user { Username = "admin", IsAdmin = true };
                return true;
            }

            var user = Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                currentUser = user;
                return true;
            }

            Console.WriteLine("Login gagal.");
            return false;
        }

        //public List<user> GetTopUsers(int jumlah)
        //{
        //    return User.OrderByDescending(u => u.Skor).Take(jumlah).ToList();
        //}

        public void Logout() => currentUser = null;

        public user? GetCurrentUser() => currentUser;
    }
}
