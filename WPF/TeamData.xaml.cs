using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for TeamData.xaml
    /// </summary>
    public partial class TeamData : Window
    {
        private Team team;
        public TeamData(Team team)
        {
            this.team = team;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            tbCountry.Text = team?.Country;
            tbCode.Text = team?.FifaCode;
            tbDraw.Text = team?.Draws.ToString();
            tbLoss.Text = team?.Losses.ToString();
            tbGamesPlayed.Text = team?.GamesPlayed.ToString();
            tbWins.Text = team?.Wins.ToString();
            tbGoalDifference.Text = team?.GoalDifferential.ToString();
            tbGoalsRecieved.Text = team?.GoalsAgainst.ToString();
            tbGoalsScored.Text = team?.GoalsFor.ToString();
        }      
    }
}
