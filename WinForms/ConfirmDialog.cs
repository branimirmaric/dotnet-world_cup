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
    public partial class ConfirmDialog : Form
    {
        public ConfirmDialog()
        {
            InitializeComponent();
        }

        private void Buttons_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnConfirm.PerformClick();
                    break;

                case Keys.Escape:
                    btnCancel.PerformClick();
                    break;
            }
        }
    }
}
