using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRWebHub
{
    public partial class agahiVasile : UserControl
    {
        public agahiVasile()
        {
            InitializeComponent();
        }
        private Color _defaultBackColor = Color.FromArgb(40, 40, 40);
        private Color _hoverBackColor = Color.FromArgb(70, 70, 70);
        private void Category_MouseMove(object sender, MouseEventArgs e)
        {
            Button currentButton = sender as Button;
            currentButton.ForeColor = Color.Yellow;
            currentButton.BackColor = _hoverBackColor;

        }
        private void Category_MouseLeave(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            currentButton.BackColor = _defaultBackColor;
            currentButton.ForeColor = Color.SpringGreen;

        }
        private void test1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Controls.Clear();
            this.Controls.Add(mainMenu);
        }

        private void AgahiVasile1_Click(object sender, EventArgs e)
        {
            string url = "https://divar.ir/s/iran";
            Process.Start(url);
        }

        private void AgahiVasile2_Click(object sender, EventArgs e)
        {
            string url = "https://www.sheypoor.com/";
            Process.Start(url);
        }

        private void AgahiVasile3_Click(object sender, EventArgs e)
        {
            string url = "https://esam.ir/";
            Process.Start(url);
        }

        private void AgahiVasile4_Click(object sender, EventArgs e)
        {
            string url = "https://basalam.ir/";
            Process.Start(url);
        }
    }
}
