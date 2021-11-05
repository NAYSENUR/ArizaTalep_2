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
    public partial class Form2_Kullanici_mdi_Mesajlar : Form
    {
        public Form2_Kullanici_mdi_Mesajlar()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        public void tum_mesajlari_listele()
        {
            SqlCommand sorgu = new SqlCommand("Mesajlar_Kisi_Listesi", con.baglanti());
            sorgu.CommandType = CommandType.StoredProcedure;

            sorgu.Parameters.AddWithValue("@mesaj_kisi_id", Class_KullanıcıBilgileri.k_id);
            SqlDataReader dr = sorgu.ExecuteReader();

            while (dr.Read())
            {
                int sahip_id = Convert.ToInt32(dr["mesaj_Sahibi_id"]);
                Button dynamicButton = new Button();
                Label label = new Label();

                if (sahip_id.ToString() == Class_KullanıcıBilgileri.k_id)
                {
                    dynamicButton.Height = 50;
                    dynamicButton.Width = 180;
                    dynamicButton.Text = dr["mesaj_icerik"].ToString();
                    dynamicButton.Name = dr["mesaj_id"].ToString();
                    dynamicButton.BackColor = Color.LightPink;

                    label.Height = 15;
                    label.Width = 180;
                    label.Text = Class_KullanıcıBilgileri.k_ad;
                    label.Name = dr["mesaj_id"].ToString();

                    flowLayoutPanel1.Controls.Add(label);

                    //dynamicButton.Location = new Point(20, 150); sağ yada sol

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

        private void Form2_Kullanici_mdi_Mesajlar_Load(object sender, EventArgs e)
        {
            tum_mesajlari_listele();


            SqlCommand cmd = new SqlCommand("Mesaj_Kullanici_Oku", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mesaj_id", txt_son_mesaj_id.Text);

            cmd.Parameters.AddWithValue("@mesaj_Okundu_Kullanici", "True");

            cmd.ExecuteNonQuery();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand sorgu = new SqlCommand("Mesajlar_Kisi_Listesi", con.baglanti());
            sorgu.CommandType = CommandType.StoredProcedure;

            sorgu.Parameters.AddWithValue("@mesaj_kisi_id", Class_KullanıcıBilgileri.k_id);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            gridView1.Columns["mesaj_id"].Caption = "ID";
            gridView1.Columns["mesaj_icerik"].Caption = "İÇERİK";
            gridView1.Columns["mesaj_gonderim_zamani"].Caption = "GÖNDERİM ZAMANI";
            gridView1.Columns["mesaj_Okundu_Kullanici"].Caption = "KULLANICI OKUNDU";
            gridView1.Columns["mesaj_Okundu_Yonetici"].Caption = "YÖNETİCİ OKUDU";
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;

            SqlCommand cmd = new SqlCommand("Mesaj_Gonder", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mesaj_icerik", richEditControl1.Text);

            cmd.Parameters.AddWithValue("@mesaj_gonderim_zamani", bugun);

            cmd.Parameters.AddWithValue("@mesaj_kisi_id", Class_KullanıcıBilgileri.k_id);

            cmd.Parameters.AddWithValue("@mesaj_ts_id", 0.ToString());

            cmd.Parameters.AddWithValue("@mesaj_cevap_id", 0.ToString());

            cmd.Parameters.AddWithValue("@mesaj_Sahibi_id", Class_KullanıcıBilgileri.k_id);

            cmd.ExecuteNonQuery();

            flowLayoutPanel1.Controls.Clear();

            richEditControl1.Text = "";

            tum_mesajlari_listele();
        }
    }
}
