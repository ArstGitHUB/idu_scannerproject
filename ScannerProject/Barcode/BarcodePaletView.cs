using System;
using ScannerProject.Helper;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;

namespace ScannerProject
{
    public partial class BarcodePaletView : DevExpress.XtraEditors.XtraUserControl
    {
        public BarcodePaletView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            refreshGrid();
            base.OnLoad(e);
        }

        private void sbAddNew_Click(object sender, EventArgs e)
        {
            var frm = new BarcodePaletNewForm();
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
            var frm = new BarcodePaletNewForm();
            frm.oid = row["Code"].ToString();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                refreshGrid();
            else
                refreshGrid();
        }
        void refreshGrid()
        {
            //var obj = Utility.GetObjects("SELECT A.*, B.ItemName FROM ItemDetail A INNER JOIN Item B ON A.ItemID = B.ItemID WHERE A.IsDeleted = 0", ScannerProject.Helper.DBConnection.conn);
            var obj = Utility.GetObjects("SELECT A.\"Code\", B.\"ItemName\", A.\"U_KindOfLabelID\" AS \"KindOfLabel\", \"U_PaletNumber\" AS \"Barcode\" FROM \"@PALET\" A LEFT OUTER JOIN OITM B ON A.\"U_ItemID\" = B.\"ItemCode\" WHERE A.\"U_IsDeleted\" = 0");
            gc.DataSource = obj;
        }

        private void repDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = gv.GetFocusedDataRow();
            if (row == null)
                return;
            var cmd = string.Format("UPDATE \"@PALET\" SET \"U_IsDeleted\" = 1 WHERE \"Code\" = '{0}'", row["Code"]);
            Utility.GetObjects(cmd);
            refreshGrid();
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
    }
}
