using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ariza_Talep_2
{
    public partial class Form4_2_GoruntuleTalepDetay : Form
    {
        public Form4_2_GoruntuleTalepDetay()
        {
            InitializeComponent();
        }
        
        Sqlbaglantisi con = new Sqlbaglantisi();

        public void tum_mesajlari_listele_yonetici()
        {
            SqlCommand sorgu = new SqlCommand("Mesajlar_Yonetici_Kisi_Listesi", con.baglanti());
            sorgu.CommandType = CommandType.StoredProcedure;

            sorgu.Parameters.AddWithValue("@mesaj_kisi_id", Class_Detay.k_kisi_id); //yönetici girişinden giriş yapıldığı için...

            //sorgu.Parameters.AddWithValue("@mesaj_kisi_id", Class_KullanıcıBilgileri.k_id); //giren kullanıcı bu
            SqlDataReader dr = sorgu.ExecuteReader();

            while (dr.Read())
            {
                int sahip_id = Convert.ToInt32(dr["mesaj_Sahibi_id"]);
                Button dynamicButton = new Button();
                Label label = new Label();

                if (sahip_id.ToString() == Class_Detay.k_kisi_id)
                {
                    dynamicButton.Height = 50;
                    dynamicButton.Width = 180;
                    dynamicButton.Text = dr["mesaj_icerik"].ToString();
                    dynamicButton.Name = dr["mesaj_id"].ToString();
                    dynamicButton.BackColor = Color.LightPink;

                    label.Height = 15;
                    label.Width = 180;
                    label.Text = dr["kullanici_adi_soyadi"].ToString();

                    label.Name = dr["mesaj_id"].ToString();

                    flowLayoutPanel1.Controls.Add(label);

                    flowLayoutPanel1.Controls.Add(dynamicButton);
                }
                else
                {
                    dynamicButton.Height = 50;
                    dynamicButton.Width = 180;
                    dynamicButton.Text = dr["mesaj_icerik"].ToString();
                    dynamicButton.Name = dr["mesaj_id"].ToString();
                    dynamicButton.BackColor = Color.AliceBlue;

                    label.Height = 15;
                    label.Width = 180;
                    label.Text = dr["kullanici_adi_soyadi"].ToString();
                    //label.Text = "Yönetici";
                    label.Name = dr["mesaj_id"].ToString();

                    flowLayoutPanel1.Controls.Add(label);

                    flowLayoutPanel1.Controls.Add(dynamicButton);
                }
                txt_son_mesaj_id.Text = dr["mesaj_id"].ToString();
            }
            flowLayoutPanel1.AutoScrollPosition = new Point(AutoScrollPosition.X, AutoScrollPosition.Y + 5000);
        }

        private void Form4_2_GoruntuleTalepDetay_Load(object sender, EventArgs e)
        {
            txt_oncelik_duzeyi.Text = Class_Detay.k_oncelik_duzeyi;

            lbl_kisi_id.Text = Class_Detay.k_kisi_id;
            lbl_kisi_ad.Text = Class_Detay.k_kullanici_adi;
            lbl_kisi_bolum.Text = Class_Detay.k_bolum_adi;
            lbl_olusturulma_tarihi.Text = Class_Detay.k_olusturulma_tarihi;

            lbl_mesaj_id.Text = Class_Detay.k_id;

            richEditControl1.Text = Class_Detay.k_icerik;
            tum_mesajlari_listele_yonetici(); //flowLayoutPanel1 içerisi doluyorr...
        }

        private void btn_mesajGonder_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;

            SqlCommand cmd = new SqlCommand("Mesaj_Gonder", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mesaj_icerik", richEditControl2.Text);

            cmd.Parameters.AddWithValue("@mesaj_gonderim_zamani", bugun);

            cmd.Parameters.AddWithValue("@mesaj_kisi_id", Class_Detay.k_kisi_id);

            cmd.Parameters.AddWithValue("@mesaj_ts_id", 0.ToString());

            cmd.Parameters.AddWithValue("@mesaj_cevap_id", 0.ToString());

            cmd.Parameters.AddWithValue("@mesaj_Sahibi_id", Class_KullanıcıBilgileri.k_id);

            cmd.ExecuteNonQuery();

            flowLayoutPanel1.Controls.Clear();

            richEditControl2.Text = "";

            tum_mesajlari_listele_yonetici();
        }
    }
}
