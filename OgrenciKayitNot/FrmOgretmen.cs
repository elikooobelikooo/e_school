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

namespace OgrenciKayitNot
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public string Numara;
        SqlBaglanti bgl = new SqlBaglanti();
        void OgrenciListesi()
        {
            SqlCommand komur = new SqlCommand("select * from TblOgrenci" , bgl.bagglanti());
            SqlDataAdapter da = new SqlDataAdapter(komur);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void Notlistesi()
        {
            SqlCommand komut = new SqlCommand("Execute Ogrenciler" , bgl.bagglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }
        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            OgrenciListesi();
            Notlistesi();
            LblNumara.Text = Numara;

            SqlCommand komut = new SqlCommand("select * from TblOgretmen where Numara=@p1", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", Numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
            }
            bgl.bagglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblOgrenci (Ad, Soyad,Numara, Sifre, Fotograf) values (@p1, @p2,@p3,@p4,@p5)", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskNumara.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", fotograf);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ogrenci sisteme add olundu","bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.bagglanti().Close();
            OgrenciListesi();
            Notlistesi();
        }
        string fotograf;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fotograf = openFileDialog1.FileName;
            pctbxFoto.ImageLocation = fotograf;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            pctbxFoto.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            SqlCommand komut = new SqlCommand("select * from TblNotlar where OGID=(select ID from TblOgrenci where Numara=@p1)", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", MskNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtSinav1.Text = dr[1].ToString();
                txtSinav2.Text = dr[2].ToString();
                txtSinav3.Text = dr[3].ToString();
                txtProje.Text = dr[4].ToString();
                txtOrtalama.Text = dr[5].ToString();
                txtDurum.Text = dr[6].ToString();
            }
            bgl.bagglanti().Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update TblOgrenci set Ad=@p1, Soyad=@p2, Sifre=@p3, Fotograf=@p4 where Numara=@p5", bgl.bagglanti());
            komut1.Parameters.AddWithValue("@p1", txtAd.Text ?? (object)DBNull.Value);
            komut1.Parameters.AddWithValue("@p2", txtSoyad.Text ?? (object)DBNull.Value);
            komut1.Parameters.AddWithValue("@p3", txtSifre.Text ?? (object)DBNull.Value);
            komut1.Parameters.AddWithValue("@p4", pctbxFoto.ImageLocation);
            komut1.Parameters.AddWithValue("@p5", MskNumara.Text ?? (object)DBNull.Value);
            komut1.ExecuteNonQuery();
           // MessageBox.Show("Ogrenci bilgisi guncellendi", "bolgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.bagglanti().Close();
            SqlCommand komut2 = new SqlCommand("update TblNotlar set Sinav1=@p1, Sinav2=@p2, sinav3=@p3, Proje=@p4, Ortalama=@p5, Durum=@p6 where OGID=(select ID from TblOgrenci where Numara=@p7)", bgl.bagglanti());
            komut2.Parameters.AddWithValue("@p1", txtSinav1.Text);
            komut2.Parameters.AddWithValue("@p2", txtSinav2.Text);
            komut2.Parameters.AddWithValue("@p3", txtSinav3.Text);
            komut2.Parameters.AddWithValue("@p4", txtProje.Text);
            komut2.Parameters.AddWithValue("@p5", Convert.ToDecimal(txtOrtalama.Text));
            komut2.Parameters.AddWithValue("@p6", txtDurum.Text);
            komut2.Parameters.AddWithValue("@p7", MskNumara.Text);
            komut2.ExecuteNonQuery();
           // komut.ExecuteNonQuery();
            MessageBox.Show("Ogrenci bilgisi guncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.bagglanti().Close();
            OgrenciListesi();
            Notlistesi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, proje, ortalama;
            sinav1 = Convert.ToDouble(txtSinav1.Text);
            sinav2 = Convert.ToDouble(txtSinav2.Text);
            sinav3 = Convert.ToDouble(txtSinav3.Text);
            proje = Convert.ToDouble(txtProje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txtOrtalama.Text = ortalama.ToString();
            if (ortalama>=50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text = "False";
            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DuyuruFormu frm = new DuyuruFormu();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmDuyurular frm = new frmDuyurular();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.numara = LblNumara.Text;
            frm.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
