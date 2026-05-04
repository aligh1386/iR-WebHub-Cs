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
    public partial class Pezashki : UserControl
    {
        public Pezashki()
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
        private void Pezashki1_Click(object sender, EventArgs e)
        {
            string url = "https://www.drsaina.com/";
            Process.Start(url);
        }

        private void Pezashki2_Click(object sender, EventArgs e)
        {
            string url = "https://nobat.ir/";
            Process.Start(url);
        }

        private void Pezashki3_Click(object sender, EventArgs e)
        {
            string url = "https://www.salamati24.com/fa";
            Process.Start(url);
        }

        private void Pezashki4_Click(object sender, EventArgs e)
        {
            string url = "https://drdr.ir/";
            Process.Start(url);
        }

        private void Pezashki5_Click(object sender, EventArgs e)
        {
            string url = "https://doctor-yab.ir/";
            Process.Start(url);
        }

        private void Pezashki6_Click(object sender, EventArgs e)
        {
            string url = "https://doctoreto.com/";
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
