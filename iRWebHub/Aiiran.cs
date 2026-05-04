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
    public partial class Aiiran : UserControl
    {
        public Aiiran()
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

        private void AI1_Click(object sender, EventArgs e)
        {
            string url = "https://gapgpt.app/chat";
            Process.Start(url);
        }

        private void AI2_Click(object sender, EventArgs e)
        {
            string url = "https://hooshang.ai/";
            Process.Start(url);
        }

        private void AI3_Click(object sender, EventArgs e)
        {
            string url = "https://panel.roboo.ir/";
            Process.Start(url);
        }

        private void AI4_Click(object sender, EventArgs e)
        {
            string url = "https://liara.ir/products/ai/";
            Process.Start(url);
        }

        private void AI5_Click(object sender, EventArgs e)
        {
            string url = "https://llm.bertina.ir/";
            Process.Start(url);
        }
    }
}
