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

namespace InsaatZ
{
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *From TBL_FIRMALAR",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridview.DataSource = dt;
        }
        private void gridview_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void Sehirlisteli()
        {
            SqlCommand command = new SqlCommand("Select SHEHER from TBL_SHEHERLER", bgl.baglanti());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit1.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void Rayon()
        {
            SqlCommand command = new SqlCommand("Select RAYON from TBL_RAYONLAR", bgl.baglanti());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit2.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtMV.Text = "";
            MSAS.Text = "";
            MskSv.Text = "";
            TxtSektor.Text = "";
            MskTf1.Text = "";
            MskTf2.Text = "";
            MskTf3.Text = "";
            TxtMail.Text = "";
            MskTf4.Text = "";
            comboBoxEdit1.Text = "";
            comboBoxEdit2.Text = "";
            TxtVergi.Text = "";
            TxtAdres.Text = "";
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            listele();
            Sehirlisteli();
            Rayon();
            temizle();
        }
   

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSektor.Text = dr["SEKTOR"].ToString();
                MSAS.Text = dr["MEHSULDARADSOYAD"].ToString();
                TxtMV.Text = dr["MEHSULDARSTATUS"].ToString();
                MskSv.Text = dr["MEHSULDARSN"].ToString();
                MskTf1.Text = dr["TELEFON1"].ToString();
                MskTf2.Text = dr["TELEFON2"].ToString();
                MskTf3.Text = dr["TELEFON3"].ToString();
                MskTf4.Text = dr["FAX"].ToString();
            
                TxtMail.Text = dr["MAIL"].ToString();
                comboBoxEdit1.Text = dr["SHEHER"].ToString();
                comboBoxEdit2.Text = dr["RAYON"].ToString();
                TxtAdres.Text = dr["ADDRESS"].ToString();
                TxtVergi.Text = dr["VERGIDAIRE"].ToString();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TBL_FIRMALAR " +
                "(AD,MEHSULDARSTATUS,MEHSULDARADSOYAD,MEHSULDARSN,Sektor,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,SHEHER,RAYON,VERGIDAIRE,ADDRESS) " +
                "VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", TxtAd.Text);
            command.Parameters.AddWithValue("@p2", TxtMV.Text);
            command.Parameters.AddWithValue("@p3", MSAS.Text);
            command.Parameters.AddWithValue("@p4", MskSv.Text);
            command.Parameters.AddWithValue("@p5", TxtSektor.Text);
            command.Parameters.AddWithValue("@p6", MskTf1.Text);
            command.Parameters.AddWithValue("@p7", MskTf2.Text);
            command.Parameters.AddWithValue("@p8", MskTf3.Text);
            command.Parameters.AddWithValue("@p9", TxtMail.Text);
            command.Parameters.AddWithValue("@p10", MskTf4.Text);
            command.Parameters.AddWithValue("@p11", comboBoxEdit1.Text);
            command.Parameters.AddWithValue("@p12", comboBoxEdit2.Text);
            command.Parameters.AddWithValue("@p13", TxtVergi.Text);
            command.Parameters.AddWithValue("@p14", TxtAdres.Text);
          
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sistemdə yadda saxlanıldı ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmək istədiynizdən əminsinizmi ?", "Məhsulu sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                SqlCommand command = new SqlCommand("Delete from TBL_FIRMALAR where ID=@p1", bgl.baglanti());
                command.Parameters.AddWithValue("@p1", TxtId.Text);
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Firma Bazadan silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                temizle();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update TBL_FIRMALAR set AD=@p1,MEHSULDARSTATUS=@p2,MEHSULDARADSOYAD=@p3,MEHSULDARSN=@p4,Sektor=@p5," +
                "TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,SHEHER=@p11,RAYON=@p12,VERGIDAIRE=@p13,ADDRESS=@p14 where ID=@p15", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", TxtAd.Text);
            command.Parameters.AddWithValue("@p2", TxtMV.Text);
            command.Parameters.AddWithValue("@p3", MSAS.Text);
            command.Parameters.AddWithValue("@p4", MskSv.Text);
            command.Parameters.AddWithValue("@p5", TxtSektor.Text);
            command.Parameters.AddWithValue("@p6", MskTf1.Text);
            command.Parameters.AddWithValue("@p7", MskTf2.Text);
            command.Parameters.AddWithValue("@p8", MskTf3.Text);
            command.Parameters.AddWithValue("@p9", TxtMail.Text);
            command.Parameters.AddWithValue("@p10", MskTf4.Text);
            command.Parameters.AddWithValue("@p11", comboBoxEdit1.Text);
            command.Parameters.AddWithValue("@p12", comboBoxEdit2.Text);
            command.Parameters.AddWithValue("@p13", TxtVergi.Text);
            command.Parameters.AddWithValue("@p14", TxtAdres.Text);
            command.Parameters.AddWithValue("@p15", TxtId.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Məlumatları Yeniləndi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }
        /*
private void simpleButton2_Click(object sender, EventArgs e)
{
TxtId.Text = "";
TxtAd.Text = "";
TxtMV.Text = "";
MSAS.Text = "";
MskSv.Text = "";
TxtSektor.Text = "";
MskTf1.Text = "";
MskTf2.Text = "";
MskTf3.Text = "";
TxtMail.Text = "";
MskTf4.Text = "";
comboBoxEdit1.Text = "";
comboBoxEdit2.Text = "";
TxtVergi.Text = "";
TxtAdres.Text = "";
}
*/
    }
}
