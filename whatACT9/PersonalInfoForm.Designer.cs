namespace whatACT9
{
    partial class PersonalInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInfoForm));
            labelFullName = new Label();
            labelAge = new Label();
            labelGender = new Label();
            comboBoxGender = new ComboBox();
            textBoxFullName = new TextBox();
            textBoxAge = new TextBox();
            buttonSave = new Button();
            buttonLogout = new Button();
            pictureBox1 = new PictureBox();
            ffs = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFullName.Location = new Point(235, 127);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(134, 50);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "NAME:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAge.Location = new Point(235, 230);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(97, 50);
            labelAge.TabIndex = 1;
            labelAge.Text = "AGE:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGender.Location = new Point(235, 328);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(169, 50);
            labelGender.TabIndex = 2;
            labelGender.Text = "GENDER:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(235, 381);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(290, 28);
            comboBoxGender.TabIndex = 3;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(235, 175);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(290, 27);
            textBoxFullName.TabIndex = 4;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(235, 283);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(290, 27);
            textBoxAge.TabIndex = 5;
            textBoxAge.TextChanged += textBoxAge_TextChanged;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ControlLightLight;
            buttonSave.BackgroundImage = (Image)resources.GetObject("buttonSave.BackgroundImage");
            buttonSave.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSave.Location = new Point(737, 175);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(50, 55);
            buttonSave.TabIndex = 6;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackgroundImage = (Image)resources.GetObject("buttonLogout.BackgroundImage");
            buttonLogout.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLogout.Location = new Point(737, 293);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(50, 55);
            buttonLogout.TabIndex = 7;
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(209, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(683, 314);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // ffs
            // 
            ffs.AutoSize = true;
            ffs.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ffs.Location = new Point(98, 12);
            ffs.Name = "ffs";
            ffs.Size = new Size(488, 67);
            ffs.TabIndex = 9;
            ffs.Text = "USER INFORMATION";
            ffs.Click += ffs_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 75);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(730, 144);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 11;
            label1.Text = "SAVE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(720, 262);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 12;
            label2.Text = "LOGOUT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(232, 205);
            label3.Name = "label3";
            label3.Size = new Size(293, 17);
            label3.TabIndex = 13;
            label3.Text = "---------------------------------------------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(235, 313);
            label4.Name = "label4";
            label4.Size = new Size(293, 17);
            label4.TabIndex = 14;
            label4.Text = "---------------------------------------------------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(235, 414);
            label5.Name = "label5";
            label5.Size = new Size(293, 17);
            label5.TabIndex = 15;
            label5.Text = "---------------------------------------------------------";
            // 
            // PersonalInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 551);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(ffs);
            Controls.Add(buttonLogout);
            Controls.Add(buttonSave);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxFullName);
            Controls.Add(comboBoxGender);
            Controls.Add(labelGender);
            Controls.Add(labelAge);
            Controls.Add(labelFullName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalInfoForm";
            Text = "PersonalInfoForm";
            Load += PersonalInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFullName;
        private Label labelAge;
        private Label labelGender;
        private ComboBox comboBoxGender;
        private TextBox textBoxFullName;
        private TextBox textBoxAge;
        private Button buttonSave;
        private Button buttonLogout;
        private PictureBox pictureBox1;
        private Label ffs;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}