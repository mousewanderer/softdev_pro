namespace whatACT9
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
            LABELUSERNAME = new Label();
            Minimize = new Button();
            exit = new Button();
            textBoxUsername = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonExit = new Button();
            FORGOTpass = new LinkLabel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // LABELUSERNAME
            // 
            LABELUSERNAME.AutoSize = true;
            LABELUSERNAME.BackColor = Color.FromArgb(255, 241, 226);
            LABELUSERNAME.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LABELUSERNAME.Location = new Point(476, 146);
            LABELUSERNAME.Name = "LABELUSERNAME";
            LABELUSERNAME.Size = new Size(306, 46);
            LABELUSERNAME.TabIndex = 0;
            LABELUSERNAME.Text = "ENTER USERNAME:";
            // 
            // Minimize
            // 
            Minimize.BackColor = Color.Yellow;
            Minimize.BackgroundImage = (Image)resources.GetObject("Minimize.BackgroundImage");
            Minimize.BackgroundImageLayout = ImageLayout.Zoom;
            Minimize.FlatStyle = FlatStyle.Flat;
            Minimize.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Minimize.Location = new Point(1018, 12);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(45, 45);
            Minimize.TabIndex = 1;
            Minimize.UseVisualStyleBackColor = false;
            Minimize.Click += Minimize_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Yellow;
            exit.BackgroundImage = (Image)resources.GetObject("exit.BackgroundImage");
            exit.BackgroundImageLayout = ImageLayout.Zoom;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(1085, 12);
            exit.Name = "exit";
            exit.Size = new Size(45, 45);
            exit.TabIndex = 2;
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(463, 205);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(332, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 241, 226);
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(463, 246);
            label1.Name = "label1";
            label1.Size = new Size(332, 50);
            label1.TabIndex = 4;
            label1.Text = "ENTER PASSWORD";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 241, 226);
            pictureBox1.Location = new Point(387, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 300);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(245, 212, 183);
            pictureBox2.Location = new Point(140, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(763, 340);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(463, 308);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(332, 27);
            textBoxPassword.TabIndex = 8;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.White;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Location = new Point(511, 359);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.White;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(660, 359);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // FORGOTpass
            // 
            FORGOTpass.ActiveLinkColor = Color.Maroon;
            FORGOTpass.AutoSize = true;
            FORGOTpass.BackColor = Color.FromArgb(255, 241, 226);
            FORGOTpass.Location = new Point(568, 401);
            FORGOTpass.Name = "FORGOTpass";
            FORGOTpass.Size = new Size(125, 20);
            FORGOTpass.TabIndex = 11;
            FORGOTpass.TabStop = true;
            FORGOTpass.Text = "Forgot Password?";
            FORGOTpass.LinkClicked += FORGOTpass_LinkClicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(exit);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 71);
            panel1.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(245, 212, 183);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(172, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 247);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(163, 8, 11);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1151, 534);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(FORGOTpass);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(label1);
            Controls.Add(textBoxUsername);
            Controls.Add(LABELUSERNAME);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LABELUSERNAME;
        private Button Minimize;
        private Button exit;
        private TextBox textBoxUsername;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonExit;
        private LinkLabel FORGOTpass;
        private Panel panel1;
        private PictureBox pictureBox3;
    }
}
