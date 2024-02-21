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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cinema
{
    public partial class FilmDetails : Form
    {
        private Film film;
        private User loggedInUser;
        public FilmDetails(Film film, User user)
        {
            InitializeComponent();
            this.film = film;
            this.loggedInUser = user;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            InitializeLayout();
        }

        private void InitializeLayout()
        {
            PictureBox picBoxPhoto = new PictureBox();
            picBoxPhoto.Dock = DockStyle.Fill;
            picBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            if (File.Exists(film.posterPath))
                picBoxPhoto.Image = Image.FromFile(film.posterPath);

            panel2.Controls.Add(picBoxPhoto);

            Label labelFilmDetails = new Label();
            labelFilmDetails.Text =
                $"Tytuł: {film.title}\n" +
                $"Rok Produkcji: {film.yearOfProduction}\n" +
                $"Ograniczenia wiekowe: {film.minimalAge}\n";
            labelFilmDetails.Text += $"Gatunek: {string.Join(", ", film.genre)}\n";
            labelFilmDetails.ForeColor = Color.Black;
            labelFilmDetails.Font = new Font("Segoe UI", 12f);
            labelFilmDetails.AutoSize = true;

            panel3.Controls.Add(labelFilmDetails);

            Label labelFilmDescription = new Label();
            labelFilmDescription.Text = $"{film.description}";
            labelFilmDescription.ForeColor = Color.Black;
            labelFilmDescription.Font = new Font("Segoe UI", 12f);
            labelFilmDescription.AutoSize = true;

            panel4.Controls.Add(labelFilmDescription);

            Panel panelAiringButtons = new Panel();
            panelAiringButtons.BackColor = Color.Transparent;
            panelAiringButtons.Size = new Size(ClientSize.Width / 2, ClientSize.Height / 2);
            panelAiringButtons.Location = new Point(ClientSize.Width / 2, ClientSize.Height - 150);

            int buttonWidth = 200;
            int buttonHeight = 30;
            int buttonSpacing = 10;
            int xPosition = 10;

            foreach (Airings airing in film.airings)
            {
                Button airingButton = new Button();
                airingButton.Text = $"{airing.time}";
                airingButton.Size = new Size(buttonWidth, buttonHeight); 
                airingButton.Location = new Point(xPosition, 10); 
                xPosition += buttonWidth + buttonSpacing; 
                panelAiringButtons.Controls.Add(airingButton);

                airingButton.Click += (sender, e) => AiringButton_Click(airing, film, loggedInUser);

                panelAiringButtons.Controls.Add(airingButton);
            }

            Controls.Add(panelAiringButtons);

        }
        private void AiringButton_Click(Airings airing, Film film, User user)
        {
            // Create and show the HallDetails form, passing the airing information
            RoomDetails roomDetails = new RoomDetails(airing, film, user);
            roomDetails.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(loggedInUser);
            form1.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserDetails userDetails = new UserDetails(loggedInUser);
            userDetails.Show();
            this.Close();
        }
    }
}
