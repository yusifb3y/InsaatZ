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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER ",bgl.baglanti());
            da.Fill(dt);
            gridview.DataSource = dt;
        
        
        }
        void Sehirlisteli()
        {
            SqlCommand command = new SqlCommand("Select SHEHER from TBL_SHEHERLER", bgl.baglanti());
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
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

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            Sehirlisteli();
            Rayon();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into TBL_MUSTERILER " +
                "(AD,SOYAD,TELEFON1,TELEFON2,SN,MAIL,SHEHER,RAYON,ADRESS,VERGIDAIRESI) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)"
                , bgl.baglanti()) ;
            command.Parameters.AddWithValue("@p1", TxtAd.Text);
            command.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            command.Parameters.AddWithValue("@p3", MskTf1.Text);
            command.Parameters.AddWithValue("@p4", MskTf2.Text);
            command.Parameters.AddWithValue("@p5", MskSv.Text);
            command.Parameters.AddWithValue("@p6", TxtMail.Text);
            command.Parameters.AddWithValue("@p7", comboBoxEdit1.Text);
            command.Parameters.AddWithValue("@p8", comboBoxEdit2.Text);
            command.Parameters.AddWithValue("@p9", TxtAdres.Text);
            command.Parameters.AddWithValue("@p10", TxtVergi.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müştəri sistemə əlavə edildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            



        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTf1.Text = dr["TELEFON1"].ToString();
                MskTf2.Text = dr["TELEFON2"].ToString();
                MskSv.Text = dr["SN"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                comboBoxEdit1.Text = dr["SHEHER"].ToString();
                comboBoxEdit2.Text = dr["RAYON"].ToString();
                TxtAdres.Text = dr["ADRESS"].ToString();
                TxtVergi.Text = dr["VERGIDAIRESI"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmək istədiynizdən əminsinizmi ?", "Müştərini sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                SqlCommand command = new SqlCommand("Delete from TBL_MUSTERILER where ID=@p1", bgl.baglanti());
                command.Parameters.AddWithValue("@p1", TxtId.Text);
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müştəri bazadan silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listele();
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTf1.Text = "";
            MskTf2.Text = "";
            MskSv.Text = "";
            TxtMail.Text = "";
            comboBoxEdit1.Text = "";
            comboBoxEdit2.Text = "";
            TxtAdres.Text = "";
            TxtVergi.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update TBL_MUSTERILER set " +
                "AD=@p1 , SOYAD=@p2,TELEFON1=@p3,TELEFON2=@p4,SN=@p5,MAIL=@p6,SHEHER=@p7,RAYON=@p8,ADRESS=@p9,VERGIDAIRESI=@p10 where ID=@p11",bgl.baglanti());

            command.Parameters.AddWithValue("@p1", TxtAd.Text);
            command.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            command.Parameters.AddWithValue("@p3", MskTf1.Text);
            command.Parameters.AddWithValue("@p4", MskTf2.Text);
            command.Parameters.AddWithValue("@p5", MskSv.Text);
            command.Parameters.AddWithValue("@p6", TxtMail.Text);
            command.Parameters.AddWithValue("@p7", comboBoxEdit1.Text);
            command.Parameters.AddWithValue("@p8", comboBoxEdit2.Text);
            command.Parameters.AddWithValue("@p9", TxtAdres.Text);
            command.Parameters.AddWithValue("@p10", TxtVergi.Text);
            command.Parameters.AddWithValue("@p11", TxtId.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müştəri məlumatları yeniləndi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridview_Click(object sender, EventArgs e)
        {

        }
    }
}
