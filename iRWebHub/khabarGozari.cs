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
    public partial class khabarGozari : UserControl
    {
        public khabarGozari()
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
        private void Khabar1_Click(object sender, EventArgs e)
        {
            string url = "https://www.zoomon.ir/";
            Process.Start(url);
        }

        private void Khabar2_Click(object sender, EventArgs e)
        {
            string url = "https://pedal.ir/";
            Process.Start(url);
        }

        private void Khabar3_Click(object sender, EventArgs e)
        {
            string url = "https://zoomg.ir/";
            Process.Start(url);
        }

        private void Khabar4_Click(object sender, EventArgs e)
        {
            string url = "https://filmzi.com/";
            Process.Start(url);
        }

        private void Khabar5_Click(object sender, EventArgs e)
        {
            string url = "https://kojaro.com/";
            Process.Start(url);
        }

        private void Khabar6_Click(object sender, EventArgs e)
        {
            string url = "https://www.sharghdaily.com/";
            Process.Start(url);
        }

        private void Khabar7_Click(object sender, EventArgs e)
        {
            string url = "https://hammihanonline.ir/";
            Process.Start(url);
        }

        private void Khabar8_Click(object sender, EventArgs e)
        {
            string url = "https://www.etemadonline.com/";
            Process.Start(url);
        }

        private void Khabar9_Click(object sender, EventArgs e)
        {
            string url = "https://www.entekhab.ir/";
            Process.Start(url);
        }

        private void Khabar10_Click(object sender, EventArgs e)
        {
            string url = "https://www.irna.ir/";
            Process.Start(url);
        }

        private void Khabar11_Click(object sender, EventArgs e)
        {
            string url = "https://www.isna.ir/";
            Process.Start(url);
        }

        private void Khabar12_Click(object sender, EventArgs e)
        {
            string url = "https://www.ilna.ir/";
            Process.Start(url);
        }

        private void Khabar13_Click(object sender, EventArgs e)
        {
            string url = "https://www.khabaronline.ir/";
            Process.Start(url);
        }

        private void Khabar14_Click(object sender, EventArgs e)
        {
            string url = "https://www.asriran.com/";
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
