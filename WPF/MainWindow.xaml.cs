using ClassLibrary.Model;
using ClassLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinForms;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string RESOLUTION_DEL = "x";

        List<ClassLibrary.Model.Match> matches;
        List<StartingEleven> firstTeam = new();
        List<StartingEleven> secondTeam = new();
        string? championship;
        string? language;
        string? resolution;
        private IRepo repo;

        public MainWindow()
        {
            LoadSettings();
            InitializeComponent();
            InitRepo();
            InitComboBoxes();
        }
        private void LoadSettings(bool startup = true)
        {
            if (FileRepo.HasConfig() && startup)
            {
                Dictionary<string, string> settings = FileRepo.GetConfig();
                championship = settings["cbChampionship"];
                language = settings["gbLanguage"];
                resolution = settings["gbResolution"];
                if (resolution.Length == 0)
                {
                    Settings settingsForm = new(true);
                    settingsForm.ShowDialog();
                    LoadSettings();
                }
                SetLocalization(language);
                SetWindowSize(resolution);
            }
            else
            {
                Settings settingsForm = new(true);
                settingsForm.ShowDialog();
                LoadSettings();
            }
        }

        private void InitRepo() => repo = RepoFactory.GetRepo(championship);
        private void InitComboBoxes()
        {
            List<Team> teams = repo.GetTeams();
            cbFirstTeam.ItemsSource = teams;
            if (FileRepo.HasSavedTeam())
            {
                string favouriteTeamCode = FileRepo.GetSavedTeam();
                cbFirstTeam.SelectedValue = favouriteTeamCode;
            }
        }

        private static void SetLocalization(string language)
            => Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = new CultureInfo(language);

        private void SetWindowSize(string resolution)
        {
            string[] res = resolution.Split(RESOLUTION_DEL);
          
            if (res[0] == "FullScreen")
            {
                WindowState = WindowState.Maximized;
            }

            MinWidth = double.Parse(res[0]);
            MinHeight = double.Parse(res[1]);
        }
        
        private void BtnFirstData_Click(object sender, RoutedEventArgs e) => new TeamData(repo.GetTeam(cbFirstTeam.SelectedValue.ToString())).Show();       
        
        private void BtnSecondData_Click(object sender, RoutedEventArgs e) => new TeamData(repo.GetTeam(cbSecondTeam.SelectedValue.ToString())).Show();
        
        private void CbFirstTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearPanel();
            ClearScore();
            
            string? firstTeam = cbFirstTeam.SelectedValue.ToString();
            matches = repo.GetMatchesCountry(firstTeam);
            Dictionary<string, string> secondTeams = new();
            foreach (var match in matches)
            {
                if (match.AwayTeam.Code == firstTeam)
                {
                    secondTeams.Add(match.HomeTeam.Country, match.HomeTeam.Code);
                }
                else
                {
                    secondTeams.Add(match.AwayTeam.Country, match.AwayTeam.Code);
                }
            }
            cbSecondTeam.ItemsSource = secondTeams;            
            cbSecondTeam.IsEnabled = true;
        }              

        private void CbSecondTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearPanel();            
            string? second_Team = cbSecondTeam.SelectedValue.ToString();
            ClassLibrary.Model.Match? match = matches.Find(m => m.AwayTeam.Code == second_Team || m.HomeTeam.Code == second_Team);
            
            string firstTeamScore;
            string secondTeamScore;
            if (match?.AwayTeam.Code == second_Team)
            {
                firstTeam = match?.HomeTeamStatistics?.StartingEleven;
                secondTeam = match?.AwayTeamStatistics?.StartingEleven;
                firstTeamScore = match?.HomeTeam.Goals.ToString();
                secondTeamScore = match?.AwayTeam.Goals.ToString();
            }
            else
            {
                firstTeam = match?.AwayTeamStatistics?.StartingEleven;
                secondTeam = match?.HomeTeamStatistics?.StartingEleven;
                firstTeamScore = match?.AwayTeam.Goals.ToString();
                secondTeamScore = match?.HomeTeam.Goals.ToString();
            }
            ShowPlayers(firstTeam, secondTeam);
            ShowResult(firstTeamScore, secondTeamScore);            
        }

        private void ShowPlayers(List<StartingEleven>? firstTeam, List<StartingEleven>? secondTeam)
        {
            foreach (var firstTeamPlayer in firstTeam)
            {
                Player player = new(firstTeamPlayer);
                player.Width = 100;
                player.Height = 40;
                pnlFirstTeam.Children.Add(player);
            }
            foreach (var secondTeamPlayer in secondTeam)
            {
                Player player = new(secondTeamPlayer);
                player.Width = 100;
                player.Height = 40;
                pnlSecondTeam.Children.Add(player);
            }
        }
        private void ClearScore() => tbScore.Text = "select right team";
        private void ShowResult(string? firstTeamScore, string? secondTeamScore) => tbScore.Text = firstTeamScore + ":" + secondTeamScore;
        
        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;
            ClearPanel();
            LoadSettings(startup: false);
            InitializeComponent();
            InitRepo();
            InitComboBoxes();
            Cursor = Cursors.Arrow;
        }

        private void ClearPanel()
        {
            pnlFirstTeam.Children.OfType<StackPanel>().ToList().ForEach(p => p.Children.Clear());
            pnlSecondTeam.Children.OfType<StackPanel>().ToList().ForEach(p => p.Children.Clear());
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ConfirmDialog confirmDialog = new();
            e.Cancel = confirmDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
