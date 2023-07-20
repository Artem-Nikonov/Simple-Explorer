using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проводник
{
    public partial class Mp3Redactor : Form
    {
        Mp3Player player;
        string path = "";

        public Mp3Redactor()
        {
            InitializeComponent();
        }

        public Mp3Redactor(string path)
        {
            InitializeComponent();
            this.path = path;
            player = new Mp3Player(path);
        }

        double[] speed = new double[] { 0.25, 0.5, 0.75, 1, 1.25, 1.5, 1.75, 2 };
        private void Mp3Redactor_Load(object sender, EventArgs e)
        {
            SpeedComboBoxSettings(speed);
            speedComboBox.SelectedIndex = 3;
            timer1.Start();
            string songName = GetSongName(path);
            Text += $" ({songName})";
            SongName.Text = songName;
            player.SubscribeOnPlayStateChangeEvent(Funct);
        }

        private void Mp3Redactor_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.UnSubscribeOnPlayStateChangeEvent(Funct);
            timer1.Stop();
            player.StopSong();
            GC.Collect();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            SetSongSpeed();
            if (!timer1.Enabled)
                timer1.Start();
            player.ChangeStateOfSong();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.SetVolume(volumeTrackBar1.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(player.GetStringCurrentTime()))
            {
                timer1.Stop();
                currentTimeLabel.Text = player.GetStringTime();
                timeTrackBar.Value = timeTrackBar.Maximum;
                return;
            }
            currentTimeLabel.Text = player.GetStringCurrentTime();
            double CurrentTime = player.GetDoubleCurrentTime();
            timeTrackBar.Value = (int)CurrentTime;
        }

        private void timeTrackBar_Scroll(object sender, EventArgs e)
        {
            player.SetTime(timeTrackBar.Value);
            currentTimeLabel.Text = player.GetStringCurrentTime();
        }

        private void speedComboBox_SelectedIndexChanged(object sender, EventArgs e) => SetSongSpeed();


        //вспомогательные методы

        public void Funct(int NewState)
        {
            timeLabel.Text = player.GetStringTime();
            double Time = player.GetDoubleTime();
            timeTrackBar.Maximum = (int)Time;
            ChangeButtonText();
        }
           
        private string GetSongName(string path)
        {
            string fullName = Path.GetFileName(path);
            string type = new FileInformator().GetFileType(path);
            string name = fullName.Replace(type, "");
            return name;
        }

        private void ChangeButtonText()
        {
            bool Playing = player.IsPlaying();
            PlayButton.Text = Playing ? "▍ ▍" : "▶";
        }

        public void SpeedComboBoxSettings(double[] speed)
        {
            foreach (double sp in speed)
            {
                speedComboBox.Items.Add(sp);
            }
            speedComboBox.SelectedIndex = 1;
        }

        private void SetSongSpeed()
        {
            double speed = 1;
            double.TryParse(speedComboBox.Text, out speed);
            player.SetSpeed(speed);
        }

    }
}
