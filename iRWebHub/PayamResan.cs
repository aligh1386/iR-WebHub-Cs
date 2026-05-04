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
    public partial class PayamResan : UserControl
    {
        public PayamResan()
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

        private void PayamResan1_Click(object sender, EventArgs e)
        {
            string url = "https://web.bale.ai/";
            Process.Start(url);
        }

        private void PayamResan2_Click(object sender, EventArgs e)
        {
            string url = "https://web.eitaa.com/";
            Process.Start(url);
        }

        private void PayamResan3_Click(object sender, EventArgs e)
        {
            string url = "https://web.rubika.ir/";
            Process.Start(url);
        }

        private void PayamResan4_Click(object sender, EventArgs e)
        {
            string url = "https://web.splus.ir/";
            Process.Start(url);
        }

        private void PayamResan5_Click(object sender, EventArgs e)
        {
            string url = "https://web.gap.im/";
            Process.Start(url);
        }

        private void PayamResan6_Click(object sender, EventArgs e)
        {
            string url = "https://web.igap.net/";
            Process.Start(url);
        }

        private void PayamResan7_Click(object sender, EventArgs e)
        {
            string url = "https://virasty.com/";
            Process.Start(url);

        }
    }
}
