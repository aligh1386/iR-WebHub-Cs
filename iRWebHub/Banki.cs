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
    public partial class Banki : UserControl
    {
        public Banki()
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

        private void Banki1_Click(object sender, EventArgs e)
        {
            string url = "https://asanpardakht.ir/";
            Process.Start(url);
        }

        private void Banki2_Click(object sender, EventArgs e)
        {
            string url = "https://780.ir/app/dl";
            Process.Start(url);

        }

        private void Banki3_Click(object sender, EventArgs e)
        {
            string url = "https://724.ir/";
            Process.Start(url);
        }

        private void Banki4_Click(object sender, EventArgs e)
        {
            string url = "https://hamrahcard.ir/";
            Process.Start(url);
        }

        private void Banki5_Click(object sender, EventArgs e)
        {
            string url = "https://sekeh.behpardakht.ir/";
            Process.Start(url);
        }
    }
}
