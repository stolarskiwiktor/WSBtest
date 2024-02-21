namespace Cinema
{
    partial class RegisterForm
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
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
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
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(200, 180, 150);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(45, 302);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 36);
            textBox1.TabIndex = 23;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(147, 260);
            label1.Name = "label1";
            label1.Size = new Size(77, 38);
            label1.TabIndex = 24;
            label1.Text = "Imię";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(200, 180, 150);
            textBox4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(45, 398);
            textBox4.Margin = new Padding(4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ShortcutsEnabled = false;
            textBox4.Size = new Size(310, 36);
            textBox4.TabIndex = 25;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 356);
            label2.Name = "label2";
            label2.Size = new Size(154, 38);
            label2.TabIndex = 26;
            label2.Text = "Nazwisko";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(200, 180, 150);
            textBox2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(45, 490);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ShortcutsEnabled = false;
            textBox2.Size = new Size(310, 36);
            textBox2.TabIndex = 27;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(60, 448);
            label3.Name = "label3";
            label3.Size = new Size(295, 38);
            label3.TabIndex = 28;
            label3.Text = "Nazwa użytkownika";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(200, 180, 150);
            textBox3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(45, 581);
            textBox3.Margin = new Padding(4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ShortcutsEnabled = false;
            textBox3.Size = new Size(310, 36);
            textBox3.TabIndex = 29;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(125, 539);
            label4.Name = "label4";
            label4.Size = new Size(99, 38);
            label4.TabIndex = 30;
            label4.Text = "Hasło";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(200, 180, 150);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(60, 638);
            button2.Name = "button2";
            button2.Size = new Size(236, 49);
            button2.TabIndex = 31;
            button2.Text = "Zarejestruj się";
            button2.UseVisualStyleBackColor = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(390, 742);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button2;
    }
}