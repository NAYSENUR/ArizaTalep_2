using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
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
    public partial class Form1_KayitOl : Form
    {
        public Form1_KayitOl()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        bool yeni_kullanici = false;

        private void Form1_KayitOl_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Bolumleri_Listele", con.baglanti());

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxEdit2.Properties.ValueMember = "bolum_id";
            comboBoxEdit2.Properties.DisplayMember = "bolum_adi";
            comboBoxEdit2.Properties.DataSource = dt;
            //comboBoxEdit2.Text = "Seçiniz..";


            comboBoxEdit2.Properties.PopupFormMinSize = new Size(50, 50);

            comboBoxEdit2.Properties.PopulateColumns();
            comboBoxEdit2.Properties.Columns["bolum_id"].Visible = false;
        }

        private void btn_KAYDET_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (yeni_kullanici)
                {
                    SqlCommand cmd = new SqlCommand("Kullanici_KAYDET", con.baglanti());
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter id = new SqlParameter("@kullanici_id", SqlDbType.Int);
                    id.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(id);

                    cmd.Parameters.AddWithValue("@kullanici_adi_soyadi", txt_adi.Text);

                    cmd.Parameters.AddWithValue("@kullanici_sistem_adi", txt_kullanici_adi.Text);

                    cmd.Parameters.AddWithValue("@kullanici_sistem_sifre", txt_sifre.Text);

                    cmd.Parameters.AddWithValue("@kullanici_bolum_id", comboBoxEdit2.EditValue.ToString());

                    cmd.ExecuteNonQuery();

                    XtraMessageBox.Show(" Şimdi tanımladıgınız kullanici_adi ve şifre ile giriş yapabilirsiniz...");

                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Var olmayan bir kullanıcı adı giriniz..", "Bu kullanıcı Adından Var..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_kullanici_adi_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Kullanici_Varmi_Kontrol", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@kullanici_ad", txt_kullanici_adi.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            int id_bilgisi = Convert.ToInt32(dt.Rows[0]["var_mi"]);

            if (id_bilgisi.ToString() == "1")
            {
                labelControl9.Text = "Bu Kullanıcı Adından Var...";
                yeni_kullanici = false;
                dxErrorProvider1.SetError(txt_kullanici_adi, "Bu kullanıcı Adından Var..");
            }
            else
            {
                labelControl9.Text = "Bu Kullanıcı Adı Alınabilir..";
                yeni_kullanici = true;
                dxErrorProvider1.SetError(txt_kullanici_adi, "");
            }
        }

        private void txt_adi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_adi.Text))
            {
                e.Cancel = true;
                txt_adi.Focus();
                dxErrorProvider1.SetError(txt_adi, "Boş bırakılmamalıdır..");
            }
            else
            {
                e.Cancel = false;
                dxErrorProvider1.SetError(txt_adi, "");
            }
        }

        private void txt_sifre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_sifre.Text))
            {
                e.Cancel = true;
                txt_sifre.Focus();
                dxErrorProvider1.SetError(txt_sifre, "Boş bırakılmamalıdır..");
            }
            else
            {
                e.Cancel = false;
                dxErrorProvider1.SetError(txt_sifre, "");
            }
        }

        private void comboBoxEdit2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxEdit2.Text))
            {
                e.Cancel = true;
                comboBoxEdit2.Focus();
                dxErrorProvider1.SetError(comboBoxEdit2, "Seçim Yapınız..");
            }
            else
            {
                e.Cancel = false;
                dxErrorProvider1.SetError(comboBoxEdit2, "");
            }
        }

        private void txt_kullanici_adi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_kullanici_adi.Text))
            {
                e.Cancel = true;
                txt_kullanici_adi.Focus();
                dxErrorProvider1.SetError(txt_kullanici_adi, "Boş bırakılmamalıdır..");
            }
            else
            {
                e.Cancel = false;
                dxErrorProvider1.SetError(txt_kullanici_adi, "");
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                txt_sifre.Properties.UseSystemPasswordChar = false;
                checkEdit1.Text = "Gizle";
            }
            else
            {
                txt_sifre.Properties.UseSystemPasswordChar = true;
                checkEdit1.Text = "Göster";
            }
        }
    }
}
