using ClassLibrary.Repository;
using System.Text;

namespace WinForms
{
    public partial class Settings : Form
    {
        private const string DEL = ":";
        private const string MEN_CHAMP = "Men's Championship";
        private const string WOMEN_CHAMP = "Women's Championship";

        private bool isWpf;

        public Settings(bool isWpf = false)
        {
            InitializeComponent();
            InitComboBox();
            InitData();
            if (isWpf)
            {
                this.isWpf = isWpf;
                ShowWpfControls();
            }
        }

        private void ShowWpfControls()
        {
            lblWpf.Visible = true;
            gbResolution.Visible = true;
            rbSmall.Visible = true;
            rbMedium.Visible = true;
            rbFullScreen.Visible = true;
        }

        private void InitComboBox()
        {
            cbChampionship.Items.Add(MEN_CHAMP);
            cbChampionship.Items.Add(WOMEN_CHAMP);
            cbChampionship.SelectedIndex = 0;
        }

        private void InitData()
        {
            if (FileRepo.HasConfig())
            {
                Dictionary<string, string> settings = FileRepo.GetConfig();
                cbChampionship.SelectedIndex = int.Parse(settings[nameof(cbChampionship)]);
                gbLanguage.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Tag.ToString() == settings[nameof(gbLanguage)]).Checked = true;
                if (isWpf)
                {
                    gbResolution.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Tag.ToString() == settings[nameof(gbResolution)]).Checked = true;
                }
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (FormValid())
            {
                StringBuilder sb = new();
                sb.AppendLine(nameof(cbChampionship) + DEL + cbChampionship.SelectedIndex);
                sb.Append(nameof(gbLanguage) + DEL + gbLanguage.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Tag?.ToString());

                if (isWpf)
                {
                    sb.Append(Environment.NewLine);
                    sb.AppendLine(nameof(gbResolution) + DEL + gbResolution.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Tag?.ToString());
                }

                ConfirmDialog dialog = new();
                DialogResult dialogResult = dialog.ShowDialog();

                if (dialogResult is DialogResult.OK)
                {
                    FileRepo.SaveConfig(sb.ToString());
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Choose setup.", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool FormValid()
        {
            var language = gbLanguage.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (isWpf)
            {
                var resolution = gbResolution.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                return cbChampionship.SelectedIndex != -1 && language != null && resolution != null;
            }
            else
            {
                return cbChampionship.SelectedIndex != -1 && language != null;
            }
        }
    }
}