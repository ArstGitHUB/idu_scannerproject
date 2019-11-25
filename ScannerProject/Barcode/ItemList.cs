using DevExpress.Utils;

using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraLayout;
using DevExpress.XtraTab;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;
using System.IO;
using ScannerProject.Helper;

namespace ScannerProject
{
    public partial class ItemList : RibbonForm
    {
        public string itemID = "";
        public ItemList()
        {
            this.InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var table = Utility.GetObjects("SELECT \"ItemCode\", \"ItemName\", \"FrgnName\" FROM OITM WHERE \"U_idu_item_type\" = 3");
            gc.DataSource = table;
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            var row = gv.GetFocusedDataRow();
            if (row == null)
                return;
            itemID = row["ItemCode"].ToString();
            this.Dispose();
        }

        private void sbSelect_Click(object sender, EventArgs e)
        {
            gv_DoubleClick(sender, e);
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
