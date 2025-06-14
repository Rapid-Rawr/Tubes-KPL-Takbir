using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using WinFormsApp1.Utilities;

namespace WinFormsApp1.Controllers
{
    public static class UsersController
    {
        private static readonly string filePath = "users.json";
        private static List<Users> userList = JsonHelper.LoadFromFile<List<Users>>(filePath) ?? new List<Users>();

        public static List<Users> GetAllUsers() => userList;

        public static Users? GetUserByUsername(string username)
        {
            return userList.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        public static void RegisterUser(Users user)
        {
            userList.Add(user);
            SaveChanges();
        }

        public static bool Login(string username, string password)
        {
            return userList.Any(u => u.Username == username && u.Password == password);
        }

        public static void SaveChanges()
        {
            JsonHelper.SaveToFile(filePath, userList);
        }
    }

}
