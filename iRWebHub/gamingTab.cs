using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iRWebHub
{
    public partial class gamingTab : UserControl
    {
        private List<Button> categoryButtons = new List<Button>();
        private Color _defaultBackColor = Color.FromArgb(40, 40, 40);
        private Color _hoverBackColor = Color.FromArgb(70, 70, 70);
        public gamingTab()
        {
            InitializeComponent();
            categoryButtons.Add(Download1);
            categoryButtons.Add(Download2);
            categoryButtons.Add(Download3);
            categoryButtons.Add(Download4);
            categoryButtons.Add(Download5);
            categoryButtons.Add(Svlist1);
            categoryButtons.Add(Svlist2);
            categoryButtons.Add(Svlist3);
            categoryButtons.Add(Svlist4);
            categoryButtons.Add(Svlist5);
            categoryButtons.Add(VideoGame1);
            categoryButtons.Add(VideoGame2);
            categoryButtons.Add(VideoGame3);
            categoryButtons.Add(farsiSaz1);
            categoryButtons.Add(farsiSaz2);
            categoryButtons.Add(farsiSaz3);
            categoryButtons.Add(farsiSaz4);
            categoryButtons.Add(farsiSaz5);
            categoryButtons.Add(Stream1);
            categoryButtons.Add(Stream2);


            foreach (Button btn in categoryButtons)
            {
                btn.MouseMove += Category_MouseMove;
                btn.MouseLeave += Category_MouseLeave;
                btn.BackColor = _defaultBackColor;

            }
        }

        private void Category_MouseMove(object sender, MouseEventArgs e)
        {
            Button currentButton = sender as Button;
            if (currentButton != null)
            {
                foreach (Button btn in categoryButtons)
                {
                    if (btn == currentButton)
                    {

                        btn.ForeColor = Color.Yellow;
                        btn.BackColor = _hoverBackColor;
                    }
                    else
                    {
                        btn.BackColor = _defaultBackColor;
                        btn.ForeColor = Color.SpringGreen;
                    }
                }
            }
        }
        private void Category_MouseLeave(object sender, EventArgs e)
        {
            foreach (Button btn in categoryButtons)
            {
                btn.BackColor = _defaultBackColor;
                btn.ForeColor = Color.SpringGreen;

            }
        }

        private void test1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Controls.Clear();
            this.Controls.Add(menu);

        }

        private void Download1_Click(object sender, EventArgs e)
        {
            string url1 = "https://asia-game.org/";
            string url2 = "https://www.sarzamindownload.com/1549/-%D8%A8%D8%A7%D8%B2%DB%8C-%DA%A9%D8%A7%D9%86%D8%AA%D8%B1-%D8%A7%D8%B3%D8%AA%D8%B1%DB%8C%DA%A9-1.6-%D8%8C-%D8%A2%D9%BE%D8%AF%DB%8C%D8%AA-%D8%A8%D9%87%D9%85%D9%86-1404%D8%8C-%D8%A8%D8%A7-%D8%B3%D8%B1%D9%88%D8%B1%D9%87%D8%A7%DB%8C-%D8%A7%DB%8C%D8%B1%D8%A7%D9%86%DB%8C-%D8%A2%D9%86%D9%84%D8%A7%DB%8C%D9%86---Counter-Strike-1.6-v9";
            string url3 = "https://shadowgames.ir/%d8%af%d8%a7%d9%86%d9%84%d9%88%d8%af-%d8%a8%d8%a7%d8%b2%db%8c-%da%a9%d8%a7%d9%86%d8%aa%d8%b1-%d8%a2%d9%86%d9%84%d8%a7%db%8c%d9%86-counter-stricke-1-6/";
            Process.Start(url1);
            Process.Start(url2);
            Process.Start(url3);
        }

        private void Download2_Click(object sender, EventArgs e)
        {
            string url1 = "https://topmix-game.ir/counter-strike-source/";
            string url2 = "https://www.sarzamindownload.com/26671/-%D8%A8%D8%A7%D8%B2%DB%8C-%DA%A9%D8%A7%D9%86%D8%AA%D8%B1-%D8%B3%D9%88%D8%B1%D8%B3-%D8%A2%D9%86%D9%84%D8%A7%DB%8C%D9%86-%D8%A8%D9%87-%D9%87%D9%85%D8%B1%D8%A7%D9%87-%D8%B3%D8%B1%D9%88%D8%B1%D9%87%D8%A7%DB%8C-%D8%A7%DB%8C%D8%B1%D8%A7%D9%86%DB%8C---Counter-Strike:-Source";
            string url3 = "https://shadowgames.ir/%d8%af%d8%a7%d9%86%d9%84%d9%88%d8%af-%d8%a8%d8%a7%d8%b2%db%8c-%da%a9%d8%a7%d9%86%d8%aa%d8%b1-%d8%b3%d9%88%d8%b1%d8%b3-%d8%a2%d9%86%d9%84%d8%a7%db%8c%d9%86-css-source/";
            Process.Start(url1);
            Process.Start(url2);
            Process.Start(url3);
        }

        private void Download3_Click(object sender, EventArgs e)
        {
            string url1 = "https://gold-team.org/call-of-duty-4-cod4x/";
            string url2 = "https://uupload.ir/view/cod4-client-manualinstall_21.1_e471.zip";
            Process.Start(url1);
            Process.Start(url2);
        }

        private void Download4_Click(object sender, EventArgs e)
        {
            string url1 = "https://silasdl.ir/download-warcraft-3-atinad-garena-total-new-maps/";
            Process.Start(url1);
        }

        private void Download5_Click(object sender, EventArgs e)
        {
            string url2 = "https://www.aparat.com/v/bcsn10k";
            string url1 = "https://phoenixclient.ir/en";
            Process.Start(url1);
            Process.Start(url2);
        }

        private void Svlist1_Click(object sender, EventArgs e)
        {
            string url1 = "https://asia-game.org/server/";
            string url2 = "https://shadowgames.ir/servers-status/";
            Process.Start(url1);
            Process.Start(url2);
        }

        private void Svlist2_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.master-server.ir/game-cssv34.html";
            Process.Start(url1);
        }

        private void Svlist3_Click(object sender, EventArgs e)
        {
            string url1 = "http://status.irproness.com/";
            Process.Start(url1);
        }

        private void Svlist4_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.xcraft.ir/";
            Process.Start(url1);
        }

        private void VideoGame1_Click(object sender, EventArgs e)
        {
            string url1 = "https://gamefa.com/";
            Process.Start(url1);
        }

        private void VideoGame2_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.zoomg.ir/";
            Process.Start(url1);
        }

        private void VideoGame3_Click(object sender, EventArgs e)
        {
            string url1 = "https://vigiato.net/";
            Process.Start(url1);
        }

        private void farsiSaz1_Click(object sender, EventArgs e)
        {
            string url1 = "https://gameq.ir/category/farsi-saz-game/";
            Process.Start(url1);
        }

        private void farsiSaz2_Click(object sender, EventArgs e)
        {
            string url1 = "https://fansub.ir/";
            Process.Start(url1);
        }

        private void farsiSaz3_Click(object sender, EventArgs e)
        {
            string url1 = "https://playfa.net/";
            Process.Start(url1);
        }

        private void farsiSaz4_Click(object sender, EventArgs e)
        {
            string url1 = "https://pnegar.ir/";
            Process.Start(url1);
        }

        private void farsiSaz5_Click(object sender, EventArgs e)
        {
            string url1 = "https://persianlingo.ir/";
            Process.Start(url1);
        }

        private void Svlist5_Click(object sender, EventArgs e)
        {
            string url1 = "https://iranmta.ir/";
            Process.Start(url1);
        }

        private void Stream1_Click(object sender, EventArgs e)
        {
            string url1 = "https://pixelg.ir/";
            Process.Start(url1);
        }

        private void Stream2_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.aparat.com/live";
            Process.Start(url1);
        }
    }
}
