namespace QUANLYNHANSU
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDanToc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonGiao = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrinhDo = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnHopDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhenThuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDieuChuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoiViec = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDanToc,
            this.btnTonGiao,
            this.btnTrinhDo,
            this.btnNhanVien,
            this.btnPhongBan,
            this.btnHopDong,
            this.btnKhenThuong,
            this.btnDieuChuyen,
            this.btnThoiViec});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(904, 193);
            // 
            // btnDanToc
            // 
            this.btnDanToc.Caption = "Dân tộc";
            this.btnDanToc.Id = 1;
            this.btnDanToc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanToc.ImageOptions.Image")));
            this.btnDanToc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDanToc.ImageOptions.LargeImage")));
            this.btnDanToc.Name = "btnDanToc";
            this.btnDanToc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Caption = "Tôn giáo";
            this.btnTonGiao.Id = 2;
            this.btnTonGiao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTonGiao.ImageOptions.Image")));
            this.btnTonGiao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTonGiao.ImageOptions.LargeImage")));
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Caption = "Trình độ";
            this.btnTrinhDo.Id = 3;
            this.btnTrinhDo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrinhDo.ImageOptions.Image")));
            this.btnTrinhDo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTrinhDo.ImageOptions.LargeImage")));
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 4;
            this.btnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.Image")));
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Caption = "Phòng ban";
            this.btnPhongBan.Id = 5;
            this.btnPhongBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhongBan.ImageOptions.SvgImage")));
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongBan_ItemClick);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Caption = "Hợp đồng";
            this.btnHopDong.Id = 6;
            this.btnHopDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHopDong.ImageOptions.SvgImage")));
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Caption = "Khen Thưởng - Kỷ Luật";
            this.btnKhenThuong.Id = 7;
            this.btnKhenThuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhenThuong.ImageOptions.SvgImage")));
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDieuChuyen
            // 
            this.btnDieuChuyen.Caption = "Điều chuyển";
            this.btnDieuChuyen.Id = 8;
            this.btnDieuChuyen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDieuChuyen.ImageOptions.SvgImage")));
            this.btnDieuChuyen.Name = "btnDieuChuyen";
            this.btnDieuChuyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDieuChuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDieuChuyen_ItemClick);
            // 
            // btnThoiViec
            // 
            this.btnThoiViec.Caption = "Thôi việc";
            this.btnThoiViec.Id = 9;
            this.btnThoiViec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoiViec.ImageOptions.SvgImage")));
            this.btnThoiViec.Name = "btnThoiViec";
            this.btnThoiViec.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThoiViec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoiViec_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanToc, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTonGiao, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTrinhDo, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhongBan, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanVien, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục dùng chung";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHopDong, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhenThuong, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDieuChuyen, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThoiViec, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Nghiệp vụ";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 499);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDanToc;
        private DevExpress.XtraBars.BarButtonItem btnTonGiao;
        private DevExpress.XtraBars.BarButtonItem btnTrinhDo;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnPhongBan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnHopDong;
        private DevExpress.XtraBars.BarButtonItem btnKhenThuong;
        private DevExpress.XtraBars.BarButtonItem btnDieuChuyen;
        private DevExpress.XtraBars.BarButtonItem btnThoiViec;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}

