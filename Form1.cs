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
using System.IO;

namespace DersEtütü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı=new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=DersEtüt;Integrated Security=True");

        void temizle()
        {
            cmbDERS.Text = " ";
            cmbOGRETMEN.Text = " ";
            mskSAAT.Text = " ";
            mskTARİH.Text = " ";
        }

        void etütlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etut",baglantı);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        void derslistesi()
        {
            SqlDataAdapter da= new SqlDataAdapter("select * from TBLDERSLER",baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDERS.ValueMember = "DERSID";
            cmbDERS.DisplayMember = "DERSAD";
            cmbDERS.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etütlistesi();
        }

        private void cmbDERS_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TBLOGRETMENLER WHERE DERSID=" + cmbDERS.SelectedValue, baglantı);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            cmbOGRETMEN.ValueMember = "OGRTID";
            cmbOGRETMEN.DisplayMember = "AD";
            cmbOGRETMEN.DataSource = dt;
        }

        private void btnETÜTOLUŞTUR_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) VALUES (@P1,@P2,@P3,@P4)",baglantı);
            komut.Parameters.AddWithValue("@P1", cmbDERS.SelectedValue);
            komut.Parameters.AddWithValue("@P2", cmbOGRETMEN.SelectedValue);
            komut.Parameters.AddWithValue("@P3", mskTARİH.Text);
            komut.Parameters.AddWithValue("@P4", mskSAAT.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Etüt Başarıyla Oluşturuldu","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtDERSID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnETÜTVER_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update TBLETUT set OGRENCIID=@P1,DURUM=@P2 WHERE ID=@P3 ", baglantı);
            komut.Parameters.AddWithValue("@P1",txtÖGRENCİ.Text);
            komut.Parameters.AddWithValue("@P2", 1);
            komut.Parameters.AddWithValue("@P3",txtDERSID.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Öğrenciye Etüt Verildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFOTOGRAFEKLE_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation=openFileDialog1.FileName;
        }

        private void btnÖĞRENCİEKLE_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglantı);
            komut.Parameters.AddWithValue("@P1", txtÖĞRENCİAD.Text);
            komut.Parameters.AddWithValue("@P2", txtÖĞRENCİSOYAD.Text);
            komut.Parameters.AddWithValue("@P3",pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@P4", txtÖĞRENCİSINIF.Text);
            komut.Parameters.AddWithValue("@P5", mskTELEFON.Text);
            komut.Parameters.AddWithValue("@P6", txtMAİL.Text);
            komut.ExecuteNonQuery();
            baglantı.Close() ;
            MessageBox.Show("Öğrenci Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void btnDERSEKLE_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM TBLDERSLER WHERE DERSAD = @X1", baglantı);
            kontrolKomut.Parameters.AddWithValue("@X1", txtDERSEKLE.Text);
            int dersSayisi = (int)kontrolKomut.ExecuteScalar();
            baglantı.Close();

            if (dersSayisi > 0)
            {
                MessageBox.Show("Bu ders zaten veritabanında bulunuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO TBLDERSLER (DERSAD) VALUES (@X1)", baglantı);
                komut.Parameters.AddWithValue("@X1", txtDERSEKLE.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Ders Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }

        }

        private void btnÖĞRETMENEKLE_Click(object sender, EventArgs e)
        {
            baglantı.Open ();
            SqlCommand komut = new SqlCommand("insert into TBLOGRETMENLER (AD,SOYAD,DERSID) VALUES(@K1,@K2,@K3)", baglantı);
            komut.Parameters.AddWithValue("@K1",txtÖĞRETMENAD.Text);
            komut.Parameters.AddWithValue("@K2", txtÖĞRETMENSOYAD.Text);
            komut.Parameters.AddWithValue("@K3", cmbDERS.SelectedValue);
            komut .ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Öğretmen Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }
    }
}
