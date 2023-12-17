using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Player : UserControl
    {
        private const string IMG_PATH = @"/Resources/person.jpg";

        private StartingEleven player;
        private string imagePath;
        public bool IsFavourite { get; set; }

        public Player(StartingEleven player, bool isFavourite, string path = IMG_PATH)
        {
            InitializeComponent();
            this.player = player;
            this.imagePath = path;
            this.IsFavourite = isFavourite;
            Init();
        }

        public void SetFavourite(bool isFavourite)
        {
            this.IsFavourite = isFavourite;
            Init();
        }

        private void Init()
        {
            pbIcon.ImageLocation = imagePath;
            pbFavourite.Visible = IsFavourite;
            lblName.Text = player.Name;
            lblPosition.Text = player.Position;
            lblShirtNumber.Text = player.ShirtNumber.ToString();
            lblCaptain.Text = player.Captain ? "Captain" : "";
            lblFilter.Text = player.Filter.ToString();
            if (player.Filter != 0)
            {
                lblFilter.Visible = true;
            }
        }

        private void Player_MouseDown(object sender, MouseEventArgs e)
        {
            Player player = (Player)sender;
            player.DoDragDrop(player, DragDropEffects.Move);
        }
        public StartingEleven GetAsStartingElevenType()
        {
            return player;
        }
    }
}
