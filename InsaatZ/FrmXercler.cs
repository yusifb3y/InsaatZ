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
    public partial class FrmXercler : Form
    {
        public FrmXercler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From TBL_GIDERLER",bgl.baglanti());
            da.Fill(dt);
            gridview.DataSource = dt;
            

        }
        void temizle()
        {
            TxtId.Text = "";
            comboBox1.Text = "";
            TxtIl.Text = "";
            TxtElek.Text = "";
            TxtSu.Text = "";
            TxtQaz.Text = "";
            TxtInter.Text = "";
            TxtMaas.Text = "";
            TxtExtra.Text = "";
            richTextBox1.Text = "";

        }
        private void FrmXercler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("Insert into TBL_GIDERLER " +
                "(AY,IL,ELEKTRIK,SU,QAZ,INTERNET,MAASLAR,EKSTRA,QEYDLER) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)"
                , bgl.baglanti());
            command.Parameters.AddWithValue("@p1", comboBox1.Text);
            command.Parameters.AddWithValue("@p2", TxtIl.Text);
            command.Parameters.AddWithValue("@p3",decimal.Parse(TxtElek.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(TxtSu.Text));
            command.Parameters.AddWithValue("@p5", decimal.Parse(TxtQaz.Text));
            command.Parameters.AddWithValue("@p6",decimal.Parse(TxtInter.Text));
            command.Parameters.AddWithValue("@p7",decimal.Parse(TxtMaas.Text));
            command.Parameters.AddWithValue("@p8",decimal.Parse(TxtExtra.Text));
            command.Parameters.AddWithValue("@p9",richTextBox1.Text);
            command.ExecuteNonQuery();
            temizle();
            bgl.baglanti().Close();
            MessageBox.Show("Xərc sistemə əlavə edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                comboBox1.Text = dr["AY"].ToString();
                TxtIl.Text = dr["IL"].ToString();
                TxtElek.Text = dr["ELEKTRIK"].ToString();
                TxtSu.Text = dr["SU"].ToString();
                TxtQaz.Text = dr["QAZ"].ToString();
                TxtInter.Text = dr["INTERNET"].ToString();
                TxtMaas.Text = dr["MAASLAR"].ToString();
                TxtExtra.Text = dr["EKSTRA"].ToString();
                richTextBox1.Text = dr["QEYDLER"].ToString();
            }
        }

        private void gridview_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmək istədiynizdən əminsinizmi ?", "Xerci sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                SqlCommand command = new SqlCommand("Delete from TBL_GIDERLER where ID=@p1", bgl.baglanti());
                command.Parameters.AddWithValue("@p1", TxtId.Text);
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Xerc bazadan silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listele();
                temizle();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update TBL_GIDERLER set " +
                "AY=@p1 , IL=@p2,ELEKTRIK=@p3,SU=@p4,QAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,QEYDLER=@p9  where ID=@p10", bgl.baglanti());

            command.Parameters.AddWithValue("@p1", comboBox1.Text);
            command.Parameters.AddWithValue("@p2", TxtIl.Text);
            command.Parameters.AddWithValue("@p3", TxtElek.Text);
            command.Parameters.AddWithValue("@p4", TxtSu.Text);
            command.Parameters.AddWithValue("@p5", TxtQaz.Text);
            command.Parameters.AddWithValue("@p6", TxtInter.Text);
            command.Parameters.AddWithValue("@p7", TxtMaas.Text);
            command.Parameters.AddWithValue("@p8", TxtExtra.Text);
            command.Parameters.AddWithValue("@p9", richTextBox1.Text);
            command.Parameters.AddWithValue("@p10", TxtId.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müştəri məlumatları yeniləndi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                comboBox1.Text = dr["AY"].ToString();
                TxtIl.Text = dr["IL"].ToString();
                TxtElek.Text = dr["ELEKTRIK"].ToString();
                TxtSu.Text = dr["SU"].ToString();
                TxtQaz.Text = dr["QAZ"].ToString();
                TxtInter.Text = dr["INTERNET"].ToString();
                TxtMaas.Text = dr["MAASLAR"].ToString();
                TxtExtra.Text = dr["EKSTRA"].ToString();
                richTextBox1.Text = dr["QEYDLER"].ToString();
            }
        }
    }
}
