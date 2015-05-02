using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKoltuklariYerlestir_Click(object sender, EventArgs e)
        {

            int xSirasi = Convert.ToInt32(nudXSirasi.Value);
            int ySirasi = Convert.ToInt32(nudYSirasi.Value);
            for (int x = 0; x < xSirasi; x++)
            {
                for (int y = 0; y < ySirasi; y++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point(x * 50, y * 50);
                    btn.Text = "-";
                    btn.Click += btn_Click;

                    Koltuk koltuk = new Koltuk();
                    koltuk.xKonumu = x;
                    koltuk.yKonumu = y;
                    koltuk.cinsiyetTipi = CinsiyetTipi.TanimliDegil;

                    btn.Tag = koltuk;
                    scAnaPanel.Panel2.Controls.Add(btn);
                }
            }
        }
        // CinsiyetTipi
        //0 - Tanımlı Değil
        //1 - Erkek
        //2 - Kadın
        //3 - Hiçbiri

        class Koltuk
        {
            public int xKonumu;
            public int yKonumu;
            public CinsiyetTipi cinsiyetTipi;
        }

        enum CinsiyetTipi
        {
            TanimliDegil = 0,
            Erkek = 1,
            Kadin = 2,
            Hicbiri = 3
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            Koltuk koltuk = ((Koltuk)btn.Tag);

            CinsiyetTipi cinsiyetTipi = koltuk.cinsiyetTipi;
            int xKonumu = koltuk.xKonumu;
            int yKonumu = koltuk.yKonumu;

            Koltuk yanKoltuk = YanKoltuguGetir(koltuk);
            //Cinsiyet tiplerini karşılaştır eğer farklıyse kaydetmeden mesaj goster
            if (cinsiyetTipi == CinsiyetTipi.TanimliDegil)
            {
                if (rbErkek.Checked)
                {
                    if (yanKoltuk.cinsiyetTipi == CinsiyetTipi.Erkek
                        || yanKoltuk.cinsiyetTipi == CinsiyetTipi.TanimliDegil
                        || yanKoltuk.cinsiyetTipi == CinsiyetTipi.Hicbiri)
                    {
                        btn.Text = "E";
                        btn.BackColor = Color.Blue;

                        koltuk.cinsiyetTipi = CinsiyetTipi.Erkek;
                        btn.Tag = koltuk;
                    }
                    else
                    {
                        DialogResult mesajSonucu = MessageBox.Show("Yan Yana koltuklar aynı cinsiyet olması gerekiyor, yinede eklemek ister misiniz?", 
                            "Cinsiyet Farklılığı",
                            MessageBoxButtons.YesNo);
                        if(mesajSonucu == System.Windows.Forms.DialogResult.Yes)
                        {
                            btn.Text = "E";
                            btn.BackColor = Color.Blue;

                            koltuk.cinsiyetTipi = CinsiyetTipi.Erkek;
                            btn.Tag = koltuk;
                        }
                    }
                }
                else if (rbKadin.Checked)
                {
                    if (yanKoltuk.cinsiyetTipi == CinsiyetTipi.Kadin
                        || yanKoltuk.cinsiyetTipi == CinsiyetTipi.TanimliDegil
                        || yanKoltuk.cinsiyetTipi == CinsiyetTipi.Hicbiri)
                    {
                        btn.Text = "K";
                        btn.BackColor = Color.Pink;

                        koltuk.cinsiyetTipi = CinsiyetTipi.Kadin;
                        btn.Tag = koltuk;
                    }
                    else
                    {
                        MessageBox.Show("Yan Yana koltuklar aynı cinsiyet olması gerekiyor");
                    }
                }
                else if (rbHicbiri.Checked)
                {
                    btn.Text = "H";
                    btn.BackColor = Color.Purple;

                    koltuk.cinsiyetTipi = CinsiyetTipi.Hicbiri;
                    btn.Tag = koltuk;
                }
                else
                {
                    btn.Text = "-";
                    btn.BackColor = Color.Empty;

                    koltuk.cinsiyetTipi = CinsiyetTipi.TanimliDegil;
                    btn.Tag = koltuk;
                }
            }
            else
            {
                btn.Text = "-";
                btn.BackColor = Color.Empty;

                koltuk.cinsiyetTipi = CinsiyetTipi.TanimliDegil;
                btn.Tag = koltuk;
            }
        }

        private Koltuk YanKoltuguGetir(Koltuk koltuk)
        {
            Koltuk yanKoltuk = new Koltuk();

            foreach (Control control in scAnaPanel.Panel2.Controls)
            {
                if (control is Button)
                {
                    Button btn = (control as Button);
                    Koltuk donguKoltugu = ((Koltuk)btn.Tag);
                    if (koltuk.yKonumu == donguKoltugu.yKonumu)
                    {
                        // buraya tıklanan buton ile yanı seviyedeki 4 buton gelecek
                        int artisSayisi;
                        // 0 veya 2 numaralı koltuk olduğundan yan koltuk xkonumun 1 fazlası
                        if (koltuk.xKonumu % 2 == 0)
                        {
                            artisSayisi = 1;
                        }
                        // 1 veya 3 numaralı koltuk olduğundan yan koltuk xkonumun 1 azı
                        else
                        {
                            artisSayisi = -1;
                        }

                        if (donguKoltugu.xKonumu == koltuk.xKonumu + artisSayisi)
                        {
                            yanKoltuk = donguKoltugu;
                            break;
                        }
                    }
                }
            }

            return yanKoltuk;
        }

        private void cbKoltukTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
