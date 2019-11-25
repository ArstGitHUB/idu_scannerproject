using System;
using ScannerProject.Helper;
using System.Windows.Forms;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;

namespace ScannerProject
{
    public partial class BarcodeView : DevExpress.XtraEditors.XtraUserControl
    {
        public bool isView = false;
        public BarcodeView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (isView)
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciStartDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciEndDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciRefresh.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                try
                {
                    deStartDate.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 2);
                }
                catch (Exception)
                {
                    deStartDate.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                }
                deEndDate.EditValue = DateTime.Now;
                colAction.VisibleIndex = -1;
                if (CurrentUser.UserID.ToUpper() == "MANPRO2" || CurrentUser.UserID.ToUpper() == "MANPRO3" || CurrentUser.UserID.ToUpper() == "IT" || CurrentUser.UserID.ToUpper() == "BOD")
                {
                    colAction.VisibleIndex = 0;
                }
            }
            refreshGrid();
            base.OnLoad(e);
        }

        private void sbAddNew_Click(object sender, EventArgs e)
        {
            var frm = new BarcodeAddNewForm();
            frm.oid = "";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                refreshGrid();
            else
                refreshGrid();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            var row = gv.GetFocusedDataRow();
            if (row == null)
                return;
            var frm = new BarcodeAddNewForm();
            frm.isView = isView;
            frm.oid = row["Code"].ToString();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                refreshGrid();
            else
                refreshGrid();
        }
        void refreshGrid()
        {
            var type = "";
            if (CurrentUser.UserID.ToUpper() == "TERMINAL_1" || CurrentUser.UserID.ToUpper() == "MANPRO2" || CurrentUser.UserID.ToUpper() == "ASMPRO2" || CurrentUser.UserID.ToUpper() == "STFPRD1" || CurrentUser.UserID.ToUpper() == "STFPRD2")
            {
                type = @" AND ""U_MachineNo"" LIKE '9011'";
            }
            else if (CurrentUser.UserID.ToUpper() == "TERMINAL_2" || CurrentUser.UserID.ToUpper() == "ASMPRO3" || CurrentUser.UserID.ToUpper() == "STFPRD1" || CurrentUser.UserID.ToUpper() == "ASMMKT3")
            {
                type = @" AND ""U_MachineNo"" LIKE '9021'";
            }
            else if (CurrentUser.UserID.ToUpper() == "TERMINAL_3" || CurrentUser.UserID.ToUpper() == "ASMPRO4" || CurrentUser.UserID.ToUpper() == "STFPRD1" || CurrentUser.UserID.ToUpper() == "ASMPRO5")
            {
                type = @" AND ""U_MachineNo"" LIKE '9031'";
            }
            else if (CurrentUser.UserID.ToUpper() == "MANPRO3")
            {
                type = @" AND (""U_MachineNo"" LIKE '9031' OR ""U_MachineNo"" LIKE '9021')";
            }
            if (!isView)
            {
                type = type + @" AND A.""U_Status"" LIKE '0'";
            }
            else
            {
                type = type + string.Format(@"AND TO_DATE(CASE
            	            WHEN LEFT(""U_Barcode"", 1) LIKE 'G' THEN '2016'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'H' THEN '2017'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'I' THEN '2018'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'J' THEN '2019'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'K' THEN '2020'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'L' THEN '2021'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'M' THEN '2022'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'N' THEN '2023'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'O' THEN '2024'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'P' THEN '2025'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'Q' THEN '2026'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'R' THEN '2027'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'S' THEN '2028'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'T' THEN '2029'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'U' THEN '2030'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'V' THEN '2031'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'W' THEN '2032'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'X' THEN '2033'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'Y' THEN '2034'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'Z' THEN '2035'
                            WHEN LEFT(""U_Barcode"", 1) LIKE '1' THEN '2018'
                            ELSE '2018'
                          END ||
                          CASE
                            WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'A' THEN '10'
                            WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'B' THEN '11'
                            WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'C' THEN '12'
                            ELSE(0 || CASE WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE '0' THEN '6' ELSE SUBSTRING(""U_Barcode"", 3, 1) END)
                          END ||
                          CASE WHEN SUBSTRING(""U_Barcode"", 4, 2) > '31' THEN '01' ELSE SUBSTRING(""U_Barcode"", 4, 2) END) BETWEEN '{0:yyy-MM-dd 00:00:00}' AND '{1:yyy-MM-dd 23:59:59}'", deStartDate.EditValue, deEndDate.EditValue);
            }
            var obj = Utility.hanaConnection(string.Format(@"
                SELECT A.""Code"", B.""ItemName"", A.""U_KindOfLabelID"" AS ""KindOfLabel"", ""U_Barcode"" AS ""Barcode"", ""U_MachineDesc"" AS ""Machine""
                , ""U_SlittingOrder"" AS ""SlittingOrder"", A.""U_WHInDivision"" AS ""WHDivision"", A.""U_NWeight1"" AS ""NetWeight""
                , ""U_Remark1"" AS ""Remark"", ""U_CoreIdLength"" AS ""CoreID""
                , ""U_Location"" AS ""Location""
                , TO_DATE(CASE
            	            WHEN LEFT(""U_Barcode"", 1) LIKE 'G' THEN '2016'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'H' THEN '2017'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'I' THEN '2018'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'J' THEN '2019'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'K' THEN '2020'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'L' THEN '2021'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'M' THEN '2022'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'N' THEN '2023'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'O' THEN '2024'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'P' THEN '2025'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'Q' THEN '2026'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'R' THEN '2027'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'S' THEN '2028'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'T' THEN '2029'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'U' THEN '2030'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'V' THEN '2031'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'W' THEN '2032'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'X' THEN '2033'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'Y' THEN '2034'
                            WHEN LEFT(""U_Barcode"", 1) LIKE 'Z' THEN '2035'
                            WHEN LEFT(""U_Barcode"", 1) LIKE '1' THEN '2018'
                            ELSE '2018'
                          END ||
                          CASE
                            WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'A' THEN '10'
                            WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'B' THEN '11'
                            WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'C' THEN '12'
                            ELSE(0 || CASE WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE '0' THEN '6' ELSE SUBSTRING(""U_Barcode"", 3, 1) END)
                          END ||
                          CASE WHEN SUBSTRING(""U_Barcode"", 4, 2) > '31' THEN '01' ELSE SUBSTRING(""U_Barcode"", 4, 2) END) AS ""TransDate""
                FROM {0}.""@ITEMDETAIL"" A
                LEFT OUTER JOIN {0}.OITM B ON A.""U_ItemID"" = B.""ItemCode""
                WHERE A.""U_IsDeleted"" = 0 {1}", System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"], type));
            gc.DataSource = obj;
        }

        private void repDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = gv.GetFocusedDataRow();
            if (row == null)
                return;
            if (MessageBox.Show("Are you want to delete ?", "Notifikasi", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                var cmd = string.Format("UPDATE \"@ITEMDETAIL\" SET \"U_IsDeleted\" = 1 WHERE \"Code\" = '{0}'", row["Code"]);
                Utility.GetObjects(cmd);
                refreshGrid();
            }
        }

        private void sbExport_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Excel File (*.xlsx)|*.xlsx";
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                var printingSystem = new PrintingSystemBase();
                var compositeLink = new CompositeLinkBase();
                compositeLink.PrintingSystemBase = printingSystem;

                var link = new PrintableComponentLinkBase();
                link.Component = gc;
                compositeLink.Links.Add(link);

                var options = new XlsxExportOptions();
                options.ExportMode = XlsxExportMode.SingleFilePageByPage;

                compositeLink.CreatePageForEachLink();
                compositeLink.ExportToXlsx(sfd.FileName, options);

                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
