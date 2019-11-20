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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnOgretmenGiris_Click(object sender, EventArgs e)
        {
            if (MSKOgretmenNumara.Text=="" || TxtxOgretmenSifre.Text=="")
            {
                MessageBox.Show("Lutefn bos gecmeyin", "uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from TblOgretmen where Numara=@p1 and sifre=@p2", bgl.bagglanti());
                komut.Parameters.AddWithValue("@p1", MSKOgretmenNumara.Text);
                komut.Parameters.AddWithValue("@p2", TxtxOgretmenSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    FrmOgretmen frm = new FrmOgretmen();
                    frm.Numara = MSKOgretmenNumara.Text;
                    frm.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatali numara ve ya sifre girdiniz", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
           
            bgl.bagglanti().Close();
        }

        private void BtnOgrenciGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TblOgrenci where Numara=@p1 and Sifre=@p2",bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1",MSKOgrenciNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgrenciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgrenci frm = new FrmOgrenci();
                frm.numara = MSKOgrenciNumara.Text;
                frm.Show();
               
                MessageBox.Show("Sisteme hos geldiniz", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali numara ve ya sifre girdiniz", "uyari", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.bagglanti().Close();
        }
    }
}
