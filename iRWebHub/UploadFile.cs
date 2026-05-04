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
    public partial class UploadFile : UserControl
    {
        public UploadFile()
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
        private void UploadFile1_Click(object sender, EventArgs e)
        {
            string url = "https://www.picofile.com/";
            Process.Start(url);
        }

        private void UploadFile2_Click(object sender, EventArgs e)
        {
            string url = "https://uupload.ir/";
            Process.Start(url);
        }

        private void UploadFile3_Click(object sender, EventArgs e)
        {
            string url = "https://uploadkon.ir/";
            Process.Start(url);
        }

        private void UploadFile4_Click(object sender, EventArgs e)
        {
            string url = "http://guardnet.ir/";
            Process.Start(url);
        }

        private void UploadFile5_Click(object sender, EventArgs e)
        {
            string url = "https://up.20script.ir/";
            Process.Start(url);
        }

        private void UploadFile6_Click(object sender, EventArgs e)
        {
            string url = "https://files.ir/";
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
