using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace H2D.AudioPlayer.App
{
    public class PlaylistHelper
    {
        private static void SavePlaylist(PlaylistModel playlist)
        {
            try
            {
                string filePath = Application.StartupPath + @"\Playlist\" + playlist.PlaylistName + ".xml";
                XmlHelper.SaveXML(playlist, filePath);
            }
            catch (Exception ex)
            {
                ex.ShowException();
            }
        }

        private static PlaylistModel LoadPlaylist(string playlist)
        {
            try
            {
                string filePath = Application.StartupPath + @"\Playlist\" + playlist + ".xml";
                return XmlHelper.LoadXML<PlaylistModel>(filePath);
            }
            catch (Exception ex)
            {
                ex.ShowException();
                return null;
            }
        }

        private static List<PlaylistModel> LoadPlaylist()
        {
            try
            {
                var lstPlaylist = new List<PlaylistModel>();
                string folder = Application.StartupPath + @"\Playlist\";
                if (!Directory.Exists(folder))
                {
                    return null;
                }
                var lstFile = Directory.GetFiles(folder);
                if (lstFile == null || lstFile.Count() <= 0)
                {
                    return null;
                }
                foreach (var file in lstFile)
                {
                    lstPlaylist.Add(XmlHelper.LoadXML<PlaylistModel>(file));
                }
                return lstPlaylist;
            }
            catch (Exception ex)
            {
                ex.ShowException();
                return null;
            }
        }
    }
}
