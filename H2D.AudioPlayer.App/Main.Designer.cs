namespace H2D.AudioPlayer.App
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnMenuLeft = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnSubTools = new System.Windows.Forms.Panel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.pnSubPlaylist = new System.Windows.Forms.Panel();
            this.btnExportPlaylist = new System.Windows.Forms.Button();
            this.btnImportPlaylist = new System.Windows.Forms.Button();
            this.btnManagingPlaylist = new System.Windows.Forms.Button();
            this.btnNewPlayList = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.pnSubMedia = new System.Windows.Forms.Panel();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pnControl = new System.Windows.Forms.Panel();
            this.pnVol = new System.Windows.Forms.Panel();
            this.pnVolCurrent = new System.Windows.Forms.Panel();
            this.lbVol = new System.Windows.Forms.Label();
            this.lbTimeCurrent = new System.Windows.Forms.Label();
            this.lbLastTime = new System.Windows.Forms.Label();
            this.pnTime = new System.Windows.Forms.Panel();
            this.pnTimeCurrent = new System.Windows.Forms.Panel();
            this.picVol = new System.Windows.Forms.PictureBox();
            this.picPlaylist = new System.Windows.Forms.PictureBox();
            this.picShuffle = new System.Windows.Forms.PictureBox();
            this.picRepeat = new System.Windows.Forms.PictureBox();
            this.picPre = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lbSongName = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnMenuTop = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisualizationAlchemy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisualizationBattery = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBarAndWave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisualizationBars = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisualizationScope = new System.Windows.Forms.ToolStripMenuItem();
            this.pnPlayList = new System.Windows.Forms.Panel();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.timerPanRight = new System.Windows.Forms.Timer(this.components);
            this.menuSong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemoveTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnMenuLeft.SuspendLayout();
            this.pnSubTools.SuspendLayout();
            this.pnSubPlaylist.SuspendLayout();
            this.pnSubMedia.SuspendLayout();
            this.pnControl.SuspendLayout();
            this.pnVol.SuspendLayout();
            this.pnTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.pnCenter.SuspendLayout();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.pbTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnMenuTop.SuspendLayout();
            this.menu.SuspendLayout();
            this.menuSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenuLeft
            // 
            this.pnMenuLeft.AutoScroll = true;
            this.pnMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnMenuLeft.Controls.Add(this.btnExit);
            this.pnMenuLeft.Controls.Add(this.btnHelp);
            this.pnMenuLeft.Controls.Add(this.pnSubTools);
            this.pnMenuLeft.Controls.Add(this.btnTools);
            this.pnMenuLeft.Controls.Add(this.pnSubPlaylist);
            this.pnMenuLeft.Controls.Add(this.btnPlaylist);
            this.pnMenuLeft.Controls.Add(this.pnSubMedia);
            this.pnMenuLeft.Controls.Add(this.btnMedia);
            this.pnMenuLeft.Controls.Add(this.pnLogo);
            this.pnMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuLeft.Location = new System.Drawing.Point(0, 58);
            this.pnMenuLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnMenuLeft.Name = "pnMenuLeft";
            this.pnMenuLeft.Size = new System.Drawing.Size(250, 462);
            this.pnMenuLeft.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 563);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(233, 45);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Silver;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 518);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(233, 45);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnSubTools
            // 
            this.pnSubTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnSubTools.Controls.Add(this.btnConvert);
            this.pnSubTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubTools.Location = new System.Drawing.Point(0, 478);
            this.pnSubTools.Name = "pnSubTools";
            this.pnSubTools.Size = new System.Drawing.Size(233, 40);
            this.pnSubTools.TabIndex = 8;
            // 
            // btnConvert
            // 
            this.btnConvert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.ForeColor = System.Drawing.Color.Silver;
            this.btnConvert.Location = new System.Drawing.Point(0, 0);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConvert.Size = new System.Drawing.Size(233, 40);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Media convert";
            this.btnConvert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // btnTools
            // 
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.ForeColor = System.Drawing.Color.Silver;
            this.btnTools.Image = ((System.Drawing.Image)(resources.GetObject("btnTools.Image")));
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(0, 433);
            this.btnTools.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTools.Size = new System.Drawing.Size(233, 45);
            this.btnTools.TabIndex = 5;
            this.btnTools.Text = "Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // pnSubPlaylist
            // 
            this.pnSubPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnSubPlaylist.Controls.Add(this.btnExportPlaylist);
            this.pnSubPlaylist.Controls.Add(this.btnImportPlaylist);
            this.pnSubPlaylist.Controls.Add(this.btnManagingPlaylist);
            this.pnSubPlaylist.Controls.Add(this.btnNewPlayList);
            this.pnSubPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubPlaylist.Location = new System.Drawing.Point(0, 270);
            this.pnSubPlaylist.Name = "pnSubPlaylist";
            this.pnSubPlaylist.Size = new System.Drawing.Size(233, 163);
            this.pnSubPlaylist.TabIndex = 4;
            // 
            // btnExportPlaylist
            // 
            this.btnExportPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportPlaylist.FlatAppearance.BorderSize = 0;
            this.btnExportPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnExportPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnExportPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPlaylist.ForeColor = System.Drawing.Color.Silver;
            this.btnExportPlaylist.Location = new System.Drawing.Point(0, 120);
            this.btnExportPlaylist.Name = "btnExportPlaylist";
            this.btnExportPlaylist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExportPlaylist.Size = new System.Drawing.Size(233, 40);
            this.btnExportPlaylist.TabIndex = 3;
            this.btnExportPlaylist.Text = "Export playlist";
            this.btnExportPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnImportPlaylist
            // 
            this.btnImportPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportPlaylist.FlatAppearance.BorderSize = 0;
            this.btnImportPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnImportPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnImportPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportPlaylist.ForeColor = System.Drawing.Color.Silver;
            this.btnImportPlaylist.Location = new System.Drawing.Point(0, 80);
            this.btnImportPlaylist.Name = "btnImportPlaylist";
            this.btnImportPlaylist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnImportPlaylist.Size = new System.Drawing.Size(233, 40);
            this.btnImportPlaylist.TabIndex = 2;
            this.btnImportPlaylist.Text = "Import playlist";
            this.btnImportPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnManagingPlaylist
            // 
            this.btnManagingPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagingPlaylist.FlatAppearance.BorderSize = 0;
            this.btnManagingPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnManagingPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnManagingPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagingPlaylist.ForeColor = System.Drawing.Color.Silver;
            this.btnManagingPlaylist.Location = new System.Drawing.Point(0, 40);
            this.btnManagingPlaylist.Name = "btnManagingPlaylist";
            this.btnManagingPlaylist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnManagingPlaylist.Size = new System.Drawing.Size(233, 40);
            this.btnManagingPlaylist.TabIndex = 1;
            this.btnManagingPlaylist.Text = "Managing playlist";
            this.btnManagingPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagingPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnNewPlayList
            // 
            this.btnNewPlayList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewPlayList.FlatAppearance.BorderSize = 0;
            this.btnNewPlayList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnNewPlayList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnNewPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlayList.ForeColor = System.Drawing.Color.Silver;
            this.btnNewPlayList.Location = new System.Drawing.Point(0, 0);
            this.btnNewPlayList.Name = "btnNewPlayList";
            this.btnNewPlayList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNewPlayList.Size = new System.Drawing.Size(233, 40);
            this.btnNewPlayList.TabIndex = 0;
            this.btnNewPlayList.Text = "New playlist";
            this.btnNewPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPlayList.UseVisualStyleBackColor = true;
            this.btnNewPlayList.Click += new System.EventHandler(this.btnNewPlayList_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Silver;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 225);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(233, 45);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // pnSubMedia
            // 
            this.pnSubMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnSubMedia.Controls.Add(this.btnOpenFolder);
            this.pnSubMedia.Controls.Add(this.btnOpenFile);
            this.pnSubMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMedia.Location = new System.Drawing.Point(0, 145);
            this.pnSubMedia.Name = "pnSubMedia";
            this.pnSubMedia.Size = new System.Drawing.Size(233, 80);
            this.pnSubMedia.TabIndex = 2;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFolder.FlatAppearance.BorderSize = 0;
            this.btnOpenFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnOpenFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.ForeColor = System.Drawing.Color.Silver;
            this.btnOpenFolder.Location = new System.Drawing.Point(0, 40);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOpenFolder.Size = new System.Drawing.Size(233, 40);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.ForeColor = System.Drawing.Color.Silver;
            this.btnOpenFile.Location = new System.Drawing.Point(0, 0);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOpenFile.Size = new System.Drawing.Size(233, 40);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.Color.Silver;
            this.btnMedia.Image = ((System.Drawing.Image)(resources.GetObject("btnMedia.Image")));
            this.btnMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.Location = new System.Drawing.Point(0, 100);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(233, 45);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnLogo.BackgroundImage")));
            this.pnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(233, 100);
            this.pnLogo.TabIndex = 0;
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnControl.Controls.Add(this.pnVol);
            this.pnControl.Controls.Add(this.lbVol);
            this.pnControl.Controls.Add(this.lbTimeCurrent);
            this.pnControl.Controls.Add(this.lbLastTime);
            this.pnControl.Controls.Add(this.pnTime);
            this.pnControl.Controls.Add(this.picVol);
            this.pnControl.Controls.Add(this.picPlaylist);
            this.pnControl.Controls.Add(this.picShuffle);
            this.pnControl.Controls.Add(this.picRepeat);
            this.pnControl.Controls.Add(this.picPre);
            this.pnControl.Controls.Add(this.picNext);
            this.pnControl.Controls.Add(this.picPlay);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControl.Location = new System.Drawing.Point(250, 415);
            this.pnControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(590, 105);
            this.pnControl.TabIndex = 1;
            // 
            // pnVol
            // 
            this.pnVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnVol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.pnVol.Controls.Add(this.pnVolCurrent);
            this.pnVol.Location = new System.Drawing.Point(355, 34);
            this.pnVol.Name = "pnVol";
            this.pnVol.Size = new System.Drawing.Size(153, 7);
            this.pnVol.TabIndex = 20;
            this.pnVol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Vol_MouseClick);
            this.pnVol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vol_MouseDown);
            this.pnVol.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vol_MouseMove);
            this.pnVol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vol_MouseUp);
            // 
            // pnVolCurrent
            // 
            this.pnVolCurrent.BackColor = System.Drawing.Color.White;
            this.pnVolCurrent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnVolCurrent.Location = new System.Drawing.Point(0, 0);
            this.pnVolCurrent.Name = "pnVolCurrent";
            this.pnVolCurrent.Size = new System.Drawing.Size(50, 7);
            this.pnVolCurrent.TabIndex = 1;
            this.pnVolCurrent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Vol_MouseClick);
            this.pnVolCurrent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vol_MouseDown);
            this.pnVolCurrent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vol_MouseMove);
            this.pnVolCurrent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vol_MouseUp);
            // 
            // lbVol
            // 
            this.lbVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVol.AutoSize = true;
            this.lbVol.ForeColor = System.Drawing.Color.LightGray;
            this.lbVol.Location = new System.Drawing.Point(529, 29);
            this.lbVol.Name = "lbVol";
            this.lbVol.Size = new System.Drawing.Size(28, 19);
            this.lbVol.TabIndex = 23;
            this.lbVol.Text = "0%";
            // 
            // lbTimeCurrent
            // 
            this.lbTimeCurrent.AutoSize = true;
            this.lbTimeCurrent.ForeColor = System.Drawing.Color.LightGray;
            this.lbTimeCurrent.Location = new System.Drawing.Point(17, 64);
            this.lbTimeCurrent.Name = "lbTimeCurrent";
            this.lbTimeCurrent.Size = new System.Drawing.Size(45, 19);
            this.lbTimeCurrent.TabIndex = 22;
            this.lbTimeCurrent.Text = "00:00";
            // 
            // lbLastTime
            // 
            this.lbLastTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLastTime.AutoSize = true;
            this.lbLastTime.ForeColor = System.Drawing.Color.LightGray;
            this.lbLastTime.Location = new System.Drawing.Point(529, 64);
            this.lbLastTime.Name = "lbLastTime";
            this.lbLastTime.Size = new System.Drawing.Size(45, 19);
            this.lbLastTime.TabIndex = 20;
            this.lbLastTime.Text = "00:00";
            // 
            // pnTime
            // 
            this.pnTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.pnTime.Controls.Add(this.pnTimeCurrent);
            this.pnTime.Location = new System.Drawing.Point(63, 71);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(446, 7);
            this.pnTime.TabIndex = 19;
            this.pnTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Time_MouseClick);
            this.pnTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Time_MouseDown);
            this.pnTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Time_MouseMove);
            this.pnTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Time_MouseUp);
            // 
            // pnTimeCurrent
            // 
            this.pnTimeCurrent.BackColor = System.Drawing.Color.White;
            this.pnTimeCurrent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTimeCurrent.Location = new System.Drawing.Point(0, 0);
            this.pnTimeCurrent.Name = "pnTimeCurrent";
            this.pnTimeCurrent.Size = new System.Drawing.Size(200, 7);
            this.pnTimeCurrent.TabIndex = 0;
            this.pnTimeCurrent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Time_MouseClick);
            this.pnTimeCurrent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Time_MouseDown);
            this.pnTimeCurrent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Time_MouseMove);
            this.pnTimeCurrent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Time_MouseUp);
            // 
            // picVol
            // 
            this.picVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picVol.Image = global::H2D.AudioPlayer.App.Properties.Resources.high_vol;
            this.picVol.Location = new System.Drawing.Point(325, 24);
            this.picVol.Name = "picVol";
            this.picVol.Size = new System.Drawing.Size(24, 24);
            this.picVol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVol.TabIndex = 18;
            this.picVol.TabStop = false;
            this.picVol.Click += new System.EventHandler(this.picVol_Click);
            // 
            // picPlaylist
            // 
            this.picPlaylist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlaylist.Image = global::H2D.AudioPlayer.App.Properties.Resources.playlist_off;
            this.picPlaylist.Location = new System.Drawing.Point(36, 24);
            this.picPlaylist.Name = "picPlaylist";
            this.picPlaylist.Size = new System.Drawing.Size(24, 24);
            this.picPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlaylist.TabIndex = 17;
            this.picPlaylist.TabStop = false;
            this.toolTip1.SetToolTip(this.picPlaylist, "Playlist");
            this.picPlaylist.Click += new System.EventHandler(this.picPlaylist_Click);
            // 
            // picShuffle
            // 
            this.picShuffle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShuffle.Image = global::H2D.AudioPlayer.App.Properties.Resources.unshuffle;
            this.picShuffle.Location = new System.Drawing.Point(81, 24);
            this.picShuffle.Name = "picShuffle";
            this.picShuffle.Size = new System.Drawing.Size(24, 24);
            this.picShuffle.TabIndex = 16;
            this.picShuffle.TabStop = false;
            this.toolTip1.SetToolTip(this.picShuffle, "Shuffle");
            this.picShuffle.Click += new System.EventHandler(this.picShuffle_Click);
            // 
            // picRepeat
            // 
            this.picRepeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRepeat.Image = global::H2D.AudioPlayer.App.Properties.Resources.repeat_off;
            this.picRepeat.Location = new System.Drawing.Point(273, 24);
            this.picRepeat.Name = "picRepeat";
            this.picRepeat.Size = new System.Drawing.Size(24, 24);
            this.picRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRepeat.TabIndex = 15;
            this.picRepeat.TabStop = false;
            this.toolTip1.SetToolTip(this.picRepeat, "Repeat");
            this.picRepeat.Click += new System.EventHandler(this.picRepeat_Click);
            // 
            // picPre
            // 
            this.picPre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPre.Image = ((System.Drawing.Image)(resources.GetObject("picPre.Image")));
            this.picPre.Location = new System.Drawing.Point(123, 24);
            this.picPre.Name = "picPre";
            this.picPre.Size = new System.Drawing.Size(24, 24);
            this.picPre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPre.TabIndex = 14;
            this.picPre.TabStop = false;
            this.toolTip1.SetToolTip(this.picPre, "Preview");
            this.picPre.Click += new System.EventHandler(this.picPre_Click);
            // 
            // picNext
            // 
            this.picNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.Image = ((System.Drawing.Image)(resources.GetObject("picNext.Image")));
            this.picNext.Location = new System.Drawing.Point(232, 24);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(24, 24);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picNext.TabIndex = 13;
            this.picNext.TabStop = false;
            this.toolTip1.SetToolTip(this.picNext, "Next");
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picPlay
            // 
            this.picPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlay.Image = global::H2D.AudioPlayer.App.Properties.Resources.play;
            this.picPlay.Location = new System.Drawing.Point(174, 20);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(32, 32);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlay.TabIndex = 12;
            this.picPlay.TabStop = false;
            this.toolTip1.SetToolTip(this.picPlay, "Play/Pause");
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnCenter.Controls.Add(this.pnInfo);
            this.pnCenter.Controls.Add(this.axWindowsMediaPlayer);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(250, 58);
            this.pnCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(290, 357);
            this.pnCenter.TabIndex = 2;
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.Black;
            this.pnInfo.Controls.Add(this.lbSongName);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInfo.Location = new System.Drawing.Point(0, 0);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(290, 45);
            this.pnInfo.TabIndex = 1;
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.ForeColor = System.Drawing.Color.Silver;
            this.lbSongName.Location = new System.Drawing.Point(0, 14);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbSongName.Size = new System.Drawing.Size(10, 17);
            this.lbSongName.TabIndex = 0;
            this.lbSongName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(290, 357);
            this.axWindowsMediaPlayer.TabIndex = 0;
            this.axWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer_PlayStateChange);
            // 
            // pbTitle
            // 
            this.pbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pbTitle.Controls.Add(this.lbTitle);
            this.pbTitle.Controls.Add(this.panel1);
            this.pbTitle.Controls.Add(this.pnMenuTop);
            this.pbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbTitle.Location = new System.Drawing.Point(0, 0);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(840, 58);
            this.pbTitle.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Silver;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbTitle.Size = new System.Drawing.Size(742, 31);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "H2D Player";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDoubleClick);
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(742, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel1.Size = new System.Drawing.Size(98, 31);
            this.panel1.TabIndex = 4;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(31, 31);
            this.btnMinimize.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(31, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(31, 31);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "button2";
            this.toolTip1.SetToolTip(this.btnMaximize, "Maximize");
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(62, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "button1";
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnMenuTop
            // 
            this.pnMenuTop.Controls.Add(this.menu);
            this.pnMenuTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnMenuTop.Location = new System.Drawing.Point(0, 31);
            this.pnMenuTop.Name = "pnMenuTop";
            this.pnMenuTop.Size = new System.Drawing.Size(840, 27);
            this.pnMenuTop.TabIndex = 3;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.visualizationToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(840, 27);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.openFileToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.openFolderToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // visualizationToolStripMenuItem
            // 
            this.visualizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVisualizationAlchemy,
            this.mnuVisualizationBattery,
            this.mnuBarAndWave});
            this.visualizationToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.visualizationToolStripMenuItem.Name = "visualizationToolStripMenuItem";
            this.visualizationToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.visualizationToolStripMenuItem.Text = "Visualization";
            // 
            // mnuVisualizationAlchemy
            // 
            this.mnuVisualizationAlchemy.AutoSize = false;
            this.mnuVisualizationAlchemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.mnuVisualizationAlchemy.ForeColor = System.Drawing.Color.Silver;
            this.mnuVisualizationAlchemy.Name = "mnuVisualizationAlchemy";
            this.mnuVisualizationAlchemy.Size = new System.Drawing.Size(189, 24);
            this.mnuVisualizationAlchemy.Text = "Alchemy";
            this.mnuVisualizationAlchemy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuVisualizationAlchemy.Click += new System.EventHandler(this.mnuVisualization_Click);
            // 
            // mnuVisualizationBattery
            // 
            this.mnuVisualizationBattery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.mnuVisualizationBattery.ForeColor = System.Drawing.Color.Silver;
            this.mnuVisualizationBattery.Name = "mnuVisualizationBattery";
            this.mnuVisualizationBattery.Size = new System.Drawing.Size(189, 24);
            this.mnuVisualizationBattery.Text = "Battery";
            this.mnuVisualizationBattery.Click += new System.EventHandler(this.mnuVisualization_Click);
            // 
            // mnuBarAndWave
            // 
            this.mnuBarAndWave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.mnuBarAndWave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVisualizationBars,
            this.mnuVisualizationScope});
            this.mnuBarAndWave.ForeColor = System.Drawing.Color.Silver;
            this.mnuBarAndWave.Name = "mnuBarAndWave";
            this.mnuBarAndWave.Size = new System.Drawing.Size(189, 24);
            this.mnuBarAndWave.Text = "Bars and Waves";
            // 
            // mnuVisualizationBars
            // 
            this.mnuVisualizationBars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.mnuVisualizationBars.ForeColor = System.Drawing.Color.Silver;
            this.mnuVisualizationBars.Name = "mnuVisualizationBars";
            this.mnuVisualizationBars.Size = new System.Drawing.Size(180, 24);
            this.mnuVisualizationBars.Text = "Bars";
            this.mnuVisualizationBars.Click += new System.EventHandler(this.mnuVisualization_Click);
            // 
            // mnuVisualizationScope
            // 
            this.mnuVisualizationScope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.mnuVisualizationScope.ForeColor = System.Drawing.Color.Silver;
            this.mnuVisualizationScope.Name = "mnuVisualizationScope";
            this.mnuVisualizationScope.Size = new System.Drawing.Size(180, 24);
            this.mnuVisualizationScope.Text = "Scope";
            this.mnuVisualizationScope.Click += new System.EventHandler(this.mnuVisualization_Click);
            // 
            // pnPlayList
            // 
            this.pnPlayList.AutoScroll = true;
            this.pnPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnPlayList.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPlayList.Location = new System.Drawing.Point(540, 58);
            this.pnPlayList.Name = "pnPlayList";
            this.pnPlayList.Size = new System.Drawing.Size(300, 357);
            this.pnPlayList.TabIndex = 1;
            // 
            // timerPlay
            // 
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // timerPanRight
            // 
            this.timerPanRight.Interval = 15;
            this.timerPanRight.Tick += new System.EventHandler(this.timerPanRight_Tick);
            // 
            // menuSong
            // 
            this.menuSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.menuSong.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.menuSong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemoveTrack,
            this.btnOpenLocation});
            this.menuSong.Name = "menuSong";
            this.menuSong.ShowImageMargin = false;
            this.menuSong.Size = new System.Drawing.Size(178, 64);
            this.menuSong.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuSong_ItemClicked);
            // 
            // btnRemoveTrack
            // 
            this.btnRemoveTrack.AutoSize = false;
            this.btnRemoveTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnRemoveTrack.ForeColor = System.Drawing.Color.Silver;
            this.btnRemoveTrack.Name = "btnRemoveTrack";
            this.btnRemoveTrack.Size = new System.Drawing.Size(202, 30);
            this.btnRemoveTrack.Text = "Delete";
            this.btnRemoveTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpenLocation
            // 
            this.btnOpenLocation.AutoSize = false;
            this.btnOpenLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnOpenLocation.ForeColor = System.Drawing.Color.Silver;
            this.btnOpenLocation.Name = "btnOpenLocation";
            this.btnOpenLocation.Size = new System.Drawing.Size(202, 30);
            this.btnOpenLocation.Text = "Open file location";
            this.btnOpenLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 520);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnPlayList);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnMenuLeft);
            this.Controls.Add(this.pbTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(840, 520);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H2D Player";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnMenuLeft.ResumeLayout(false);
            this.pnSubTools.ResumeLayout(false);
            this.pnSubPlaylist.ResumeLayout(false);
            this.pnSubMedia.ResumeLayout(false);
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            this.pnVol.ResumeLayout(false);
            this.pnTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.pnCenter.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.pbTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnMenuTop.ResumeLayout(false);
            this.pnMenuTop.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.menuSong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenuLeft;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Panel pnSubMedia;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Panel pnSubPlaylist;
        private System.Windows.Forms.Button btnExportPlaylist;
        private System.Windows.Forms.Button btnImportPlaylist;
        private System.Windows.Forms.Button btnManagingPlaylist;
        private System.Windows.Forms.Button btnNewPlayList;
        private System.Windows.Forms.Label lbVol;
        private System.Windows.Forms.Label lbTimeCurrent;
        private System.Windows.Forms.Label lbLastTime;
        private System.Windows.Forms.Panel pnTime;
        private System.Windows.Forms.PictureBox picVol;
        private System.Windows.Forms.PictureBox picPlaylist;
        private System.Windows.Forms.PictureBox picShuffle;
        private System.Windows.Forms.PictureBox picRepeat;
        private System.Windows.Forms.PictureBox picPre;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picPlay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Panel pnPlayList;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Panel pnVol;
        private System.Windows.Forms.Panel pnTimeCurrent;
        private System.Windows.Forms.Timer timerPanRight;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Panel pnVolCurrent;
        private System.Windows.Forms.ContextMenuStrip menuSong;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveTrack;
        private System.Windows.Forms.ToolStripMenuItem btnOpenLocation;
        private System.Windows.Forms.Panel pnSubTools;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pbTitle;
        private System.Windows.Forms.Panel pnMenuTop;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuVisualizationAlchemy;
        private System.Windows.Forms.ToolStripMenuItem mnuVisualizationBattery;
        private System.Windows.Forms.ToolStripMenuItem mnuBarAndWave;
        private System.Windows.Forms.ToolStripMenuItem mnuVisualizationBars;
        private System.Windows.Forms.ToolStripMenuItem mnuVisualizationScope;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTitle;
    }
}