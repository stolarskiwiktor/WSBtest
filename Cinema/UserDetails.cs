using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Classes;

namespace Cinema
{
    public partial class UserDetails : Form
    {
        private User loggedInUser;

        public UserDetails(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            button2.Click += Button2_Click;
            InitializeAccInfo();
            InitializeReservations();
        }

        private void InitializeAccInfo()
        {
            Label labelUserDetails = new Label();
            labelUserDetails.Text =
                $"Imię: {loggedInUser.name}\n" +
                $"Nazwisko: {loggedInUser.surname}\n" +
                $"Nazwa użytkownika: {loggedInUser.username}\n";
            labelUserDetails.ForeColor = Color.Black;
            labelUserDetails.Font = new Font("Segoe UI", 12f);
            labelUserDetails.AutoSize = true;

            panel2.Controls.Add(labelUserDetails);

            Button logoutButton = new Button();
            logoutButton.Text = "Wyloguj się";
            logoutButton.Font = new Font("Segoe UI", 12f);
            logoutButton.Size = new Size(150, 50);
            logoutButton.Location = new Point(10, panel2.Height - 60); // Adjust location as needed
            logoutButton.Click += LogoutButton_Click;

            panel2.Controls.Add(logoutButton);
        }

        private void InitializeReservations()
        {
            flowLayoutPanel1.WrapContents = true;
/*            flowLayoutPanel1.AutoSize = true;*/
            flowLayoutPanel1.AutoScroll = true; // Enable auto-scroll
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;



            foreach (Reservation reservation in loggedInUser.reservations)
            {
                Panel panel = new Panel();
                panel.BackColor = Color.Transparent;
                panel.Size = new Size(flowLayoutPanel1.ClientSize.Width - 20, 300);
                panel.Margin = new Padding(10);
                panel.BorderStyle = BorderStyle.FixedSingle;

                Label labelTitle = new Label();
                labelTitle.Text = $"Tytuł filmu: {reservation.Title}\n";
                labelTitle.ForeColor = Color.Black;
                labelTitle.Font = new Font("Segoe UI", 18f, FontStyle.Bold);
                labelTitle.AutoSize = true;
                labelTitle.Location = new Point(10, 10); // Adjust the location as needed

                panel.Controls.Add(labelTitle);

                Label labelRowSeat = new Label();
                labelRowSeat.Text = $"Rząd: {reservation.Seat.seat_row}, Miejsce: {reservation.Seat.seat_number}";
                labelRowSeat.AutoSize = true;
                labelRowSeat.Location = new Point(10, labelTitle.Bottom + 10); // Position below the title label

                Label labelTime = new Label();
                labelTime.Text = $"Czas: {reservation.Time.ToString("dd/MM/yyyy HH:mm")}";
                labelTime.AutoSize = true;
                labelTime.Location = new Point(10, labelRowSeat.Bottom + 10); // Position below the row seat label

                panel.Controls.Add(labelRowSeat);
                panel.Controls.Add(labelTime);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(loggedInUser);
            form1.Show();
            this.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Handle the logout button click event
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
