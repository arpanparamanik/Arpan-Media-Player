
namespace Arpan_MediaPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SongsList = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.imgAlbum = new System.Windows.Forms.PictureBox();
            this.songProgress = new System.Windows.Forms.ProgressBar();
            this.volume = new System.Windows.Forms.TrackBar();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.lblVol = new System.Windows.Forms.Label();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblVolume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // SongsList
            // 
            this.SongsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SongsList.FormattingEnabled = true;
            this.SongsList.HorizontalScrollbar = true;
            this.SongsList.ItemHeight = 30;
            this.SongsList.Location = new System.Drawing.Point(4, 68);
            this.SongsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SongsList.Name = "SongsList";
            this.SongsList.Size = new System.Drawing.Size(366, 480);
            this.SongsList.TabIndex = 0;
            this.SongsList.SelectedIndexChanged += new System.EventHandler(this.SongsList_SelectedIndexChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(646, 470);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(53, 46);
            this.btnPlay.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnPlay, "Play");
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(701, 470);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(53, 46);
            this.btnPause.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnPause, "Pause");
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(536, 470);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(53, 46);
            this.btnPrev.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnPrev, "Previous");
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(591, 470);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 46);
            this.btnNext.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnNext, "Next");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(756, 470);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(53, 46);
            this.btnStop.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnStop, "Stop");
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFile
            // 
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.Location = new System.Drawing.Point(866, 470);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(53, 46);
            this.btnFile.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnFile, "Open mp3 files");
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // imgAlbum
            // 
            this.imgAlbum.Image = global::Arpan_MediaPlayer.Properties.Resources._default;
            this.imgAlbum.Location = new System.Drawing.Point(488, 68);
            this.imgAlbum.Name = "imgAlbum";
            this.imgAlbum.Size = new System.Drawing.Size(453, 363);
            this.imgAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAlbum.TabIndex = 7;
            this.imgAlbum.TabStop = false;
            // 
            // songProgress
            // 
            this.songProgress.Location = new System.Drawing.Point(418, 453);
            this.songProgress.Name = "songProgress";
            this.songProgress.Size = new System.Drawing.Size(605, 11);
            this.songProgress.TabIndex = 8;
            this.songProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.songProgress_MouseDown);
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(954, 145);
            this.volume.Maximum = 100;
            this.volume.Name = "volume";
            this.volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volume.Size = new System.Drawing.Size(69, 256);
            this.volume.TabIndex = 9;
            this.volume.Scroll += new System.EventHandler(this.volume_Scroll);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(414, 467);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(72, 30);
            this.lblStart.TabIndex = 10;
            this.lblStart.Text = "00:00";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(961, 467);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(72, 30);
            this.lblEnd.TabIndex = 11;
            this.lblEnd.Text = "00:00";
            // 
            // progressTimer
            // 
            this.progressTimer.Enabled = true;
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol.Location = new System.Drawing.Point(963, 120);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(60, 22);
            this.lblVol.TabIndex = 14;
            this.lblVol.Text = "lblVol";
            // 
            // btnShuffle
            // 
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Image")));
            this.btnShuffle.Location = new System.Drawing.Point(811, 470);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(53, 46);
            this.btnShuffle.TabIndex = 15;
            this.toolTip.SetToolTip(this.btnShuffle, "Shuffle");
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnSuffle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 62);
            this.panel1.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1055, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.toolTip.SetToolTip(this.btnExit, "Close");
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(3, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(304, 34);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Arpan - Media Player";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(568, 345);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(332, 56);
            this.player.TabIndex = 13;
            this.player.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1051, 567);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(8, 8);
            this.axWindowsMediaPlayer1.TabIndex = 12;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(953, 409);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(70, 22);
            this.lblVolume.TabIndex = 17;
            this.lblVolume.Text = "Volume";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1101, 550);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.player);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.songProgress);
            this.Controls.Add(this.imgAlbum);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.SongsList);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SongsList;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.PictureBox imgAlbum;
        private System.Windows.Forms.ProgressBar songProgress;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblVolume;
    }
}

