using System.Collections.Generic;

namespace H2D.AudioPlayer.App
{
    public class PlaylistModel
    {
        public string PlaylistName { get; set; }
        public List<SongModel> Songs { get; set; }
    }

    public class SongModel
    {
        public string SongName { get; set; }
        public string FilePath { get; set; }
    }
}
