namespace Cinema
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 260);
            label1.Name = "label1";
            label1.Size = new Size(295, 38);
            label1.TabIndex = 12;
            label1.Text = "Nazwa użytkownika";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(200, 180, 150);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(13, 302);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 36);
            textBox1.TabIndex = 13;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(200, 180, 150);
            textBox4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(13, 402);
            textBox4.Margin = new Padding(4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ShortcutsEnabled = false;
            textBox4.Size = new Size(342, 36);
            textBox4.TabIndex = 14;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(137, 351);
            label2.Name = "label2";
            label2.Size = new Size(99, 38);
            label2.TabIndex = 15;
            label2.Text = "Hasło";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(31, 30, 68);
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(363, 302);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(31, 30, 68);
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(363, 402);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.AcceptsReturn = true;
            textBox5.BackColor = Color.FromArgb(200, 180, 150);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Cursor = Cursors.Hand;
            textBox5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox5.ForeColor = Color.Black;
            textBox5.ImeMode = ImeMode.NoControl;
            textBox5.Location = new Point(120, 457);
            textBox5.Margin = new Padding(4);
            textBox5.MaxLength = 200;
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(145, 27);
            textBox5.TabIndex = 18;
            textBox5.Text = "Reset hasła";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.WordWrap = false;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.BackColor = Color.FromArgb(200, 180, 150);
            button1.Cursor = Cursors.Hand;
            button1.DialogResult = DialogResult.Continue;
            button1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(45, 553);
            button1.Margin = new Padding(2, 3, 2, 79);
            button1.Name = "button1";
            button1.Size = new Size(310, 101);
            button1.TabIndex = 19;
            button1.Text = "Zaloguj się";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(200, 180, 150);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(86, 672);
            button2.Name = "button2";
            button2.Size = new Size(236, 49);
            button2.TabIndex = 20;
            button2.Text = "Zarejestruj się";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(31, 30, 68);
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Image = Properties.Resources.log;
            pictureBox3.Location = new Point(45, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(310, 260);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(423, 752);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox3;
    }
}