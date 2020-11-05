namespace InsaatZ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.İnşaat = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnMehsul = new DevExpress.XtraBars.BarButtonItem();
            this.BtnStok = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMusteri = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnIsci = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnXercler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKassa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnQeyd = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAnaSehife = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBanklar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnTelefonlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFakturalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAyar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.İnşaat)).BeginInit();
            this.SuspendLayout();
            // 
            // İnşaat
            // 
            this.İnşaat.ExpandCollapseItem.Id = 0;
            this.İnşaat.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.İnşaat.ExpandCollapseItem,
            this.İnşaat.SearchEditItem,
            this.BtnMehsul,
            this.BtnStok,
            this.BtnMusteri,
            this.BtnFirmalar,
            this.BtnIsci,
            this.barButtonItem6,
            this.BtnXercler,
            this.BtnKassa,
            this.BtnQeyd,
            this.BtnAnaSehife,
            this.BtnBanklar,
            this.barButtonItem12,
            this.BtnTelefonlar,
            this.BtnFakturalar,
            this.BtnAyar});
            this.İnşaat.Location = new System.Drawing.Point(0, 0);
            this.İnşaat.Margin = new System.Windows.Forms.Padding(4);
            this.İnşaat.MaxItemId = 18;
            this.İnşaat.Name = "İnşaat";
            this.İnşaat.OptionsMenuMinWidth = 440;
            this.İnşaat.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.İnşaat.Size = new System.Drawing.Size(1445, 183);
            // 
            // BtnMehsul
            // 
            this.BtnMehsul.Caption = "Məhsullar";
            this.BtnMehsul.Id = 1;
            this.BtnMehsul.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMehsul.ImageOptions.Image")));
            this.BtnMehsul.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMehsul.ImageOptions.LargeImage")));
            this.BtnMehsul.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnMehsul.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnMehsul.Name = "BtnMehsul";
            this.BtnMehsul.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // BtnStok
            // 
            this.BtnStok.Caption = "Stoklar";
            this.BtnStok.Id = 3;
            this.BtnStok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnStok.ImageOptions.Image")));
            this.BtnStok.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnStok.ImageOptions.LargeImage")));
            this.BtnStok.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnStok.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnStok.Name = "BtnStok";
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.Caption = "Müştərilər";
            this.BtnMusteri.Id = 4;
            this.BtnMusteri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusteri.ImageOptions.Image")));
            this.BtnMusteri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMusteri.ImageOptions.LargeImage")));
            this.BtnMusteri.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnMusteri.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMusteri_ItemClick);
            // 
            // BtnFirmalar
            // 
            this.BtnFirmalar.Caption = "Firmalar";
            this.BtnFirmalar.Id = 5;
            this.BtnFirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFirmalar.ImageOptions.Image")));
            this.BtnFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFirmalar.ImageOptions.LargeImage")));
            this.BtnFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnFirmalar.Name = "BtnFirmalar";
            this.BtnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFirmalar_ItemClick);
            // 
            // BtnIsci
            // 
            this.BtnIsci.Caption = "İşçilər";
            this.BtnIsci.Id = 6;
            this.BtnIsci.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnIsci.ImageOptions.Image")));
            this.BtnIsci.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnIsci.ImageOptions.LargeImage")));
            this.BtnIsci.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnIsci.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnIsci.Name = "BtnIsci";
            this.BtnIsci.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnIsci_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // BtnXercler
            // 
            this.BtnXercler.Caption = "Xərclər";
            this.BtnXercler.Id = 8;
            this.BtnXercler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnXercler.ImageOptions.Image")));
            this.BtnXercler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnXercler.ImageOptions.LargeImage")));
            this.BtnXercler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnXercler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnXercler.Name = "BtnXercler";
            this.BtnXercler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnXercler_ItemClick);
            // 
            // BtnKassa
            // 
            this.BtnKassa.Caption = "Kassa";
            this.BtnKassa.Id = 9;
            this.BtnKassa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKassa.ImageOptions.Image")));
            this.BtnKassa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKassa.ImageOptions.LargeImage")));
            this.BtnKassa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnKassa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnKassa.Name = "BtnKassa";
            // 
            // BtnQeyd
            // 
            this.BtnQeyd.Caption = "Qeydlər";
            this.BtnQeyd.Id = 10;
            this.BtnQeyd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnQeyd.ImageOptions.Image")));
            this.BtnQeyd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnQeyd.ImageOptions.LargeImage")));
            this.BtnQeyd.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnQeyd.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnQeyd.Name = "BtnQeyd";
            // 
            // BtnAnaSehife
            // 
            this.BtnAnaSehife.Caption = "Ana Səhifə";
            this.BtnAnaSehife.Id = 11;
            this.BtnAnaSehife.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnaSehife.ImageOptions.Image")));
            this.BtnAnaSehife.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAnaSehife.ImageOptions.LargeImage")));
            this.BtnAnaSehife.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnAnaSehife.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAnaSehife.Name = "BtnAnaSehife";
            // 
            // BtnBanklar
            // 
            this.BtnBanklar.Caption = "Banklar";
            this.BtnBanklar.Id = 12;
            this.BtnBanklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBanklar.ImageOptions.Image")));
            this.BtnBanklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBanklar.ImageOptions.LargeImage")));
            this.BtnBanklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnBanklar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnBanklar.Name = "BtnBanklar";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Id = 13;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // BtnTelefonlar
            // 
            this.BtnTelefonlar.Caption = "Telefonlar";
            this.BtnTelefonlar.Id = 14;
            this.BtnTelefonlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTelefonlar.ImageOptions.Image")));
            this.BtnTelefonlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnTelefonlar.ImageOptions.LargeImage")));
            this.BtnTelefonlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnTelefonlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnTelefonlar.Name = "BtnTelefonlar";
            this.BtnTelefonlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnTelefonlar_ItemClick);
            // 
            // BtnFakturalar
            // 
            this.BtnFakturalar.Caption = "Fakturalar";
            this.BtnFakturalar.Id = 16;
            this.BtnFakturalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFakturalar.ImageOptions.Image")));
            this.BtnFakturalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFakturalar.ImageOptions.LargeImage")));
            this.BtnFakturalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Arial", 11F);
            this.BtnFakturalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnFakturalar.Name = "BtnFakturalar";
            // 
            // BtnAyar
            // 
            this.BtnAyar.Caption = "Parametrlər";
            this.BtnAyar.Id = 17;
            this.BtnAyar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyar.ImageOptions.Image")));
            this.BtnAyar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAyar.ImageOptions.LargeImage")));
            this.BtnAyar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnAyar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAyar.Name = "BtnAyar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "İnşaat";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAnaSehife);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMehsul);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnStok);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMusteri);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnIsci);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnXercler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnKassa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnQeyd);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnBanklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnTelefonlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFakturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAyar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 554);
            this.Controls.Add(this.İnşaat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.İnşaat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl İnşaat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnMehsul;
        private DevExpress.XtraBars.BarButtonItem BtnStok;
        private DevExpress.XtraBars.BarButtonItem BtnMusteri;
        private DevExpress.XtraBars.BarButtonItem BtnFirmalar;
        private DevExpress.XtraBars.BarButtonItem BtnIsci;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem BtnXercler;
        private DevExpress.XtraBars.BarButtonItem BtnKassa;
        private DevExpress.XtraBars.BarButtonItem BtnQeyd;
        private DevExpress.XtraBars.BarButtonItem BtnAnaSehife;
        private DevExpress.XtraBars.BarButtonItem BtnBanklar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem BtnTelefonlar;
        private DevExpress.XtraBars.BarButtonItem BtnFakturalar;
        private DevExpress.XtraBars.BarButtonItem BtnAyar;
    }
}

