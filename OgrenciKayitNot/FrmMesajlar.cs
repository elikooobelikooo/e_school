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
    public partial class FrmMesajlar : Form
    {
        public string numara;

        public FrmMesajlar()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void gelenmesajlar()
        {
            SqlCommand komut = new SqlCommand("select * from TblMesajlar where Alici=@p1", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void gedenmesajalar()
        {
            SqlCommand komut = new SqlCommand("select TblMesajlar.ID,  concat(TblOgrenci.Ad , ' ' ,TblOgrenci.Soyad) as AdSoyad, CONCAT(TblOgretmen.AD, ' ' ,TblOgretmen.SOYAD )  as SoyadAd, TblMesajlar.Basliq, TblMesajlar.Icerik from TblMesajlar inner join TblOgrenci on TblOgrenci.Numara = TblMesajlar.Alici inner join TblOgretmen on TblOgretmen.Numara = TblMesajlar.Gonderen where TblMesajlar.Gonderen=@p1", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            // textBox1.Text = "sdds";
            textBox1.Text = numara;
            gelenmesajlar();
            gedenmesajalar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblMesajlar (Gonderen, Alici, Basliq, Icerik) values (@p1, @p2,@p3,@p4)", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", txtAlici.Text);
            komut.Parameters.AddWithValue("@p3", txtKonu.Text);
            komut.Parameters.AddWithValue("@p4", rchtxtMesaj.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Mesaj basiryla iletildi...", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.bagglanti().Close();
            gelenmesajlar();
            gedenmesajalar();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



           
            /// sehv basladi
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string elmir = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ////var elmir= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            SqlCommand komut = new SqlCommand("select Ad, Soyad from TblOgrenci where Numara="+elmir+"", bgl.bagglanti());
         
            SqlDataReader da =komut.ExecuteReader();
            while (da.Read())
            {
                MessageBox.Show(da[0].ToString()+" "+da[1].ToString());
                // txtDurum.Text = dr[6].ToString();
            }

            bgl.bagglanti().Close();

            //// txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            string elmir = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            ////var elmir= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            SqlCommand komut = new SqlCommand("select Ad, Soyad from TblOgrenci where Numara=" + elmir + "", bgl.bagglanti());

            SqlDataReader da = komut.ExecuteReader();
            while (da.Read())
            {
                MessageBox.Show(da[0].ToString() + " " + da[1].ToString());
                // txtDurum.Text = dr[6].ToString();
            }

            bgl.bagglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SqlCommand komut = new SqlCommand("select * from TblMesajlar inner join TblOgrenci on TblOgrenci.Numara = TblMesajlar.Gonderen inner join TblOgretmen on TblOgretmen.Numara = TblMesajlar.Alici where TblMesajlar.ID=@p1", bgl.bagglanti());
              komut.Parameters.AddWithValue("@p1", dataGridView1.Rows[secilen].Cells[0].Value);
            SqlDataReader dr =  komut.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show( dr[12].ToString());
                textBox1.Text = dr[12].ToString();
                txtAlici.Text = dr[6].ToString();
                txtKonu.Text = dr[3].ToString();
                rchtxtMesaj.Text = dr[4].ToString();
            }
            bgl.bagglanti().Close();


        }
    }
}
