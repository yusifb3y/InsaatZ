using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsaatZ
{
    public partial class FRM_Rehber : Form
    {
        public FRM_Rehber()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FRM_Rehber_Load(object sender, EventArgs e)
        {
            //musteriler
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD,SOYAD,TELEFON1,TELEFON2,MAIL from TBL_MUSTERILER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource=dt;
            //firma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2= new SqlDataAdapter("Select AD,MEHSULDARADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX from TBL_FIRMALAR", bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
