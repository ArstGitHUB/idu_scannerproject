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

namespace ScannerProject
{
    public partial class BarcodePrintList : RibbonForm
    {
        string Oid = "0";
        public BarcodePrintList()
        {
            this.InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //this.Text = "Mixtra Inti Tekindo";

            //load table print   
            //var obj = ScannerProject.Helper.Utility.hanaConnection("SELECT * FROM UAT_DB.\"@PRINTDOCUMENT\"");
            //gridControl1.DataSource = obj;
            refreshTable();
        }

        private void sbAddNew_Click(object sender, EventArgs e)
        {
            var frm = new BarcodePrintForm();
            frm.printDocumentID = Oid;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                refreshTable();
            else
                refreshTable();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var obj = gridView1.GetFocusedDataRow();
            if (obj == null) return;

            var frm = new BarcodePrintForm();
            frm.printDocumentID = obj["Code"].ToString();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                refreshTable();
            else
                refreshTable();
        }
        void refreshTable()
        {
            var obj = ScannerProject.Helper.Utility.hanaConnection(string.Format("SELECT \"Code\", \"PRINTNAME\" AS \"Name\", \"GROUP\" AS \"Group\" FROM {0}.\"@PRINTDOCUMENT\" WHERE \"U_IsDeleted\" = 0 ORDER BY \"Name\"", System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]));
            gridControl1.DataSource = obj;
        }

        private void repDelete_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null)
                return;
            var cmd = string.Format("UPDATE {1}.\"@PRINTDOCUMENT\" SET \"U_IsDeleted\" = 1 WHERE \"Code\" = '{0}'", row["Code"], System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]);
            ScannerProject.Helper.Utility.hanaConnection(cmd);
            refreshTable();
        }
    }
}
