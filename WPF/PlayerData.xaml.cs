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
using System.Xml.Linq;

namespace WPF
{
    /// <summary>
    /// Interaction logic for PlayerData.xaml
    /// </summary>
    public partial class PlayerData : Window
    {
        public Player player { get; set; }
        public PlayerData(Player player)
        {
            this.player = player;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            tbName.Text = player.PlayerModel.Name;
            tbGoals.Text = player.GoalsScored.ToString();
            tbNumber.Text = player.PlayerModel.ShirtNumber.ToString();
            tbPosition.Text = player.PlayerModel.Position;
            tbYellowCards.Text = player.YellowCards.ToString();
            tbCaptain.Text = player.PlayerModel.Captain ? "Captain" : "";
        }
    }
}
