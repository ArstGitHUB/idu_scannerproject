
using DevExpress.XtraBars.Ribbon;
using System;
using ScannerProject.Helper;
using System.Data;

namespace ScannerProject
{
    public partial class BarcodeHistory : RibbonForm
    {
        public BarcodeHistory()
        {
            this.InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Rows.Add("0", "NEW");
            table.Rows.Add("1", "Warehouse IN");
            table.Rows.Add("-1", "Delivery Order");
            lueType.Properties.DataSource = table;
            lueType.Properties.DisplayMember = "Name";
            lueType.Properties.ValueMember = "ID";

            lueType.EditValue = "0";

        }
        void refresh()
        {
            //var table = Utility.GetObjects("SELECT \"ItemCode\", \"ItemName\", \"FrgnName\" FROM OITM WHERE \"U_idu_item_type\" = 3");
            var table = Utility.GetObjects(string.Format("SELECT \"U_ItemID\" AS \"ItemCode\", \"U_Barcode\" AS \"Barcode\" FROM \"@ITEMDETAIL\" WHERE \"U_IsDeleted\" = 0 AND \"U_Status\" LIKE '{0}'",lueType.EditValue));
            gc.DataSource = table;
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void sbSearch_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
