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
    public partial class KhadamatDolati : UserControl
    {
        public KhadamatDolati()
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
        private void Dolat1_Click(object sender, EventArgs e)
        {
            string url = "https://www.intamedia.ir/";
            Process.Start(url);
        }

        private void Dolat2_Click(object sender, EventArgs e)
        {
            string url = "https://sana.adliran.ir/Sana/Index#/Main";
            Process.Start(url);
        }

        private void Dolat3_Click(object sender, EventArgs e)
        {
            string url = "https://141.ir/";
            Process.Start(url);
        }

        private void Dolat4_Click(object sender, EventArgs e)
        {
            string url = "http://www.epolice.ir/";
            Process.Start(url);
        }

        private void Dolat5_Click(object sender, EventArgs e)
        {
            string url = "https://tamin.ir/";
            Process.Start(url);
        }

        private void Dolat6_Click(object sender, EventArgs e)
        {
            string url = "https://www.sabteahval.ir/";
            Process.Start(url);
        }

        private void Dolat7_Click(object sender, EventArgs e)
        {
            string url = "http://www.epolice.ir/";
            Process.Start(url);
        }

        private void Dolat8_Click(object sender, EventArgs e)
        {
            string url = "https://www.irimo.ir/far/index.php";
            Process.Start(url);
        }

        private void Dolat9_Click(object sender, EventArgs e)
        {
            string url = "https://ssaa.ir/";
            Process.Start(url);
        }

        private void Dolat10_Click(object sender, EventArgs e)
        {
            string url = "http://adliran.ir/";
            Process.Start(url);
        }

        private void Dolat11_Click(object sender, EventArgs e)
        {
            string url = "https://tracking.post.ir/";
            Process.Start(url);

        }

        private void Dolat12_Click(object sender, EventArgs e)
        {
            string url = "http://irsc.ut.ac.ir/index.php?lang=fa";
            Process.Start(url);
        }

        private void Dolat13_Click(object sender, EventArgs e)
        {
            string url = "http://www.irantvto.ir/";
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
