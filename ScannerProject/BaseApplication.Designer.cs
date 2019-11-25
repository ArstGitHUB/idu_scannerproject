using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ScannerProject
{
    partial class BaseApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseApplication));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiUser = new DevExpress.XtraBars.BarStaticItem();
            this.bsiLicense = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLogin = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeliveryNote = new DevExpress.XtraBars.BarButtonItem();
            this.bbiManageBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrintBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.bbiItemTransfer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReturn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiKindOfLabel = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRePrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBarcodeHistory = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPaletBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.rbModule = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbScannerMenu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBarcodeMenu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pnlModule = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlModule)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bsiUser,
            this.bsiLicense,
            this.barButtonItem1,
            this.bbiLogin,
            this.bbiLogOut,
            this.bbiExit,
            this.bbiDeliveryNote,
            this.bbiManageBarcode,
            this.bbiPrintBarcode,
            this.bbiItemTransfer,
            this.bbiReturn,
            this.barButtonItem2,
            this.barButtonItem3,
            this.bbiKindOfLabel,
            this.bbiRePrint,
            this.bbiBarcodeHistory,
            this.bbiPaletBarcode,
            this.barStaticItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbModule});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(800, 179);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ItemLinks.Add(this.bbiLogin);
            this.ribbon.Toolbar.ItemLinks.Add(this.bbiLogOut);
            this.ribbon.Toolbar.ItemLinks.Add(this.bbiExit);
            // 
            // bsiUser
            // 
            this.bsiUser.Caption = "User Name";
            this.bsiUser.Id = 1;
            this.bsiUser.Name = "bsiUser";
            this.bsiUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiLicense
            // 
            this.bsiLicense.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiLicense.Caption = "Inti Data Utama";
            this.bsiLicense.Id = 2;
            this.bsiLicense.Name = "bsiLicense";
            this.bsiLicense.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbiLogin
            // 
            this.bbiLogin.Caption = "Login";
            this.bbiLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiLogin.Glyph")));
            this.bbiLogin.Id = 4;
            this.bbiLogin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiLogin.LargeGlyph")));
            this.bbiLogin.Name = "bbiLogin";
            this.bbiLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLogin_ItemClick);
            // 
            // bbiLogOut
            // 
            this.bbiLogOut.Caption = "Logout";
            this.bbiLogOut.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiLogOut.Glyph")));
            this.bbiLogOut.Id = 5;
            this.bbiLogOut.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiLogOut.LargeGlyph")));
            this.bbiLogOut.Name = "bbiLogOut";
            this.bbiLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLogOut_ItemClick);
            // 
            // bbiExit
            // 
            this.bbiExit.Caption = "Exit";
            this.bbiExit.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExit.Glyph")));
            this.bbiExit.Id = 6;
            this.bbiExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiExit.LargeGlyph")));
            this.bbiExit.Name = "bbiExit";
            this.bbiExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExit_ItemClick);
            // 
            // bbiDeliveryNote
            // 
            this.bbiDeliveryNote.Caption = "Delivery Note";
            this.bbiDeliveryNote.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiDeliveryNote.Glyph")));
            this.bbiDeliveryNote.Id = 7;
            this.bbiDeliveryNote.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiDeliveryNote.LargeGlyph")));
            this.bbiDeliveryNote.Name = "bbiDeliveryNote";
            this.bbiDeliveryNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeliveryNote_ItemClick);
            // 
            // bbiManageBarcode
            // 
            this.bbiManageBarcode.Caption = "Manage Barcode Design";
            this.bbiManageBarcode.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiManageBarcode.Glyph")));
            this.bbiManageBarcode.Id = 8;
            this.bbiManageBarcode.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiManageBarcode.LargeGlyph")));
            this.bbiManageBarcode.Name = "bbiManageBarcode";
            this.bbiManageBarcode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiManageBarcode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiManageBarcode_ItemClick);
            // 
            // bbiPrintBarcode
            // 
            this.bbiPrintBarcode.Caption = "Print Barcode";
            this.bbiPrintBarcode.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiPrintBarcode.Glyph")));
            this.bbiPrintBarcode.Id = 9;
            this.bbiPrintBarcode.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiPrintBarcode.LargeGlyph")));
            this.bbiPrintBarcode.Name = "bbiPrintBarcode";
            this.bbiPrintBarcode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintBarcode_ItemClick);
            // 
            // bbiItemTransfer
            // 
            this.bbiItemTransfer.Caption = "Item Transfer";
            this.bbiItemTransfer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiItemTransfer.Glyph")));
            this.bbiItemTransfer.Id = 10;
            this.bbiItemTransfer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiItemTransfer.LargeGlyph")));
            this.bbiItemTransfer.Name = "bbiItemTransfer";
            this.bbiItemTransfer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiItemTransfer_ItemClick);
            // 
            // bbiReturn
            // 
            this.bbiReturn.Caption = "Return Item";
            this.bbiReturn.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiReturn.Glyph")));
            this.bbiReturn.Id = 11;
            this.bbiReturn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiReturn.LargeGlyph")));
            this.bbiReturn.Name = "bbiReturn";
            this.bbiReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReturn_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "bbiConnectDatabase";
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 13;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // bbiKindOfLabel
            // 
            this.bbiKindOfLabel.Caption = "Kind Of Label";
            this.bbiKindOfLabel.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiKindOfLabel.Glyph")));
            this.bbiKindOfLabel.Id = 14;
            this.bbiKindOfLabel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiKindOfLabel.LargeGlyph")));
            this.bbiKindOfLabel.Name = "bbiKindOfLabel";
            this.bbiKindOfLabel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiKindOfLabel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiKindOfLabel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiKindOfLabel_ItemClick);
            // 
            // bbiRePrint
            // 
            this.bbiRePrint.Caption = "Re-Print";
            this.bbiRePrint.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiRePrint.Glyph")));
            this.bbiRePrint.Id = 15;
            this.bbiRePrint.Name = "bbiRePrint";
            this.bbiRePrint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiRePrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRePrint_ItemClick);
            // 
            // bbiBarcodeHistory
            // 
            this.bbiBarcodeHistory.Caption = "Barcode History";
            this.bbiBarcodeHistory.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiBarcodeHistory.Glyph")));
            this.bbiBarcodeHistory.Id = 16;
            this.bbiBarcodeHistory.Name = "bbiBarcodeHistory";
            this.bbiBarcodeHistory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiBarcodeHistory.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiBarcodeHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBarcodeHistory_ItemClick);
            // 
            // bbiPaletBarcode
            // 
            this.bbiPaletBarcode.Caption = "Palet Barcode";
            this.bbiPaletBarcode.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiPaletBarcode.Glyph")));
            this.bbiPaletBarcode.Id = 17;
            this.bbiPaletBarcode.Name = "bbiPaletBarcode";
            this.bbiPaletBarcode.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiPaletBarcode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPaletBarcode_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 18;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // rbModule
            // 
            this.rbModule.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbScannerMenu,
            this.rbBarcodeMenu});
            this.rbModule.Name = "rbModule";
            this.rbModule.Text = "Module";
            // 
            // rbScannerMenu
            // 
            this.rbScannerMenu.AllowMinimize = false;
            this.rbScannerMenu.AllowTextClipping = false;
            this.rbScannerMenu.ItemLinks.Add(this.bbiItemTransfer);
            this.rbScannerMenu.ItemLinks.Add(this.bbiDeliveryNote);
            this.rbScannerMenu.ItemLinks.Add(this.bbiReturn);
            this.rbScannerMenu.Name = "rbScannerMenu";
            this.rbScannerMenu.ShowCaptionButton = false;
            this.rbScannerMenu.Text = "Scanner Menu";
            // 
            // rbBarcodeMenu
            // 
            this.rbBarcodeMenu.ItemLinks.Add(this.bbiKindOfLabel);
            this.rbBarcodeMenu.ItemLinks.Add(this.bbiPrintBarcode);
            this.rbBarcodeMenu.ItemLinks.Add(this.bbiPaletBarcode);
            this.rbBarcodeMenu.ItemLinks.Add(this.bbiBarcodeHistory);
            this.rbBarcodeMenu.ItemLinks.Add(this.bbiRePrint);
            this.rbBarcodeMenu.ItemLinks.Add(this.bbiManageBarcode);
            this.rbBarcodeMenu.Name = "rbBarcodeMenu";
            this.rbBarcodeMenu.Text = "Barcode Menu";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiUser);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiLicense);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 496);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(800, 40);
            // 
            // pnlModule
            // 
            this.pnlModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModule.Location = new System.Drawing.Point(0, 179);
            this.pnlModule.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlModule.Name = "pnlModule";
            this.pnlModule.Size = new System.Drawing.Size(800, 317);
            this.pnlModule.TabIndex = 5;
            // 
            // BaseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.pnlModule);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "BaseApplication";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlModule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private IContainer components = (IContainer)null;
        protected BarStaticItem bsiLicense;
        protected RibbonPage rbModule;
        private BarButtonItem barButtonItem1;
        private BarButtonItem bbiLogin;
        private BarButtonItem bbiLogOut;
        private BarButtonItem bbiExit;
        private BarButtonItem bbiDeliveryNote;
        private BarButtonItem bbiManageBarcode;
        private BarButtonItem bbiPrintBarcode;
        private RibbonPageGroup rbScannerMenu;
        private RibbonPageGroup rbBarcodeMenu;
        private BarButtonItem bbiItemTransfer;
        private DevExpress.XtraEditors.PanelControl pnlModule;
        private BarButtonItem bbiReturn;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem3;
        private BarButtonItem bbiKindOfLabel;
        private BarButtonItem bbiRePrint;
        private BarButtonItem bbiBarcodeHistory;
        private BarButtonItem bbiPaletBarcode;
        private BarStaticItem barStaticItem1;
    }
}