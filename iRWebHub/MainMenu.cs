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
    public partial class MainMenu : UserControl
    {
        private List<Button> categoryButtons = new List<Button>();
        private Color _defaultBackColor = Color.FromArgb(40, 40, 40);
        private Color _hoverBackColor = Color.FromArgb(70, 70, 70);
        public MainMenu()
        {
            InitializeComponent();
            categoryButtons.Add(category1);
            categoryButtons.Add(SearchEngine);
            categoryButtons.Add(Appdl);
            categoryButtons.Add(FilmVaSerial);
            categoryButtons.Add(MusicVpodcast);
            categoryButtons.Add(Aiiran);
            categoryButtons.Add(amozeshi);
            categoryButtons.Add(Onlineshop);
            categoryButtons.Add(BuyFood);
            categoryButtons.Add(MasirYab);
            categoryButtons.Add(BitGold);
            categoryButtons.Add(Karyabi);
            categoryButtons.Add(kargozari);
            categoryButtons.Add(Pezashki);
            categoryButtons.Add(KhadamatDolati);
            categoryButtons.Add(bime);
            categoryButtons.Add(khabarGozari);
            categoryButtons.Add(Varzeshi);
            categoryButtons.Add(Banki);
            categoryButtons.Add(UploadFile);
            categoryButtons.Add(agahiVasile);
            categoryButtons.Add(PayamResan);

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
                        string myBtn = btn.Text;
                        welcome.ForeColor = Color.SpringGreen;
                        welcome.Text = myBtn;
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
                string welcometext = "برنامه نت ملی";
                welcome.ForeColor = Color.White;
                welcome.Text = welcometext;

            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }


        private void welcome_MouseMove(object sender, MouseEventArgs e)
        {
            string welcometext = "ساخته شده توسط علی جی اچ";
            welcome.ForeColor = Color.Yellow;
            welcome.Text = welcometext;
        }

        private void welcome_MouseLeave(object sender, EventArgs e)
        {
            string welcometext = "برنامه نت ملی";
            welcome.ForeColor = Color.White;
            welcome.Text = welcometext;
        }

        private void category1_Click(object sender, EventArgs e)
        {
            gamingTab gaming = new gamingTab();
            this.Controls.Clear();
            this.Controls.Add(gaming);
        }

        private void SearchEngine_Click(object sender, EventArgs e)
        {
            SearchEngine searchEngine = new SearchEngine();
            this.Controls.Clear();
            this.Controls.Add(searchEngine);
        }

        private void Appdl_Click(object sender, EventArgs e)
        {
            AppDL appDL = new AppDL();
            this.Controls.Clear();
            this.Controls.Add(appDL);
        }

        private void FilmVaSerial_Click(object sender, EventArgs e)
        {
            FilmVserial filmVserial = new FilmVserial();
            this.Controls.Clear();
            this.Controls.Add(filmVserial);
        }

        private void MusicVpodcast_Click(object sender, EventArgs e)
        {
            musicVpodCast musicVpodCast = new musicVpodCast();
            this.Controls.Clear(); 
            this.Controls.Add(musicVpodCast);
        }

        private void Aiiran_Click(object sender, EventArgs e)
        {
            Aiiran aiiran = new Aiiran();
            this.Controls.Clear();
            this.Controls.Add(aiiran);
        }

        private void amozeshi_Click(object sender, EventArgs e)
        {
            amozeshi amozeshi = new amozeshi();
            this.Controls.Clear();
            this.Controls.Add(amozeshi);
        }

        private void Onlineshop_Click(object sender, EventArgs e)
        {
            Onlineshop onlineshop = new Onlineshop();
            this.Controls.Clear();
            this.Controls.Add(onlineshop);
        }

        private void BuyFood_Click(object sender, EventArgs e)
        {
            BuyFood onlinebuyfood = new BuyFood();
            this.Controls.Clear();
            this.Controls.Add(onlinebuyfood);
        }

        private void MasirYab_Click(object sender, EventArgs e)
        {
            string url1 = "https://neshan.org/";
            string url2 = "https://balad.ir/";
            Process.Start(url1);
            Process.Start(url2);
        }

        private void BitGold_Click(object sender, EventArgs e)
        {
            BitGold onlineBitGold = new BitGold();
            this.Controls.Clear();
            this.Controls.Add(onlineBitGold);
        }

        private void Karyabi_Click(object sender, EventArgs e)
        {
            Karyabi onlineKaryabi = new Karyabi();
            this.Controls.Clear();
            this.Controls.Add(onlineKaryabi);
        }

        private void Pezashki_Click(object sender, EventArgs e)
        {
            Pezashki pezashki = new Pezashki();
            this.Controls.Clear();
            this.Controls.Add(pezashki);
        }

        private void KhadamatDolati_Click(object sender, EventArgs e)
        {
            KhadamatDolati khadamat = new KhadamatDolati();
            this.Controls.Clear();
            this.Controls.Add(khadamat);
        }

        private void bime_Click(object sender, EventArgs e)
        {
            bime bime = new bime();
            this.Controls.Clear();
            this.Controls.Add(bime);
        }

        private void khabarGozari_Click(object sender, EventArgs e)
        {
            khabarGozari khabar = new khabarGozari();
            this.Controls.Clear();
            this.Controls.Add(khabar);
        }

        private void kargozari_Click(object sender, EventArgs e)
        {
            kargozari kari = new kargozari();
            this.Controls.Clear();
            this.Controls.Add(kari);
        }

        private void Varzeshi_Click(object sender, EventArgs e)
        {
            Varzeshi varzeshi = new Varzeshi();
            this.Controls.Clear();
            this.Controls.Add(varzeshi);
        }

        private void UploadFile_Click(object sender, EventArgs e)
        {
            UploadFile uploadFile = new UploadFile();
            this.Controls.Clear();
            this.Controls.Add(uploadFile);
        }

        private void Banki_Click(object sender, EventArgs e)
        {
            Banki banki = new Banki();
            this.Controls.Clear();
            this.Controls.Add(banki);
        }

        private void agahiVasile_Click(object sender, EventArgs e)
        {
            agahiVasile agahi = new agahiVasile();
            this.Controls.Clear();
            this.Controls.Add(agahi);
        }

        private void PayamResan_Click(object sender, EventArgs e)
        {
            PayamResan payamResan = new PayamResan();
            this.Controls.Clear();
            this.Controls.Add(payamResan);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void telegram_Click(object sender, EventArgs e)
        {
            string url = "https://t.me/Ghablame86/";
            Process.Start(url);
        }

        private void Github_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/aligh1386/";
            Process.Start(url);
        }
    }
}
