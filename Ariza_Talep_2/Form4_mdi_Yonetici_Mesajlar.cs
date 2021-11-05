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
    public partial class Form4_mdi_Yonetici_Mesajlar : Form
    {
        public Form4_mdi_Yonetici_Mesajlar()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        public void son_mesaj_okundu_yonetici(string son_mesaj_id)
        {
            SqlCommand cmd = new SqlCommand("Mesaj_Yonetici_Oku", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mesaj_id", son_mesaj_id);

            cmd.Parameters.AddWithValue("@mesaj_Okundu_Yonetici", "True");

            cmd.ExecuteNonQuery();

            Form4_Yonetici_Ekrani f4_Yonetici_Ekrani = new Form4_Yonetici_Ekrani();
            f4_Yonetici_Ekrani.mesaj_sayisi();
        }

        public void tum_mesajlari_listele_yonetici(string kisi_id)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlCommand sorgu = new SqlCommand("Mesajlar_Yonetici_Kisi_Listesi", con.baglanti());
            sorgu.CommandType = CommandType.StoredProcedure;

            sorgu.Parameters.AddWithValue("@mesaj_kisi_id", kisi_id); //yönetici girişinden giriş yapıldığı için...

            SqlDataReader dr = sorgu.ExecuteReader();

            while (dr.Read())
            {
                int sahip_id = Convert.ToInt32(dr["mesaj_Sahibi_id"]);
                Button dynamicButton = new Button();
                Label label = new Label();

                if (sahip_id.ToString() == kisi_id)
                {
                    dynamicButton.Height = 50;
                    dynamicButton.Width = 230;
                    dynamicButton.Text = dr["mesaj_icerik"].ToString();
                    dynamicButton.Name = dr["mesaj_id"].ToString();
                    dynamicButton.BackColor = Color.LightPink;

                    label.Height = 15;
                    label.Width = 230;
                    label.Text = dr["kullanici_adi_soyadi"].ToString();

                    label.Name = dr["mesaj_id"].ToString();

                    flowLayoutPanel1.Controls.Add(label);

                    flowLayoutPanel1.Controls.Add(dynamicButton);
                }
                else
                {
                    dynamicButton.Height = 50;
                    dynamicButton.Width = 230;
                    dynamicButton.Text = dr["mesaj_icerik"].ToString();
                    dynamicButton.Name = dr["mesaj_id"].ToString();
                    dynamicButton.BackColor = Color.AliceBlue;

                    label.Height = 15;
                    label.Width = 230;

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

        public void mesaj_atan_kişilerin_listesi()
        {
            SqlCommand sorgu_1 = new SqlCommand("Okunmamıs_Olanlar", con.baglanti());
            sorgu_1.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr_1 = sorgu_1.ExecuteReader();

            SqlCommand sorgu = new SqlCommand("Tum_Mesaj_Atanlar", con.baglanti());
            sorgu.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = sorgu.ExecuteReader();

            while (dr.Read())
            {
                Button dynamicButton = new Button();

                dynamicButton.Height = 70;
                dynamicButton.Width = 180;
                dynamicButton.Text = dr["kullanici_adi_soyadi"].ToString();
                dynamicButton.Name = dr["kullanici_id"].ToString();
                dynamicButton.BackColor = Color.LightBlue;

                while (dr_1.Read())
                {
                    if (dr["kullanici_id"].ToString() == dr_1["kullanici_id"].ToString())
                    {
                        dynamicButton.Font = new Font("Sitka Small", 9, FontStyle.Bold);
                    }
                    else
                    {
                        //dynamicButton.Font = new Font("Sitka Small", 9, FontStyle.Bold);
                    }
                }

                dynamicButton.Click += new EventHandler(dynamicButton_click);

                flowLayoutPanel4.Controls.Add(dynamicButton);
            }


        }

        private void Form4_mdi_Yonetici_Mesajlar_Load(object sender, EventArgs e)
        {
            mesaj_atan_kişilerin_listesi();
        }

        private void dynamicButton_click(object sender, EventArgs e)
        {

            string buton_adi = (sender as Button).Name.ToString();
            txt_kisi_id_bilgi.Text = buton_adi;
            tum_mesajlari_listele_yonetici(buton_adi); //kişi id

            son_mesaj_okundu_yonetici(txt_son_mesaj_id.Text);
            flowLayoutPanel4.Controls.Clear();
            mesaj_atan_kişilerin_listesi();
        }

        private void btn_mesajGonder_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;

            SqlCommand cmd = new SqlCommand("Mesaj_Gonder", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mesaj_icerik", richEditControl2.Text);

            cmd.Parameters.AddWithValue("@mesaj_gonderim_zamani", bugun);

            cmd.Parameters.AddWithValue("@mesaj_kisi_id", txt_kisi_id_bilgi.Text);

            cmd.Parameters.AddWithValue("@mesaj_ts_id", 0.ToString());

            cmd.Parameters.AddWithValue("@mesaj_cevap_id", 0.ToString());

            cmd.Parameters.AddWithValue("@mesaj_Sahibi_id", Class_KullanıcıBilgileri.k_id);

            cmd.ExecuteNonQuery();

            flowLayoutPanel1.Controls.Clear();

            richEditControl2.Text = "";

            tum_mesajlari_listele_yonetici(txt_kisi_id_bilgi.Text);
        }
    }
}
