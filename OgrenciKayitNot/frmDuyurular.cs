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
    public partial class frmDuyurular : Form
    {
        public frmDuyurular()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void frmDuyurular_Load(object sender, EventArgs e)
        {
            ListBox lst = new ListBox();
            Point lstkonum = new Point(10, 10);
            lst.Name = "Listbox1";
            lst.Height = 200;
            lst.Width = 150;
            lst.Location = lstkonum;
            this.Controls.Add(lst);
            SqlCommand komut = new SqlCommand("select * from TblDuyurular", bgl.bagglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lst.Items.Add(dr[0]+" "+dr[1]);
            }

            bgl.bagglanti().Close();
        }
    }
}
