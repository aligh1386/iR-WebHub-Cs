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
    public partial class amozeshi : UserControl
    {
        public amozeshi()
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

        private void Dickshenery1_Click(object sender, EventArgs e)
        {
            string url = "https://abadis.ir/";
            Process.Start(url);
        }

        private void Dickshenery2_Click(object sender, EventArgs e)
        {
            string url = "https://llm.targoman.ir/";
            Process.Start(url);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.faraazin.ir/";
            Process.Start(url);
        }

        private void amozesh1_Click(object sender, EventArgs e)
        {
            string url = "https://faradars.org/";
            Process.Start(url);
        }

        private void amozesh2_Click(object sender, EventArgs e)
        {
            string url = "https://maktabkhooneh.org/";
            Process.Start(url);
        }

        private void amozesh3_Click(object sender, EventArgs e)
        {
            string url = "https://www.roshd.ir/";
            Process.Start(url);
        }

        private void amozesh4_Click(object sender, EventArgs e)
        {
            string url = "https://www.bamaclass.com/";
            Process.Start(url);
        }

        private void amozesh5_Click(object sender, EventArgs e)
        {
            string url = "https://quera.org/college";
            Process.Start(url);
        }

        private void amozesh6_Click(object sender, EventArgs e)
        {
            string url = "https://www.amoozesh.ir/";
            Process.Start(url);

        }
    }
}
