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
            ((System.ComponentModel.ISupportInitialize)Screen).BeginInit();
            SuspendLayout();
            // 
            // Screen
            // 
            Screen.BackColor = Color.Silver;
            Screen.Location = new Point(300, 55);
            Screen.Name = "Screen";
            Screen.Padding = new Padding(5);
            Screen.Size = new Size(612, 402);
            Screen.TabIndex = 0;
            Screen.TabStop = false;
            // 
            // Namebutton
            // 
            Namebutton.BackColor = Color.White;
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
            nametext.Font = new Font("Segoe UI", 12F);
            nametext.ForeColor = Color.FromArgb(64, 64, 64);
            nametext.Location = new Point(39, 37);
            nametext.Name = "nametext";
            nametext.Size = new Size(195, 28);
            nametext.TabIndex = 3;
            nametext.Text = "ENTER YOUR NAME: ";
            nametext.Click += nametext_Click;
            // 
            // agetext
            // 
            agetext.AutoSize = true;
            agetext.Font = new Font("Segoe UI", 12F);
            agetext.ForeColor = Color.FromArgb(64, 64, 64);
            agetext.Location = new Point(58, 166);
            agetext.Name = "agetext";
            agetext.Size = new Size(176, 28);
            agetext.TabIndex = 4;
            agetext.Text = "ENTER YOUR AGE: ";
            agetext.TextAlign = ContentAlignment.TopCenter;
            // 
            // NameResult
            // 
            NameResult.AutoSize = true;
            NameResult.BackColor = Color.Silver;
            NameResult.Font = new Font("Segoe UI", 15F);
            NameResult.ForeColor = Color.WhiteSmoke;
            NameResult.Location = new Point(319, 68);
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
            COLORTEXT.Font = new Font("Segoe UI", 12F);
            COLORTEXT.ForeColor = Color.FromArgb(64, 64, 64);
            COLORTEXT.Location = new Point(21, 311);
            COLORTEXT.Name = "COLORTEXT";
            COLORTEXT.Size = new Size(250, 28);
            COLORTEXT.TabIndex = 8;
            COLORTEXT.Text = "Change Background Color: ";
            COLORTEXT.TextAlign = ContentAlignment.TopCenter;
            COLORTEXT.Click += label1_Click_1;
            // 
            // ageresult
            // 
            ageresult.AutoSize = true;
            ageresult.BackColor = Color.Silver;
            ageresult.Font = new Font("Segoe UI", 15F);
            ageresult.ForeColor = Color.WhiteSmoke;
            ageresult.Location = new Point(615, 68);
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
            greenbutton.Location = new Point(138, 354);
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
            Blue.Location = new Point(79, 354);
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
            redbutton.Location = new Point(80, 406);
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
            normal.Location = new Point(138, 406);
            normal.Name = "normal";
            normal.Size = new Size(53, 46);
            normal.TabIndex = 13;
            normal.Text = "U";
            normal.UseVisualStyleBackColor = false;
            normal.Click += normal_Click;
            // 
            // Experiment5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(936, 491);
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
            Name = "Experiment5";
            Text = "Experiment 5";
            ((System.ComponentModel.ISupportInitialize)Screen).EndInit();
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
    }
}
