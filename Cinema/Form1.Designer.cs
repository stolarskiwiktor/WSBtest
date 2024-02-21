namespace Cinema
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Nav = new Panel();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Nav.SuspendLayout();
            SuspendLayout();
            // 
            // Nav
            // 
            Nav.BackColor = Color.Firebrick;
            Nav.Controls.Add(button2);
            Nav.Controls.Add(button1);
            Nav.Dock = DockStyle.Top;
            Nav.Location = new Point(0, 0);
            Nav.Name = "Nav";
            Nav.Size = new Size(2573, 177);
            Nav.TabIndex = 0;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(60, 236);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(2473, 1037);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 228, 228);
            ClientSize = new Size(2573, 1299);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Nav);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Nav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Nav;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
