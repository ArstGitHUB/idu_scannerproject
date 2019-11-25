using System;
using ScannerProject.Helper;

namespace ScannerProject
{
    public partial class KindOfLabelView : DevExpress.XtraEditors.XtraUserControl
    {
        public KindOfLabelView()
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
            var frm = new KindOfLabelForm();
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
            var frm = new KindOfLabelForm();
            frm.oid = row["Code"].ToString();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                refreshGrid();
            else
                refreshGrid();
        }
        void refreshGrid()
        {
            var obj = Utility.GetObjects("SELECT \"Code\", \"Name\", \"U_LabelName\" AS \"LabelName\" FROM \"@KINDOFLABEL\" WHERE \"U_IsDeleted\" = 0");
            gc.DataSource = obj;
        }

        private void repDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = gv.GetFocusedDataRow();
            if (row == null)
                return;
            var cmd = string.Format("UPDATE \"@KINDOFLABEL\" SET \"U_IsDeleted\" = 1 WHERE \"Code\" = '{0}'", row["Code"]);
            Utility.GetObjects(cmd);
            refreshGrid();
        }
    }
}
