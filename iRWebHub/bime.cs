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
    public partial class bime : UserControl
    {
        public bime()
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

        private void bime1_Click(object sender, EventArgs e)
        {
            string url = "https://www.centinsur.ir/";
            Process.Start(url);
        }

        private void bime2_Click(object sender, EventArgs e)
        {
            string url = "https://iraninsurance.ir/home";
            Process.Start(url);
        }

        private void bime3_Click(object sender, EventArgs e)
        {
            string url = "https://dana-insurance.com/";
            Process.Start(url);
        }

        private void bime4_Click(object sender, EventArgs e)
        {
            string url = "https://alborzinsurance.ir/";
            Process.Start(url);
        }

        private void bime5_Click(object sender, EventArgs e)
        {
            string url = "https://mic.co.ir/";
            Process.Start(url);

        }

        private void bime6_Click(object sender, EventArgs e)
        {
            string url = "https://bimehma.com/";
            Process.Start(url);
        }

        private void bime7_Click(object sender, EventArgs e)
        {
            string url = "https://parsianinsurance.ir/fa-IR/parsianinsurance/1/page/%D8%AE%D8%A7%D9%86%D9%87";
            Process.Start(url);
        }

        private void bime8_Click(object sender, EventArgs e)
        {
            string url = "https://atiyehsazan.ir/";
            Process.Start(url);
        }

        private void bime9_Click(object sender, EventArgs e)
        {
            string url = "https://www.bimehasia.com/";
            Process.Start(url);
        }

        private void bime10_Click(object sender, EventArgs e)
        {
            string url = "https://www.azki.com/";
            Process.Start(url);
        }

        private void bime11_Click(object sender, EventArgs e)
        {
            string url = "https://www.azki.com/";
            Process.Start(url);
        }
    }
}
