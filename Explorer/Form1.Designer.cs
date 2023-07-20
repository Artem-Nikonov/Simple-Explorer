namespace WinFormsApp1
{
    partial class Functions
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.ShowAllFiles = new System.Windows.Forms.Button();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.CurrentDir = new System.Windows.Forms.Label();
            this.GoToParentDir = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.OpenTxt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateDirButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SetFontButton = new System.Windows.Forms.Button();
            this.SetDarkThemeButton = new System.Windows.Forms.Button();
            this.SetLightThemeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Teal;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(148, 81);
            this.listBox1.MinimumSize = new System.Drawing.Size(550, 400);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(766, 405);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // PathBox
            // 
            this.PathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.PathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathBox.ForeColor = System.Drawing.Color.Gray;
            this.PathBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PathBox.Location = new System.Drawing.Point(148, 11);
            this.PathBox.MinimumSize = new System.Drawing.Size(363, 27);
            this.PathBox.Name = "PathBox";
            this.PathBox.PlaceholderText = "Путь";
            this.PathBox.Size = new System.Drawing.Size(579, 27);
            this.PathBox.TabIndex = 1;
            // 
            // ShowAllFiles
            // 
            this.ShowAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAllFiles.BackColor = System.Drawing.Color.Black;
            this.ShowAllFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowAllFiles.ForeColor = System.Drawing.Color.Gray;
            this.ShowAllFiles.Location = new System.Drawing.Point(814, 11);
            this.ShowAllFiles.MinimumSize = new System.Drawing.Size(100, 29);
            this.ShowAllFiles.Name = "ShowAllFiles";
            this.ShowAllFiles.Size = new System.Drawing.Size(100, 29);
            this.ShowAllFiles.TabIndex = 2;
            this.ShowAllFiles.Text = "Перейти";
            this.ShowAllFiles.UseVisualStyleBackColor = false;
            this.ShowAllFiles.Click += new System.EventHandler(this.ShowAllFiles_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.TypeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TypeBox.ForeColor = System.Drawing.Color.Gray;
            this.TypeBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TypeBox.Location = new System.Drawing.Point(733, 11);
            this.TypeBox.MinimumSize = new System.Drawing.Size(75, 27);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.PlaceholderText = "*.тип";
            this.TypeBox.Size = new System.Drawing.Size(75, 27);
            this.TypeBox.TabIndex = 3;
            this.TypeBox.Tag = "";
            // 
            // CurrentDir
            // 
            this.CurrentDir.AutoSize = true;
            this.CurrentDir.ForeColor = System.Drawing.SystemColors.Window;
            this.CurrentDir.Location = new System.Drawing.Point(73, 9);
            this.CurrentDir.Name = "CurrentDir";
            this.CurrentDir.Size = new System.Drawing.Size(33, 20);
            this.CurrentDir.TabIndex = 4;
            this.CurrentDir.Text = "      ";
            // 
            // GoToParentDir
            // 
            this.GoToParentDir.BackColor = System.Drawing.Color.Black;
            this.GoToParentDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToParentDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GoToParentDir.ForeColor = System.Drawing.Color.Gray;
            this.GoToParentDir.Location = new System.Drawing.Point(3, 5);
            this.GoToParentDir.Name = "GoToParentDir";
            this.GoToParentDir.Size = new System.Drawing.Size(29, 29);
            this.GoToParentDir.TabIndex = 6;
            this.GoToParentDir.Text = "<";
            this.GoToParentDir.UseVisualStyleBackColor = false;
            this.GoToParentDir.Click += new System.EventHandler(this.GoToParentDir_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Black;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateButton.ForeColor = System.Drawing.Color.Gray;
            this.CreateButton.Location = new System.Drawing.Point(8, 116);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 29);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.ForeColor = System.Drawing.Color.Gray;
            this.nameBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameBox.Location = new System.Drawing.Point(8, 49);
            this.nameBox.Name = "nameBox";
            this.nameBox.PlaceholderText = "Имя";
            this.nameBox.Size = new System.Drawing.Size(100, 27);
            this.nameBox.TabIndex = 11;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Black;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.Gray;
            this.DeleteButton.Location = new System.Drawing.Point(8, 151);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 29);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.BackColor = System.Drawing.Color.Black;
            this.TypeComboBox.DropDownHeight = 100;
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.DropDownWidth = 100;
            this.TypeComboBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.IntegralHeight = false;
            this.TypeComboBox.Location = new System.Drawing.Point(8, 82);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(100, 28);
            this.TypeComboBox.TabIndex = 13;
            // 
            // OpenTxt
            // 
            this.OpenTxt.BackColor = System.Drawing.Color.Black;
            this.OpenTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenTxt.ForeColor = System.Drawing.Color.Gray;
            this.OpenTxt.Location = new System.Drawing.Point(8, 186);
            this.OpenTxt.Name = "OpenTxt";
            this.OpenTxt.Size = new System.Drawing.Size(100, 29);
            this.OpenTxt.TabIndex = 16;
            this.OpenTxt.Text = "Открыть txt";
            this.OpenTxt.UseVisualStyleBackColor = false;
            this.OpenTxt.Click += new System.EventHandler(this.OpenTxt_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UpdateDirButton);
            this.panel1.Controls.Add(this.GoToParentDir);
            this.panel1.Controls.Add(this.CurrentDir);
            this.panel1.Location = new System.Drawing.Point(148, 44);
            this.panel1.MinimumSize = new System.Drawing.Size(550, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 39);
            this.panel1.TabIndex = 19;
            // 
            // UpdateDirButton
            // 
            this.UpdateDirButton.BackColor = System.Drawing.Color.Black;
            this.UpdateDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDirButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateDirButton.ForeColor = System.Drawing.Color.Gray;
            this.UpdateDirButton.Location = new System.Drawing.Point(38, 5);
            this.UpdateDirButton.Name = "UpdateDirButton";
            this.UpdateDirButton.Size = new System.Drawing.Size(29, 29);
            this.UpdateDirButton.TabIndex = 7;
            this.UpdateDirButton.Text = "⭯";
            this.UpdateDirButton.UseVisualStyleBackColor = false;
            this.UpdateDirButton.Click += new System.EventHandler(this.UpdateDirButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TypeComboBox);
            this.panel2.Controls.Add(this.OpenTxt);
            this.panel2.Controls.Add(this.nameBox);
            this.panel2.Controls.Add(this.CreateButton);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 242);
            this.panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.MinimumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Создание";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.SetFontButton);
            this.panel3.Controls.Add(this.SetDarkThemeButton);
            this.panel3.Controls.Add(this.SetLightThemeButton);
            this.panel3.Location = new System.Drawing.Point(12, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 179);
            this.panel3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.MinimumSize = new System.Drawing.Size(100, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Темы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetFontButton
            // 
            this.SetFontButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetFontButton.BackColor = System.Drawing.Color.Black;
            this.SetFontButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetFontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetFontButton.ForeColor = System.Drawing.Color.Gray;
            this.SetFontButton.Location = new System.Drawing.Point(8, 113);
            this.SetFontButton.Name = "SetFontButton";
            this.SetFontButton.Size = new System.Drawing.Size(100, 29);
            this.SetFontButton.TabIndex = 16;
            this.SetFontButton.Text = "Шрифты";
            this.SetFontButton.UseVisualStyleBackColor = false;
            this.SetFontButton.Click += new System.EventHandler(this.SetFontButton_Click);
            // 
            // SetDarkThemeButton
            // 
            this.SetDarkThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetDarkThemeButton.BackColor = System.Drawing.Color.Black;
            this.SetDarkThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDarkThemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetDarkThemeButton.ForeColor = System.Drawing.Color.Gray;
            this.SetDarkThemeButton.Location = new System.Drawing.Point(8, 43);
            this.SetDarkThemeButton.Name = "SetDarkThemeButton";
            this.SetDarkThemeButton.Size = new System.Drawing.Size(100, 29);
            this.SetDarkThemeButton.TabIndex = 7;
            this.SetDarkThemeButton.Text = "Тёмная";
            this.SetDarkThemeButton.UseVisualStyleBackColor = false;
            this.SetDarkThemeButton.Click += new System.EventHandler(this.SetDarkThemeButton_Click);
            // 
            // SetLightThemeButton
            // 
            this.SetLightThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetLightThemeButton.BackColor = System.Drawing.Color.Black;
            this.SetLightThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetLightThemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetLightThemeButton.ForeColor = System.Drawing.Color.Gray;
            this.SetLightThemeButton.Location = new System.Drawing.Point(8, 78);
            this.SetLightThemeButton.Name = "SetLightThemeButton";
            this.SetLightThemeButton.Size = new System.Drawing.Size(100, 29);
            this.SetLightThemeButton.TabIndex = 12;
            this.SetLightThemeButton.Text = "Светлая";
            this.SetLightThemeButton.UseVisualStyleBackColor = false;
            this.SetLightThemeButton.Click += new System.EventHandler(this.SetLightThemeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Explorer";
            // 
            // Functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(966, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.ShowAllFiles);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(925, 591);
            this.Name = "Functions";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проводник";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private TextBox PathBox;
        private Button ShowAllFiles;
        private TextBox TypeBox;
        private Label CurrentDir;
        private Button GoToParentDir;
        private Button CreateButton;
        private RichTextBox richTextBox1;
        private Button button2;
        private TextBox nameBox;
        private Button DeleteButton;
        private ComboBox TypeComboBox;
        private FontDialog fontDialog1;
        private Button OpenTxt;
        private Panel panel1;
        private Button UpdateDirButton;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Button SetFontButton;
        private Button SetDarkThemeButton;
        private Button button4;
        private Label label3;
        private Button SetLightThemeButton;
        //private ListBox FilesAndDirsListBox1;
        //private ListBox listBox1;
    }
}