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
    public partial class DuyuruFormu : Form
    {
        public DuyuruFormu()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void listele()
        {
            SqlCommand komut = new SqlCommand("select * from TblDuyurular", bgl.bagglanti()) ;
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void DuyuruFormu_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblDuyurular (ICERIK) values (@p1)", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru olusturuldu", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.bagglanti().Close();
            listele();
        }
        string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            this.Text = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TblDuyurular where ID=@p1", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            bgl.bagglanti().Close();
            listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblDuyurular set ICERIK=@p1 where ID=@p2", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", richTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", id);
            komut.ExecuteNonQuery();
            MessageBox.Show("duyuru guncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.bagglanti().Close();
            listele();
        }
    }
}
    