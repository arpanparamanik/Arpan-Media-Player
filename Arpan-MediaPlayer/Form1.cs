using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arpan_MediaPlayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            volume.Value = 60;
            lblVol.Text = "60 %";
        }

        string[] files, paths;
        bool suffle = false;

        private void SongsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[SongsList.SelectedIndex];
            player.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(paths[SongsList.SelectedIndex]);
                if(file.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    imgAlbum.Image = Image.FromStream(new MemoryStream(bin));
                }
                else
                {
                    imgAlbum.Image = Properties.Resources._default;
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                //imgAlbum.Image = Image.FromFile("Resources\\default.jpg");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            songProgress.Value = 0;
            lblStart.Text = "00:00";
            lblEnd.Text = "00:00";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(suffle)
            {
                Random rnd = new Random();
                int currItem = rnd.Next(SongsList.SelectedIndex, SongsList.Items.Count + 1);
                SongsList.SelectedIndex = currItem;
            }
            else
            {
                if (SongsList.SelectedIndex < SongsList.Items.Count - 1)
                {
                    SongsList.SelectedIndex += 1;
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (suffle)
            {
                Random rnd = new Random();
                int currItem = rnd.Next(0, SongsList.SelectedIndex + 1);
                SongsList.SelectedIndex = currItem;
            }
            else
            {
                if (SongsList.SelectedIndex > 0)
                {
                    SongsList.SelectedIndex -= 1;
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                songProgress.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                songProgress.Value = (int)player.Ctlcontrols.currentPosition;

                lblStart.Text = player.Ctlcontrols.currentPositionString;
                lblEnd.Text = player.Ctlcontrols.currentItem.durationString.ToString();

                if(songProgress.Value == songProgress.Maximum)
                {
                    if (suffle)
                    {
                        Random rnd = new Random();
                        int currItem = rnd.Next(SongsList.SelectedIndex, SongsList.Items.Count + 1);
                        SongsList.SelectedIndex = currItem;
                    }
                    else
                    {
                        if (SongsList.SelectedIndex < SongsList.Items.Count - 1)
                        {
                            SongsList.SelectedIndex += 1;
                        }
                    }
                }
            }
        }

        private void volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = volume.Value;
            lblVol.Text = volume.Value + " %";
        }

        private void songProgress_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / songProgress.Width;
        }

        private void btnSuffle_Click(object sender, EventArgs e)
        {
            if(suffle)
            {
                suffle = false;
                btnShuffle.BackColor = SystemColors.Control;
            }
            else
            {
                suffle = true;
                btnShuffle.BackColor = SystemColors.ButtonHighlight;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.DefaultExt = "mp3";
            ofd.Title = "Select songs";
            ofd.Filter = "MP3 files|*.mp3";
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                foreach(string n in files)
                {
                    SongsList.Items.Add(n);
                }
                SongsList.SelectedIndex = 0;
            }
        }

    }
}
