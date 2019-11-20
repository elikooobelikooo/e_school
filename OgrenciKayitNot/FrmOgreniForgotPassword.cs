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
    public partial class FrmOgreniForgotPassword : Form
    {
        public FrmOgreniForgotPassword()
        {
            InitializeComponent();
        }
        public string numaraPassword;
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmOgreniForgotPassword_Load(object sender, EventArgs e)
        {
            this.Text = numaraPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblOgrenci set Sifre=@p1 where Numara=@p2", bgl.bagglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", this.Text);
            komut.ExecuteNonQuery();
            bgl.bagglanti().Close();
        }
    }
}
