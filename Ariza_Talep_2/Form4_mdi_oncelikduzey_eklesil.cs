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
    public partial class Form4_mdi_oncelikduzey_eklesil : Form
    {
        public Form4_mdi_oncelikduzey_eklesil()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        void oncelik_duzey_listele()
        {
            SqlCommand cmd = new SqlCommand("Oncelikleri_Listele", con.baglanti());

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            gridView1.Columns[0].Visible = false;

            gridView1.Columns["oncelik_duzey_adi"].Caption = "Düzey Adı";
        }

        private void Form4_mdi_oncelikduzey_eklesil_Load(object sender, EventArgs e)
        {
            oncelik_duzey_listele();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Oncelik_Ekle", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@oncelik_duzey_adi", txt_oncelik_duzey_adi.Text);

            cmd.ExecuteNonQuery();

            oncelik_duzey_listele();
        }

        private void btn_oncelik_Sil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Devam Etmek İstediğinizde Seçili Olan Öncelik Düzeyi Silinecektir", "Devam Etmek İstiyor musunuz ?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Oncelik_Duzeyi_Sil", con.baglanti());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@oncelik_duzey_id", gridView1.GetFocusedRowCellValue("oncelik_duzey_id").ToString());

                cmd.ExecuteNonQuery();

                oncelik_duzey_listele();
            }
        }
    }
}
