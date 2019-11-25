using DevExpress.XtraBars;
using System;
using System.Windows.Forms;

namespace ScannerProject
{
    public partial class BaseApplication : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected internal string license = "";
        protected BarStaticItem bsiUser;

        public BaseApplication()
        {
            this.InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
            //this.Text = "MIXTRA INTI TEKINDO";

            CheckPolicy();

            //this.bsiLicense.Caption = "MIXTRA INTI TEKINDO";
            this.bsiUser.Caption = string.Format("{0} - {1} - {2} - (2019-04-01-16)", CurrentUser.UserID, CurrentUser.Role, System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]);

        }

        void CheckPolicy(bool isLogout = false)
        {
            rbBarcodeMenu.Visible = true;
            rbScannerMenu.Visible = true;
            pnlModule.Controls.Clear();

            if (string.IsNullOrEmpty(CurrentUser.UserID) && !isLogout)
            {
                rbModule.Visible = false;
                var frm = new LoginForm();
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    rbModule.Visible = true;
                }
            }
            if (CurrentUser.UserID == "IT" || CurrentUser.UserID == "BOD" || CurrentUser.UserID == "Manager")
                bbiManageBarcode.Visibility = BarItemVisibility.Always;
            if (CurrentUser.UserID == "STFPRD1" || CurrentUser.UserID == "ASMPRO5" || CurrentUser.UserID == "ASMMKT3" || CurrentUser.UserID == "STFPRD2")
            {
                bbiItemTransfer.Visibility = BarItemVisibility.Never;
                bbiDeliveryNote.Visibility = BarItemVisibility.Never;
                bbiReturn.Visibility = BarItemVisibility.Never;
                bbiKindOfLabel.Visibility = BarItemVisibility.Never;
                bbiPrintBarcode.Visibility = BarItemVisibility.Never;
                bbiPaletBarcode.Visibility = BarItemVisibility.Never;
            }
            if (CurrentUser.UserID == "ASMPRO4" || CurrentUser.UserID == "ASMPRO2" || CurrentUser.UserID == "ASMPRO3")
            {
                bbiItemTransfer.Visibility = BarItemVisibility.Never;
                bbiDeliveryNote.Visibility = BarItemVisibility.Never;
                bbiReturn.Visibility = BarItemVisibility.Never;
                bbiKindOfLabel.Visibility = BarItemVisibility.Never;
                bbiPaletBarcode.Visibility = BarItemVisibility.Never;
            }
            if (!string.IsNullOrEmpty(CurrentUser.Role) && !CurrentUser.IsAdministrator)
            {
                switch (CurrentUser.Role)
                {
                    case "Scanner":
                        rbBarcodeMenu.Visible = false;
                        rbScannerMenu.Visible = true;
                        break;
                    case "Barcode":
                        rbBarcodeMenu.Visible = true;
                        rbScannerMenu.Visible = false;
                        break;
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            var result = MessageBox.Show("Do you want to close application?", "Exit Confirmation",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

        private void bbiLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            CurrentUser.Logout();
            CheckPolicy();
        }

        private void bbiLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            CurrentUser.Logout();
            rbModule.Visible = false;
            CheckPolicy(true);
        }

        private void bbiExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = MessageBox.Show("Do you want to close application?", "Exit Confirmation",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result != DialogResult.No) this.Dispose(); 
        }

        private void bbiDeliveryNote_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlModule.Controls.Clear();
            var myUC = new DeliveryOrderView();

            myUC.Dock = DockStyle.Fill;
            pnlModule.Controls.Add(myUC);
        }

        private void bbiManageBarcode_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new BarcodePrintList();
            frm.ShowDialog();
        }

        private void bbiPrintBarcode_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlModule.Controls.Clear();

            var myUC = new BarcodeView();

            myUC.Dock = DockStyle.Fill;
            pnlModule.Controls.Add(myUC);
        }

        private void bbiItemTransfer_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlModule.Controls.Clear();
            var myUC = new ItemTransferView();

            myUC.Dock = DockStyle.Fill;
            pnlModule.Controls.Add(myUC);
        }

        private void bbiReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlModule.Controls.Clear();
            var myUC = new ReturView();

            myUC.Dock = DockStyle.Fill;
            pnlModule.Controls.Add(myUC);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new ord.frmMain();
            frm.ShowDialog();
        }

        private void bbiKindOfLabel_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlModule.Controls.Clear();

            var myUC = new KindOfLabelView();

            myUC.Dock = DockStyle.Fill;
            pnlModule.Controls.Add(myUC);
        }

        private void bbiRePrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlModule.Controls.Clear();

            var myUC = new BarcodeView();
            myUC.isView = true;
            myUC.Dock = DockStyle.Fill;
            pnlModule.Controls.Add(myUC);
        }

        private void bbiBarcodeHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new BarcodeHistory();
            frm.ShowDialog();
        }

        private void bbiPaletBarcode_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlModule.Controls.Clear();

            var myUC = new BarcodePaletView();

            myUC.Dock = DockStyle.Fill;
            pnlModule.Controls.Add(myUC);
        }
    }
}