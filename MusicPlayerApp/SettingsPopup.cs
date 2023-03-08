using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class SettingsPopup : Form
    {
        public delegate void Info();
        public event Info LanguageChanged;
        public event Info ColorsChanged;

        public SettingsPopup() {
            InitializeComponent();
            InitializeLanguageSelect();
            UpdateLocalization();
            UpdateColors();
            darkModeCheck.Checked = Colors.darkMode;
        }

        void UpdateLocalization() {
            languageLabel.Text = Localization.GetWord(12);
            titleLabel.Text = Localization.GetWord(13);
            addDirectoriesButton.Text = Localization.GetWord(14);
            darkModeCheck.Text = Localization.GetWord(16);
        }

        void UpdateColors() {
            // backgrounds
            titlePanel.BackColor = Colors.TitleBackground;
            BackColor = Colors.Background;
            addDirectoriesButton.BackColor = Colors.Background;

            // fonts
            languageLabel.ForeColor = Colors.Font;
            addDirectoriesButton.ForeColor = Colors.Font;
            darkModeCheck.ForeColor = Colors.Font;
        }

        void InitializeLanguageSelect() {
            for (int i = 0; i < Enum.GetNames(typeof(Localization.Language)).Length; i++) {
                languageSelect.Items.Add((Localization.Language)i);
            }
            languageSelect.SelectedIndex = (int)Localization.selectedLanguage;
        }

        private void addDirectoriesButton_Click(object sender, EventArgs e) {
            Process.Start(Control.pathsFile);
        }

        private void darkModeCheck_CheckedChanged(object sender, EventArgs e) {
            Colors.darkMode = darkModeCheck.Checked;
            ColorsChanged?.Invoke();
            UpdateColors();
        }

        private void languageSelect_DropDownClosed(object sender, EventArgs e) {
            Localization.selectedLanguage = (Localization.Language)languageSelect.SelectedIndex;
            LanguageChanged?.Invoke();
            UpdateLocalization();
        }

        private void exitButton_Click(object sender, EventArgs e) => Close();

        private void exitButton_MouseEnter(object sender, EventArgs e) {
            exitButton.BackColor = Colors.CloseButtonHover;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e) {
            exitButton.BackColor = Colors.TitleBackground;
        }

        private Point _mouseLoc;

        private void titleLabel_MouseDown(object sender, MouseEventArgs e) => _mouseLoc = e.Location;

        private void titleLabel_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }
    }
}
