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
    public partial class FrmOgrenci : Form
    {
        void notlistesi()
        {
            SqlCommand komut = new SqlCommand("Select * from TblNotlar where  OGID=(select ID from TblOgrenci where Numara=@p1)", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblSinav1.Text = dr[1].ToString();
                LblSinav2.Text = dr[2].ToString();
                LblSinav3.Text = dr[3].ToString();
                lblProje.Text = dr[4].ToString();
                lblortalama.Text = dr[5].ToString();
            }
            bgl.bagglanti().Close();
            if (Convert.ToDouble(lblortalama.Text)>=50)
            {
                lblDurum.Text = "Gecti";
            }
            else
            {
                lblDurum.Text = "Kesildi";
            }
        }
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        public string numara;
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;

            SqlCommand komut = new SqlCommand("Select * from TblOgrenci where Numara=@p1", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                pictureBox1.ImageLocation = dr[5].ToString();
            }
            bgl.bagglanti().Close();
            notlistesi();
        }

        private void LblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgreniForgotPassword frm = new FrmOgreniForgotPassword();
            frm.numaraPassword = LblNumara.Text;
            frm.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.numara = LblNumara.Text;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDuyurular frm = new frmDuyurular();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bak oglum cikmak istedigine eminmisin?", "Uyai!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
