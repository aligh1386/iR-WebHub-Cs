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
    public partial class AppDL : UserControl
    {
        public AppDL()
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

        private void Soft98_Click(object sender, EventArgs e)
        {
            string url1 = "https://soft98.ir/";
            Process.Start(url1);
        }

        private void DownloadHa_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.downloadha.com/";
            Process.Start(url1);
        }

        private void Par30Game_Click(object sender, EventArgs e)
        {
            string url1 = "https://par30games.net/";
            Process.Start(url1);
        }

        private void GameQ_Click(object sender, EventArgs e)
        {
            string url1 = "https://gameq.ir/";
            Process.Start(url1);
        }

        private void DownloadFarsi_Click(object sender, EventArgs e)
        {
            string url1 = "https://download.ir/";
            Process.Start(url1);
        }

        private void SarzaminDl_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.sarzamindownload.com/";
            Process.Start(url1);
        }

        private void YasDl_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.yasdl.com/";
            Process.Start(url1);
        }

        private void VGDL_Click(object sender, EventArgs e)
        {
            string url1 = "https://vgdl.ir/";
            Process.Start(url1);
        }

        private void Dlfox_Click(object sender, EventArgs e)
        {
            string url1 = "https://dlfox.com/";
            Process.Start(url1);
        }

        private void Farsriod_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.farsroid.com/";
            Process.Start(url1);
        }

        private void myket_Click(object sender, EventArgs e)
        {
            string url1 = "https://myket.ir/";
            Process.Start(url1);
        }

        private void coffeebaz_Click(object sender, EventArgs e)
        {
            string url1 = "https://cafebazaar.ir/app";
            Process.Start(url1);
        }

        private void sibche_Click(object sender, EventArgs e)
        {
            string url1 = "https://sibche.com/";
            Process.Start(url1);
        }

        private void Sibapp_Click(object sender, EventArgs e)
        {
            string url1 = "https://sibapp.com/";
            Process.Start(url1);
        }

        private void Iapp_Click(object sender, EventArgs e)
        {
            string url1 = "https://iapps.ir/";
            Process.Start(url1);
        }
    }
}
