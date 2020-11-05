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
    public partial class FrmMehsullar : Form
    {
        public FrmMehsullar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From TBL_Mehsul", bgl.baglanti());
            
            da.Fill(dt);
            Mehsullar.DataSource = dt;
        }
        private void FrmMehsullar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //yadda saxlama
         
            SqlCommand command = new SqlCommand("insert into TBL_MEHSUL" +
                "(MEHSULAD,MARKA,MODEL,ADET,ALISQIYMETI,SATISQIYMETI) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6)"

                ,bgl.baglanti());
            command.Parameters.AddWithValue("@p1", TxtAd.Text);
            command.Parameters.AddWithValue("@p3", TxtMarka.Text);
            command.Parameters.AddWithValue("@p2", TxtModel.Text);
            command.Parameters.AddWithValue("@p4", int.Parse((Num.Value).ToString()));
            command.Parameters.AddWithValue("@p5", decimal.Parse((TxtAlis.Text).ToString()));
            command.Parameters.AddWithValue("@p6", decimal.Parse((TxtSatis.Text).ToString()));
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Məhsul yadda saxlanıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmək istədiynizdən əminsinizmi ?", "Məhsulu sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                SqlCommand sil = new SqlCommand("Delete From TBL_MEHSUL where ID=@p1", bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", TxtID.Text);
                sil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Mehsul Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Listele();
            }
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dr["ID"].ToString();
            TxtAd.Text = dr["MEHSULAD"].ToString();
            TxtMarka.Text = dr["MODEL"].ToString();
            TxtModel.Text = dr["MARKA"].ToString();
            Num.Value =decimal.Parse(dr["ADET"].ToString());
            TxtSatis.Text = dr["SATISQIYMETI"].ToString();
            TxtAlis.Text = dr["ALISQIYMETI"].ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update TBL_MEHSUL set MEHSULAD=@p1,MODEL=@p2,MARKA=@p3,ADET=@p4,ALISQIYMETI=@p5,SATISQIYMETI=@p6 " +
                "where ID=@p9",bgl.baglanti());
            command.Parameters.AddWithValue("@p1", TxtAd.Text);
            command.Parameters.AddWithValue("@p3", TxtMarka.Text);
            command.Parameters.AddWithValue("@p2", TxtModel.Text);
            command.Parameters.AddWithValue("@p4", int.Parse((Num.Value).ToString()));
            command.Parameters.AddWithValue("@p5", decimal.Parse((TxtAlis.Text).ToString()));
            command.Parameters.AddWithValue("@p6", decimal.Parse((TxtSatis.Text).ToString()));
            command.Parameters.AddWithValue("@p9", TxtID.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Məhsul yeniləndi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void Mehsullar_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            TxtID.Text = "";
            TxtID.Enabled = false;
            TxtAd.Text = "";
            TxtAlis.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            TxtSatis.Text = "";
            Num.Value = 0;
        }

        private void Num_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
