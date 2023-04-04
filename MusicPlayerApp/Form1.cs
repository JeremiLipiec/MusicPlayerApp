using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayerApp
{
    enum LoopMode
    {
        All,
        Single,
        None
    }

    public partial class MusicPlayerApp : Form
    {
        LoopMode looping = LoopMode.All;

        readonly int autoPlayNextSongDelay = 3;
        bool stoppedByUser = false;
        int timeout;

        MusicBank songBank = new MusicBank();

        public MusicPlayerApp() {
            InitializeComponent();
            UpdateLocalization();
            UpdateColors();

            versionLabel.Text = "v1.0.1";

            MusicPlayer.settings.volume = 1;
            volumeSlider.Value = 1;
            MusicPlayer.uiMode = "none";

            volumelabel.Text = MusicPlayer.settings.volume.ToString();

            currentDurationLabel.Text = "00:00";
            songdurationlabel.Text = "00:00";

            timeout = autoPlayNextSongDelay;

            timer1.Interval = 1000;
            timer1.Start();

            volumeSlider.MouseWheel += new MouseEventHandler(VolumeChangeOnMouseWheel);
            musicProgressBar2.MouseWheel += new MouseEventHandler(DoNothingOnMouseWheel);
        }

        public void UpdateLocalization() {
            playSongButton.Text = Localization.GetWord(0);
            volumeTextLabel.Text = Localization.GetWord(6);
            loadButton.Text = Localization.GetWord(7);
            playStateLabel.Text = GetPlayStateLabelText();
            playStateLabel.Text = GetPlayStateLabelText();

            if (MusicPlayer.playState == WMPPlayState.wmppsPlaying) {
                UpdateInfoLabel(songBank[songsList.SelectedIndex].SongName);
            } else {
                UpdateInfoLabel(Localization.GetWord(1));
            }

            if (songsList.Items.Count == 0) {
                loadInfoLabel.Text = Localization.GetWord(5);
            } else {
                string info = string.Format(Localization.GetWord(2), songBank.SongCount, songBank.DirectoriesCount) + " ";
                loadInfoLabel.Text = info + Localization.GetWord(3) + ": " + Control.SecondsToBetter(songBank.SumDurationInSeconds);
            }
        }

        public void UpdateColors() {
            UpdateMusicButtonsColors();

            // backgrounds
            Title.BackColor = Colors.TitleBackground;
            BackColor = Colors.Background;
            songsList.BackColor = Colors.Background;
            loadButton.BackColor = Colors.ListButtonBackground;
            playSongButton.BackColor = Colors.ListButtonBackground;
            minimalizeControl.BackColor = Colors.TitleBackground;
            closeControl.BackColor = Colors.TitleBackground;
            settingsControl.BackColor = Colors.TitleBackground;

            // fonts
            songsList.ForeColor = Colors.Font;
            loadInfoLabel.ForeColor = Colors.Font;
            loadButton.ForeColor = Colors.Font;
            playSongButton.ForeColor = Colors.Font;
            volumeTextLabel.ForeColor = Colors.Font;
            volumelabel.ForeColor = Colors.Font;
            currentDurationLabel.ForeColor = Colors.Font;
            songdurationlabel.ForeColor = Colors.Font;
        }

        void InitializeSongs() {
            songsList.Items.Clear();

            foreach (Song song in songBank.songsList)
                songsList.Items.Add(Control.SecondsToBetter(song.DurationInSeconds) + " | " + song.SongName);

            UpdateLocalization();

            if (songBank.DirectoriesCount == 0)
                loadInfoLabel.Text = Localization.GetWord(17);
        }

        private void DoNothingOnMouseWheel(object sender, MouseEventArgs e) {
            HandledMouseEventArgs ee = (HandledMouseEventArgs)e;
            ee.Handled = true;
        }

        private void VolumeChangeOnMouseWheel(object sender, MouseEventArgs e) {
            int val = volumeSlider.Value;
            int scr = Math.Sign(e.Delta);

            if ((val > 0 && scr < 0) || (val < 100 && scr > 0))
                volumeSlider.Value += scr;

            volumelabel.Text = volumeSlider.Value.ToString();
            MusicPlayer.settings.volume = volumeSlider.Value;

            HandledMouseEventArgs ee = (HandledMouseEventArgs)e;
            ee.Handled = true;
        }

        private void UpdateInfoLabel(string text) => InfoLabel.Text = text;

        private void MusicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) {
            playStateLabel.Text = GetPlayStateLabelText();

            switch (MusicPlayer.playState) {
                case (WMPPlayState.wmppsMediaEnded): {
                    if (songsList.SelectedIndex < songsList.Items.Count - 1 && looping == LoopMode.All)
                        songsList.SelectedIndex++;
                    else if (looping == LoopMode.All)
                        songsList.SelectedIndex = 0;
                    break;
                }
                case (WMPPlayState.wmppsPlaying): {
                    songdurationlabel.Text = MusicPlayer.Ctlcontrols.currentItem.durationString;
                    break;
                }
            }

            UpdateMusicButtonsColors();
        }

        void UpdateMusicButtonsColors() {
            playbutton.BackColor = Colors.Background;
            pausebutton.BackColor = Colors.Background;
            stopbutton.BackColor = Colors.Background;

            switch (MusicPlayer.playState) {
                case (WMPPlayState.wmppsStopped): {
                    stopbutton.BackColor = Colors.MusicButtonActive;
                    break;
                }
                case (WMPPlayState.wmppsPlaying): {
                    playbutton.BackColor = Colors.MusicButtonActive;
                    break;
                }
            }
        }

        private string GetPlayStateLabelText() {
            switch (MusicPlayer.playState) {
                case WMPPlayState.wmppsUndefined: return Localization.GetWord(8);
                case WMPPlayState.wmppsWaiting: return Localization.GetWord(8);
                case WMPPlayState.wmppsReady: return Localization.GetWord(8);
                case WMPPlayState.wmppsMediaEnded: return Localization.GetWord(8);
                case WMPPlayState.wmppsStopped: return Localization.GetWord(9);
                case WMPPlayState.wmppsPlaying: return Localization.GetWord(10);
                case WMPPlayState.wmppsTransitioning: return Localization.GetWord(10);
                case WMPPlayState.wmppsPaused: return Localization.GetWord(11);
                default: throw new Exception(MusicPlayer.playState.ToString());
            };
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if(MusicPlayer.Ctlcontrols.currentItem is null)
                currentDurationLabel.Text = MusicPlayer.Ctlcontrols.currentPositionString;
            else if (MusicPlayer.Ctlcontrols.currentPosition > MusicPlayer.Ctlcontrols.currentItem.duration)
                currentDurationLabel.Text = MusicPlayer.Ctlcontrols.currentItem.durationString;
            else currentDurationLabel.Text = MusicPlayer.Ctlcontrols.currentPositionString;
            
            if (currentDurationLabel.Text.Length == 0) {
                currentDurationLabel.Text = "00:00";
            } else {
                musicProgressBar2.Value = Math.Min((int)(MusicPlayer.Ctlcontrols.currentPosition / MusicPlayer.Ctlcontrols.currentItem.duration * 100), 100);
            }

            if (MusicPlayer.playState == WMPPlayState.wmppsStopped && !stoppedByUser && looping != LoopMode.None) {
                timeout--;
                if (timeout == 0) {
                    PlaySelected();
                    timeout = autoPlayNextSongDelay;
                }
            }
        }

        private void musicprogressbar2_MouseDown(object sender, MouseEventArgs e) { // do poprawy, jest git
            int cutout = 8;
            int barwidth = musicProgressBar2.Width;
            int innerbar = barwidth - cutout * 2;
            double ratio = innerbar / 100f;

            if (e.X < cutout) musicProgressBar2.Value = 0; // ok
            else if (e.X > barwidth - cutout) musicProgressBar2.Value = 100; // ok
            else musicProgressBar2.Value = (int)((e.X - cutout) / ratio);

            if (MusicPlayer.currentMedia != null) {
                MusicPlayer.Ctlcontrols.currentPosition = MusicPlayer.Ctlcontrols.currentItem.duration * (musicProgressBar2.Value / 100f);
                if (MusicPlayer.Ctlcontrols.currentPositionString.Length == 0)
                    currentDurationLabel.Text = "00:00";
                else
                    currentDurationLabel.Text = MusicPlayer.Ctlcontrols.currentPositionString;
            }
        }

        // volume slider
        private void volumeslider_Scroll(object sender, EventArgs e) {
            volumelabel.Text = volumeSlider.Value.ToString();
            MusicPlayer.settings.volume = volumeSlider.Value;
        }

        private void volumeslider_MouseDown(object sender, MouseEventArgs e) { // do poprawy, jest git
            int cutout = 8;
            int barwidth = volumeSlider.Width;
            int innerbar = barwidth - cutout * 2;
            double ratio = innerbar / 100f;

            if (e.X < cutout) volumeSlider.Value = 0; // ok
            else if (e.X > barwidth - cutout) volumeSlider.Value = 100; // ok
            else volumeSlider.Value = (int)((e.X - cutout) / ratio);

            volumelabel.Text = volumeSlider.Value.ToString();
            MusicPlayer.settings.volume = volumeSlider.Value;
        }

        #region Control Buttons

        private void settingsControl_MouseUp(object sender, MouseEventArgs e) {
            SettingsPopup popup = new SettingsPopup();
            popup.LanguageChanged += UpdateLocalization;
            popup.ColorsChanged += UpdateColors;
            popup.Show();
            popup.TopMost = true;
            popup.Location = new Point(Location.X + Size.Width - 200 + e.Location.X, Location.Y + e.Location.Y);
        }

        private void settingsControl_MouseEnter(object sender, EventArgs e) {
            settingsControl.BackColor = Colors.ControlButtonHover;
        }

        private void settingsControl_MouseLeave(object sender, EventArgs e) {
            settingsControl.BackColor = Colors.TitleBackground;
        }

        private void minimalizeControl_MouseEnter(object sender, EventArgs e) {
            minimalizeControl.BackColor = Colors.ControlButtonHover;
        }

        private void minimalizeControl_MouseLeave(object sender, EventArgs e) {
            minimalizeControl.BackColor = Colors.TitleBackground;
        }

        private void minimalizeControl_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void closeControl_MouseEnter(object sender, EventArgs e) {
            closeControl.BackColor = Colors.CloseButtonHover;
        }

        private void closeControl_MouseLeave(object sender, EventArgs e) {
            closeControl.BackColor = Colors.TitleBackground;
        }

        private void closeControl_Click(object sender, EventArgs e) {
            Close();
        }

        #endregion

        #region Music List Buttons

        private void playSongButton_MouseEnter(object sender, EventArgs e) {
            playSongButton.BackColor = Colors.ListButtonHover;
        }

        private void playSongButton_MouseLeave(object sender, EventArgs e) {
            playSongButton.BackColor = Colors.ListButtonBackground;
        }

        private void playSongButton_Click(object sender, EventArgs e) {
            if (songsList.SelectedItem != null) {
                PlaySelected();
            } else {
                UpdateInfoLabel(Localization.GetWord(4));
            }
        }

        private void loadButton_MouseEnter(object sender, EventArgs e) {
            loadButton.BackColor = Colors.ListButtonHover;
        }

        private void loadButton_MouseLeave(object sender, EventArgs e) {
            loadButton.BackColor = Colors.ListButtonBackground;
        }

        private void loadButton_Click(object sender, EventArgs e) {
            stopbutton_Click(this, new EventArgs());

            if (songsList.Items.Count <= 0) {
                songBank = new MusicBank();
                InitializeSongs();
                return;
            } else if (MessageBox.Show(Localization.GetWord(18), Localization.GetWord(19), MessageBoxButtons.YesNo) == DialogResult.Yes) {
                songBank = new MusicBank();
                InitializeSongs();
            }
        }

        private void PlaySelected() {
            UpdateInfoLabel(songBank[songsList.SelectedIndex].SongName);
            MusicPlayer.URL = songBank[songsList.SelectedIndex].SongPath;
            pausebutton.BackColor = Colors.Background;

            musicProgressBar2.Value = 0;
            currentDurationLabel.Text = "00:00";

            songdurationlabel.Text = MusicPlayer.Ctlcontrols.currentItem.duration.ToString();
            stoppedByUser = false;
        }

        #endregion

        #region Music Steering Buttons

        //play

        private void playbutton_MouseEnter(object sender, EventArgs e) {
            if (MusicPlayer.playState != WMPPlayState.wmppsPlaying) {
                playbutton.BackColor = Colors.MusicButtonHover;
            }
        }

        private void playbutton_MouseLeave(object sender, EventArgs e) {
            if (MusicPlayer.playState != WMPPlayState.wmppsPlaying) {
                playbutton.BackColor = Colors.Background;
            }
        }

        private void playbutton_Click(object sender, EventArgs e) {
            MusicPlayer.Ctlcontrols.play();
            pausebutton.BackColor = Colors.Background;
            stoppedByUser = false;
            playbutton.BackColor = Colors.MusicButtonActive;
        }

        //pause

        private void pausebutton_MouseEnter(object sender, EventArgs e) {
            if (MusicPlayer.playState != WMPPlayState.wmppsPaused) {
                pausebutton.BackColor = Colors.MusicButtonHover;
            }
        }

        private void pausebutton_MouseLeave(object sender, EventArgs e) {
            if (MusicPlayer.playState != WMPPlayState.wmppsPaused) {
                pausebutton.BackColor = Colors.Background;
            }
        }

        private void pausebutton_Click(object sender, EventArgs e) {
            MusicPlayer.Ctlcontrols.pause();
            pausebutton.BackColor = Colors.MusicButtonActive;
        }

        // stop

        private void stopbutton_MouseEnter(object sender, EventArgs e) {
            if (MusicPlayer.playState != WMPPlayState.wmppsStopped) {
                stopbutton.BackColor = Colors.MusicButtonHover;
            }
        }

        private void stopbutton_MouseLeave(object sender, EventArgs e) {
            if (MusicPlayer.playState != WMPPlayState.wmppsStopped) {
                stopbutton.BackColor = Colors.Background;
            }
        }

        private void stopbutton_Click(object sender, EventArgs e) {
            MusicPlayer.Ctlcontrols.stop();
            stoppedByUser = true;
            musicProgressBar2.Value = 0;
            currentDurationLabel.Text = "00:00";
            pausebutton.BackColor = Colors.Background;
        }

        // repeating

        private void repeatTypeButton_MouseEnter(object sender, EventArgs e) {
            repeatTypeButton.BackColor = Colors.MusicButtonHover;
        }

        private void repeatTypeButton_MouseLeave(object sender, EventArgs e) {
            repeatTypeButton.BackColor = Colors.Background;
        }

        private void repeatTypeButton_Click(object sender, EventArgs e) {
            switch (looping) {
                case (LoopMode.All): {
                    looping = LoopMode.Single;
                    repeatTypeButton.Image = pictureone.Image;
                    break;
                }
                case (LoopMode.Single): {
                    looping = LoopMode.None;
                    repeatTypeButton.Image = picturenone.Image;
                    break;
                }
                case (LoopMode.None): {
                    looping = LoopMode.All;
                    repeatTypeButton.Image = pictureinf.Image;
                    break;
                }
            }
        }

        #endregion

        #region Window Moving

        private Point _mouseLoc;

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e) => _mouseLoc = e.Location;

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }
        private void Title_MouseDown(object sender, MouseEventArgs e) => _mouseLoc = e.Location;

        private void Title_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }

        #endregion
    }
}
