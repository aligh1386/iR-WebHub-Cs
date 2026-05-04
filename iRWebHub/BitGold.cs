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
    public partial class BitGold : UserControl
    {
        public BitGold()
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
        private void Crypto1_Click(object sender, EventArgs e)
        {
            string url = "https://nobitex.ir/";
            Process.Start(url);
        }

        private void Crypto2_Click(object sender, EventArgs e)
        {
            string url = "https://bitpin.ir/";
            Process.Start(url);
        }

        private void Crypto3_Click(object sender, EventArgs e)
        {
            string url = "https://wallex.ir/";
            Process.Start(url);
        }

        private void Crypto4_Click(object sender, EventArgs e)
        {
            string url = "https://tetherland.com/";
            Process.Start(url);
        }

        private void Crypto5_Click(object sender, EventArgs e)
        {
            string url = "https://abantether.com/";
            Process.Start(url);
        }

        private void Gold1_Click(object sender, EventArgs e)
        {
            string url = "https://milli.gold/";
            Process.Start(url);
        }

        private void Gold2_Click(object sender, EventArgs e)
        {
            string url = "https://melligold.com/";
            Process.Start(url);
        }

        private void Gold3_Click(object sender, EventArgs e)
        {
            string url = "https://wallgold.ir/app";
            Process.Start(url);
        }

        private void Gold4_Click(object sender, EventArgs e)
        {
            string url = "https://talasea.ir/";
            Process.Start(url);
        }

        private void Gold5_Click(object sender, EventArgs e)
        {
            string url = "https://investment.snapp.ir/gold/";
            Process.Start(url);
        }

        private void Gold6_Click(object sender, EventArgs e)
        {
            string url = "https://taline.ir/";
            Process.Start(url);
        }

        private void test1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Controls.Clear();
            this.Controls.Add(mainMenu);
        }
    }
}
