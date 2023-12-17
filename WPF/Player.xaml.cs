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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WPF
{
    /// <summary>
    /// Interaction logic for Player.xaml
    /// </summary>
    public partial class Player : UserControl
    {
        private const string IMG_PATH = @"/Images/jersey.png";
        private string imgPath;
        public StartingEleven PlayerModel { get; set; }
        public int GoalsScored { get; set; }
        public int YellowCards { get; set; }
        public Player(StartingEleven player, string imgPath = IMG_PATH)
        {
            this.PlayerModel = player;
            this.imgPath = imgPath;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            tbName.Text = PlayerModel.Name;
            tbNumber.Text = PlayerModel.ShirtNumber.ToString();
            tbCaptain.Text = PlayerModel.Captain ? "C" : "";
        }

        private void Player_MouseDown(object sender, MouseButtonEventArgs e) => new PlayerData(this).Show();        
    }
}
