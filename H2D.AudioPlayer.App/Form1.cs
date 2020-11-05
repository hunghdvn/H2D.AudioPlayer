using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2D.AudioPlayer.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbFile_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var obj = lbFile.SelectedItem as FileInfo;
                if (obj == null)
                {
                    return;
                }
                axWindowsMediaPlayer.URL = obj.Value;
            }
            catch
            {

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                lbFile.Items.Clear();
                using (var openFile = new OpenFileDialog())
                {
                    openFile.Multiselect = true;
                    openFile.Filter = "Mp3 File|*.mp3";
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        var lstFile = new List<FileInfo>();
                        foreach (var item in openFile.FileNames)
                        {
                            lstFile.Add(new FileInfo { Display = openFile.SafeFileNames[openFile.FileNames.ToList().IndexOf(item)], Value = item });
                        }
                        lbFile.DataSource = lstFile;
                    }
                }
            }
            catch
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class FileInfo
    {
        public string Value { get; set; }
        public string Display { get; set; }
    }
}
