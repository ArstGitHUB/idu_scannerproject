using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using ScannerProject.Helper;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;

namespace ScannerProject
{
    public partial class ItemTransferView : UserControl
    {
        DataTable tableDetail = new DataTable();
        DataTable tableSummary = new DataTable();
        DataTable tableDelivery = new DataTable();
        public ItemTransferView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (tableSummary.Columns["ItemID"] == null) tableSummary.Columns.Add("ItemID", typeof(string));
            if (tableSummary.Columns["ItemCode"] == null) tableSummary.Columns.Add("ItemCode", typeof(string));
            if (tableSummary.Columns["ItemName"] == null) tableSummary.Columns.Add("ItemName", typeof(string));
            if (tableSummary.Columns["Qty"] == null) tableSummary.Columns.Add("Qty", typeof(int));

            RefreshData();
            //lueItemTransfer.Enabled = false;
            sbProceed.Enabled = false;

            //lciItemTransfer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            base.OnLoad(e);
        }

        void RefreshData()
        {
            //var table = Utility.GetObjects("SELECT ItemTransferID, VoucherNo AS Display FROM ItemTransfer WHERE STATUS = 'Draft'", ScannerProject.Helper.DBConnection.conn);
            //lueItemTransfer.Properties.DataSource = table;
            //lueItemTransfer.Properties.DisplayMember = "Display";
            //lueItemTransfer.Properties.ValueMember = "ItemTransferID";

            //lueItemTransfer.EditValue = "";
            tableDelivery.Clear();
            tableSummary.Clear();
        }

        private void sbGenerate_Click(object sender, EventArgs e)
        {
            sbGenerate.Enabled = false;

            Utility.StartService();
            //lueItemTransfer.Enabled = true;
            sbProceed.Enabled = true;

            gcRawData.DataSource = Utility.GenerateData(tableDetail, "IN");
            gcSummary.DataSource = Summarize();

            teRollNumber.EditValue = "";
            sbAdd.Enabled = true;
        }   

        DataTable Summarize()
        {
            tableSummary.Clear();
            if (tableDetail == null || tableDetail.Rows.Count < 1) return null;
            var tableBarcode = Utility.GetObjects("SELECT \"U_Barcode\" AS \"Barcode\", \"U_ItemID\" AS \"ItemID\", B.\"ItemName\", \"U_ItemID\" AS \"ItemCode\" FROM \"@ITEMDETAIL\" A INNER JOIN OITM B ON A.\"U_ItemID\" = B.\"ItemCode\" WHERE A.\"U_IsDeleted\" = 0 AND \"U_Status\" LIKE '0'");
            //var tableBarcode = Utility.GetObjects(
            //    @"SELECT Barcode, A.ItemID, B.ItemName, B.ItemCode FROM Barcode A INNER JOIN Item B ON A.ItemID = B.ItemID WHERE Status = 1", Helper.DBConnection.conn);

            if (tableDetail.Columns["ItemCode"] == null) tableDetail.Columns.Add("ItemCode", typeof(string));
            foreach (DataRow r in tableDetail.Rows)
            {
                var trim = r["RawData"].ToString();//.Substring(2);//I1404072118
                if (tableBarcode.Select(string.Format("Barcode = '{0}'", trim)).Length > 0)
                {
                    var selected = tableBarcode.Select(string.Format("Barcode = '{0}'", trim)).CopyToDataTable().Rows;
                    r["ItemCode"] = selected[0]["ItemID"];
                    var row = tableSummary.Select(string.Format("ItemID = '{0}'", selected[0]["ItemID"]));
                    if (row.Length > 0)
                    {
                        row[0]["Qty"] = Convert.ToDecimal(row[0]["Qty"]) + 1;
                    }
                    else
                        tableSummary.Rows.Add(selected[0]["ItemID"], selected[0]["ItemCode"], selected[0]["ItemName"], 1);
                }
            }

            //table Delivery Order List
            //var table = Utility.GetObjects("SELECT ItemTransferID, TransDate, VoucherNo FROM ItemTransfer WHERE STATUS = 'Draft'", ScannerProject.Helper.DBConnection.conn);
            //gcItemTransferList.DataSource = table;

            return tableSummary;
        }

        //private void lueItemTransfer_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (lueItemTransfer == null || string.IsNullOrEmpty(lueItemTransfer.EditValue.ToString())) return;
        //    var obj = Utility.GetObjects(string.Format(
        //        @"SELECT A.ItemTransferID, A.ItemTransferDetailID, A.ItemID, A.Qty, B.ItemName, B.ItemCode 
        //            FROM ItemTransferDETAIL A INNER JOIN Item B ON A.ItemID = B.ItemID
        //            WHERE ItemTransferID = '{0}'", lueItemTransfer.EditValue), Helper.DBConnection.conn);
        //    tableDelivery = obj;

        //    if (tableDelivery.Columns["QtySystem"] == null) tableDelivery.Columns.Add("QtySystem", typeof(int));
        //    foreach (DataRow r in tableDelivery.Rows)
        //    {
        //        var qtySystem = 0;
        //        if (tableSummary.Select(string.Format("ItemID = '{0}'", r["ItemID"])).Length > 0)
        //        {
        //            var row = tableSummary.Select(string.Format("ItemID = '{0}'", r["ItemID"])).CopyToDataTable().Rows;
        //            qtySystem = Convert.ToInt32(row[0]["Qty"]);
        //        }

        //        r["QtySystem"] = qtySystem;                
        //    }

        //    gcItemTransfer.DataSource = tableDelivery;
        //}

        private void sbProceed_Click(object sender, EventArgs e)
        {
            // Initializing progress bar properties
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = tableDetail.Rows.Count;
            progressBarControl1.Properties.Minimum = 0;

            //Create Warehouse In dan Item Transfer
            var error = "";
            foreach (DataRow r in tableDetail.Rows)
            {
                var barcode = Utility.insertGoodsReceivedandItemTransfer(r["RawData"].ToString());
                error = error + barcode;
                progressBarControl1.PerformStep();
                progressBarControl1.Update();
            }

            if (error != "")
            {
                error = error.Substring(0, (error.Length) - 2);
                MessageBox.Show("Roll Number yang gagal : " + error);
            }
            RefreshData();
            gcSummary.DataSource = Summarize();
            return;
        }

        private void gvRawData_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var row = gvRawData.GetDataRow(e.RowHandle);
            if (row == null) return;

            var tableBarcode = Utility.GetObjects(string.Format("SELECT \"U_Barcode\" AS \"Barcode\" FROM \"@ITEMDETAIL\" WHERE \"U_IsDeleted\" = 0 AND \"U_Status\" LIKE '0' AND \"U_Barcode\" LIKE '{0}'", row["RawData"]));
            if (tableBarcode.Rows.Count < 1)
            {
                e.Appearance.BackColor = Color.LightPink;
                tableBarcode = Utility.GetObjects(string.Format("SELECT \"U_Status\" AS \"Status\" FROM \"@ITEMDETAIL\" WHERE \"U_IsDeleted\" = 0 AND \"U_Barcode\" LIKE '{0}'", row["RawData"]));
                if (tableBarcode.Rows.Count > 0)
                {
                    var row1 = tableBarcode.Rows[0];
                    if (row1["Status"].ToString() == "1")
                    {
                        e.Appearance.BackColor = Color.LightBlue;
                    }

                }
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
                link.Component = gcRawData;
                compositeLink.Links.Add(link);

                link = new PrintableComponentLinkBase();
                link.Component = gcSummary;
                compositeLink.Links.Add(link);

                var options = new XlsxExportOptions();
                options.ExportMode = XlsxExportMode.SingleFilePageByPage;

                compositeLink.CreatePageForEachLink();
                compositeLink.ExportToXlsx(sfd.FileName, options);

                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void sbProcess_Click(object sender, EventArgs e)
        {
            if (teRollNumber.EditValue.ToString() == "")
                return;
            var status = Utility.GetObjects(string.Format(@"SELECT ""U_Status"" FROM ""@ITEMDETAIL"" WHERE ""U_Barcode"" LIKE '{0}' AND ""U_IsDeleted"" LIKE '0'", teRollNumber.EditValue));
            if (status.Rows.Count == 0)
            {
                MessageBox.Show("Roll Number : "+ teRollNumber.EditValue.ToString()+ " Belum di buat");
                teRollNumber.EditValue = "";
                return;
            }
            var obj = tableDetail.Select(string.Format("RawData = '{0}'", teRollNumber.EditValue));
            if (obj.Length > 0)
            {
                MessageBox.Show("Roll Number : " + teRollNumber.EditValue.ToString() + " sudah ada di dalam list");
                teRollNumber.EditValue = "";
                return;
            }
            tableDetail.Rows.Add("MANUAL", "MANUAL", teRollNumber.EditValue.ToString());
            gcSummary.DataSource = Summarize();
            teRollNumber.EditValue = "";
        }

        //private void gvItemTransfer_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        //{
        //    var row = gvItemTransfer.GetDataRow(e.RowHandle);
        //    if (row == null) return;
        //    if (Convert.ToInt32(row["Qty"]) > Convert.ToInt32(row["QtySystem"]))
        //        e.Appearance.BackColor = Color.PaleVioletRed;
        //}

        //private void gvItemTransferList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    var row = gvItemTransferList.GetFocusedDataRow();
        //    if (row == null) return;

        //    this.lueItemTransfer.EditValue = row["ItemTransferID"];
        //}
    }
}
