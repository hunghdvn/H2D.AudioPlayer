using H2D.AudioPlayer.App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2D.AudioPlayer.App
{
    public partial class Main : Form
    {
        private bool Playing = false;
        private bool Shuffle = false;
        private bool Repeat = false;
        private bool Mute = false;
        private int CurrentVol = 0;
        private bool ShowList = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer.settings.volume = 100;
                pnSubMedia.Visible = false;
                pnSubPlaylist.Visible = false;
                pnPlayList.Width = 0;
                PlayMusic(Application.StartupPath + @"\ChiecLaKho-PhamTruong.mp3");
                ShowVolume();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void ShowVolume()
        {
            int vol = (int)(pnVol.Width * (double)(axWindowsMediaPlayer.settings.volume / 100M));
            pnVolCurrent.Width = vol;
            lbVol.Text = axWindowsMediaPlayer.settings.volume + "%";
        }

        private void PlayMusic(string url)
        {
            axWindowsMediaPlayer.URL = url;
            Playing = true;
            picPlay.Image = Resources.pause;
            timerPlay.Enabled = true;
            timerPlay.Start();
            lbSongName.Text = axWindowsMediaPlayer.currentMedia.name;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            pnSubPlaylist.Visible = false;
            pnSubMedia.Visible = !pnSubMedia.Visible;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picPlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                ShowList = !ShowList;
                timerPanRight.Enabled = true;
                timerPanRight.Start();
                picPlaylist.Image = pnPlayList.Width == 300 ? Resources.playlist_off : Resources.playlist_on;
                pnInfo.Visible = !ShowList;
            }
            catch
            {

            }
        }

        private void ShowPlaylist(bool show)
        {
            if (show)
            {
                if (pnPlayList.Width < 300)
                {
                    pnPlayList.Width += 10;
                    Thread.Sleep(10);
                    ShowPlaylist(show);
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (pnPlayList.Width > 0)
                {
                    pnPlayList.Width -= 10;
                    Thread.Sleep(10);
                    ShowPlaylist(show);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            pnSubPlaylist.Visible = !pnSubPlaylist.Visible;
            pnSubMedia.Visible = false;
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (Playing)
                {
                    axWindowsMediaPlayer.Ctlcontrols.pause();
                    picPlay.Image = Resources.play;
                }
                else
                {
                    axWindowsMediaPlayer.Ctlcontrols.play();
                    picPlay.Image = Resources.pause;
                }
                Playing = !Playing;
            }
            catch
            {

            }
        }

        private void picShuffle_Click(object sender, EventArgs e)
        {
            try
            {
                picShuffle.Image = Shuffle ? Resources.unshuffle : Resources.shuffle;
                Shuffle = !Shuffle;
            }
            catch
            {

            }
        }

        private void timerPlay_Tick(object sender, EventArgs e)
        {
            try
            {
                lbLastTime.Text = axWindowsMediaPlayer.currentMedia.durationString;
                lbTimeCurrent.Text = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
                var currentTime = axWindowsMediaPlayer.Ctlcontrols.currentPosition;
                var allTime = axWindowsMediaPlayer.currentMedia.duration;
                pnTimeCurrent.Width = (int)(pnTime.Width * (currentTime / allTime));
            }
            catch
            {

            }
        }

        private void pnTime_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SetTime(e.Location.X);
            }
            catch
            {

            }
        }

        private void SetTime(int x)
        {
            pnTimeCurrent.Width = x;
            var currentTime = (double)pnTimeCurrent.Width;
            var allTime = (double)pnTime.Width;
            var current = axWindowsMediaPlayer.currentMedia.duration * (currentTime / allTime);
            axWindowsMediaPlayer.Ctlcontrols.currentPosition = current;
        }

        private void pnTimeCurrent_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SetTime(e.Location.X);
            }
            catch
            {

            }
        }

        private void pnVol_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SetVolume(e.Location.X);
            }
            catch
            {

            }
        }

        private void SetVolume(double x)
        {
            var totalVol = pnVol.Width;
            var vol = x / totalVol * 100;
            axWindowsMediaPlayer.settings.volume = (int)vol;
            ShowVolume();
        }

        private void pnVolCurrent_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SetVolume(e.Location.X);
            }
            catch
            {

            }
        }

        private void picVol_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mute)
                {
                    axWindowsMediaPlayer.settings.volume = CurrentVol;
                    ShowVolPicture();
                }
                else
                {
                    CurrentVol = axWindowsMediaPlayer.settings.volume;
                    axWindowsMediaPlayer.settings.volume = 0;
                    picVol.Image = Resources.mute;
                }
                Mute = !Mute;
            }
            catch
            {

            }
        }

        private void ShowVolPicture()
        {
            picVol.Image = axWindowsMediaPlayer.settings.volume > 50 ? Resources.high_vol : Resources.low_vol;
        }

        private void picRepeat_Click(object sender, EventArgs e)
        {
            try
            {
                Repeat = !Repeat;
                axWindowsMediaPlayer.settings.setMode("loop", Repeat);
                picRepeat.Image = Repeat ? Resources.repeat_on : Resources.repeat_off;
            }
            catch
            {

            }
        }

        private void timerPanRight_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ShowList)
                {
                    pnPlayList.Width += 10;
                    if (pnPlayList.Width == 300)
                        timerPanRight.Stop();
                }
                else
                {
                    pnPlayList.Width -= 10;
                    if (pnPlayList.Width == 0)
                        timerPanRight.Stop();
                }
            }
            catch
            {

            }
        }
    }
}
