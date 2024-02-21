namespace Cinema
{
    partial class RoomDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomDetails));
            Nav = new Panel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label2 = new Label();
            labe1 = new Label();
            label1 = new Label();
            Nav.SuspendLayout();
            SuspendLayout();
            // 
            // Nav
            // 
            Nav.BackColor = Color.FromArgb(31, 30, 68);
            Nav.Controls.Add(button2);
            Nav.Controls.Add(button1);
            Nav.Dock = DockStyle.Top;
            Nav.Location = new Point(0, 0);
            Nav.Name = "Nav";
            Nav.Size = new Size(2573, 177);
            Nav.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(227, 156);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.user_alt_1_svgrepo_com2;
            button1.Location = new Point(2410, 32);
            button1.Name = "button1";
            button1.Size = new Size(123, 127);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button3.ForeColor = Color.White;
            button3.Location = new Point(748, 212);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(1015, 36);
            button3.TabIndex = 5;
            button3.Text = "Ekran";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 499);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 34);
            label2.TabIndex = 6;
            label2.Text = "Legenda";
            label2.UseCompatibleTextRendering = true;
            // 
            // labe1
            // 
            labe1.AutoSize = true;
            labe1.BackColor = Color.FromArgb(192, 0, 0);
            labe1.Font = new Font("Arial Narrow", 11F);
            labe1.Location = new Point(228, 546);
            labe1.Margin = new Padding(4, 0, 4, 0);
            labe1.Name = "labe1";
            labe1.Size = new Size(156, 26);
            labe1.TabIndex = 7;
            labe1.Text = "Czerwony - zajęte";
            labe1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 0);
            label1.Font = new Font("Arial Narrow", 11F);
            label1.Location = new Point(228, 589);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 26);
            label1.TabIndex = 8;
            label1.Text = "Zielony - wolne";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RoomDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(2573, 1299);
            Controls.Add(label1);
            Controls.Add(labe1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(Nav);
            Name = "RoomDetails";
            Text = "RoomDetails";
            Nav.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Nav;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label2;
        private Label labe1;
        private Label label1;
    }
}