using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using ScannerProject.Helper;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;

namespace ScannerProject
{
    public partial class DeliveryOrderView : UserControl
    {
        DataTable tableDetailAll = new DataTable();
        DataTable tableDetail = new DataTable();
        DataTable tableSummary = new DataTable();
        DataTable tableDelivery = new DataTable();
        public DeliveryOrderView()
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
            lueDeliveryOrder.Enabled = false;
            sbProceed.Enabled = false;
            lueJobNo.EditValue = "";

            lciDeliveryNote.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            base.OnLoad(e);
        }

        void RefreshData()
        {
            var table = Utility.GetObjects("SELECT \"draftKey\", \"DocEntry\" AS \"DeliveryOrderID\", \"DocNum\" AS \"Display\" FROM ODRF WHERE \"ObjType\" = 15 AND \"DocStatus\" = 'O'");
            //var table = Utility.GetObjects("SELECT DeliveryOrderID, VoucherNo AS Display FROM DELIVERYORDER WHERE STATUS = 'Draft'", ScannerProject.Helper.DBConnection.conn);
            lueDeliveryOrder.Properties.DataSource = table;
            lueDeliveryOrder.Properties.DisplayMember = "Display";
            lueDeliveryOrder.Properties.ValueMember = "DeliveryOrderID";
            
            lueDeliveryOrder.EditValue = "";
            tableDelivery.Clear();
            tableSummary.Clear();
        }

        private void sbGenerate_Click(object sender, EventArgs e)
        {
            sbGenerate.Enabled = false;

            Utility.StartService();
            lueDeliveryOrder.Enabled = true;
            sbProceed.Enabled = true;

            tableDetail = Utility.GenerateData(tableDetail, "OUT");
            gcRawData.DataSource = tableDetail;
            gcSummary.DataSource = Summarize();
            tableDetailAll = tableDetail.Copy();

            DataView view = new DataView((DataTable)gcRawData.DataSource);
            DataTable distinctValues = view.ToTable(true, "Job");
            lueJobNo.Properties.DataSource = distinctValues;
            lueJobNo.Properties.DisplayMember = "Job";
            lueJobNo.Properties.ValueMember = "Job";
            lueJobNo.EditValue = "";

            teRollNumber.EditValue = "";
            sbTambah.Enabled = true;
        }   

        DataTable Summarize()
        {
            tableSummary.Clear();
            if (tableDetail == null || tableDetail.Rows.Count < 1) return null;
            var tableBarcode = Utility.GetObjects("SELECT \"U_Barcode\" AS \"Barcode\", \"U_ItemID\" AS \"ItemID\", B.\"ItemName\", \"U_ItemID\" AS \"ItemCode\" FROM \"@ITEMDETAIL\" A INNER JOIN OITM B ON A.\"U_ItemID\" = B.\"ItemCode\" WHERE A.\"U_IsDeleted\" = 0 AND \"U_Status\" LIKE '1'");
            if (tableDetail.Columns["ItemCode"] == null) tableDetail.Columns.Add("ItemCode", typeof(string));
            foreach (DataRow r in tableDetail.Rows)
            {
                //var trim = r["RawData"].ToString().Substring(4);//I1404072118
                if (tableBarcode.Select(string.Format("Barcode = '{0}'", r["RawData"])).Length > 0)
                {
                    var selected = tableBarcode.Select(string.Format("Barcode = '{0}'", r["RawData"])).CopyToDataTable().Rows;

                    var row = tableSummary.Select(string.Format("ItemID = '{0}'", selected[0]["ItemID"]));
                    r["ItemCode"] = selected[0]["ItemID"];
                    if (selected[0]["ItemID"].ToString() == "NT03025092512000")
                    {
                    }
                    if (row.Length > 0)
                    {
                        row[0]["Qty"] = Convert.ToDecimal(row[0]["Qty"]) + 1;
                    }
                    else
                        tableSummary.Rows.Add(selected[0]["ItemID"], selected[0]["ItemCode"], selected[0]["ItemName"], 1);
                }
            }

            //table Delivery Order List
            var table = Utility.GetObjects(@"
                        SELECT T0.""draftKey"", T0.""DocEntry"" AS ""DeliveryOrderID"", TO_VARCHAR (TO_DATE(T0.""DocDate""), 'DD-MM-YYYY')""TransDate""
                        , T0.""JrnlMemo"" AS ""VoucherNo"", T2.""CardName"" AS ""BusinessPartner""
                        , CASE WHEN T0.""U_idu_prdtype"" = '210' THEN 'Polyester Film'
                                WHEN T0.""U_idu_prdtype"" = '211' THEN 'Nylon Film #1'
                                WHEN T0.""U_idu_prdtype"" = '212' THEN 'Nylon Film #2'
                                ELSE '' END AS ""Factory""
                        FROM ODRF T0 LEFT OUTER JOIN ODLN T1 ON T0.""DocEntry"" = T1.""draftKey""
                        LEFT OUTER JOIN OCRD T2 ON T0.""CardCode"" = T2.""CardCode""
                        WHERE T0.""ObjType"" = 15 AND T0.""DocStatus"" = 'O'");
            //var table = Utility.GetObjects("SELECT DeliveryOrderID, TransDate, VoucherNo FROM DELIVERYORDER WHERE STATUS = 'Draft'", ScannerProject.Helper.DBConnection.conn);
            gcDeliveryOrderList.DataSource = table;

            return tableSummary;
        }

        private void lueDeliveryOrder_EditValueChanged(object sender, EventArgs e)
        {
            if (lueDeliveryOrder == null || string.IsNullOrEmpty(lueDeliveryOrder.EditValue.ToString())) return;

            var obj = Utility.GetObjects(string.Format("SELECT \"DocEntry\", \"LineNum\", \"ItemCode\" AS \"ItemID\", \"U_idu_rollqty\" AS \"Qty\", \"Dscription\" AS \"ItemName\", \"ItemCode\" FROM DRF1 WHERE \"DocEntry\" = '{0}'", lueDeliveryOrder.EditValue));
            
            //var obj = Utility.GetObjects(string.Format(
            //    @"SELECT A.DeliveryOrderID, A.DeliveryOrderDetailID, A.ItemID, A.Qty, B.ItemName, B.ItemCode 
            //        FROM DELIVERYORDERDETAIL A INNER JOIN Item B ON A.ItemID = B.ItemID
            //        WHERE DELIVERYORDERID = '{0}'", lueDeliveryOrder.EditValue), Helper.DBConnection.conn);
            tableDelivery = obj;

            if (tableDelivery.Columns["QtySystem"] == null) tableDelivery.Columns.Add("QtySystem", typeof(int));
            foreach (DataRow r in tableDelivery.Rows)
            {
                var qtySystem = 0;
                if (tableSummary.Select(string.Format("ItemID = '{0}'", r["ItemID"])).Length > 0)
                {
                    var row = tableSummary.Select(string.Format("ItemID = '{0}'", r["ItemID"])).CopyToDataTable().Rows;
                    qtySystem = Convert.ToInt32(row[0]["Qty"]);
                }

                r["QtySystem"] = qtySystem;                
            }

            gcDeliveryOrder.DataSource = tableDelivery;
        }

        private void sbProceed_Click(object sender, EventArgs e)
        {
            var flag = 1;
            //validate
            foreach (DataRow r in tableDelivery.Rows)
            {
                var validate = tableSummary.Select(string.Format("ItemID = '{0}'", r["ItemID"]));
                if (validate.Length < 1)
                {
                    flag = 0;
                    break;
                }

                //Qty Deliv Lebih Besar
                if (r["Qty"] == "")
                {
                    flag = 0;
                    break;
                }
                if (Convert.ToDecimal(r["Qty"]) > Convert.ToInt32(validate[0]["Qty"]))
                {
                    flag = 0;
                    break;
                }
            }

            if (flag == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("INVALID QTY");
                return;
            }

            //create DO, masukkin ke SAP
            Utility.insertDeliveryOrder(tableDelivery, tableDetail);
            //foreach (DataRow r in tableDelivery.Rows)
            //{
            //    Utility.insertDeliveryOrder(tableDetail);
            //}
            RefreshData();
            gcSummary.DataSource = Summarize();
            return;

            //Utility.GetObjects(
            //    string.Format(
            //        @"UPDATE DELIVERYORDER SET STATUS = 'Submit' WHERE DELIVERYORDERID = '{0}'",lueDeliveryOrder.EditValue),Helper.DBConnection.conn);

            //foreach (DataRow r in tableDelivery.Rows)
            //{
            //    var loop = Convert.ToInt16(r["Qty"]);
            //    var itemid = r["ItemID"].ToString();
            //    for (int i = 0; i < loop; i++)
            //    {
            //        var barcode = Utility.FindObject("BarCode", "BarCode", string.Format("ItemID = '{0}' AND Status = 1", itemid), "", "", "", Helper.DBConnection.conn);
            //        Utility.GetObjects(
            //            string.Format(
            //                @"UPDATE BARCODE SET STATUS = 0 WHERE BARCODE = '{0}'", barcode), Helper.DBConnection.conn);
            //    }
            //}
            //RefreshData();
            //gcSummary.DataSource = Summarize();

            //DevExpress.XtraEditors.XtraMessageBox.Show("ChangeStatus");
        }

        private void gvDeliveryOrder_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            var row = gvDeliveryOrder.GetDataRow(e.RowHandle);
            if (row == null) return;
            if (row["Qty"] != "")
            {
                if (Convert.ToDecimal(row["Qty"]) > Convert.ToDecimal(row["QtySystem"]))
                    e.Appearance.BackColor = Color.PaleVioletRed;
            }
            else
            {
                e.Appearance.BackColor = Color.PaleVioletRed;
            }
        }

        private void gvDeliveryOrderList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var row = gvDeliveryOrderList.GetFocusedDataRow();
            if (row == null) return;

            this.lueDeliveryOrder.EditValue = row["DeliveryOrderID"];
        }

        private void gvRawData_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            var row = gvRawData.GetDataRow(e.RowHandle);
            if (row == null) return;

            var tableBarcode = Utility.GetObjects(string.Format("SELECT \"U_Barcode\" AS \"Barcode\" FROM \"@ITEMDETAIL\" WHERE \"U_IsDeleted\" = 0 AND \"U_Status\" LIKE '1' AND \"U_Barcode\" LIKE '{0}'", row["RawData"]));
            if (tableBarcode.Rows.Count < 1)
                e.Appearance.BackColor = Color.LightPink;
        }

        private void sbTambah_Click(object sender, EventArgs e)
        {
            if (teRollNumber.EditValue.ToString() == "")
                return;
            var status = Utility.GetObjects(string.Format(@"SELECT ""U_Status"" FROM ""@ITEMDETAIL"" WHERE ""U_Barcode"" LIKE '{0}' AND ""U_IsDeleted"" LIKE '0'", teRollNumber.EditValue));
            if (status.Rows.Count == 0)
            {
                MessageBox.Show("Roll Number : " + teRollNumber.EditValue.ToString() + " Belum di buat");
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

        private void lueJobNo_EditValueChanged(object sender, EventArgs e)
        {
            if (lueJobNo.EditValue.ToString() == "")
            {
                tableDetail = tableDetailAll.Copy();
                gcRawData.DataSource = tableDetail;
                gcSummary.DataSource = Summarize();
            }
            else
            {
                tableDetail = tableDetailAll.Select(string.Format("Job = '{0}'", lueJobNo.EditValue)).CopyToDataTable();
                gcRawData.DataSource = tableDetail;
                gcSummary.DataSource = Summarize();
            }
        }

        private void lueJobNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                lueJobNo.EditValue = "";
            }
        }

        private void repButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = gvRawData.GetFocusedDataRow();
            if (row == null) return;

            tableDetailAll.AcceptChanges();
            foreach (DataRow r in tableDetailAll.Rows)
            {
                if (r["RawData"].ToString() == row["RawData"].ToString())
                {
                    r.Delete();
                }
            }
            tableDetailAll.AcceptChanges();

            row.Delete();
            row.Table.AcceptChanges();

            gcSummary.DataSource = Summarize();
            
        }

        private void sbExcel_Click(object sender, EventArgs e)
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
    }
}
