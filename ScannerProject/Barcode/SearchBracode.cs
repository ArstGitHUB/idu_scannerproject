using DevExpress.XtraBars.Ribbon;
using System;
using System.Windows.Forms;
using ScannerProject.Helper;

namespace ScannerProject
{
    public partial class SearchBarcode : RibbonForm
    {
        public string itemID = "";
        public SearchBarcode()
        {
            this.InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            teBarcode.EditValue = "";

            var table = Utility.hanaConnection(string.Format("SELECT \"Name\" FROM {0}.\"@PRINTDOCUMENT\" WHERE \"U_IsDeleted\" = 0", System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]));
            lueLabel.Properties.DataSource = table;
            lueLabel.Properties.DisplayMember = "Name";
            lueLabel.Properties.ValueMember = "Name";

            lueLabel.EditValue = "";
        }

        private void sbSelect_Click(object sender, EventArgs e)
        {
            var obj = Utility.GetObjects(string.Format("SELECT \"Code\", \"U_KindOfLabelID\" AS \"Label\", \"U_Barcode\" AS \"Barcode\" FROM \"@ITEMDETAIL\" WHERE \"U_IsDeleted\" = 0 AND \"U_Barcode\" LIKE '{0}'", teBarcode.EditValue));
            if (obj.Rows.Count > 0)
            {
                Utility.Print(lueLabel.EditValue.ToString() == "" ? obj.Rows[0]["Label"].ToString() : lueLabel.EditValue.ToString(), obj.Rows[0]["Code"].ToString());
                Dispose();
            }
            else
            {
                MessageBox.Show("Barcode Not Found !!");
            }
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void lueLabel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                var frm = new LabelList { labelID = lueLabel.EditValue.ToString() };
                frm.ShowDialog(this);
                lueLabel.EditValue = frm.labelID;
            }
            else if (e.Button.Index == 2)
            {
                lueLabel.EditValue = "";
            }
        }
    }
}
