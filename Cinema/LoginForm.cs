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
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinema
{
    public partial class LoginForm : Form
    {
        private List<User> users;
        public LoginForm()
        {
            InitializeComponent();
            button2.Click += button2_Click;
            textBox4.PasswordChar = '*';
            this.FormClosing += LoginForm_FormClosing;
            InitializeUsers();
        }

        private void InitializeUsers()
        {
            string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.json");

            if (File.Exists(userFilePath))
            {
                LoadUsersFromJson(userFilePath);
            }
            else
            {
                // Jeśli plik nie istnieje, utwórz go i dodaj przykładowego użytkownika
                string hashedPasswordTest = HashPassword("test123");
                users = new List<User> { new User("test", hashedPasswordTest, "Jan", "Kowalski", new List<Reservation>()) };

                SaveUsersToJson(userFilePath);
            }
        }

        private void LoadUsersFromJson(string jsonFilePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(jsonFilePath);
                users = JsonSerializer.Deserialize<List<User>>(jsonContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveUsersToJson(string jsonFilePath)
        {
            try
            {
                string jsonContent = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(jsonFilePath, jsonContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox4.Text;
            string hashedPassword = HashPassword(enteredPassword);

            // Sprawdź czy istnieje użytkownik o podanych danych
            User loggedInUser = users.FirstOrDefault(u => u.username == enteredUsername && u.password == hashedPassword);

            if (loggedInUser != null)
            {
                // Przejdź do kolejnego formularza, przekazując obiekt User
                Form1 form1 = new Form1(loggedInUser);
                form1.Show();
                this.Hide();
            }
            else
            {
                // Wyświetl komunikat o błędnych danych
                MessageBox.Show("Błędna nazwa użytkownika lub hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
