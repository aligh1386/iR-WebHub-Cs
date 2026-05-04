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
    public partial class Onlineshop : UserControl
    {
        public Onlineshop()
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
        private void OShop1_Click(object sender, EventArgs e)
        {
            string url = "https://torob.com/";
            Process.Start(url);
        }

        private void OShop2_Click(object sender, EventArgs e)
        {
            string url = "https://www.digikala.com/";
            Process.Start(url);
        }

        private void OShop3_Click(object sender, EventArgs e)
        {
            string url = "https://www.technolife.com/";
            Process.Start(url);
        }

        private void OShop4_Click(object sender, EventArgs e)
        {
            string url = "https://afraa.shop/";
            Process.Start(url);
        }

        private void OShop5_Click(object sender, EventArgs e)
        {
            string url = "https://www.okala.com/stores";
            Process.Start(url);
        }

        private void OShop6_Click(object sender, EventArgs e)
        {
            string url = "https://emalls.ir/";
            Process.Start(url);
        }

        private void OShop7_Click(object sender, EventArgs e)
        {
            string url = "https://basalam.com/";
            Process.Start(url);
        }

        private void OShop8_Click(object sender, EventArgs e)
        {
            string url = "https://amol-language-house.ir/";
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
