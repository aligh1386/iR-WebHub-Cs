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
    public partial class musicVpodCast : UserControl
    {
        public musicVpodCast()
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
        private void Music1_Click(object sender, EventArgs e)
        {
            string url = "https://beatmastering.ir/";
            Process.Start(url);
        }

        private void Music2_Click(object sender, EventArgs e)
        {
            string url = "https://download1music.ir/";
            Process.Start(url);
        }

        private void Music3_Click(object sender, EventArgs e)
        {
            string url = "https://rozmusic.com/";
            Process.Start(url);
        }

        private void Music4_Click(object sender, EventArgs e)
        {
            string url = "https://musics-fa.com/download-songs/";
            Process.Start(url);
        }

        private void Music5_Click(object sender, EventArgs e)
        {
            string url = "https://musicdel.ir/single-tracks/";
            Process.Start(url);
        }

        private void Music6_Click(object sender, EventArgs e)
        {
            string url = "https://upmusics.com/category/single-tracks/";
            Process.Start(url);
        }

        private void Music7_Click(object sender, EventArgs e)
        {
            string url = "https://www.teh-music.com/";
            Process.Start(url);
        }

        private void Music8_Click(object sender, EventArgs e)
        {
            string url = "https://biamusic.ir/";
            Process.Start(url);

        }

        private void PodCast1_Click(object sender, EventArgs e)
        {
            string url = "https://www.ravkadeh.ir/";
            Process.Start(url); 
        }

        private void PodCast2_Click(object sender, EventArgs e)
        {
            string url = "https://rokhpodcast.ir/";
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
