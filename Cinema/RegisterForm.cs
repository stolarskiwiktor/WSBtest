using Cinema.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Cinema
{
    partial class RegisterForm : Form
    {
        private static string UsersFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.json");

        public RegisterForm()
        {
            InitializeComponent();
            button2.Click += RegisterButton_Click;
            textBox3.PasswordChar = '*';
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox4.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (IsUsernameAvailable(username))
                {
                    List<User> existingUsers = LoadUsersFromJson(UsersFilePath);

                    string hashedPassword = HashPassword(password);

                    existingUsers.Add(new User(username, hashedPassword, firstName, lastName, new List<Reservation>()));

                    SaveUsersToJson(existingUsers, UsersFilePath);

                    MessageBox.Show("Rejestracja Udana!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nazwa już istnjieje.Proszę wybrać inną nazwę", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private static bool IsUsernameAvailable(string username)
        {
            List<User> existingUsers = LoadUsersFromJson(UsersFilePath);

            return !existingUsers.Any(user => user.username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }
        private static List<User> LoadUsersFromJson(string jsonFilePath)
        {
            List<User> existingUsers = new List<User>();

            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string jsonContent = File.ReadAllText(jsonFilePath);
                    existingUsers = JsonSerializer.Deserialize<List<User>>(jsonContent);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
            }

            return existingUsers;
        }

        private static void SaveUsersToJson(List<User> users, string jsonFilePath)
        {
            try
            {
                string jsonContent = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(jsonFilePath, jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving users: {ex.Message}");
            }
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
