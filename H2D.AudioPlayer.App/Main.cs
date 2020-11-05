using H2D.AudioPlayer.App.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
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
        private List<string> ListFile;
        private bool BIsMouseDown = false;

        public Main(List<string> lstFile)
        {
            InitializeComponent();
            ListFile = lstFile;
        }

        public void AddNewTrack(string url)
        {
            if()
            axWindowsMediaPlayer.currentPlaylist.appendItem(axWindowsMediaPlayer.newMedia(url));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer.settings.volume = 100;
                pnSubMedia.Visible = true;
                pnSubPlaylist.Visible = false;
                pnPlayList.Width = 0;
                pnTimeCurrent.Width = 0;
                ShowVolume();
                if (ListFile.Count > 0)
                {
                    AddPlayList(ListFile);
                    picPlay_Click(null, null);
                }
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

        private void PlayMusic()
        {
            Playing = true;
            picPlay.Image = Resources.pause;
            timerPlay.Enabled = true;
            timerPlay.Start();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            try
            {
                pnSubPlaylist.Visible = false;
                pnSubMedia.Visible = !pnSubMedia.Visible;
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
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
                LoadPlayList();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void LoadPlayList()
        {
            if (!ShowList)
                return;
            pnPlayList.Controls.Clear();
            int count = axWindowsMediaPlayer.currentPlaylist.count;
            if (count == 0)
                return;
            for (int i = count - 1; i > -1; i--)
            {
                var font = new Font("Tahoma", 10);
                var label = new Label
                {
                    Font = font,
                    AutoSize = false,
                    Text = "     " + axWindowsMediaPlayer.currentPlaylist.Item[i].name,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0),
                    Height = 35,
                    ForeColor = Color.Silver,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    Tag = i
                };
                if (label.Text == "     " + axWindowsMediaPlayer.currentMedia.name)
                {
                    label.BackColor = Color.FromArgb(21, 7, 17);
                    label.Image = Resources.playing;
                }
                else
                {
                    label.BackColor = Color.FromArgb(35, 32, 39);
                    label.Image = null;
                }
                label.DoubleClick += Song_DoubleClick;
                pnPlayList.Controls.Add(label);
            }
        }

        private void Song_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var lable = sender as Label;
                int index = int.Parse(lable.Tag.ToString());
                axWindowsMediaPlayer.Ctlcontrols.playItem(axWindowsMediaPlayer.currentPlaylist.Item[index]);
                LoadPlayList();
            }
            catch (Exception ex)
            {
                ex.ShowException();
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
            try
            {
                pnSubPlaylist.Visible = !pnSubPlaylist.Visible;
                pnSubMedia.Visible = false;
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (Playing)
                {
                    axWindowsMediaPlayer.Ctlcontrols.pause();
                    picPlay.Image = Resources.play;
                    timerPlay.Stop();
                }
                else
                {
                    PlayMusic();
                    axWindowsMediaPlayer.Ctlcontrols.play();
                    picPlay.Image = Resources.pause;
                }
                Playing = !Playing;
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void picShuffle_Click(object sender, EventArgs e)
        {
            try
            {
                picShuffle.Image = Shuffle ? Resources.unshuffle : Resources.shuffle;
                Shuffle = !Shuffle;
                axWindowsMediaPlayer.settings.setMode("shuffle", Shuffle);
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void timerPlay_Tick(object sender, EventArgs e)
        {
            try
            {
                lbSongName.Text = axWindowsMediaPlayer.status;
                lbLastTime.Text = axWindowsMediaPlayer.currentMedia.durationString;
                lbTimeCurrent.Text = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
                var currentTime = axWindowsMediaPlayer.Ctlcontrols.currentPosition;
                var allTime = axWindowsMediaPlayer.currentMedia.duration;
                pnTimeCurrent.Width = (int)(pnTime.Width * (currentTime / allTime));
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void pnTime_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                SetTime(e.Location.X);
            }
            catch (Exception ex)
            {
                ex.ShowException();
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
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void pnVol_MouseDown(object sender, MouseEventArgs e)
        {
            BIsMouseDown = true;
        }

        private void SetVolume(double x)
        {
            if (!BIsMouseDown)
                return;
            var totalVol = pnVol.Width;
            var vol = x / totalVol * 100;
            axWindowsMediaPlayer.settings.volume = (int)vol;
            ShowVolume();
        }

        private void pnVolCurrent_MouseDown(object sender, MouseEventArgs e)
        {
            BIsMouseDown = true;
        }

        private void picVol_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mute)
                {
                    axWindowsMediaPlayer.settings.volume = CurrentVol;
                    ShowVolPicture();
                    ShowVolume();
                }
                else
                {
                    CurrentVol = axWindowsMediaPlayer.settings.volume;
                    SetVolume(0);
                    picVol.Image = Resources.mute;
                }
                Mute = !Mute;
            }
            catch (Exception ex)
            {
                ex.ShowException();
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
            catch (Exception ex)
            {
                ex.ShowException();
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
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFile = new OpenFileDialog())
                {
                    openFile.Multiselect = true;
                    openFile.Filter = "Audio File|*.mp3; *.wav; *.mp4";
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        axWindowsMediaPlayer.currentPlaylist = axWindowsMediaPlayer.newPlaylist("", "");
                        AddPlayList(openFile.FileNames.ToList());
                    }
                    picPlay_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void AddPlayList(List<string> lists)
        {
            foreach (var item in lists)
            {
                axWindowsMediaPlayer.currentPlaylist.appendItem(axWindowsMediaPlayer.newMedia(item));
            }
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer.Ctlcontrols.next();
                PlayMusic();
                LoadPlayList();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void picPre_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer.Ctlcontrols.previous();
                PlayMusic();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dic = new FolderBrowserDialog())
                {
                    if (dic.ShowDialog() == DialogResult.OK)
                    {
                        var lstFile = Directory.GetFiles(dic.SelectedPath, "*.mp3").ToList();
                        lstFile.AddRange(Directory.GetFiles(dic.SelectedPath, "*.wav"));
                        axWindowsMediaPlayer.currentPlaylist = axWindowsMediaPlayer.newPlaylist("", "");
                        foreach (var item in lstFile)
                        {
                            axWindowsMediaPlayer.currentPlaylist.appendItem(axWindowsMediaPlayer.newMedia(item));
                        }
                    }
                    picPlay_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void btnRecent_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                Playing = false;
                picPlay.Image = Resources.play;
            }
        }

        private void pnVol_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                SetVolume(e.Location.X);
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void pnVol_MouseUp(object sender, MouseEventArgs e)
        {
            BIsMouseDown = false;
        }

        private void pnVolCurrent_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                SetVolume(e.Location.X);
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void pnVolCurrent_MouseUp(object sender, MouseEventArgs e)
        {
            BIsMouseDown = false;
        }

        private void pnVolCurrent_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SetVolume(e.Location.X);
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void pnVol_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SetVolume(e.Location.X);
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }
    }
}
