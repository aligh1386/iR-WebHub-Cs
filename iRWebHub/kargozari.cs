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
    public partial class kargozari : UserControl
    {
        public kargozari()
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

        private void kargozari1_Click(object sender, EventArgs e)
        {
            string url = "https://hafezbroker.ir/";
            Process.Start(url);
        }

        private void kargozari2_Click(object sender, EventArgs e)
        {
            string url = "https://agah.com/";
            Process.Start(url);
        }

        private void kargozari3_Click(object sender, EventArgs e)
        {
            string url = "https://mobile.oibourse.ir/Login";
            Process.Start(url);
        }

        private void kargozari4_Click(object sender, EventArgs e)
        {
            string url = "https://www.emofid.com/";
            Process.Start(url);
        }

        private void kargozari5_Click(object sender, EventArgs e)
        {
            string url = "https://farabi.irbrokersite.ir/";
            Process.Start(url);

        }

        private void kargozari6_Click(object sender, EventArgs e)
        {
            string url = "https://armanbroker.ir/";
            Process.Start(url);
        }
    }
}
