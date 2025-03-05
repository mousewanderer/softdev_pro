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
            headpanel = new Panel();
            buttonadd = new Button();
            buttonclear = new Button();
            buttonremove = new Button();
            listBoxshopping = new ListBox();
            comboboxcategory = new ComboBox();
            labelcombobox = new Label();
            labellistbox = new Label();
            textBoxitem = new TextBox();
            savebutton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            contextMenuListBox = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItemToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItemToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            editToolStripMenuItemToolStripMenuItem2 = new ToolStripMenuItem();
            contextMenuListBox.SuspendLayout();
            SuspendLayout();
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.Maroon;
            sidepanel.Dock = DockStyle.Left;
            sidepanel.Location = new Point(0, 0);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(165, 551);
            sidepanel.TabIndex = 0;
            // 
            // headpanel
            // 
            headpanel.BackColor = Color.Firebrick;
            headpanel.Dock = DockStyle.Top;
            headpanel.Location = new Point(165, 0);
            headpanel.Name = "headpanel";
            headpanel.Size = new Size(935, 75);
            headpanel.TabIndex = 1;
            // 
            // buttonadd
            // 
            buttonadd.BackColor = Color.Yellow;
            buttonadd.BackgroundImage = Properties.Resources.Microsoft_Fluentui_Emoji_Mono_Hammer_512;
            buttonadd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonadd.FlatStyle = FlatStyle.Popup;
            buttonadd.ImageAlign = ContentAlignment.TopCenter;
            buttonadd.Location = new Point(493, 180);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(52, 43);
            buttonadd.TabIndex = 2;
            buttonadd.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonadd.UseVisualStyleBackColor = false;
            buttonadd.Click += buttonadd_Click;
            // 
            // buttonclear
            // 
            buttonclear.BackColor = Color.Yellow;
            buttonclear.BackgroundImage = (Image)resources.GetObject("buttonclear.BackgroundImage");
            buttonclear.BackgroundImageLayout = ImageLayout.Zoom;
            buttonclear.FlatStyle = FlatStyle.Popup;
            buttonclear.ImageAlign = ContentAlignment.TopCenter;
            buttonclear.Location = new Point(493, 279);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(52, 43);
            buttonclear.TabIndex = 3;
            buttonclear.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonclear.UseVisualStyleBackColor = false;
            buttonclear.Click += buttonclear_Click;
            // 
            // buttonremove
            // 
            buttonremove.BackColor = Color.Yellow;
            buttonremove.BackgroundImage = (Image)resources.GetObject("buttonremove.BackgroundImage");
            buttonremove.BackgroundImageLayout = ImageLayout.Zoom;
            buttonremove.FlatStyle = FlatStyle.Popup;
            buttonremove.ImageAlign = ContentAlignment.TopCenter;
            buttonremove.Location = new Point(493, 229);
            buttonremove.Name = "buttonremove";
            buttonremove.Size = new Size(52, 43);
            buttonremove.TabIndex = 4;
            buttonremove.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonremove.UseVisualStyleBackColor = false;
            buttonremove.Click += buttonremove_Click;
            // 
            // listBoxshopping
            // 
            listBoxshopping.BackColor = Color.Crimson;
            listBoxshopping.FormattingEnabled = true;
            listBoxshopping.Location = new Point(707, 144);
            listBoxshopping.Name = "listBoxshopping";
            listBoxshopping.Size = new Size(338, 324);
            listBoxshopping.TabIndex = 2;
            // 
            // comboboxcategory
            // 
            comboboxcategory.FormattingEnabled = true;
            comboboxcategory.Location = new Point(394, 146);
            comboboxcategory.Name = "comboboxcategory";
            comboboxcategory.Size = new Size(151, 28);
            comboboxcategory.TabIndex = 3;
            comboboxcategory.SelectedIndexChanged += comboboxcategory_SelectedIndexChanged;
            // 
            // labelcombobox
            // 
            labelcombobox.AutoSize = true;
            labelcombobox.Location = new Point(458, 78);
            labelcombobox.Name = "labelcombobox";
            labelcombobox.Size = new Size(87, 20);
            labelcombobox.TabIndex = 4;
            labelcombobox.Text = "Combo Box";
            // 
            // labellistbox
            // 
            labellistbox.AutoSize = true;
            labellistbox.Location = new Point(707, 116);
            labellistbox.Name = "labellistbox";
            labellistbox.Size = new Size(60, 20);
            labellistbox.TabIndex = 5;
            labellistbox.Text = "List Box";
            // 
            // textBoxitem
            // 
            textBoxitem.BackColor = Color.Yellow;
            textBoxitem.Location = new Point(310, 113);
            textBoxitem.Name = "textBoxitem";
            textBoxitem.Size = new Size(235, 27);
            textBoxitem.TabIndex = 6;
            textBoxitem.TextChanged += textBoxitem_TextChanged;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(451, 328);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(94, 53);
            savebutton.TabIndex = 7;
            savebutton.Text = "savebutton";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 191);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 8;
            label1.Text = "ADD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 240);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 9;
            label2.Text = "Remove";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 290);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 10;
            label3.Text = "Clear";
            // 
            // contextMenuListBox
            // 
            contextMenuListBox.ImageScalingSize = new Size(20, 20);
            contextMenuListBox.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuListBox.Name = "contextMenuListBox";
            contextMenuListBox.Size = new Size(211, 80);
            contextMenuListBox.Opening += contextMenuListBox_Opening;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItemToolStripMenuItem, editToolStripMenuItemToolStripMenuItem1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(210, 24);
            toolStripMenuItem1.Text = "Remove";
            // 
            // editToolStripMenuItemToolStripMenuItem
            // 
            editToolStripMenuItemToolStripMenuItem.Name = "editToolStripMenuItemToolStripMenuItem";
            editToolStripMenuItemToolStripMenuItem.Size = new Size(269, 26);
            editToolStripMenuItemToolStripMenuItem.Text = "removeToolStripMenuItem";
            editToolStripMenuItemToolStripMenuItem.Click += editToolStripMenuItemToolStripMenuItem_Click;
            // 
            // editToolStripMenuItemToolStripMenuItem1
            // 
            editToolStripMenuItemToolStripMenuItem1.Name = "editToolStripMenuItemToolStripMenuItem1";
            editToolStripMenuItemToolStripMenuItem1.Size = new Size(269, 26);
            editToolStripMenuItemToolStripMenuItem1.Text = "editToolStripMenuItem";
            editToolStripMenuItemToolStripMenuItem1.Click += editToolStripMenuItemToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItemToolStripMenuItem2 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(210, 24);
            toolStripMenuItem2.Text = "Edit";
            // 
            // editToolStripMenuItemToolStripMenuItem2
            // 
            editToolStripMenuItemToolStripMenuItem2.Name = "editToolStripMenuItemToolStripMenuItem2";
            editToolStripMenuItemToolStripMenuItem2.Size = new Size(245, 26);
            editToolStripMenuItemToolStripMenuItem2.Text = "editToolStripMenuItem";
            editToolStripMenuItemToolStripMenuItem2.Click += editToolStripMenuItemToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1100, 551);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(savebutton);
            Controls.Add(buttonremove);
            Controls.Add(textBoxitem);
            Controls.Add(buttonclear);
            Controls.Add(buttonadd);
            Controls.Add(labellistbox);
            Controls.Add(labelcombobox);
            Controls.Add(comboboxcategory);
            Controls.Add(listBoxshopping);
            Controls.Add(headpanel);
            Controls.Add(sidepanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            contextMenuListBox.ResumeLayout(false);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private ContextMenuStrip contextMenuListBox;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItemToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem editToolStripMenuItemToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItemToolStripMenuItem2;
    }
}
