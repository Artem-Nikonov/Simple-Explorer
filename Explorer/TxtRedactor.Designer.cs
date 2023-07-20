namespace Проводник
{
    partial class TxtRedactor
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
            this.textOfFile = new System.Windows.Forms.RichTextBox();
            this.SaveTxtFileButton = new System.Windows.Forms.Button();
            this.RemoveTextButton = new System.Windows.Forms.Button();
            this.RestoreTextButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FontSettings = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textOfFile
            // 
            this.textOfFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textOfFile.BackColor = System.Drawing.Color.Black;
            this.textOfFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textOfFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textOfFile.ForeColor = System.Drawing.Color.Teal;
            this.textOfFile.Location = new System.Drawing.Point(12, 12);
            this.textOfFile.Name = "textOfFile";
            this.textOfFile.Size = new System.Drawing.Size(634, 333);
            this.textOfFile.TabIndex = 0;
            this.textOfFile.Text = "";
            // 
            // SaveTxtFileButton
            // 
            this.SaveTxtFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveTxtFileButton.BackColor = System.Drawing.Color.Black;
            this.SaveTxtFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveTxtFileButton.ForeColor = System.Drawing.Color.DarkGray;
            this.SaveTxtFileButton.Location = new System.Drawing.Point(498, 15);
            this.SaveTxtFileButton.Name = "SaveTxtFileButton";
            this.SaveTxtFileButton.Size = new System.Drawing.Size(116, 29);
            this.SaveTxtFileButton.TabIndex = 1;
            this.SaveTxtFileButton.Text = "Сохранить файл";
            this.SaveTxtFileButton.UseVisualStyleBackColor = false;
            this.SaveTxtFileButton.Click += new System.EventHandler(this.SaveTxtFileButton_Click);
            // 
            // RemoveTextButton
            // 
            this.RemoveTextButton.BackColor = System.Drawing.Color.Black;
            this.RemoveTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveTextButton.ForeColor = System.Drawing.Color.DarkGray;
            this.RemoveTextButton.Location = new System.Drawing.Point(15, 15);
            this.RemoveTextButton.Name = "RemoveTextButton";
            this.RemoveTextButton.Size = new System.Drawing.Size(121, 29);
            this.RemoveTextButton.TabIndex = 2;
            this.RemoveTextButton.Text = "Очистить документ";
            this.RemoveTextButton.UseVisualStyleBackColor = false;
            this.RemoveTextButton.Click += new System.EventHandler(this.RemoveTextButton_Click);
            // 
            // RestoreTextButton
            // 
            this.RestoreTextButton.BackColor = System.Drawing.Color.Black;
            this.RestoreTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreTextButton.ForeColor = System.Drawing.Color.DarkGray;
            this.RestoreTextButton.Location = new System.Drawing.Point(176, 15);
            this.RestoreTextButton.Name = "RestoreTextButton";
            this.RestoreTextButton.Size = new System.Drawing.Size(121, 29);
            this.RestoreTextButton.TabIndex = 3;
            this.RestoreTextButton.Text = "Восстановить";
            this.RestoreTextButton.UseVisualStyleBackColor = false;
            this.RestoreTextButton.Click += new System.EventHandler(this.RestoreTextButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FontSettings);
            this.panel1.Controls.Add(this.RemoveTextButton);
            this.panel1.Controls.Add(this.SaveTxtFileButton);
            this.panel1.Controls.Add(this.RestoreTextButton);
            this.panel1.Location = new System.Drawing.Point(12, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 59);
            this.panel1.TabIndex = 4;
            // 
            // FontSettings
            // 
            this.FontSettings.BackColor = System.Drawing.Color.Black;
            this.FontSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.FontSettings.ForeColor = System.Drawing.Color.Teal;
            this.FontSettings.Location = new System.Drawing.Point(337, 15);
            this.FontSettings.Name = "FontSettings";
            this.FontSettings.Size = new System.Drawing.Size(121, 29);
            this.FontSettings.TabIndex = 5;
            this.FontSettings.Text = "Аа (шрифты)";
            this.FontSettings.UseVisualStyleBackColor = false;
            this.FontSettings.Click += new System.EventHandler(this.FontSettings_Click_1);
            // 
            // TxtRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(658, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textOfFile);
            this.MinimumSize = new System.Drawing.Size(672, 283);
            this.Name = "TxtRedactor";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Текстовый редактор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TxtRedactor_FormClosed);
            this.Load += new System.EventHandler(this.TxtRedactor_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox textOfFile;
        private Button SaveTxtFileButton;
        private Button RemoveTextButton;
        private Button RestoreTextButton;
        private Panel panel1;
        private FontDialog fontDialog1;
        private Button FontSettings;
    }
}