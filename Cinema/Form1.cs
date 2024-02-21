using Cinema.Classes;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        private FilmRepository filmRepository;
        private User loggedInUser;
        public Form1(User user)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 224, 192);
            Nav.BackColor = Color.FromArgb(31, 30, 68);
            filmRepository = new FilmRepository();
            this.loggedInUser = user;
            button1.Click += Button1_Click;
            LoadFilms(filmRepository);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadFilms(FilmRepository filmRepository)
        {

            flowLayoutPanel1.WrapContents = true;
/*            flowLayoutPanel1.AutoSize = true;*/
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            int totalHeight = 0;
            foreach (Film film in filmRepository.GetFilmList())
            {
                Panel panel;
                panel = new Panel();
                panel.BackColor = Color.Transparent;
                panel.Size = new Size(flowLayoutPanel1.ClientSize.Width - 20, 300);
                panel.Margin = new Padding(10);
                panel.BorderStyle = BorderStyle.FixedSingle;

                PictureBox picBox;
                picBox = new PictureBox();
                picBox.Size = new Size(200, 305);
                picBox.Location = new Point(10, 10);
                picBox.SizeMode = PictureBoxSizeMode.Zoom;
                picBox.Dock = DockStyle.Left;

                if (File.Exists(film.posterPath))
                    picBox.Image = Image.FromFile(film.posterPath);

                Label labelTitle;
                labelTitle = new Label();
                labelTitle.Text = film.title;
                labelTitle.ForeColor = Color.Black;
                labelTitle.Font = new Font("Segoe UI", 18f, FontStyle.Bold);
                labelTitle.Size = new Size(panel.ClientSize.Width - picBox.Width - 30, 50);
                labelTitle.Location = new Point(picBox.Right + 10, (panel.Height - labelTitle.Height) / 2);
                labelTitle.AutoSize = true;

                panel.Controls.Add(picBox);
                panel.Controls.Add(labelTitle);

                totalHeight += panel.Height;
                flowLayoutPanel1.Controls.Add(panel);
                panel.Click += (sender, e) => Panel_Click(film, loggedInUser);
            }
        }

        private void Panel_Click(Film film, User user)
        {
            FilmDetails filmDetails = new FilmDetails(film, user);
            filmDetails.Show();
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