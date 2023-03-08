using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using WMPLib;
using System.Drawing;

namespace MusicPlayerApp
{
    public static class Colors
    {
        public static bool darkMode = true;
        public static Color TitleBackground { get => darkMode ? Color.FromArgb(51, 51, 51) : Color.FromArgb(60, 60, 60); }
        public static Color Background { get => darkMode ? Color.FromArgb(91, 91, 91) : Color.FromArgb(190, 190, 190); }
        public static Color ControlButtonHover { get => darkMode ? Color.FromArgb(61, 61, 61) : Color.FromArgb(80, 80, 80); }
        public static Color CloseButtonHover { get => darkMode ? Color.FromArgb(130, 61, 61) : Color.FromArgb(130, 80, 80); }
        public static Color MusicButtonHover { get => darkMode ? Color.Gray : Color.LightGray; }
        public static Color MusicButtonActive { get => darkMode ? Color.White : Color.LightGray; }
        public static Color ListButtonHover { get => darkMode ? Color.Gray : Color.LightGray; }
        public static Color ListButtonBackground { get => darkMode ? Color.FromArgb(51, 51, 51) : Color.LightGray; }
        public static Color Font { get => darkMode ? Color.LightGray : Color.Black; }
    }

    public class Song
    {
        public string SongName { get; private set; }
        public int DurationInSeconds { get; private set; }
        public string SongPath { get; private set; }

        public Song(string songName, int lengthInSeconds, string songPath) {
            SongName = songName;
            DurationInSeconds = lengthInSeconds;
            SongPath = songPath;
        }
    }

    public class MusicBank
    {
        public List<Song> songsList = new List<Song>();
        List<string> songDirectories = new List<string>();

        WindowsMediaPlayerClass wmpc = new WindowsMediaPlayerClass();

        public int SongCount { get => songsList.Count; }
        public int DirectoriesCount { get => songDirectories.Count; }
        public int SumDurationInSeconds {
            get {
                int wyn = 0;
                foreach (Song song in songsList)
                    wyn += song.DurationInSeconds;
                return wyn;
            }
        }

        public Song this[int i] { get => i >= 0 && i < songsList.Count ? songsList[i] : null; }

        public MusicBank() {
            GetPaths();
            GetSongList();
        }

        void GetPaths() {
            string[] directories = File.ReadAllLines(Control.pathsFile);
            foreach (string path in directories)
                if (Directory.Exists(path))
                    songDirectories.Add(path);
        }

        void GetSongList() {
            foreach (string path in songDirectories) {
                LoadSongsFromDirectory(path);
            }
        }

        void LoadSongsFromDirectory(string directoryPath) {
            foreach (string songPath in Directory.GetFiles(directoryPath)) {
                if (Control.IsSongInCorrectFormat(songPath))
                    LoadSong(songPath);
            }
        }

        void LoadSong(string songPath) {
            IWMPMedia songInfo = wmpc.newMedia(songPath);
            string songName = songPath.Split('\\').Last();
            songsList.Add(new Song(songName, (int)songInfo.duration, songPath));
        }
    }

    static class Control
    {
        public static string pathsFile = "paths.txt";

        static string[] acceptedFormats = {
            "mp3",
            "wav"
        };

        public static string SecondsToBetter(int seconds) {
            TimeSpan span = TimeSpan.FromSeconds(seconds);

            string result = $"{span.Minutes.ToString("D2")}m {span.Seconds.ToString("D2")}s ";

            if (span.Hours > 0)
                result = $"{span.Hours.ToString("D2")}h " + result;

            return result;
        }

        public static bool IsSongInCorrectFormat(string fileName) {
            foreach (string format in acceptedFormats) {
                if (fileName.Contains(format))
                    return true;
            }
            return false;
        }
    }

    public static class Localization
    {
        public enum Language
        {
            English,
            Polski
        }

        public static Language selectedLanguage = Language.English;

        public static string GetWord(uint wordId) {
            switch (selectedLanguage) {
                case Language.English: return GetFromEnglish(wordId);
                case Language.Polski: return GetFromPolish(wordId);
                default: return GetFromEnglish(wordId);
            }
        }

        static string GetFromEnglish(uint wordId) {
            switch (wordId) {
                case 0: return "Play";
                case 1: return "Select Song";
                case 2: return "Loaded {0} songs from {1} directories.";
                case 3: return "Duration";
                case 4: return "No Song Selected!";
                case 5: return "No songs loaded";
                case 6: return "Volume";
                case 7: return "Load Songs";
                case 8: return "Waiting";
                case 9: return "Stopped";
                case 10: return "Playing";
                case 11: return "Paused";

                case 12: return "Language";
                case 13: return "Settings";
                case 14: return "Add Directory";
                case 15: return "Save";
                case 16: return "Dark Mode";
                case 17: return "No valid paths specified, add in settings";

                default: return "n/a";
            }
        }

        static string GetFromPolish(uint wordId) {
            switch (wordId) {
                case 0: return "Graj";
                case 1: return "Wybierz Piosenkę";
                case 2: return "Załadowano {0} piosenek z {1} folderów.";
                case 3: return "Długość";
                case 4: return "Nie wybrano piosenki!";
                case 5: return "Brak załadowanych piosenek";
                case 6: return "Głośność";
                case 7: return "Załaduj";
                case 8: return "Oczekuje";
                case 9: return "Zatrzymano";
                case 10: return "Odtwarzanie";
                case 11: return "Wstrzymano";

                case 12: return "Język";
                case 13: return "Ustawienia";
                case 14: return "Dodaj Folder";
                case 15: return "Zapisz";
                case 16: return "Ciemny Motyw";
                case 17: return "Brak zadeklarowanych istniejących folderów, dodaj przez ustawienia";

                default: return "n/a";
            }
        }
    }
}
