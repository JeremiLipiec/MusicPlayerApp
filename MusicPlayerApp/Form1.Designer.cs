
namespace MusicPlayerApp
{
    partial class MusicPlayerApp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.Title = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.controlsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.closeControl = new System.Windows.Forms.PictureBox();
            this.minimalizeControl = new System.Windows.Forms.PictureBox();
            this.settingsControl = new System.Windows.Forms.PictureBox();
            this.pictureinf = new System.Windows.Forms.PictureBox();
            this.pictureone = new System.Windows.Forms.PictureBox();
            this.picturenone = new System.Windows.Forms.PictureBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.songsList = new System.Windows.Forms.ListBox();
            this.playSongButton = new System.Windows.Forms.Button();
            this.playbutton = new System.Windows.Forms.PictureBox();
            this.pausebutton = new System.Windows.Forms.PictureBox();
            this.stopbutton = new System.Windows.Forms.PictureBox();
            this.volumeSlider = new System.Windows.Forms.TrackBar();
            this.volumelabel = new System.Windows.Forms.Label();
            this.volumeTextLabel = new System.Windows.Forms.Label();
            this.currentDurationLabel = new System.Windows.Forms.Label();
            this.songdurationlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.musicProgressBar2 = new System.Windows.Forms.TrackBar();
            this.playStateLabel = new System.Windows.Forms.Label();
            this.loadInfoLabel = new System.Windows.Forms.Label();
            this.repeatTypeButton = new System.Windows.Forms.PictureBox();
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.loadButton = new System.Windows.Forms.Button();
            this.Title.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimalizeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureinf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturenone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicProgressBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatTypeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Title.Controls.Add(this.versionLabel);
            this.Title.Controls.Add(this.TitleLabel);
            this.Title.Controls.Add(this.controlsPanel);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(800, 40);
            this.Title.TabIndex = 0;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // versionLabel
            // 
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.versionLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.versionLabel.Location = new System.Drawing.Point(177, 13);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(66, 19);
            this.versionLabel.TabIndex = 17;
            this.versionLabel.Text = "v 0.0.0.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(174, 40);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Music Player";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseMove);
            // 
            // controlsPanel
            // 
            this.controlsPanel.ColumnCount = 3;
            this.controlsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlsPanel.Controls.Add(this.closeControl, 2, 0);
            this.controlsPanel.Controls.Add(this.minimalizeControl, 1, 0);
            this.controlsPanel.Controls.Add(this.settingsControl, 0, 0);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlsPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.controlsPanel.Location = new System.Drawing.Point(688, 0);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.RowCount = 1;
            this.controlsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlsPanel.Size = new System.Drawing.Size(112, 40);
            this.controlsPanel.TabIndex = 20;
            // 
            // closeControl
            // 
            this.closeControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeControl.Image = ((System.Drawing.Image)(resources.GetObject("closeControl.Image")));
            this.closeControl.Location = new System.Drawing.Point(74, 0);
            this.closeControl.Margin = new System.Windows.Forms.Padding(0);
            this.closeControl.Name = "closeControl";
            this.closeControl.Size = new System.Drawing.Size(38, 40);
            this.closeControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeControl.TabIndex = 1;
            this.closeControl.TabStop = false;
            this.closeControl.Click += new System.EventHandler(this.closeControl_Click);
            this.closeControl.MouseEnter += new System.EventHandler(this.closeControl_MouseEnter);
            this.closeControl.MouseLeave += new System.EventHandler(this.closeControl_MouseLeave);
            // 
            // minimalizeControl
            // 
            this.minimalizeControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimalizeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minimalizeControl.Image = ((System.Drawing.Image)(resources.GetObject("minimalizeControl.Image")));
            this.minimalizeControl.Location = new System.Drawing.Point(37, 0);
            this.minimalizeControl.Margin = new System.Windows.Forms.Padding(0);
            this.minimalizeControl.Name = "minimalizeControl";
            this.minimalizeControl.Size = new System.Drawing.Size(37, 40);
            this.minimalizeControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimalizeControl.TabIndex = 2;
            this.minimalizeControl.TabStop = false;
            this.minimalizeControl.Click += new System.EventHandler(this.minimalizeControl_Click);
            this.minimalizeControl.MouseEnter += new System.EventHandler(this.minimalizeControl_MouseEnter);
            this.minimalizeControl.MouseLeave += new System.EventHandler(this.minimalizeControl_MouseLeave);
            // 
            // settingsControl
            // 
            this.settingsControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Image = ((System.Drawing.Image)(resources.GetObject("settingsControl.Image")));
            this.settingsControl.Location = new System.Drawing.Point(0, 0);
            this.settingsControl.Margin = new System.Windows.Forms.Padding(0);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(37, 40);
            this.settingsControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsControl.TabIndex = 3;
            this.settingsControl.TabStop = false;
            this.settingsControl.MouseEnter += new System.EventHandler(this.settingsControl_MouseEnter);
            this.settingsControl.MouseLeave += new System.EventHandler(this.settingsControl_MouseLeave);
            this.settingsControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.settingsControl_MouseUp);
            // 
            // pictureinf
            // 
            this.pictureinf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureinf.Image = ((System.Drawing.Image)(resources.GetObject("pictureinf.Image")));
            this.pictureinf.Location = new System.Drawing.Point(425, 157);
            this.pictureinf.Margin = new System.Windows.Forms.Padding(0);
            this.pictureinf.Name = "pictureinf";
            this.pictureinf.Size = new System.Drawing.Size(50, 50);
            this.pictureinf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureinf.TabIndex = 19;
            this.pictureinf.TabStop = false;
            this.pictureinf.Visible = false;
            // 
            // pictureone
            // 
            this.pictureone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureone.Image = ((System.Drawing.Image)(resources.GetObject("pictureone.Image")));
            this.pictureone.Location = new System.Drawing.Point(557, 157);
            this.pictureone.Margin = new System.Windows.Forms.Padding(0);
            this.pictureone.Name = "pictureone";
            this.pictureone.Size = new System.Drawing.Size(50, 50);
            this.pictureone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureone.TabIndex = 18;
            this.pictureone.TabStop = false;
            this.pictureone.Visible = false;
            // 
            // picturenone
            // 
            this.picturenone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturenone.Image = ((System.Drawing.Image)(resources.GetObject("picturenone.Image")));
            this.picturenone.Location = new System.Drawing.Point(493, 157);
            this.picturenone.Margin = new System.Windows.Forms.Padding(0);
            this.picturenone.Name = "picturenone";
            this.picturenone.Size = new System.Drawing.Size(50, 50);
            this.picturenone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturenone.TabIndex = 17;
            this.picturenone.TabStop = false;
            this.picturenone.Visible = false;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoEllipsis = true;
            this.InfoLabel.BackColor = System.Drawing.Color.Black;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InfoLabel.ForeColor = System.Drawing.Color.White;
            this.InfoLabel.Location = new System.Drawing.Point(12, 51);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(336, 33);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "n/a";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songsList
            // 
            this.songsList.BackColor = System.Drawing.Color.Gray;
            this.songsList.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songsList.ForeColor = System.Drawing.Color.White;
            this.songsList.FormattingEnabled = true;
            this.songsList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songsList.ItemHeight = 21;
            this.songsList.Location = new System.Drawing.Point(359, 66);
            this.songsList.Name = "songsList";
            this.songsList.Size = new System.Drawing.Size(429, 319);
            this.songsList.TabIndex = 1;
            // 
            // playSongButton
            // 
            this.playSongButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.playSongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playSongButton.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playSongButton.ForeColor = System.Drawing.Color.White;
            this.playSongButton.Location = new System.Drawing.Point(359, 393);
            this.playSongButton.Name = "playSongButton";
            this.playSongButton.Size = new System.Drawing.Size(271, 45);
            this.playSongButton.TabIndex = 4;
            this.playSongButton.Text = "Play Song";
            this.playSongButton.UseVisualStyleBackColor = false;
            this.playSongButton.Click += new System.EventHandler(this.playSongButton_Click);
            this.playSongButton.MouseEnter += new System.EventHandler(this.playSongButton_MouseEnter);
            this.playSongButton.MouseLeave += new System.EventHandler(this.playSongButton_MouseLeave);
            // 
            // playbutton
            // 
            this.playbutton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playbutton.Image = ((System.Drawing.Image)(resources.GetObject("playbutton.Image")));
            this.playbutton.Location = new System.Drawing.Point(12, 393);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(50, 50);
            this.playbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playbutton.TabIndex = 4;
            this.playbutton.TabStop = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            this.playbutton.MouseEnter += new System.EventHandler(this.playbutton_MouseEnter);
            this.playbutton.MouseLeave += new System.EventHandler(this.playbutton_MouseLeave);
            // 
            // pausebutton
            // 
            this.pausebutton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pausebutton.Image = ((System.Drawing.Image)(resources.GetObject("pausebutton.Image")));
            this.pausebutton.Location = new System.Drawing.Point(68, 393);
            this.pausebutton.Name = "pausebutton";
            this.pausebutton.Size = new System.Drawing.Size(50, 50);
            this.pausebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pausebutton.TabIndex = 5;
            this.pausebutton.TabStop = false;
            this.pausebutton.Click += new System.EventHandler(this.pausebutton_Click);
            this.pausebutton.MouseEnter += new System.EventHandler(this.pausebutton_MouseEnter);
            this.pausebutton.MouseLeave += new System.EventHandler(this.pausebutton_MouseLeave);
            // 
            // stopbutton
            // 
            this.stopbutton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stopbutton.Image = ((System.Drawing.Image)(resources.GetObject("stopbutton.Image")));
            this.stopbutton.Location = new System.Drawing.Point(124, 393);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(50, 50);
            this.stopbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stopbutton.TabIndex = 6;
            this.stopbutton.TabStop = false;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            this.stopbutton.MouseEnter += new System.EventHandler(this.stopbutton_MouseEnter);
            this.stopbutton.MouseLeave += new System.EventHandler(this.stopbutton_MouseLeave);
            // 
            // volumeSlider
            // 
            this.volumeSlider.LargeChange = 0;
            this.volumeSlider.Location = new System.Drawing.Point(242, 398);
            this.volumeSlider.Maximum = 100;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(106, 45);
            this.volumeSlider.SmallChange = 0;
            this.volumeSlider.TabIndex = 8;
            this.volumeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeSlider.Scroll += new System.EventHandler(this.volumeslider_Scroll);
            this.volumeSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeslider_MouseDown);
            // 
            // volumelabel
            // 
            this.volumelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.volumelabel.ForeColor = System.Drawing.Color.White;
            this.volumelabel.Location = new System.Drawing.Point(302, 417);
            this.volumelabel.Name = "volumelabel";
            this.volumelabel.Size = new System.Drawing.Size(46, 26);
            this.volumelabel.TabIndex = 9;
            this.volumelabel.Text = "---";
            this.volumelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volumeTextLabel
            // 
            this.volumeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.volumeTextLabel.ForeColor = System.Drawing.Color.White;
            this.volumeTextLabel.Location = new System.Drawing.Point(236, 424);
            this.volumeTextLabel.Name = "volumeTextLabel";
            this.volumeTextLabel.Size = new System.Drawing.Size(72, 17);
            this.volumeTextLabel.TabIndex = 10;
            this.volumeTextLabel.Text = "volume";
            this.volumeTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // currentDurationLabel
            // 
            this.currentDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentDurationLabel.ForeColor = System.Drawing.Color.White;
            this.currentDurationLabel.Location = new System.Drawing.Point(12, 362);
            this.currentDurationLabel.Name = "currentDurationLabel";
            this.currentDurationLabel.Size = new System.Drawing.Size(50, 23);
            this.currentDurationLabel.TabIndex = 11;
            this.currentDurationLabel.Text = "00-00";
            this.currentDurationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // songdurationlabel
            // 
            this.songdurationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.songdurationlabel.ForeColor = System.Drawing.Color.White;
            this.songdurationlabel.Location = new System.Drawing.Point(292, 362);
            this.songdurationlabel.Name = "songdurationlabel";
            this.songdurationlabel.Size = new System.Drawing.Size(56, 23);
            this.songdurationlabel.TabIndex = 12;
            this.songdurationlabel.Text = "00-00";
            this.songdurationlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // musicProgressBar2
            // 
            this.musicProgressBar2.AutoSize = false;
            this.musicProgressBar2.LargeChange = 1;
            this.musicProgressBar2.Location = new System.Drawing.Point(68, 362);
            this.musicProgressBar2.Maximum = 100;
            this.musicProgressBar2.Name = "musicProgressBar2";
            this.musicProgressBar2.Size = new System.Drawing.Size(218, 20);
            this.musicProgressBar2.TabIndex = 13;
            this.musicProgressBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.musicProgressBar2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.musicprogressbar2_MouseDown);
            // 
            // playStateLabel
            // 
            this.playStateLabel.BackColor = System.Drawing.Color.Black;
            this.playStateLabel.ForeColor = System.Drawing.Color.White;
            this.playStateLabel.Location = new System.Drawing.Point(18, 338);
            this.playStateLabel.Name = "playStateLabel";
            this.playStateLabel.Size = new System.Drawing.Size(198, 18);
            this.playStateLabel.TabIndex = 14;
            this.playStateLabel.Text = "waiting";
            // 
            // loadInfoLabel
            // 
            this.loadInfoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.loadInfoLabel.ForeColor = System.Drawing.Color.White;
            this.loadInfoLabel.Location = new System.Drawing.Point(359, 40);
            this.loadInfoLabel.Name = "loadInfoLabel";
            this.loadInfoLabel.Size = new System.Drawing.Size(429, 26);
            this.loadInfoLabel.TabIndex = 15;
            this.loadInfoLabel.Text = "No songs loaded";
            this.loadInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repeatTypeButton
            // 
            this.repeatTypeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repeatTypeButton.Image = ((System.Drawing.Image)(resources.GetObject("repeatTypeButton.Image")));
            this.repeatTypeButton.Location = new System.Drawing.Point(180, 393);
            this.repeatTypeButton.Name = "repeatTypeButton";
            this.repeatTypeButton.Size = new System.Drawing.Size(50, 50);
            this.repeatTypeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.repeatTypeButton.TabIndex = 16;
            this.repeatTypeButton.TabStop = false;
            this.repeatTypeButton.Click += new System.EventHandler(this.repeatTypeButton_Click);
            this.repeatTypeButton.MouseEnter += new System.EventHandler(this.repeatTypeButton_MouseEnter);
            this.repeatTypeButton.MouseLeave += new System.EventHandler(this.repeatTypeButton_MouseLeave);
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(12, 51);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(336, 305);
            this.MusicPlayer.TabIndex = 3;
            this.MusicPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MusicPlayer_PlayStateChange);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Location = new System.Drawing.Point(636, 393);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(152, 45);
            this.loadButton.TabIndex = 17;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            this.loadButton.MouseEnter += new System.EventHandler(this.loadButton_MouseEnter);
            this.loadButton.MouseLeave += new System.EventHandler(this.loadButton_MouseLeave);
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureinf);
            this.Controls.Add(this.picturenone);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.pictureone);
            this.Controls.Add(this.repeatTypeButton);
            this.Controls.Add(this.loadInfoLabel);
            this.Controls.Add(this.playStateLabel);
            this.Controls.Add(this.musicProgressBar2);
            this.Controls.Add(this.songdurationlabel);
            this.Controls.Add(this.currentDurationLabel);
            this.Controls.Add(this.volumeTextLabel);
            this.Controls.Add(this.volumelabel);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.pausebutton);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.playSongButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.MusicPlayer);
            this.Controls.Add(this.songsList);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicPlayerApp";
            this.Text = "Music Player App";
            this.Title.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimalizeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureinf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturenone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicProgressBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatTypeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox closeControl;
        private System.Windows.Forms.ListBox songsList;
        private AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button playSongButton;
        private System.Windows.Forms.PictureBox minimalizeControl;
        private System.Windows.Forms.PictureBox playbutton;
        private System.Windows.Forms.PictureBox pausebutton;
        private System.Windows.Forms.PictureBox stopbutton;
        private System.Windows.Forms.TrackBar volumeSlider;
        private System.Windows.Forms.Label volumelabel;
        private System.Windows.Forms.Label volumeTextLabel;
        private System.Windows.Forms.Label currentDurationLabel;
        private System.Windows.Forms.Label songdurationlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar musicProgressBar2;
        private System.Windows.Forms.Label playStateLabel;
        private System.Windows.Forms.Label loadInfoLabel;
        private System.Windows.Forms.PictureBox repeatTypeButton;
        private System.Windows.Forms.PictureBox pictureone;
        private System.Windows.Forms.PictureBox picturenone;
        private System.Windows.Forms.PictureBox pictureinf;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TableLayoutPanel controlsPanel;
        private System.Windows.Forms.PictureBox settingsControl;
    }
}

