namespace Biggeract7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sidepanel = new Panel();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            labelcombobox = new Label();
            savebutton = new Button();
            textBoxitem = new TextBox();
            comboboxcategory = new ComboBox();
            pictureBox2 = new PictureBox();
            buttonclear = new Button();
            buttonadd = new Button();
            buttonremove = new Button();
            headpanel = new Panel();
            button2 = new Button();
            exitbutton = new Button();
            listBoxshopping = new ListBox();
            labellistbox = new Label();
            contextMenuListBox = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItemToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItemToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            editToolStripMenuItemToolStripMenuItem2 = new ToolStripMenuItem();
            labelCounter = new Label();
            pictureBox1 = new PictureBox();
            sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            headpanel.SuspendLayout();
            contextMenuListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.FromArgb(255, 182, 162);
            sidepanel.Controls.Add(label2);
            sidepanel.Controls.Add(pictureBox4);
            sidepanel.Controls.Add(pictureBox3);
            sidepanel.Controls.Add(textBox1);
            sidepanel.Controls.Add(label1);
            sidepanel.Controls.Add(label4);
            sidepanel.Controls.Add(labelcombobox);
            sidepanel.Controls.Add(savebutton);
            sidepanel.Controls.Add(textBoxitem);
            sidepanel.Controls.Add(comboboxcategory);
            sidepanel.Controls.Add(pictureBox2);
            sidepanel.Controls.Add(buttonclear);
            sidepanel.Controls.Add(buttonadd);
            sidepanel.Controls.Add(buttonremove);
            sidepanel.Dock = DockStyle.Left;
            sidepanel.Location = new Point(0, 0);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(327, 551);
            sidepanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 182, 162);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 440);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 18;
            label2.Text = "Search Item";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(33, 225);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 49);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(23, 455);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 44);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 472);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 182, 162);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 235);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 14;
            label1.Text = "Enter Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 182, 162);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 146);
            label4.Name = "label4";
            label4.Size = new Size(149, 28);
            label4.TabIndex = 13;
            label4.Text = "Select Category";
            // 
            // labelcombobox
            // 
            labelcombobox.AutoSize = true;
            labelcombobox.BackColor = Color.Transparent;
            labelcombobox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcombobox.Location = new Point(23, 9);
            labelcombobox.Name = "labelcombobox";
            labelcombobox.Size = new Size(279, 108);
            labelcombobox.TabIndex = 4;
            labelcombobox.Text = "Shopping Cart\r\n List App";
            labelcombobox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // savebutton
            // 
            savebutton.BackColor = Color.FromArgb(168, 213, 186);
            savebutton.BackgroundImage = (Image)resources.GetObject("savebutton.BackgroundImage");
            savebutton.BackgroundImageLayout = ImageLayout.Zoom;
            savebutton.FlatStyle = FlatStyle.Flat;
            savebutton.Location = new Point(159, 365);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(52, 43);
            savebutton.TabIndex = 7;
            savebutton.UseVisualStyleBackColor = false;
            savebutton.Click += savebutton_Click;
            // 
            // textBoxitem
            // 
            textBoxitem.BackColor = Color.FromArgb(255, 248, 242);
            textBoxitem.ForeColor = Color.FromArgb(78, 78, 78);
            textBoxitem.Location = new Point(23, 280);
            textBoxitem.Name = "textBoxitem";
            textBoxitem.Size = new Size(259, 27);
            textBoxitem.TabIndex = 6;
            textBoxitem.TextChanged += textBoxitem_TextChanged;
            // 
            // comboboxcategory
            // 
            comboboxcategory.BackColor = Color.FromArgb(255, 248, 242);
            comboboxcategory.ForeColor = Color.FromArgb(78, 78, 78);
            comboboxcategory.FormattingEnabled = true;
            comboboxcategory.Location = new Point(23, 187);
            comboboxcategory.Name = "comboboxcategory";
            comboboxcategory.Size = new Size(259, 28);
            comboboxcategory.TabIndex = 3;
            comboboxcategory.SelectedIndexChanged += comboboxcategory_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(33, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 46);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // buttonclear
            // 
            buttonclear.BackColor = Color.FromArgb(255, 107, 107);
            buttonclear.BackgroundImage = (Image)resources.GetObject("buttonclear.BackgroundImage");
            buttonclear.BackgroundImageLayout = ImageLayout.Zoom;
            buttonclear.FlatStyle = FlatStyle.Popup;
            buttonclear.ImageAlign = ContentAlignment.TopCenter;
            buttonclear.Location = new Point(230, 365);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(52, 43);
            buttonclear.TabIndex = 3;
            buttonclear.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonclear.UseVisualStyleBackColor = false;
            buttonclear.Click += buttonclear_Click;
            // 
            // buttonadd
            // 
            buttonadd.BackColor = Color.FromArgb(168, 213, 186);
            buttonadd.BackgroundImage = (Image)resources.GetObject("buttonadd.BackgroundImage");
            buttonadd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonadd.FlatStyle = FlatStyle.Popup;
            buttonadd.ImageAlign = ContentAlignment.TopCenter;
            buttonadd.Location = new Point(23, 365);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(52, 43);
            buttonadd.TabIndex = 2;
            buttonadd.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonadd.UseVisualStyleBackColor = false;
            buttonadd.Click += buttonadd_Click;
            // 
            // buttonremove
            // 
            buttonremove.BackColor = Color.FromArgb(255, 107, 107);
            buttonremove.BackgroundImage = (Image)resources.GetObject("buttonremove.BackgroundImage");
            buttonremove.BackgroundImageLayout = ImageLayout.Zoom;
            buttonremove.FlatStyle = FlatStyle.Popup;
            buttonremove.ImageAlign = ContentAlignment.TopCenter;
            buttonremove.Location = new Point(90, 365);
            buttonremove.Name = "buttonremove";
            buttonremove.Size = new Size(52, 43);
            buttonremove.TabIndex = 4;
            buttonremove.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonremove.UseVisualStyleBackColor = false;
            buttonremove.Click += buttonremove_Click;
            // 
            // headpanel
            // 
            headpanel.BackColor = Color.FromArgb(168, 213, 186);
            headpanel.BackgroundImage = (Image)resources.GetObject("headpanel.BackgroundImage");
            headpanel.Controls.Add(button2);
            headpanel.Controls.Add(exitbutton);
            headpanel.Dock = DockStyle.Top;
            headpanel.Location = new Point(327, 0);
            headpanel.Name = "headpanel";
            headpanel.Size = new Size(693, 75);
            headpanel.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 182, 162);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(575, 12);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // exitbutton
            // 
            exitbutton.BackColor = Color.FromArgb(255, 120, 107);
            exitbutton.ForeColor = Color.White;
            exitbutton.Location = new Point(631, 12);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(50, 50);
            exitbutton.TabIndex = 1;
            exitbutton.Text = "X";
            exitbutton.UseVisualStyleBackColor = false;
            exitbutton.Click += exitbutton_Click;
            // 
            // listBoxshopping
            // 
            listBoxshopping.BackColor = Color.FromArgb(255, 248, 242);
            listBoxshopping.Cursor = Cursors.Cross;
            listBoxshopping.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxshopping.ForeColor = Color.FromArgb(78, 78, 78);
            listBoxshopping.FormattingEnabled = true;
            listBoxshopping.ItemHeight = 28;
            listBoxshopping.Location = new Point(446, 156);
            listBoxshopping.Name = "listBoxshopping";
            listBoxshopping.Size = new Size(338, 312);
            listBoxshopping.TabIndex = 2;
            // 
            // labellistbox
            // 
            labellistbox.AutoSize = true;
            labellistbox.BorderStyle = BorderStyle.Fixed3D;
            labellistbox.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labellistbox.ForeColor = Color.FromArgb(78, 78, 78);
            labellistbox.Location = new Point(547, 87);
            labellistbox.Name = "labellistbox";
            labellistbox.Size = new Size(172, 56);
            labellistbox.TabIndex = 5;
            labellistbox.Text = "List Box";
            // 
            // contextMenuListBox
            // 
            contextMenuListBox.ImageScalingSize = new Size(20, 20);
            contextMenuListBox.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuListBox.Name = "contextMenuListBox";
            contextMenuListBox.Size = new Size(133, 52);
            contextMenuListBox.Opening += contextMenuListBox_Opening;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItemToolStripMenuItem, editToolStripMenuItemToolStripMenuItem1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(132, 24);
            toolStripMenuItem1.Text = "Remove";
            // 
            // editToolStripMenuItemToolStripMenuItem
            // 
            editToolStripMenuItemToolStripMenuItem.Name = "editToolStripMenuItemToolStripMenuItem";
            editToolStripMenuItemToolStripMenuItem.Size = new Size(224, 26);
            editToolStripMenuItemToolStripMenuItem.Text = "Remove";
            editToolStripMenuItemToolStripMenuItem.Click += editToolStripMenuItemToolStripMenuItem_Click;
            // 
            // editToolStripMenuItemToolStripMenuItem1
            // 
            editToolStripMenuItemToolStripMenuItem1.Name = "editToolStripMenuItemToolStripMenuItem1";
            editToolStripMenuItemToolStripMenuItem1.Size = new Size(224, 26);
            editToolStripMenuItemToolStripMenuItem1.Text = "Edit";
            editToolStripMenuItemToolStripMenuItem1.Click += editToolStripMenuItemToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItemToolStripMenuItem2 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(132, 24);
            toolStripMenuItem2.Text = "Edit";
            // 
            // editToolStripMenuItemToolStripMenuItem2
            // 
            editToolStripMenuItemToolStripMenuItem2.Name = "editToolStripMenuItemToolStripMenuItem2";
            editToolStripMenuItemToolStripMenuItem2.Size = new Size(245, 26);
            editToolStripMenuItemToolStripMenuItem2.Text = "editToolStripMenuItem";
            editToolStripMenuItemToolStripMenuItem2.Click += editToolStripMenuItemToolStripMenuItem1_Click;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCounter.ForeColor = Color.FromArgb(78, 78, 78);
            labelCounter.Location = new Point(736, 499);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(111, 23);
            labelCounter.TabIndex = 12;
            labelCounter.Text = "Total Items: 0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(168, 213, 186);
            pictureBox1.Location = new Point(432, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 338);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 243, 224);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1020, 551);
            Controls.Add(labelCounter);
            Controls.Add(labellistbox);
            Controls.Add(listBoxshopping);
            Controls.Add(headpanel);
            Controls.Add(sidepanel);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(78, 78, 78);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            sidepanel.ResumeLayout(false);
            sidepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            headpanel.ResumeLayout(false);
            contextMenuListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidepanel;
        private Panel headpanel;
        private Button buttonadd;
        private Button buttonclear;
        private Button buttonremove;
        private ListBox listBoxshopping;
        private ComboBox comboboxcategory;
        private Label labelcombobox;
        private Label labellistbox;
        private TextBox textBoxitem;
        private Button savebutton;
        private ContextMenuStrip contextMenuListBox;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItemToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem editToolStripMenuItemToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItemToolStripMenuItem2;
        private Label labelCounter;
        private Label label4;
        private Label label1;
        private Button exitbutton;
        private PictureBox pictureBox1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label2;
    }
}
