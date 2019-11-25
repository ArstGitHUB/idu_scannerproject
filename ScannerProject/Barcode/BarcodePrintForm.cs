using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using ScannerProject.Helper;
using System.IO;

namespace ScannerProject
{
    public partial class BarcodePrintForm : RibbonForm
    {
        public string printDocumentID = "0";
        public BarcodePrintForm()
        {
            this.InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //this.Text = "Mixtra Inti Tekindo";

            this.teName.EditValue = "";
            this.meQuery.EditValue = "";

            if (printDocumentID != "0") 
            {
                //var data = Utility.GetObjects("PrintDocumentID, Name, SQLQuery", "PrintDocument", string.Format("PrintDocumentID = {0}", this.printDocumentID)
                //, "", "", "", DBConnection.conn);
                var data = Utility.hanaConnection(string.Format("SELECT \"Code\", \"PRINTNAME\" AS \"Name\", \"GROUP\" AS \"Group\", \"QUERY\" AS \"SqlQuery\" FROM {1}.\"@PRINTDOCUMENT\" WHERE \"Code\" LIKE '{0}'", this.printDocumentID, System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]));
                if (data == null) return;

                var row = data.Rows[0];

                this.printDocumentID = row["Code"].ToString();
                this.teName.EditValue = row["Name"];
                this.teGroup.EditValue = row["Group"];
                if (row["SqlQuery"] != DBNull.Value)
                    this.meQuery.EditValue = System.Text.Encoding.ASCII.GetString((byte[])row["SqlQuery"]);
                else
                    meQuery.EditValue = "";

                this.teName.Focus();
            }
        }
        private bool validateData()
        {
            if (teGroup.EditValue == null) teGroup.EditValue = "";
            if (teName.EditValue == null) teName.EditValue = "";
            if (teGroup.EditValue.ToString() == "")
            {
                MessageBox.Show("Group Harus di Isi !!");
                return false;
            }
            if (teName.EditValue.ToString() == "")
            {
                MessageBox.Show("Name Harus di Isi !!");
                return false;
            }
            return true;
        }        
        private void sbDesigner_Click(object sender, EventArgs e)
        {
            if (!validateData())
                return;
            //save
            if (XtraMessageBox.Show(FindForm(), "Do you want to save?", "Save Layout"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                printDocumentID = Model.PrintDocumentModel.InsertUpdatePrintDocument(teName.Text, teGroup.Text, meQuery.Text, printDocumentID);
            }

            var xRpt = new XtraReport();
            var obj = Utility.hanaConnection(string.Format("SELECT \"LAYOUT\" AS \"Layout\" FROM {1}.\"@PRINTDOCUMENT\" WHERE \"Code\" LIKE '{0}'", this.printDocumentID, System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]));
            //var obj = Utility.FindObject("Layout", "\"PrintDocument\"", string.Format("PrintDocumentID = {0}", this.printDocumentID), "", "", "", DBConnection.conn);
            if (obj != null && obj.Rows.Count != 0)
                if (obj.Rows[0]["Layout"] != DBNull.Value)
                    xRpt.LoadLayout(new MemoryStream((byte[])obj.Rows[0]["Layout"]));

            var frm = new DesignerForm();
            frm.LoadLayout(xRpt, printDocumentID);
            frm.ShowDialog(this);
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            if (!validateData())
                return;
            Model.PrintDocumentModel.InsertUpdatePrintDocument(teName.Text, teGroup.Text, meQuery.Text, printDocumentID);
            this.Dispose();
        }
    }
}
