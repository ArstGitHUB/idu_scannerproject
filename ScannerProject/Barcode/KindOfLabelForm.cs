using DevExpress.XtraBars.Ribbon;
using ScannerProject.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerProject
{
    public partial class KindOfLabelForm : RibbonForm
    {
        public string oid = "";
        public KindOfLabelForm()
        {
            InitializeComponent();
            this.Width = 594;
            this.Height = 90;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //this.Text = "Mixtra Inti Tekindo";

            //initData();
            if (oid == "")
                newData();
            else
                loadData();

        }
        //void initData()
        //{

        //}
        void newData()
        {
            teLabelName.EditValue = "";
        }
        void loadData()
        {
            var obj = Utility.GetObjects(string.Format("SELECT * FROM \"@KINDOFLABEL\" WHERE \"Code\" = '{0}'", oid));
            if (obj == null)
                return;
            var row = obj.Rows[0];
            teLabelName.EditValue = row["U_LabelName"];
        }

        private void sbSave_Click(object sender, EventArgs e)
        {

            var cmd = "";
            if (oid == "")
            {
                var obj = Utility.GetObjects("SELECT TOP 1 \"Code\" FROM \"@KINDOFLABEL\" ORDER BY \"Code\" * 1 DESC");

                if (obj == null)
                    oid = "1";
                else
                {
                    if (obj.Rows.Count == 0)
                    {
                        oid = "1";
                    }
                    else
                    {
                        oid = (Convert.ToDecimal(obj.Rows[0]["Code"]) + 1).ToString();
                    }
                }
                cmd = string.Format("INSERT INTO \"@KINDOFLABEL\" (\"Code\", \"Name\", \"U_LabelName\", \"U_IsDeleted\") VALUES ('{0}', '{0}', '{1}', 0)", oid, teLabelName.EditValue);
            }
            else
            {
                cmd = string.Format("UPDATE \"@KINDOFLABEL\" SET \"U_LabelName\" = '{1}' WHERE \"Code\" = '{0}'", oid, teLabelName.EditValue);
            }

            Utility.GetObjects(cmd);
            this.Dispose();
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}