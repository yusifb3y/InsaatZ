using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsaatZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FrmMehsullar fr;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

                fr = new FrmMehsullar();
             //   fr.MdiParent = this;
                fr.Show();
            
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        FrmMusteriler fr2;
        private void BtnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr2==null)
            {
                fr2 = new FrmMusteriler();
               // fr2.MdiParent = this;
                fr2.Show();
            }
        }
        FrmFirmalar fr3;
        private void BtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new FrmFirmalar();
                fr3.Show();
            }        
        }
        FRM_ISCILER fr4;
        private void BtnIsci_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr4 = new FRM_ISCILER();
            fr4.Show();
        }
        FRM_Rehber fr5;
        private void BtnTelefonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr5 = new FRM_Rehber();
            fr5.Show();
        }
        FrmXercler fr6;
        private void BtnXercler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr6 = new FrmXercler();
            fr6.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
