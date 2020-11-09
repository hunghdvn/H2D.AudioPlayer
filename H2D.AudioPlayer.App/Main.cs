using H2D.AudioPlayer.App.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace H2D.AudioPlayer.App
{
    public partial class Main : Form
    {
        #region Properties
        private bool Playing = false;
        private bool Shuffle = false;
        private bool Repeat = false;
        private bool Mute = false;
        private int CurrentVol = 0;
        private bool ShowList = false;
        private List<string> ListFile;
        private List<string> CurrentPlayList = new List<string>();
        private bool BIsMouseDown = false;
        #endregion

        #region Method

        #region Init
        public Main(List<string> lstFile)
        {
            InitializeComponent();
            ListFile = lstFile;
        }

        public void AddNewTrack(string url)
        {
            try
            {
                AddTrackToPlayList(url);
                LoadPlayList();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                SetCurrentEffectType("Battery");
                //axWindowsMediaPlayer.BeginInit();
                axWindowsMediaPlayer.uiMode = "none";
                CurrentPlayList = new List<string>();
                axWindowsMediaPlayer.settings.volume = 100;
                pnSubMedia.Visible = true;
                pnSubPlaylist.Visible = false;
                pnSubTools.Visible = false;
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

        private void SetTime(int x)
        {
            if (!BIsMouseDown)
                return;
            if (axWindowsMediaPlayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                return;
            }
            pnTimeCurrent.Width = x;
            var currentTime = (double)pnTimeCurrent.Width;
            var allTime = (double)pnTime.Width;
            var current = axWindowsMediaPlayer.currentMedia.duration * (currentTime / allTime);
            axWindowsMediaPlayer.Ctlcontrols.currentPosition = current;
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

        private void PlayByTrack(WMPLib.IWMPMedia track)
        {
            if (!Playing)
            {
                axWindowsMediaPlayer.Ctlcontrols.playItem(track);
                picPlay.Image = Resources.pause;
                Playing = true;
                PlayMusic();
            }
        }
        #endregion

        #region Menu Event
        private void btnMedia_Click(object sender, EventArgs e)
        {
            try
            {
                pnSubPlaylist.Visible = false;
                pnSubTools.Visible = false;
                pnSubMedia.Visible = !pnSubMedia.Visible;
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
                    openFile.Filter = "Audio File|*.mp3; *.wav;|Video File|*.mp4; *.mkv; *.avi";
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        Playing = false;
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
            CurrentPlayList.Clear();
            foreach (var item in lists)
            {
                AddTrackToPlayList(item, false);
            }
            LoadPlayList();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dic = new FolderBrowserDialog())
                {
                    if (dic.ShowDialog() == DialogResult.OK)
                    {
                        CurrentPlayList.Clear();
                        Playing = false;
                        var lstFile = Directory.GetFiles(dic.SelectedPath, "*.mp3").ToList();
                        lstFile.AddRange(Directory.GetFiles(dic.SelectedPath, "*.wav"));
                        lstFile.AddRange(Directory.GetFiles(dic.SelectedPath, "*.flac"));
                        lstFile.AddRange(Directory.GetFiles(dic.SelectedPath, "*.mp4"));
                        lstFile.AddRange(Directory.GetFiles(dic.SelectedPath, "*.mkv"));
                        lstFile.AddRange(Directory.GetFiles(dic.SelectedPath, "*.avi"));
                        axWindowsMediaPlayer.currentPlaylist = axWindowsMediaPlayer.newPlaylist("", "");
                        foreach (var item in lstFile)
                        {
                            AddTrackToPlayList(item, false);
                        }
                        LoadPlayList();
                    }
                    picPlay_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void AddTrackToPlayList(string item, bool playAfter = true)
        {
            if (!CurrentPlayList.Contains(item))
            {
                CurrentPlayList.Add(item);
                var track = axWindowsMediaPlayer.newMedia(item);
                axWindowsMediaPlayer.currentPlaylist.appendItem(track);
                if (playAfter)
                    PlayByTrack(track);
            }
        }

        private void LoadPlayList()
        {
            if (!ShowList)
                return;
            if ((axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying ||
                 axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsTransitioning) &&
                 pnPlayList.Controls.Count == CurrentPlayList.Count)
            {
                foreach (Button button in pnPlayList.Controls)
                {
                    if (axWindowsMediaPlayer.currentPlaylist.Item[(int)button.Tag].name == axWindowsMediaPlayer.currentMedia.name)
                    {
                        button.Text = axWindowsMediaPlayer.currentMedia.name;
                        button.BackColor = Color.FromArgb(21, 7, 17);
                        button.Image = Resources.playing;
                        button.Padding = new Padding(0);
                        button.Focus();
                    }
                    else if (button.BackColor == Color.FromArgb(21, 7, 17))
                    {
                        button.Padding = new Padding(16, 0, 0, 0);
                        button.BackColor = Color.FromArgb(35, 32, 39);
                        button.Image = null;
                    }
                    else
                    {
                        continue;
                    }
                }
                return;
            }
            pnPlayList.Controls.Clear();
            int count = axWindowsMediaPlayer.currentPlaylist.count;
            if (count == 0)
                return;
            for (int i = count - 1; i > -1; i--)
            {
                var font = new Font("Tahoma", 9);
                var button = new Button
                {
                    Font = font,
                    Text = axWindowsMediaPlayer.currentPlaylist.Item[i].name,
                    Height = 35,
                    ForeColor = Color.Silver,
                    Tag = i,
                    Dock = DockStyle.Top,
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleLeft,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    ContextMenuStrip = menuSong
                };
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 7, 17);
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 7, 17);
                if (button.Text == axWindowsMediaPlayer.currentMedia.name)
                {
                    button.BackColor = Color.FromArgb(21, 7, 17);
                    button.Image = Resources.playing;
                    button.Padding = new Padding(0);
                }
                else
                {
                    button.Padding = new Padding(16, 0, 0, 0);
                    button.BackColor = Color.FromArgb(35, 32, 39);
                    button.Image = null;
                }
                button.Click += Button_Click;
                pnPlayList.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (((MouseEventArgs)e).Button == MouseButtons.Right)
                    return;
                var button = sender as Button;
                if (button == null)
                    return;
                int index = int.Parse(button.Tag.ToString());
                var track = axWindowsMediaPlayer.currentPlaylist.Item[index];
                Playing = false;
                PlayByTrack(track);
                LoadPlayList();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                pnSubPlaylist.Visible = !pnSubPlaylist.Visible;
                pnSubMedia.Visible = false;
                pnSubTools.Visible = false;
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void btnNewPlayList_Click(object sender, EventArgs e)
        {

        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            try
            {
                pnSubPlaylist.Visible = false;
                pnSubMedia.Visible = false;
                pnSubTools.Visible = !pnSubTools.Visible;
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            var help = new Help();
            help.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Control Event
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

        private void picPre_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer.Ctlcontrols.previous();
                PlayMusic();
                LoadPlayList();
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
                    Playing = false;
                }
                else
                {
                    if (axWindowsMediaPlayer.currentMedia == null)
                        return;
                    PlayMusic();
                    axWindowsMediaPlayer.Ctlcontrols.play();
                    picPlay.Image = Resources.pause;
                }
            }
            catch (Exception ex)
            {
                ex.ShowException();
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
                    lbVol.Text = "0%";
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
            if (axWindowsMediaPlayer.settings.volume == 0)
            {
                picVol.Image = Resources.mute;
                return;
            }
            picVol.Image = axWindowsMediaPlayer.settings.volume > 50 ? Resources.high_vol : Resources.low_vol;
        }
        #endregion

        #region ChangeVolSeekBar
        private void Vol_MouseClick(object sender, MouseEventArgs e)
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

        private void Vol_MouseDown(object sender, MouseEventArgs e)
        {
            BIsMouseDown = true;
        }

        private void Vol_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                SetVolume(e.Location.X);
                ShowVolPicture();
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void Vol_MouseUp(object sender, MouseEventArgs e)
        {
            BIsMouseDown = false;
        }
        #endregion

        #region ChangeTimeSeekBar
        private void Time_MouseClick(object sender, MouseEventArgs e)
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

        private void Time_MouseDown(object sender, MouseEventArgs e)
        {
            if (axWindowsMediaPlayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                BIsMouseDown = false;
                return;
            }
            BIsMouseDown = true;
        }

        private void Time_MouseMove(object sender, MouseEventArgs e)
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

        private void Time_MouseUp(object sender, MouseEventArgs e)
        {
            BIsMouseDown = false;
        }
        #endregion

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

        private void timerPanRight_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ShowList)
                {
                    pnPlayList.Width += 50;
                    if (pnPlayList.Width >= 300)
                        timerPanRight.Stop();
                }
                else
                {
                    pnPlayList.Width -= 50;
                    if (pnPlayList.Width <= 0)
                        timerPanRight.Stop();
                }
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                Playing = false;
                picPlay.Image = Resources.play;
            }
        }

        private void menuSong_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                var menu = sender as ContextMenuStrip;
                var button = menu.SourceControl as Button;
                var track = axWindowsMediaPlayer.currentPlaylist.Item[(int)button.Tag];
                if (e.ClickedItem.Name == "btnRemoveTrack")
                {
                    if (track.name == axWindowsMediaPlayer.currentMedia.name)
                    {
                        return;
                    }
                    axWindowsMediaPlayer.currentPlaylist.removeItem(track);
                    CurrentPlayList.Remove(track.sourceURL);
                    LoadPlayList();
                }
                else
                {
                    string path = track.sourceURL;
                    string dic = Path.GetDirectoryName(path);
                    Process.Start(dic);
                }
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private void btnRemoveTrack_MouseHover(object sender, EventArgs e)
        {
            btnOpenLocation.ForeColor = Color.Silver;
            btnRemoveTrack.ForeColor = Color.Black;
        }

        private void btnOpenLocation_MouseHover(object sender, EventArgs e)
        {
            btnOpenLocation.ForeColor = Color.Black;
            btnRemoveTrack.ForeColor = Color.Silver;
        }

        public void SetCurrentEffectType(string value)
        {
            WindowsIdentity identiry = WindowsIdentity.GetCurrent();
            String path = String.Format(@"{0}\Software\Microsoft\MediaPlayer\Preferences", identiry.User.Value);
            var key = Registry.Users.OpenSubKey(path, true);
            if (key == null)
                throw new Exception("Registry key not found!");
            key.SetValue("CurrentEffectType", value, RegistryValueKind.String);
        }

        public void SetCurrentEffectPreset(int value)
        {
            WindowsIdentity identiry = WindowsIdentity.GetCurrent();
            String path = String.Format(@"{0}\Software\Microsoft\MediaPlayer\Preferences", identiry.User.Value);
            var key = Registry.Users.OpenSubKey(path, true);
            if (key == null)
                throw new Exception("Registry key not found!");
            key.SetValue("CurrentEffectPreset", value, RegistryValueKind.DWord);
        }
        #endregion
    }
}
