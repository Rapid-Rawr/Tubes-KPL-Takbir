using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Utilities;

namespace WinFormsApp1.Views.Forms
{
    public partial class Register : Form
    {
        private const string UserFilePath = "users.json";
        private List<Users> userList;
        public Register()
        {
            InitializeComponent();
            userList = JsonHelper.LoadFromFile<List<Users>>(UserFilePath) ?? new List<Users>();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password wajib diisi.");
                return;
            }

            if (userList.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Username sudah terdaftar. Gunakan username lain.");
                return;
            }

            int newId = userList.Count > 0 ? userList.Max(u => u.Id) + 1 : 1;

            userList.Add(new Users
            {
                Id = newId,
                Username = username,
                Password = password
            });

            JsonHelper.SaveToFile(UserFilePath, userList);

            MessageBox.Show("Registrasi berhasil! Silakan login.");
            new Login().Show();
            this.Hide();
        }

        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
