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

namespace Cinema
{
    public partial class RoomDetails : Form
    {
        private Airings airing;
        private Film film;
        private User loggedInUser;
        private Dictionary<Button, Seat> seatButtons = new Dictionary<Button, Seat>();

        public RoomDetails(Airings airing, Film film, User user)
        {
            InitializeComponent();
            this.airing = airing;
            this.film = film;
            this.loggedInUser = user;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;

            InitializeLayout();
        }

        private void InitializeLayout()
        {
            // Calculate the number of rows and seats per row
            int numberOfRows = airing.rows.Count;
            int seatsPerRow = airing.numberOfSeat;

            // Calculate the total number of seats
            int totalSeats = numberOfRows * seatsPerRow;

            // Create buttons for each seat
            int buttonWidth = 50;
            int buttonHeight = 30;
            int buttonSpacing = 10;
            int startX = (Width - (seatsPerRow * (buttonWidth + buttonSpacing) - buttonSpacing)) / 2;
            int startY = (Height - (numberOfRows * (buttonHeight + buttonSpacing) - buttonSpacing)) / 2;

            int seatIndex = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                // Create a label for the row letter
                Label rowLabel = new Label();
                rowLabel.Text = airing.rows[i];
                rowLabel.Size = new Size(20, buttonHeight);
                rowLabel.Location = new Point(startX - 30, startY + i * (buttonHeight + buttonSpacing));
                Controls.Add(rowLabel);

                for (int j = 0; j < seatsPerRow; j++)
                {
                    // Check if there are more seats to display
                    if (seatIndex < airing.seats.Count)
                    {
                        Seat seat = airing.seats[seatIndex];

                        // Create a button for each seat
                        Button seatButton = new Button();
                        seatButton.Text = (j + 1).ToString();
                        seatButton.Size = new Size(buttonWidth, buttonHeight);
                        seatButton.Location = new Point(startX + j * (buttonWidth + buttonSpacing), startY + i * (buttonHeight + buttonSpacing));

                        // Set button color based on Seat.taken
                        seatButton.BackColor = seat.taken ? Color.Red : Color.Green;

                        // Add an event handler for the button click
                        seatButton.Click += (sender, e) => SeatButton_Click(seatButton, seat);

                        Controls.Add(seatButton);

                        seatButtons.Add(seatButton, seat);
                        seatIndex++;
                    }
                }
                // Add a new button at the bottom
                Button reserveAllButton = new Button();
                reserveAllButton.Text = "Reserve All Selected Seats";
                reserveAllButton.Size = new Size(buttonWidth * seatsPerRow, buttonHeight);
                reserveAllButton.Location = new Point(startX, startY + numberOfRows * (buttonHeight + buttonSpacing) + buttonSpacing);
                reserveAllButton.BackColor = Color.Gray; // Initial color
                reserveAllButton.Click += ReserveAllButton_Click;

                Controls.Add(reserveAllButton);
            }

        }
        private void ReserveAllButton_Click(object sender, EventArgs e)
        {
            // Iterate through all buttons and reserve selected seats
            foreach (Control control in Controls)
            {
                if (control is Button seatButton && seatButton.BackColor == Color.Gray)
                {
                    // Find the corresponding seat for the button
                    if (seatButtons.TryGetValue(seatButton, out Seat seat))
                    {
                        // Toggle the Taken property of the seat
                        seat.taken = true;

                        // Create a new Reservation object and add it to the list
                        Reservation reservation = new Reservation(seat, film.title, airing.time);
                        loggedInUser.reservations.Add(reservation);

                        // Set the button color based on Seat.taken
                        seatButton.BackColor = Color.Red;
                        seatButton.ForeColor = Color.Gray;

                        // Update the Airings of the film with the reserved seat
                        UpdateFilmAirings(film, airing);

                        // Persist changes to the film_repository.json file
                        UpdateFilmRepository(film);
                    }
                }
            }
            UpdateUserReservations(loggedInUser);
        }
        // Event handler for seat button click
        private void SeatButton_Click(Button seatButton, Seat seat)
        {
            if(seat.taken == true)
            {
                MessageBox.Show("To miejsce jest już zajęte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(seatButton.BackColor == Color.Gray)
            {
                seatButton.BackColor = Color.Green;
            }else
            {
                seatButton.BackColor = Color.Gray;
            }
        }

        private void UpdateUserReservations(User user)
        {
            string usersJsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.json");

            // Read the existing user data from the file
            List<User> users;
            using (StreamReader file = File.OpenText(usersJsonPath))
            {
                users = JsonSerializer.Deserialize<List<User>>(file.ReadToEnd());
            }

            // Find the user by username
            User existingUser = users.FirstOrDefault(u => u.username == user.username);

            // Update the reservations for the found user
            if (existingUser != null)
            {
                existingUser.reservations = user.reservations;
            }

            // Write the updated user data back to the file
            File.WriteAllText(usersJsonPath, JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true }));
        }

        private void UpdateFilmAirings(Film film, Airings airing)
        {
            foreach (Seat seat in airing.seats)
            {
                // Find the reserved seat in the Airings and update its taken status
                Seat reservedSeat = film.airings
                    .SelectMany(a => a.seats)
                    .FirstOrDefault(s => s.seat_row == seat.seat_row && s.seat_number == seat.seat_number);

                if (reservedSeat != null)
                {
                    reservedSeat.taken = seat.taken;
                }
            }
        }

        // Persist changes to the film_repository.json file
        private void UpdateFilmRepository(Film film)
        {
            string filmRepositoryJsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "film_repository.json");

            // Read the existing film repository data from the file
            List<Film> films;
            using (StreamReader file = File.OpenText(filmRepositoryJsonPath))
            {
                films = JsonSerializer.Deserialize<List<Film>>(file.ReadToEnd());
            }

            // Find the film in the repository by title
            Film existingFilm = films.FirstOrDefault(f => f.title == film.title);

            // Update the Airings of the found film
            if (existingFilm != null)
            {
                existingFilm.airings = film.airings;
            }

            // Write the updated film repository data back to the file
            File.WriteAllText(filmRepositoryJsonPath, JsonSerializer.Serialize(films, new JsonSerializerOptions { WriteIndented = true }));
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
