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
    public partial class Form3_Kullanici_TalepBildir : Form
    {
        public Form3_Kullanici_TalepBildir()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        private void Form3_Kullanici_TalepBildir_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Oncelikleri_Listele", con.baglanti());

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxEdit1.Properties.ValueMember = "oncelik_duzey_id";
            comboBoxEdit1.Properties.DisplayMember = "oncelik_duzey_adi";
            comboBoxEdit1.Properties.DataSource = dt;
            comboBoxEdit1.Text = "Seçiniz..";

            comboBoxEdit1.Properties.PopupFormMinSize = new Size(50, 10);

            comboBoxEdit1.Properties.PopulateColumns();
            comboBoxEdit1.Properties.Columns["oncelik_duzey_id"].Visible = false;
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;

            SqlCommand cmd = new SqlCommand("TaleplerSorunlar_Kaydet", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ts_tur_id", 2);

            //cmd.Parameters.AddWithValue("@ts_konu", txt_Konu.Text);

            cmd.Parameters.AddWithValue("@ts_acıklama", richEditControl1.Text);

            cmd.Parameters.AddWithValue("@ts_oncelik_duzeyi", comboBoxEdit1.EditValue.ToString());

            cmd.Parameters.AddWithValue("@ts_olusturulma_Tarihi", bugun);

            cmd.Parameters.AddWithValue("@kullanici_id", Class_KullanıcıBilgileri.k_id);

            cmd.ExecuteNonQuery();

            XtraMessageBox.Show("Talep Oluşturuldu");

            this.Close();
        }
    }
}
