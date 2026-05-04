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
    public partial class FilmVserial : UserControl
    {
        public FilmVserial()
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

        private void Sansor1_Click(object sender, EventArgs e)
        {
            string url1 = "https://zardfilm.in/";
            Process.Start(url1);
        }

        private void Sansor2_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.uptvs.com/";
            Process.Start(url1);
        }

        private void Sansor3_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.namava.ir/main";
            Process.Start(url1);
        }

        private void Sansor4_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.filimo.com/";
            Process.Start(url1);
        }

        private void Sansor5_Click(object sender, EventArgs e)
        {
            string url1 = "https://filmnet.ir/";
            Process.Start(url1);
        }

        private void Sansor6_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.gapfilm.ir/";
            Process.Start(url1);
        }

        private void Nosansor1_Click(object sender, EventArgs e)
        {
            string url = "https://tdmmo.xyz/login";
            Process.Start(url);
        }

        private void Nosansor2_Click(object sender, EventArgs e)
        {
            string url = "https://flzios.ir/";
            Process.Start(url);
        }

        private void Nosansor3_Click(object sender, EventArgs e)
        {
            string url = "https://s34.picofile.com/file/8489607418/fw.zip.html";
            Process.Start(url);
        }

        private void Nosansor4_Click(object sender, EventArgs e)
        {
            string url = "https://s34.picofile.com/file/8490474226/%D8%AF%D9%84%D9%81%D8%A7%D9%86.apk.html";
            Process.Start(url);
        }

        private void zirnevis1_Click(object sender, EventArgs e)
        {
            string url = "https://subkade.ir/";
            Process.Start(url);
        }

        private void zirnevis2_Click(object sender, EventArgs e)
        {
            string url = "https://3fa.ir/";
            Process.Start(url);
        }

        private void zirnevis3_Click(object sender, EventArgs e)
        {
            string url = "http://www.subtitlestar.com/";
            Process.Start(url);
        }

        private void Nosansor5_Click(object sender, EventArgs e)
        {
            string url = "https://f2mc.ir/";
            Process.Start(url);
        }

        private void Nosansor6_Click(object sender, EventArgs e)
        {
            string url = "https://movieyaab.ir/";
            Process.Start(url);
        }
    }
}
