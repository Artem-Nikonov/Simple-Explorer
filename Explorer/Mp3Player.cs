using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;
using Interfaces;

namespace Проводник
{
    internal class Mp3Player: IMp3PlayerWorker, IMp3PlayerInfo, IMp3PlayerSettings
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        string path = "";

        public Mp3Player(string path)
        {
            this.path = path;
            player.URL = path;
        }

        public void ChangeStateOfSong ()
        {
            if(player.playState == WMPPlayState.wmppsPlaying)
                player.controls.pause();
            else
                player.controls.play();
        }

        public void PlaySong()
        {
            player.controls.play();
        }

        public void StopSong()
        {
            player.controls.pause();
        }

        public bool IsPlaying()
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
                return true;
            return false;
        }

        public string GetStringTime()
        {
            string time = player.currentMedia.durationString;
            return time;
        }

        public double GetDoubleTime()
        {
            double time = player.currentMedia.duration;
            return time;
        }

        public string GetStringCurrentTime()
        {
            string time = player.controls.currentPositionString;
            return time;
        }

        public double GetDoubleCurrentTime()
        {
            double time = player.controls.currentPosition;
            return time;
        }

        public void SetVolume(int volume)
        {
            volume = volume > 100 ? 100 : volume < 0 ? 0 : volume;
            player.settings.volume = volume;
        }

        public void SetTime(int time)
        {
            player.controls.currentPosition = time;
        }

        public void SetSpeed(double speed)
        {
            player.settings.rate = speed;
        }

        public void SubscribeOnPlayStateChangeEvent(_WMPOCXEvents_PlayStateChangeEventHandler funct)
        {
            player.PlayStateChange+= funct;
        }

        public void UnSubscribeOnPlayStateChangeEvent(_WMPOCXEvents_PlayStateChangeEventHandler funct)
        {
            player.PlayStateChange -= funct;
        }
    }
}
