using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using ScannerProject.Helper;

namespace ScannerProject
{
    public partial class ReturView : UserControl
    {
        DataTable tableDetail = new DataTable();
        DataTable tableSummary = new DataTable();
        DataTable tableDelivery = new DataTable();
        public ReturView()
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
            lueRetur.Enabled = false;
            sbProceed.Enabled = false;
            sbGenerate.Enabled = true;

            lciRetur.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            base.OnLoad(e);
        }

        void RefreshData()
        {
            var table = new DataTable();
            if (ceIsInvoice.Checked)
            {
                table = Utility.GetObjects("SELECT \"DocEntry\" AS \"DocumentID\", \"DocNum\" AS \"Display\", 'Invoice' AS \"Type\" FROM OINV WHERE \"ObjType\" = 13 AND \"DocStatus\" = 'O'");
            }
            else
            {
                table = Utility.GetObjects("SELECT \"DocEntry\" AS \"DocumentID\", \"DocNum\" AS \"Display\", 'Delivery' AS \"Type\" FROM ODLN WHERE \"ObjType\" = 15 AND \"DocStatus\" = 'O'");
            }
            //var table = Utility.GetObjects("SELECT ReturID, VoucherNo AS Display FROM Retur WHERE STATUS = 'Draft'", ScannerProject.Helper.DBConnection.conn);
            lueRetur.Properties.DataSource = table;
            lueRetur.Properties.DisplayMember = "Display";
            lueRetur.Properties.ValueMember = "DocumentID";

            lueRetur.EditValue = "";
            tableDelivery.Clear();
            tableSummary.Clear();
        }

        private void sbGenerate_Click(object sender, EventArgs e)
        {
            sbGenerate.Enabled = false;

            Utility.StartService();
            lueRetur.Enabled = true;
            sbProceed.Enabled = true;

            gcRawData.DataSource = Utility.GenerateData(tableDetail, "OUT");
            gcSummary.DataSource = Summarize();
        }   

        DataTable Summarize()
        {
            if (tableDetail == null || tableDetail.Rows.Count < 1) return null;
            var tableBarcode = Utility.GetObjects("SELECT \"U_Barcode\" AS \"Barcode\", \"U_ItemID\" AS \"ItemID\", B.\"ItemName\", \"U_ItemID\" AS \"ItemCode\" FROM \"@ITEMDETAIL\" A INNER JOIN OITM B ON A.\"U_ItemID\" = B.\"ItemCode\" WHERE A.\"U_IsDeleted\" = 0 AND \"U_Status\" LIKE '-1'");
            //var tableBarcode = Utility.GetObjects(
            //    @"SELECT Barcode, A.ItemID, B.ItemName, B.ItemCode FROM Barcode A INNER JOIN Item B ON A.ItemID = B.ItemID WHERE Status = 1", Helper.DBConnection.conn);

            if (tableDetail.Columns["ItemCode"] == null) tableDetail.Columns.Add("ItemCode", typeof(string));
            foreach (DataRow r in tableDetail.Rows)
            {
                var trim = r["RawData"].ToString();//I1404072118
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
            var table = new DataTable();
            if (ceIsInvoice.Checked)
            {
                table = Utility.GetObjects("SELECT \"DocEntry\" AS \"DocumentID\", 'Invoice' AS \"Type\", TO_VARCHAR (TO_DATE(\"DocDate\"), 'DD-MM-YYYY')\"TransDate\", \"DocNum\" AS \"VoucherNo\" FROM OINV WHERE \"ObjType\" = 13 AND \"DocStatus\" = 'O'");
            }
            else
            {
                table = Utility.GetObjects("SELECT \"DocEntry\" AS \"DocumentID\", 'Invoice' AS \"Type\", TO_VARCHAR (TO_DATE(\"DocDate\"), 'DD-MM-YYYY')\"TransDate\", \"DocNum\" AS \"VoucherNo\" FROM ODLN WHERE \"ObjType\" = 15 AND \"DocStatus\" = 'O'");
            }
            //var table = Utility.GetObjects("SELECT ReturID, TransDate, VoucherNo FROM Retur WHERE STATUS = 'Draft'", ScannerProject.Helper.DBConnection.conn);
            gcReturList.DataSource = table;

            return tableSummary;
        }

        private void lueRetur_EditValueChanged(object sender, EventArgs e)
        {
            if (lueRetur == null || string.IsNullOrEmpty(lueRetur.EditValue.ToString())) return;
            var obj = new DataTable();
            if (ceIsInvoice.Checked)
            {
                obj = Utility.GetObjects(string.Format("SELECT T0.\"CardCode\", T1.\"WhsCode\", T1.\"DocEntry\", T1.\"LineNum\", T1.\"ItemCode\" AS \"ItemID\", T1.\"U_idu_rollqty\" AS \"Qty\", T1.\"Dscription\" AS \"ItemName\", T1.\"ItemCode\" FROM OINV T0 INNER JOIN INV1 T1 ON T0.\"DocEntry\" = T1.\"DocEntry\" WHERE T1.\"DocEntry\" = '{0}'", lueRetur.EditValue));
            }
            else
            {
                obj = Utility.GetObjects(string.Format("SELECT T0.\"CardCode\", T1.\"WhsCode\", T1.\"DocEntry\", T1.\"LineNum\", T1.\"ItemCode\" AS \"ItemID\", T1.\"U_idu_rollqty\" AS \"Qty\", T1.\"Dscription\" AS \"ItemName\", T1.\"ItemCode\" FROM ODLN T0 INNER JOIN DLN1 T1 ON T0.\"DocEntry\" = T1.\"DocEntry\" WHERE T1.\"DocEntry\" = '{0}'", lueRetur.EditValue));
            }
            //var obj = Utility.GetObjects(string.Format(
            //    @"SELECT A.ReturID, A.ReturDetailID, A.ItemID, A.Qty, B.ItemName, B.ItemCode 
            //        FROM ReturDETAIL A INNER JOIN Item B ON A.ItemID = B.ItemID
            //        WHERE ReturID = '{0}'", lueRetur.EditValue), Helper.DBConnection.conn);
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

            gcRetur.DataSource = tableDelivery;
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
                if (Convert.ToDecimal(validate[0]["Qty"]) == 0)
                {
                    flag = 0;
                    break;
                }
                if (Convert.ToInt32(validate[0]["Qty"]) < 0)
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
            //Create Retur Berdiri Sendiri.

            Utility.insertRetur(tableDetail, tableDelivery);
            RefreshData();
            gcSummary.DataSource = Summarize();
            return;
            #region Not Use
            //var flag = 1;
            ////validate
            //foreach (DataRow r in tableDelivery.Rows)
            //{
            //    var validate = tableSummary.Select(string.Format("ItemID = '{0}'", r["ItemID"]));
            //    if (validate.Length < 1)
            //    {
            //        flag = 0;
            //        break;
            //    }

            //    //Qty Deliv Lebih Besar
            //    if(Convert.ToInt32(r["Qty"]) > Convert.ToInt32(validate[0]["Qty"]))
            //    {
            //        flag = 0;
            //        break;
            //    }

            //}

            //if (flag == 0)
            //{
            //    DevExpress.XtraEditors.XtraMessageBox.Show("INVALID QTY");
            //    return;
            //}

            //Utility.GetObjects(
            //    string.Format(
            //        @"UPDATE Retur SET STATUS = 'Submit' WHERE ReturID = '{0}'",lueRetur.EditValue),Helper.DBConnection.conn);

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
            #endregion
        }

        private void gvRetur_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            var row = gvRetur.GetDataRow(e.RowHandle);
            if (row == null) return;
            if (row["Qty"] != "")
            {
                if (Convert.ToDecimal(row["QtySystem"]) == 0 || Convert.ToDecimal(row["QtySystem"]) < 0)
                    e.Appearance.BackColor = Color.PaleVioletRed;
            }
            else
            {
                e.Appearance.BackColor = Color.PaleVioletRed;
            }
        }

        private void gvReturList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var row = gvReturList.GetFocusedDataRow();
            if (row == null) return;

            this.lueRetur.EditValue = row["DocumentID"];
        }

        private void ceIsInvoice_CheckedChanged(object sender, EventArgs e)
        {
            OnLoad(e);
        }

        private void gvRawData_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            var row = gvRawData.GetDataRow(e.RowHandle);
            if (row == null) return;

            var tableBarcode = Utility.GetObjects(string.Format("SELECT \"U_Barcode\" AS \"Barcode\" FROM \"@ITEMDETAIL\" WHERE \"U_IsDeleted\" = 0 AND \"U_Status\" LIKE '-1' AND \"U_Barcode\" LIKE '{0}'", row["RawData"]));
            if (tableBarcode.Rows.Count < 1)
                e.Appearance.BackColor = Color.Red;
        }
    }
}
