using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace Ariza_Talep_2
{
    public partial class Form1_Giris : Form
    {
        public Form1_Giris()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        private void Form1_Giris_Load(object sender, EventArgs e)
        {

        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (txt_kullanici_giris_adi.Text != "" && txt_kullanici_giris_sifre.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Kullanici_Giris", con.baglanti());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@kullanici_s_adi", txt_kullanici_giris_adi.Text);
                cmd.Parameters.AddWithValue("@kullanici_s_sifre", txt_kullanici_giris_sifre.Text);

                SqlDataReader data_Reader = cmd.ExecuteReader();

                if (data_Reader.Read())
                {
                    Class_KullanıcıBilgileri.k_id = data_Reader[0].ToString();
                    Class_KullanıcıBilgileri.k_ad = data_Reader[1].ToString();
                    Class_KullanıcıBilgileri.k_sistem_adi = data_Reader[2].ToString();
                    //Class_KullanıcıBilgileri.k_soyadi = data_Reader[3].ToString();

                    Class_KullanıcıBilgileri.k_bolum_adi = data_Reader[4].ToString();
                    //Class_KullanıcıBilgileri.k_gorevi = data_Reader[6].ToString();
                    Class_KullanıcıBilgileri.k_yonetici = data_Reader[5].ToString();

                    //MessageBox.Show("Giriş Başarılı");

                    if (Class_KullanıcıBilgileri.k_yonetici == "True")
                    {
                        Form4_Yonetici_Ekrani f4_Yonetici_Ekrani = new Form4_Yonetici_Ekrani();
                        f4_Yonetici_Ekrani.Show();
                        this.Hide();
                        //this.Close();
                    }
                    else
                    {
                        Form2_KullanıcıEkrani f2_KullanıcıEkrani = new Form2_KullanıcıEkrani();
                        f2_KullanıcıEkrani.Show();
                        this.Hide();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Başarısız Giriş");
                }
                data_Reader.Close();

            }
            else
            {
                XtraMessageBox.Show("Boş bıralılan Alan...");
            }
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            Form1_KayitOl f1_KayitOl = new Form1_KayitOl();
            f1_KayitOl.ShowDialog();
        }

        private void Form1_Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = false; //kapatiyorr
            //e.Cancel = true; //sabit
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                txt_kullanici_giris_sifre.Properties.UseSystemPasswordChar = false;
                checkEdit1.Text = "Gizle";
            }
            else
            {
                txt_kullanici_giris_sifre.Properties.UseSystemPasswordChar = true;
                checkEdit1.Text = "Göster";
            }   
        }
    }
}
