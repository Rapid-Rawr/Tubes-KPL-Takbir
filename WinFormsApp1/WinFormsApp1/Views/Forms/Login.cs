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
    public partial class Login : Form
    {
        private const string UserFilePath = "users.json";
        private readonly List<Users> userList;
        public Login()
        {
            InitializeComponent();
            userList = JsonHelper.LoadFromFile<List<Users>>(UserFilePath) ?? new List<Users>();
        }

        private void QuizzyLogo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void tbName_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password harus diisi.");
                return;
            }

            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Login sebagai Admin berhasil!");
                this.Hide();
                new WFAdmin().Show();
                return;
            }

            var user = userList.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                MessageBox.Show("Login berhasil!");
                this.Hide();
                new WFUser(user).Show();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
