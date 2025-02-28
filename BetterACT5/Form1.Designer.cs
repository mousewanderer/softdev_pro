namespace BetterACT5
{
    partial class Experiment5
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
            Screen = new PictureBox();
            Namebutton = new Button();
            NameBox = new TextBox();
            nametext = new Label();
            agetext = new Label();
            NameResult = new Label();
            agebox = new TextBox();
            agebutton = new Button();
            COLORTEXT = new Label();
            ageresult = new Label();
            greenbutton = new Button();
            Blue = new Button();
            redbutton = new Button();
            normal = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Screen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Screen
            // 
            Screen.BackColor = Color.Silver;
            Screen.Location = new Point(300, 37);
            Screen.Name = "Screen";
            Screen.Padding = new Padding(5);
            Screen.Size = new Size(378, 402);
            Screen.TabIndex = 0;
            Screen.TabStop = false;
            // 
            // Namebutton
            // 
            Namebutton.BackColor = Color.White;
            Namebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Namebutton.ForeColor = Color.DimGray;
            Namebutton.Location = new Point(21, 101);
            Namebutton.Name = "Namebutton";
            Namebutton.Padding = new Padding(5);
            Namebutton.Size = new Size(63, 38);
            Namebutton.TabIndex = 1;
            Namebutton.Text = "Click";
            Namebutton.UseVisualStyleBackColor = false;
            Namebutton.Click += Namebutton_Click;
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.White;
            NameBox.Location = new Point(21, 68);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(250, 27);
            NameBox.TabIndex = 2;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // nametext
            // 
            nametext.AutoSize = true;
            nametext.BackColor = Color.DarkGray;
            nametext.Font = new Font("Segoe UI", 12F);
            nametext.ForeColor = Color.FromArgb(64, 64, 64);
            nametext.Location = new Point(49, 37);
            nametext.Name = "nametext";
            nametext.Size = new Size(186, 28);
            nametext.TabIndex = 3;
            nametext.Text = "ENTER YOUR NAME";
            nametext.Click += nametext_Click;
            // 
            // agetext
            // 
            agetext.AutoSize = true;
            agetext.BackColor = Color.DarkGray;
            agetext.Font = new Font("Segoe UI", 12F);
            agetext.ForeColor = Color.FromArgb(64, 64, 64);
            agetext.Location = new Point(58, 163);
            agetext.Name = "agetext";
            agetext.Size = new Size(167, 28);
            agetext.TabIndex = 4;
            agetext.Text = "ENTER YOUR AGE";
            agetext.TextAlign = ContentAlignment.TopCenter;
            // 
            // NameResult
            // 
            NameResult.AutoSize = true;
            NameResult.BackColor = Color.Silver;
            NameResult.Font = new Font("Segoe UI", 15F);
            NameResult.ForeColor = Color.Black;
            NameResult.Location = new Point(326, 55);
            NameResult.MaximumSize = new Size(300, 0);
            NameResult.Name = "NameResult";
            NameResult.Size = new Size(44, 35);
            NameResult.TabIndex = 5;
            NameResult.Text = "@:";
            NameResult.TextAlign = ContentAlignment.MiddleLeft;
            NameResult.Click += label1_Click;
            // 
            // agebox
            // 
            agebox.Location = new Point(21, 197);
            agebox.Name = "agebox";
            agebox.Size = new Size(250, 27);
            agebox.TabIndex = 6;
            agebox.TextChanged += agebox_TextChanged;
            // 
            // agebutton
            // 
            agebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agebutton.ForeColor = Color.DimGray;
            agebutton.Location = new Point(21, 230);
            agebutton.Name = "agebutton";
            agebutton.Size = new Size(63, 38);
            agebutton.TabIndex = 7;
            agebutton.Text = "Click";
            agebutton.UseVisualStyleBackColor = true;
            agebutton.Click += agebutton_Click;
            // 
            // COLORTEXT
            // 
            COLORTEXT.AutoSize = true;
            COLORTEXT.BackColor = Color.DarkGray;
            COLORTEXT.Font = new Font("Segoe UI", 12F);
            COLORTEXT.ForeColor = Color.FromArgb(64, 64, 64);
            COLORTEXT.Location = new Point(39, 295);
            COLORTEXT.Name = "COLORTEXT";
            COLORTEXT.Size = new Size(209, 28);
            COLORTEXT.TabIndex = 8;
            COLORTEXT.Text = "BACKGROUND COLOR";
            COLORTEXT.TextAlign = ContentAlignment.MiddleCenter;
            COLORTEXT.Click += label1_Click_1;
            // 
            // ageresult
            // 
            ageresult.AutoSize = true;
            ageresult.BackColor = Color.Silver;
            ageresult.Font = new Font("Segoe UI", 15F);
            ageresult.ForeColor = Color.Black;
            ageresult.Location = new Point(719, 55);
            ageresult.MaximumSize = new Size(300, 0);
            ageresult.Name = "ageresult";
            ageresult.Size = new Size(38, 35);
            ageresult.TabIndex = 9;
            ageresult.Text = "? :";
            ageresult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // greenbutton
            // 
            greenbutton.BackColor = Color.Green;
            greenbutton.ForeColor = SystemColors.ControlLight;
            greenbutton.Location = new Point(138, 329);
            greenbutton.Name = "greenbutton";
            greenbutton.Size = new Size(51, 46);
            greenbutton.TabIndex = 10;
            greenbutton.Text = "O";
            greenbutton.UseVisualStyleBackColor = false;
            greenbutton.Click += greenbutton_Click;
            // 
            // Blue
            // 
            Blue.BackColor = Color.Blue;
            Blue.ForeColor = SystemColors.ControlLight;
            Blue.Location = new Point(79, 329);
            Blue.Name = "Blue";
            Blue.Size = new Size(53, 46);
            Blue.TabIndex = 11;
            Blue.Text = "X";
            Blue.UseVisualStyleBackColor = false;
            Blue.Click += Blue_Click;
            // 
            // redbutton
            // 
            redbutton.BackColor = Color.Red;
            redbutton.ForeColor = SystemColors.ControlLight;
            redbutton.Location = new Point(80, 381);
            redbutton.Name = "redbutton";
            redbutton.Size = new Size(52, 46);
            redbutton.TabIndex = 12;
            redbutton.Text = "I";
            redbutton.UseVisualStyleBackColor = false;
            redbutton.Click += redbutton_Click;
            // 
            // normal
            // 
            normal.BackColor = Color.DimGray;
            normal.ForeColor = SystemColors.ControlLight;
            normal.Location = new Point(138, 381);
            normal.Name = "normal";
            normal.Size = new Size(53, 46);
            normal.TabIndex = 13;
            normal.Text = "U";
            normal.UseVisualStyleBackColor = false;
            normal.Click += normal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGray;
            pictureBox1.Location = new Point(21, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 28);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkGray;
            pictureBox2.Location = new Point(21, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 28);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkGray;
            pictureBox3.Location = new Point(21, 295);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 28);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Silver;
            pictureBox4.Location = new Point(698, 37);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Padding = new Padding(5);
            pictureBox4.Size = new Size(378, 402);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // Experiment5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1104, 491);
            Controls.Add(normal);
            Controls.Add(redbutton);
            Controls.Add(Blue);
            Controls.Add(greenbutton);
            Controls.Add(ageresult);
            Controls.Add(COLORTEXT);
            Controls.Add(agebutton);
            Controls.Add(agebox);
            Controls.Add(NameResult);
            Controls.Add(agetext);
            Controls.Add(nametext);
            Controls.Add(NameBox);
            Controls.Add(Namebutton);
            Controls.Add(Screen);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Name = "Experiment5";
            Text = "Experiment 5";
            ((System.ComponentModel.ISupportInitialize)Screen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Screen;
        private Button Namebutton;
        private TextBox NameBox;
        private Label nametext;
        private Label agetext;
        private Label NameResult;
        private TextBox agebox;
        private Button agebutton;
        private Label COLORTEXT;
        private Label ageresult;
        private Button greenbutton;
        private Button Blue;
        private Button redbutton;
        private Button normal;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
