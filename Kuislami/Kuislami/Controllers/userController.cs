using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Kuislami.Models;

namespace Kuislami.Controllers
{
    public  class userController
    {
        private static string userFile = "users.json";

        public  user Login()
        {
            List<user> users = JsonConvert.DeserializeObject<List<user>>(File.ReadAllText(userFile));

            while (true)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                user found = users.Find(u => u.Username == username && u.Password == password);
                if (found != null)
                {
                    Console.WriteLine("✅ Login berhasil!\n");
                    return found;
                }

                Console.WriteLine("❌ Username atau password salah. Coba lagi.\n");
            }
        }
    }
}
