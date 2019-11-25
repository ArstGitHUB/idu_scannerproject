using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using ScannerProject.Helper;
using Sap.Data.Hana;
using System.Configuration;

namespace ScannerProject
{
    public partial class DesignerForm : DevExpress.XtraEditors.XtraForm
    {
        string oid = "0";
        public DesignerForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public void LoadLayout(XtraReport xRpt, string oid)
        {
            this.oid = oid;
            if (xRpt == null) xRpt = new XtraReport();
            var table = this.GetReportData();
            if (table != null)
            {
                xRpt.DataSource = table;
                xRpt.DataMember = table.TableName;
            }
            this.reportDesigner1.OpenReport(xRpt);
        }

        private DataTable GetReportData()
        {
            DataGridView gr = new DataGridView();
            HanaConnection conn = new HanaConnection(string.Format("Server={0};UserID={1};Password={2}", ConfigurationManager.AppSettings["SAPServer"], ConfigurationManager.AppSettings["SAPUsername"], ConfigurationManager.AppSettings["SAPPassword"]));
            conn.Open();
            HanaCommand selectCmd = new HanaCommand(string.Format("SELECT \"QUERY\" AS \"SqlQuery\" FROM {1}.\"@PRINTDOCUMENT\" WHERE \"Code\" LIKE '{0}'", this.oid, ConfigurationManager.AppSettings["SAPDatabase"]), conn);
            HanaDataReader dr = selectCmd.ExecuteReader();
            gr.DataSource = dr;
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            conn.Close();
            if (dt == null || dt.Rows.Count == 0)
                return null;
            var cmdText = System.Text.ASCIIEncoding.ASCII.GetString((byte[])dt.Rows[0]["SqlQuery"]);
            if (string.IsNullOrEmpty(cmdText)) return null;
            return Utility.hanaConnection(cmdText);


            //var conn1 = DBConnection.conn;
            //try
            //{
            //    var obj = Utility.hanaConnection(string.Format("SELECT \"QUERY\" AS \"SqlQuery\" FROM \"@PRINTDOCUMENT\" WHERE \"Code\" LIKE '{0}'", this.oid));



            //    if (obj == null || obj.Rows.Count == 0) return null;

            //    var cmdText = System.Text.ASCIIEncoding.ASCII.GetString((byte[])obj.Rows[0]["SqlQuery"]);
            //    if (string.IsNullOrEmpty(cmdText)) return null;

            //    return
            //        Utility.GetObjects(cmdText, conn1);
            //}
            //catch (Exception)
            //{
            //    return null;
            //}
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //var conn = DBConnection.conn;
                //if (conn.State != ConnectionState.Open)
                //    conn.Open();

                var stream = new System.IO.MemoryStream();
                reportDesigner1.ActiveDesignPanel.Report.SaveLayout(stream);
                Model.PrintDocumentModel.SaveLayout(stream, oid);
                reportDesigner1.ActiveDesignPanel.ReportState = DevExpress.XtraReports.UserDesigner.ReportState.Saved;

                XtraMessageBox.Show(FindForm(), "Success Save Data", "Save Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(FindForm(), ex.ToString(), "Error Save Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "MIT Report (*.msrpt)|*.msrpt";
            if (sfd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sfd.FileName.Trim())) return;
                try
                {
                    if (!sfd.FileName.EndsWith(".msrpt")) sfd.FileName += ".msrpt";

                    reportDesigner1.ActiveDesignPanel.Report.SaveLayout(sfd.FileName);
                    XtraMessageBox.Show(FindForm(), "Success Save Data", "Save Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(FindForm(), ex.ToString(), "Error Save Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bbiImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";
            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(ofd.FileName.Trim())) return;
                try
                {
                    var xRpt = new XtraReport();
                    xRpt.LoadLayout(new System.IO.MemoryStream(System.IO.File.ReadAllBytes(ofd.FileName)));
                    this.reportDesigner1.OpenReport(xRpt);
                    XtraMessageBox.Show(FindForm(), "Success Save Data", "Save Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(FindForm(), ex.ToString(), "Error Save Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}