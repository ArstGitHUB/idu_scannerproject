using DevExpress.XtraBars.Ribbon;
using System;
using ScannerProject.Helper;
using System.Data;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing;

namespace ScannerProject
{
    public partial class BarcodePaletNewForm : RibbonForm
    {
        public int printDocumentID = 0;
        public string oid = "";
        string barcode = "";
        //string status = "0";
        DataTable table2;
        public BarcodePaletNewForm()
        {
            this.InitializeComponent();
            this.Width = 1193;
            this.Height = 497;
            this.MaximizeBox = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            initData();
            if (oid == "")
                newData();
            else
                loadData();

        }
        void initData()
        {

            if (this.oid == "")
            {
                lciNewPalet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                //lciPrint.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

            lciKindOfLabel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            var table = Utility.GetObjects("SELECT \"ItemCode\", \"ItemName\" AS \"Display\", \"FrgnName\" AS \"ForeignName\" FROM OITM A WHERE \"U_idu_item_type\" = 3");
            lueItem.Properties.DataSource = table;
            lueItem.Properties.DisplayMember = "Display";
            lueItem.Properties.ValueMember = "ItemCode";
            
            table = new DataTable();
            table = Utility.hanaConnection(string.Format("SELECT \"Name\" FROM {0}.\"@PRINTDOCUMENT\" WHERE \"U_IsDeleted\" = 0", System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]));
            lueKindOfLabel.Properties.DataSource = table;
            lueKindOfLabel.Properties.DisplayMember = "Name";
            lueKindOfLabel.Properties.ValueMember = "Name";

            table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Rows.Add("POLYESTER");
            table.Rows.Add("NYLON FILM #1");
            table.Rows.Add("NYLON FILM #2");
            lueFactory.Properties.DataSource = table;
            lueFactory.Properties.DisplayMember = "Name";
            lueFactory.Properties.ValueMember = "Name";

            table2 = new DataTable();
            if (table2.Columns["Code"] == null) table2.Columns.Add("Code", typeof(string));
            if (table2.Columns["RollNumber"] == null) table2.Columns.Add("RollNumber", typeof(string));
            if (table2.Columns["NetWeight"] == null) table2.Columns.Add("NetWeight", typeof(string));
        }
        void newData()
        {
            lueFactory.EditValue = "NYLON FILM #1";
            lueItem.EditValue = "";
            lueKindOfLabel.EditValue = "TPL PALET";
            teType.EditValue = "";
            teThick.EditValue = "";
            teWidth1.EditValue = "";
            teLength1.EditValue = "";
            teCoreID.EditValue = "";
            tePONumber.EditValue = "";
            teCoronaTreatement.EditValue = "";
            teChemicalTreatment.EditValue = "";
            teTPLArticle.EditValue = "";
            tePalletNumber1.EditValue = "";
            tePalletNumber2.EditValue = "";
            tePalletNumber3.EditValue = "";
            tePalletNumber4.EditValue = "";
            tePalletNumber5.EditValue = "";
            tePalletNumber6.EditValue = "";
            tePalletNumber7.EditValue = "";
            tePalletNumber8.EditValue = "";
            teJobNo.EditValue = "";
            teNetWeight.EditValue = "";
        }
        void loadData()
        {
            var obj = Utility.GetObjects(string.Format("SELECT * FROM \"@PALET\" WHERE \"Code\" = '{0}'", oid));
            if (obj == null)
                return;
            var row = obj.Rows[0];
            lueFactory.EditValue = row["U_Factory"];
            teRollNo.EditValue = row["U_RollNo"];
            lueItem.EditValue = row["U_ItemID"];
            teType.EditValue = row["U_Type"];
            teThick.EditValue = row["U_Thick"];
            teWidth1.EditValue = row["U_Width"];
            teLength1.EditValue = row["U_Length"];
            teJobNo.EditValue = row["U_JobNo"];
            teCoreID.EditValue = row["U_CoreID"];
            tePONumber.EditValue = row["U_PONumber"];
            teCoronaTreatement.EditValue = row["U_Corona"];
            teChemicalTreatment.EditValue = row["U_Chemical"];
            teTPLArticle.EditValue = row["U_TPLArticle"];
            teNetWeight.EditValue = row["U_NetWeight"];
            tePalletNumber1.EditValue = row["U_PaletNumber1"];
            tePalletNumber2.EditValue = row["U_PaletNumber2"];
            tePalletNumber3.EditValue = row["U_PaletNumber3"];
            tePalletNumber4.EditValue = row["U_PaletNumber4"];
            tePalletNumber5.EditValue = row["U_PaletNumber5"];
            tePalletNumber6.EditValue = row["U_PaletNumber6"];
            tePalletNumber7.EditValue = row["U_PaletNumber7"];
            tePalletNumber8.EditValue = row["U_PaletNumber8"];
            lueKindOfLabel.EditValue = "TPL PALET";

            table2 = Utility.GetObjects(string.Format("SELECT B.\"Code\", B.\"U_Barcode\" AS \"RollNumber\", A.\"U_NetWeight\" AS \"NetWeight\" FROM \"@PALETDETAIL\" A INNER JOIN \"@ITEMDETAIL\" B ON A.\"U_ItemDetailID\" = B.\"Code\" WHERE \"U_PaletID\" = '{0}'", this.oid));
            gc2.DataSource = table2;
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            if (!validateData())
                return;

            saveData();
            this.Dispose();
        }
        private bool validateData()
        {
            if (lueItem.EditValue == "")
            {
                MessageBox.Show("Item Must Be Choose !!");
                return false;
            }
            barcode = tePalletNumber1.EditValue.ToString() + tePalletNumber2.EditValue + tePalletNumber3.EditValue + tePalletNumber4.EditValue + tePalletNumber5.EditValue + tePalletNumber6.EditValue + tePalletNumber7.EditValue + tePalletNumber8.EditValue;
            var statusBarcode = Utility.GetObjects(string.Format("SELECT \"U_PaletNumber\" AS \"PaletNumber\" FROM \"@PALET\" WHERE \"U_PaletNumber\" LIKE '{0}' AND \"Code\" <>  '{1}' AND \"U_IsDeleted\" = 0", barcode, this.oid));
            if (statusBarcode.Rows.Count != 0)
            {
                    MessageBox.Show("Duplicate Palet Number");
                    return false;
            }
            return true;
        }
        void saveData()
        {
            var cmd = "";
            if (oid == "")
            {
                var ItemID = Utility.GetObjects("SELECT TOP 1 \"Code\" FROM \"@PALET\" ORDER BY \"Code\" * 1 DESC");
                if (ItemID == null)
                    oid = "1";
                else
                {
                    if (ItemID.Rows.Count == 0)
                    {
                        oid = "1";
                    }
                    else
                    {
                        oid = (Convert.ToDecimal(ItemID.Rows[0]["Code"]) + 1).ToString();
                    }
                }

                cmd = string.Format("INSERT INTO \"@PALET\" (\"Code\", \"Name\", \"U_ItemID\", \"U_RollNo\", \"U_KindOfLabelID\", \"U_Type\", \"U_Thick\", \"U_Width\", \"U_Length\", \"U_JobNo\", \"U_CoreID\", \"U_PONumber\", \"U_Corona\", \"U_TPLArticle\", \"U_NetWeight\", \"U_PaletNumber1\", \"U_PaletNumber2\", \"U_PaletNumber3\", \"U_PaletNumber4\", \"U_PaletNumber5\", \"U_PaletNumber6\" ,\"U_PaletNumber7\", \"U_PaletNumber8\", \"U_PaletNumber\", \"U_TransDate\", \"U_ModifiedDate\", \"U_IsDeleted\", \"U_Chemical\", \"U_Factory\") VALUES ('{0}', '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23:yyy/MM/dd}', '{23:yyy/MM/dd}', '0', '{24}', '{25}')"
                     , oid, lueItem.EditValue, teRollNo.EditValue, lueKindOfLabel.EditValue, teType.EditValue, teThick.EditValue, teWidth1.EditValue, teLength1.EditValue, teJobNo.EditValue, teCoreID.EditValue, tePONumber.EditValue, teCoronaTreatement.EditValue, teTPLArticle.EditValue, teNetWeight.EditValue, tePalletNumber1.EditValue, tePalletNumber2.EditValue, tePalletNumber3.EditValue, tePalletNumber4.EditValue, tePalletNumber5.EditValue, tePalletNumber6.EditValue, tePalletNumber7.EditValue, tePalletNumber8.EditValue, barcode, DateTime.Now, teChemicalTreatment.EditValue, lueFactory.EditValue);
            }
            else
            {

                cmd = string.Format("UPDATE \"@PALET\" SET \"U_ItemID\" = '{1}', \"U_RollNo\" = '{2}', \"U_KindOfLabelID\" = '{3}', \"U_Type\" = '{4}', \"U_Thick\" = '{5}', \"U_Width\" = '{6}', \"U_Length\" = '{7}', \"U_JobNo\" = '{8}', \"U_CoreID\" = '{9}', \"U_PONumber\" = '{10}', \"U_Corona\" = '{11}', \"U_TPLArticle\" = '{12}', \"U_NetWeight\" = '{13}', \"U_PaletNumber1\" = '{14}', \"U_PaletNumber2\" = '{15}', \"U_PaletNumber3\" = '{16}', \"U_PaletNumber4\" = '{17}', \"U_PaletNumber5\" = '{18}', \"U_PaletNumber6\" = '{19}', \"U_PaletNumber7\" = '{20}', \"U_PaletNumber8\" = '{21}', \"U_PaletNumber\" = '{22}', \"U_ModifiedDate\" = '{23:yyyy/MM/dd}', \"U_Chemical\" = '{24}', \"U_Factory\" = '{25}' WHERE \"Code\" = '{0}'"
                     , oid, lueItem.EditValue, teRollNo.EditValue, lueKindOfLabel.EditValue, teType.EditValue, teThick.EditValue, teWidth1.EditValue, teLength1.EditValue, teJobNo.EditValue, teCoreID.EditValue, tePONumber.EditValue, teCoronaTreatement.EditValue, teTPLArticle.EditValue, teNetWeight.EditValue, tePalletNumber1.EditValue, tePalletNumber2.EditValue, tePalletNumber3.EditValue, tePalletNumber4.EditValue, tePalletNumber5.EditValue, tePalletNumber6.EditValue, tePalletNumber7.EditValue, tePalletNumber8.EditValue, barcode, DateTime.Now, teChemicalTreatment.EditValue, lueFactory.EditValue);
            }
            Utility.GetObjects(cmd);

            var PaletDetailID = "0";
            cmd = string.Format("DELETE FROM \"@PALETDETAIL\" WHERE \"U_PaletID\" LIKE '{0}'", oid);
            Utility.GetObjects(cmd);
            foreach (DataRow r in table2.Rows)
            {
                var ItemID = Utility.GetObjects("SELECT TOP 1 \"Code\" FROM \"@PALETDETAIL\" ORDER BY \"Code\" * 1 DESC");
                if (ItemID == null)
                    PaletDetailID = "1";
                else
                {
                    if (ItemID.Rows.Count == 0)
                    {
                        PaletDetailID = "1";
                    }
                    else
                    {
                        PaletDetailID = (Convert.ToDecimal(ItemID.Rows[0]["Code"]) + 1).ToString();
                    }
                }
                cmd = string.Format("INSERT INTO \"@PALETDETAIL\" (\"Code\", \"Name\", \"U_PaletID\", \"U_ItemDetailID\", \"U_NetWeight\") VALUES ('{0}', '{0}', '{1}', '{2}', '{3}')", PaletDetailID, oid, r["Code"], r["NetWeight"]);
                Utility.GetObjects(cmd);
            }
            Utility.Print(lueKindOfLabel.EditValue.ToString(), this.oid);
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lueItem_EditValueChanged(object sender, EventArgs e)
        {
            loadTable();
        }
        void loadTable()
        {
            if (lueItem.EditValue == null)
                return;
            var obj = Utility.GetObjects(string.Format("SELECT TOP 1 T0.*, T0.\"U_idu_corona\" AS \"Corona\", T0.\"U_idu_chemtreat\" AS \"Chemical\", T1.\"U_idu_prd\" AS \"TypeItem\", T0.\"SWeight1\" AS \"Weight\" FROM OITM T0 INNER JOIN OITB T1 ON T0.\"ItmsGrpCod\" = T1.\"ItmsGrpCod\" WHERE T0.\"ItemCode\" = '{0}'", lueItem.EditValue));
            if (obj.Rows.Count == 0)
                return;
            var row = obj.Rows[0];
            teType.EditValue = row["U_idu_spec_typ"];
            teThick.EditValue = row["U_idu_thick"];
            teWidth1.EditValue = row["U_idu_i_width"];
            teLength1.EditValue = row["U_idu_i_length"];
            switch (row["Corona"] == "" ? 0 : Convert.ToInt32(row["Corona"]))
            {
                case 0: teCoronaTreatement.EditValue = ""; break;
                case 1: teCoronaTreatement.EditValue = "Inside"; break;
                case 2: teCoronaTreatement.EditValue = "Bothside"; break;
                case 3: teCoronaTreatement.EditValue = "Outside"; break;
            }
            switch (row["Chemical"] == "" ? 0 : Convert.ToInt32(row["Chemical"]))
            {
                case 0: teChemicalTreatment.EditValue = ""; break;
                case 1: teChemicalTreatment.EditValue = "Inside"; break;
                case 2: teChemicalTreatment.EditValue = "Bothside"; break;
                case 3: teChemicalTreatment.EditValue = "Outside"; break;
            }

            tplArticle();

            var table = Utility.hanaConnection(string.Format(@"
                        SELECT ""Code"", ""U_TransDate"" AS ""InDate"", ""U_Barcode"" AS ""RollNo""
                        , ""U_Type"" AS ""Type"", SUBSTRING(""FrgnName"", LOCATE(""FrgnName"", '-') + 1, LENGTH(""FrgnName"")) AS ""Spec""
                        , ""U_Grade"" AS ""Gr"", ""U_NWeight1"" AS ""Weight"", ""U_WHInDivision"" AS ""WHDivision"", ""U_Location"" AS ""Location""
                        , A.""U_Corona"" AS ""Corona"", A.""U_Chemical"" AS ""Chemical"", A.""U_PONumber"" AS ""PONumber"", ""U_TPLArticle"" AS ""TPLArticle""
                        FROM {3}.""@ITEMDETAIL"" A INNER JOIN {3}.OITM B ON A.""U_ItemID"" = B.""ItemCode""
                        WHERE ""U_ItemID"" LIKE '{0}'
                        AND ""U_Status"" LIKE '1'
                        AND ""U_Barcode"" LIKE '{2}%'
                        AND ""Code"" NOT IN (SELECT B.""U_ItemDetailID"" FROM {3}.""@PALET"" A INNER JOIN {3}.""@PALETDETAIL"" B ON A.""Code"" = B.""U_PaletID"" WHERE A.""U_IsDeleted"" LIKE '0' AND B.""U_PaletID"" NOT LIKE '{1}')"
                        , lueItem.EditValue, this.oid, teRollNo.EditValue, System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]));
            gc1.DataSource = table;
            gv1.BestFitColumns();
            //table2.Clear();
        }
        void tplArticle()
        {
            //if (lciTPLArticle.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Never)
            //    return;

            var tplArticle = "420";

            if (teType.EditValue == null)
                teType.EditValue = "";
            if (teType.EditValue.ToString().Substring(0, 2) == "NP")
                tplArticle = tplArticle + "0";
            else if (teType.EditValue.ToString().Substring(0, 2) == "NT")
                tplArticle = tplArticle + "1";
            else if (teType.EditValue.ToString().Substring(0, 2) == "NE")
                tplArticle = tplArticle + "4";
            else
                tplArticle = tplArticle + "";

            if (teCoronaTreatement.EditValue == null)
                teCoronaTreatement.EditValue = "";
            if (teChemicalTreatment.EditValue == null)
                teChemicalTreatment.EditValue = "";
            if (teCoronaTreatement.EditValue.ToString().ToUpper() == "INSIDE")
                tplArticle = tplArticle + "1";
            else if (teCoronaTreatement.EditValue.ToString().ToUpper() == "BOTHSIDE")
                tplArticle = tplArticle + "2";
            else if (teCoronaTreatement.EditValue.ToString().ToUpper() == "OUTSIDE")
                tplArticle = tplArticle + "3";
            else
                tplArticle = tplArticle + "0";

            tplArticle = tplArticle + ".";

            if (teThick.EditValue == null)
                teThick.EditValue = "";

            tplArticle = tplArticle + teThick.EditValue;

            tplArticle = tplArticle + ".";

            if (teWidth1.EditValue == null)
                teWidth1.EditValue = "";

            tplArticle = tplArticle + teWidth1.EditValue;

            if (teChemicalTreatment.EditValue.ToString().ToUpper() == "INSIDE")
                tplArticle = tplArticle + "i";
            else if (teChemicalTreatment.EditValue.ToString().ToUpper() == "BOTHSIDE")
                tplArticle = tplArticle + "b";
            else if (teChemicalTreatment.EditValue.ToString().ToUpper() == "OUTSIDE")
                tplArticle = tplArticle + "u";
            else
                tplArticle = tplArticle + "o";

            //if (lueCoreIDLength.EditValue == null)
            //    lueCoreIDLength.EditValue = "";
            try
            {
                if (teCoreID.EditValue.ToString().Substring(0, 2) == "76")
                    tplArticle = tplArticle + "2";
                else
                    tplArticle = tplArticle + "1";
            }
            catch (Exception)
            {
                
            }

            if (teLength1.EditValue == null)
                teLength1.EditValue = "";
            if (teLength1.EditValue.ToString() == "18000")
                tplArticle = tplArticle + "0";
            else
                tplArticle = tplArticle + "3";

            teTPLArticle.EditValue = tplArticle;
        }

        private void lueItem_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                var frm = new ItemList { itemID = lueItem.EditValue.ToString() };
                frm.ShowDialog(this);
                lueItem.EditValue = frm.itemID;
            }
            lueItem_EditValueChanged(sender, e);
        }

        private void lueKindOfLabel_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                var frm = new LabelList { labelID = lueKindOfLabel.EditValue.ToString() };
                frm.ShowDialog(this);
                lueKindOfLabel.EditValue = frm.labelID;
            }
        }

        private void sbToRight_Click(object sender, EventArgs e)
        {
            var row = gv1.GetFocusedDataRow();
            if (row == null)
                return;
            if (table2.Columns["Code"] == null) table2.Columns.Add("Code", typeof(string));
            if (table2.Columns["RollNumber"] == null) table2.Columns.Add("RollNumber", typeof(string));
            if (table2.Columns["NetWeight"] == null) table2.Columns.Add("NetWeight", typeof(string));
            foreach (DataRow r in table2.Rows)
            {
                if (r["RollNumber"].ToString() == row["RollNo"].ToString())
                {
                    MessageBox.Show("Duplicaate Roll Number !!");
                    return;
                }
            }
            table2.Rows.Add(row["Code"], row["RollNo"], row["Weight"]);
            gc2.DataSource = table2;
            decimal totalNetWeight = 0;
            foreach (DataRow r in table2.Rows)
            {
                totalNetWeight = totalNetWeight + Convert.ToDecimal(r["NetWeight"]);
            }
            teNetWeight.EditValue = totalNetWeight;
        }

        private void sbToLeft_Click(object sender, EventArgs e)
        {
            var row = gv2.GetFocusedDataRow();
            if (row == null)
                return;
            row.Delete();
            decimal totalNetWeight = 0;
            foreach (DataRow r in table2.Rows)
            {
                totalNetWeight = totalNetWeight + Convert.ToDecimal(r["NetWeight"]);
            }
            teNetWeight.EditValue = totalNetWeight;
        }

        private void gv1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var row = gv1.GetDataRow(e.RowHandle);
            if (row == null) return;

            foreach (DataRow r in table2.Rows)
            {
                if (r["Code"].ToString() == row["Code"].ToString())
                    e.Appearance.BackColor = Color.Red;
            }
        }

        private void sbTPLPalletNum_Click(object sender, EventArgs e)
        {
            try
            {
                var date = Utility.GetObjects("SELECT CASE WHEN(HOUR(CURRENT_TIME)) < 7 THEN YEAR(ADD_DAYS(CURRENT_DATE, -1)) ELSE YEAR(CURRENT_DATE) END AS \"YEAR\", CASE WHEN(HOUR(CURRENT_TIME)) < 7 THEN MONTH(ADD_DAYS(CURRENT_DATE, -1)) ELSE MONTH(CURRENT_DATE) END AS \"Month\", CASE WHEN(HOUR(CURRENT_TIME)) < 7 THEN TO_VARCHAR(TO_DATE(ADD_DAYS(CURRENT_DATE, -1)), 'DD') ELSE TO_VARCHAR(TO_DATE(CURRENT_DATE), 'DD') END AS \"Day\" FROM DUMMY;");
                switch (date.Rows[0]["Year"].ToString())
                {
                    case "2016": tePalletNumber1.EditValue = "G"; break;
                    case "2017": tePalletNumber1.EditValue = "H"; break;
                    case "2018": tePalletNumber1.EditValue = "I"; break;
                    case "2019": tePalletNumber1.EditValue = "J"; break;
                    case "2020": tePalletNumber1.EditValue = "K"; break;
                    case "2021": tePalletNumber1.EditValue = "L"; break;
                    case "2022": tePalletNumber1.EditValue = "M"; break;
                    case "2023": tePalletNumber1.EditValue = "N"; break;
                    case "2024": tePalletNumber1.EditValue = "O"; break;
                    case "2025": tePalletNumber1.EditValue = "P"; break;
                    case "2026": tePalletNumber1.EditValue = "Q"; break;
                    case "2027": tePalletNumber1.EditValue = "R"; break;
                    case "2028": tePalletNumber1.EditValue = "S"; break;
                    case "2029": tePalletNumber1.EditValue = "T"; break;
                    case "2030": tePalletNumber1.EditValue = "U"; break;
                    case "2031": tePalletNumber1.EditValue = "V"; break;
                    case "2032": tePalletNumber1.EditValue = "W"; break;
                    case "2033": tePalletNumber1.EditValue = "X"; break;
                    case "2034": tePalletNumber1.EditValue = "Y"; break;
                    case "2035": tePalletNumber1.EditValue = "Z"; break;
                }

                if (teType.EditValue.ToString().Substring(0, 2) == "NP")
                    tePalletNumber2.EditValue = "B";
                else if (teType.EditValue.ToString().Substring(0, 2) == "NT")
                    tePalletNumber2.EditValue = "C";
                else if (teType.EditValue.ToString().Substring(0, 2) == "FP")
                    tePalletNumber2.EditValue = "A";

                if (date.Rows[0]["Month"].ToString() == "10")
                    tePalletNumber3.EditValue = "A";
                else if (date.Rows[0]["Month"].ToString() == "11")
                    tePalletNumber3.EditValue = "B";
                else if (date.Rows[0]["Month"].ToString() == "12")
                    tePalletNumber3.EditValue = "C";
                else
                    tePalletNumber3.EditValue = date.Rows[0]["Month"];

                tePalletNumber4.EditValue = date.Rows[0]["Day"].ToString();

                tePalletNumber5.EditValue = Convert.ToDecimal(teThick.EditValue);
                tePalletNumber6.EditValue = teWidth1.EditValue;
                tePalletNumber7.EditValue = teLength1.EditValue.ToString().Substring(0, 2);
                tePalletNumber8.EditValue = teLength1.EditValue.ToString().Substring(2, 3);
            }
            catch (Exception)
            {

            }

            
        }

        private void teRollNo_KeyUp(object sender, KeyEventArgs e)
        {
            loadTable();
        }

        private void teCoreID_KeyUp(object sender, KeyEventArgs e)
        {
            tplArticle();
        }

        private void sbNewPalet_Click(object sender, EventArgs e)
        {
            var id = this.oid;
            this.oid = "";
            if (!validateData())
            {
                this.oid = id;
                return;
            }
            saveData();
            this.Dispose();
        }
    }
}
