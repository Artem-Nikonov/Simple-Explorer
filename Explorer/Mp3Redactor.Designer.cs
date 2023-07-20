namespace Проводник
{
    partial class Mp3Redactor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mp3Redactor));
            this.SongName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.volumeTrackBar1 = new System.Windows.Forms.TrackBar();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTrackBar = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.speedComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SongName
            // 
            this.SongName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SongName.ForeColor = System.Drawing.Color.Teal;
            this.SongName.Location = new System.Drawing.Point(63, 279);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(154, 38);
            this.SongName.TabIndex = 0;
            this.SongName.Text = "SongName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 262);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayButton.BackColor = System.Drawing.Color.Black;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.ForeColor = System.Drawing.Color.Teal;
            this.PlayButton.Location = new System.Drawing.Point(12, 320);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(45, 45);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "▍ ▍";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // volumeTrackBar1
            // 
            this.volumeTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeTrackBar1.BackColor = System.Drawing.Color.Black;
            this.volumeTrackBar1.Location = new System.Drawing.Point(559, 320);
            this.volumeTrackBar1.Maximum = 100;
            this.volumeTrackBar1.Name = "volumeTrackBar1";
            this.volumeTrackBar1.Size = new System.Drawing.Size(100, 56);
            this.volumeTrackBar1.TabIndex = 3;
            this.volumeTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeTrackBar1.Value = 100;
            this.volumeTrackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.Color.Teal;
            this.timeLabel.Location = new System.Drawing.Point(501, 356);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(56, 25);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "00:00";
            // 
            // timeTrackBar
            // 
            this.timeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeTrackBar.BackColor = System.Drawing.Color.Black;
            this.timeTrackBar.Location = new System.Drawing.Point(63, 320);
            this.timeTrackBar.Maximum = 100;
            this.timeTrackBar.Name = "timeTrackBar";
            this.timeTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeTrackBar.Size = new System.Drawing.Size(494, 56);
            this.timeTrackBar.TabIndex = 5;
            this.timeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.timeTrackBar.Scroll += new System.EventHandler(this.timeTrackBar_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTimeLabel.ForeColor = System.Drawing.Color.Teal;
            this.currentTimeLabel.Location = new System.Drawing.Point(63, 356);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(56, 25);
            this.currentTimeLabel.TabIndex = 6;
            this.currentTimeLabel.Text = "00:00";
            // 
            // speedComboBox
            // 
            this.speedComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speedComboBox.BackColor = System.Drawing.Color.Black;
            this.speedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.speedComboBox.ForeColor = System.Drawing.Color.Teal;
            this.speedComboBox.FormattingEnabled = true;
            this.speedComboBox.Location = new System.Drawing.Point(572, 348);
            this.speedComboBox.Name = "speedComboBox";
            this.speedComboBox.Size = new System.Drawing.Size(75, 28);
            this.speedComboBox.TabIndex = 7;
            this.speedComboBox.SelectedIndexChanged += new System.EventHandler(this.speedComboBox_SelectedIndexChanged);
            // 
            // Mp3Redactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(671, 403);
            this.Controls.Add(this.speedComboBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.timeTrackBar);
            this.Controls.Add(this.volumeTrackBar1);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SongName);
            this.MinimumSize = new System.Drawing.Size(645, 450);
            this.Name = "Mp3Redactor";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mp3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mp3Redactor_FormClosed);
            this.Load += new System.EventHandler(this.Mp3Redactor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private VScrollBar vScrollBar1;
        private GroupBox groupBox2;
        private Label SongName;
        private PictureBox pictureBox1;
        private Button button1;
        private TrackBar volumeTrackBar1;
        private Button PlayButton;
        private Label timeLabel;
        private TrackBar timeTrackBar;
        private System.Windows.Forms.Timer timer1;
        private Label currentTimeLabel;
        private ComboBox speedComboBox;
    }
}