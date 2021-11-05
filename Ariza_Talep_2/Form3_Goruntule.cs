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
    public partial class Form3_Goruntule : Form
    {
        public Form3_Goruntule()
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

                    //label.Text = "Yönetici:";
                    label.Name = dr["mesaj_id"].ToString();

                    flowLayoutPanel1.Controls.Add(label);

                    flowLayoutPanel1.Controls.Add(dynamicButton);
                }
                txt_son_mesaj_id.Text = dr["mesaj_id"].ToString();
            }
            flowLayoutPanel1.AutoScrollPosition = new Point(AutoScrollPosition.X, AutoScrollPosition.Y + 5000);
        }

        private void Form3_Goruntule_Load(object sender, EventArgs e)
        {
            richEditControl1.Text = Class_Detay.k_icerik;

            SqlCommand cmd = new SqlCommand("Oncelikleri_Listele", con.baglanti());

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxEdit1.Properties.ValueMember = "oncelik_duzey_id";
            comboBoxEdit1.Properties.DisplayMember = "oncelik_duzey_adi";
            comboBoxEdit1.Properties.DataSource = dt;

            comboBoxEdit1.Properties.PopupFormMinSize = new Size(50, 50);

            comboBoxEdit1.Properties.PopulateColumns();
            comboBoxEdit1.Properties.Columns["oncelik_duzey_id"].Visible = false;

            string oncelik_adi = Class_Detay.k_oncelik_duzeyi;

            int oncelik_adi_id = Convert.ToInt32(comboBoxEdit1.Properties.GetKeyValueByDisplayText(oncelik_adi));

            comboBoxEdit1.EditValue = oncelik_adi_id;
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            panelControl2.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            tum_mesajlari_listele();
        }

        private void btn_mesajGonder_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;

            SqlCommand cmd = new SqlCommand("Mesaj_Gonder", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mesaj_icerik", richEditControl2.Text);

            cmd.Parameters.AddWithValue("@mesaj_gonderim_zamani", bugun);

            cmd.Parameters.AddWithValue("@mesaj_kisi_id", Class_KullanıcıBilgileri.k_id);

            cmd.Parameters.AddWithValue("@mesaj_ts_id", 0.ToString());

            cmd.Parameters.AddWithValue("@mesaj_cevap_id", 0.ToString());

            cmd.Parameters.AddWithValue("@mesaj_Sahibi_id", Class_KullanıcıBilgileri.k_id);

            cmd.ExecuteNonQuery();

            flowLayoutPanel1.Controls.Clear();

            richEditControl2.Text = "";

            tum_mesajlari_listele();
        }
    }
}
