using DevExpress.XtraEditors;
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
    public partial class Form4_1_Kullanici_Duzenle : Form
    {
        public Form4_1_Kullanici_Duzenle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        private void Form4_1_Kullanici_Duzenle_Load(object sender, EventArgs e)
        {
            txt_ID.Text = Class_Kullanici_Duzenle.id;
            txt_Adi.Text = Class_Kullanici_Duzenle.adi;
            txt_Kullanici_adi.Text = Class_Kullanici_Duzenle.sistem_adi;

            SqlCommand cmd = new SqlCommand("Bolumleri_Listele", con.baglanti());

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxEdit1.Properties.ValueMember = "bolum_id";
            comboBoxEdit1.Properties.DisplayMember = "bolum_adi";
            comboBoxEdit1.Properties.DataSource = dt;
            comboBoxEdit1.Properties.PopupFormMinSize = new Size(50, 50);
            comboBoxEdit1.Properties.PopulateColumns();
            comboBoxEdit1.Properties.Columns["bolum_id"].Visible = false;

            string bolum_Adi = Class_Kullanici_Duzenle.bolum_adi;

            int bolum_adi_id = Convert.ToInt32(comboBoxEdit1.Properties.GetKeyValueByDisplayText(bolum_Adi));

            comboBoxEdit1.EditValue = bolum_adi_id;
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Kullanici_Guncelle", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@kullanici_id", txt_ID.Text);

            cmd.Parameters.AddWithValue("@kullanici_adi_soyadi", txt_Adi.Text);

            cmd.Parameters.AddWithValue("@kullanici_sistem_adi", txt_Kullanici_adi.Text);

            cmd.Parameters.AddWithValue("@kullanici_bolum_id", comboBoxEdit1.EditValue.ToString());

            cmd.ExecuteNonQuery();

            XtraMessageBox.Show("Güncellendi..");

            this.Close();
        }
    }
}
