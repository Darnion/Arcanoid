using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class FormMenu : Form
    {
        private FormArcanoid arcanoidGame;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Visible = false;
            arcanoidGame = new FormArcanoid();
            Hide();
            arcanoidGame.ShowDialog();
            Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
