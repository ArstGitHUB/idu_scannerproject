using System;
using System.Data;
using System.Text;

using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Sap.Data.Hana;

namespace ScannerProject.Helper
{
    public static class Utility
    {
        public static string insertGoodsReceivedandItemTransfer(string barcode)
        {
            DBConnection.oInvGenEntry = (SAPbobsCOM.Documents)DBConnection.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry);
            int i;
            DBConnection.manBatchNumber = "xyz";
            DBConnection.totalNumber = (int)(System.Convert.ToDouble(1));
            var obj = Utility.hanaConnection(string.Format(@"
            SELECT B.""ItemCode"" AS ""ItemCode"", C.""U_idu_prd"" AS ""TypeItem"", B.""ItemName"" AS ""ItemName"", ""U_Thick1"" AS ""Thick""
            , ""U_Width1"" AS ""Width"", ""U_Length1"" AS ""Length"", B.""SWeight1"" AS ""Weight"", B.""U_beas_prccode"" AS ""CostCenter""
            , D.""U_idu_dept"" AS ""Department""
            , ""U_WHInDivision"" AS ""WHDivision""
            , ""U_Location"" AS ""Location"", ""U_Remark1"" AS ""Remark""
            , ""U_KindOfLabelID"" AS ""KindOfLabel"", ""U_Team"" AS ""Team"", A.""U_CoreIdLength"" AS ""CoreID""
            , TO_DATE(CASE
            	WHEN LEFT(""U_Barcode"", 1) LIKE 'G' THEN '2016'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'H' THEN '2017'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'I' THEN '2018'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'J' THEN '2019'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'K' THEN '2020'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'L' THEN '2021'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'M' THEN '2022'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'N' THEN '2023'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'O' THEN '2024'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'P' THEN '2025'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'Q' THEN '2026'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'R' THEN '2027'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'S' THEN '2028'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'T' THEN '2029'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'U' THEN '2030'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'V' THEN '2031'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'W' THEN '2032'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'X' THEN '2033'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'Y' THEN '2034'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'Z' THEN '2035'
                WHEN LEFT(""U_Barcode"", 1) LIKE '1' THEN '2018'
                ELSE '2018'
              END ||
              CASE
                WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'A' THEN '10'
                WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'B' THEN '11'
                WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'C' THEN '12'
                ELSE(0 || CASE WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE '0' THEN '6' ELSE SUBSTRING(""U_Barcode"", 3, 1) END)
              END ||
              CASE WHEN SUBSTRING(""U_Barcode"", 4, 2) > '31' THEN '01' ELSE SUBSTRING(""U_Barcode"", 4, 2) END) AS ""Tanggal""
            FROM {1}.""@ITEMDETAIL"" A
                INNER JOIN {1}.OITM B ON ""U_ItemID"" = B.""ItemCode""
                INNER JOIN {1}.OITB C ON B.""ItmsGrpCod"" = C.""ItmsGrpCod""
                INNER JOIN {1}.OPRC D ON B.""U_beas_prccode"" = D.""PrcCode""
            WHERE A.""U_IsDeleted"" = 0
                AND A.""U_Barcode"" LIKE '{0}'
                AND A.""U_Status"" LIKE '0'", barcode, ConfigurationManager.AppSettings["SAPDatabase"]));
            if (obj.Rows.Count == 0)
                return "";
            for (i = 0; i <= DBConnection.totalNumber - 1; i++)
            {
                #region Not Used
                //                Weight 1 roll product Polyesther Film (PET) =
                //Rounddown(Thick * Width * Length * 1.4 / 1000000, 1)-- - satuannya Kg

                //Weight 1 roll product Nylon Film(NT / NP) =
                //     Rounddown(Thick * Width * Length * 1.16 / 1000000, 1)---- satuannya Kg

                // untuk set value di udf
                //DBConnection.oInvGenEntry.UserFields.Fields.Item("U_colomUDF").Value

                //if (obj.Rows[0]["TypeItem"].ToString() == "PET")
                //{
                //    DBConnection.oInvGenEntry.Lines.BatchNumbers.Quantity = (int)Math.Floor((Convert.ToDouble(obj.Rows[0]["Thick"]) * Convert.ToDouble(obj.Rows[0]["Width"]) * Convert.ToDouble(obj.Rows[0]["Length"]) * 1.4 / 1000000) / 1);
                //    DBConnection.oInvGenEntry.Lines.Quantity = (int)Math.Floor((Convert.ToDouble(obj.Rows[0]["Thick"]) * Convert.ToDouble(obj.Rows[0]["Width"]) * Convert.ToDouble(obj.Rows[0]["Length"]) * 1.4 / 1000000) / 1);
                //}
                //else
                //{
                //    DBConnection.oInvGenEntry.Lines.BatchNumbers.Quantity = (int)Math.Floor((Convert.ToDouble(obj.Rows[0]["Thick"]) * Convert.ToDouble(obj.Rows[0]["Width"]) * Convert.ToDouble(obj.Rows[0]["Length"]) * 1.6 / 1000000) / 1);
                //    DBConnection.oInvGenEntry.Lines.Quantity = (int)Math.Floor((Convert.ToDouble(obj.Rows[0]["Thick"]) * Convert.ToDouble(obj.Rows[0]["Width"]) * Convert.ToDouble(obj.Rows[0]["Length"]) * 1.6 / 1000000) / 1);
                //}
                #endregion
                DBConnection.oInvGenEntry.Lines.BatchNumbers.Quantity = Convert.ToDouble(obj.Rows[0]["Weight"]);
                DBConnection.oInvGenEntry.Lines.BatchNumbers.ManufacturerSerialNumber = DBConnection.manBatchNumber;
                DBConnection.oInvGenEntry.Lines.BatchNumbers.InternalSerialNumber = DBConnection.interSerNumber;
                //    BatchNumber must be unique
                DBConnection.oInvGenEntry.Lines.BatchNumbers.BatchNumber = barcode;//DBConnection.batchNum + i.ToString();
                DBConnection.oInvGenEntry.Lines.BatchNumbers.Location = obj.Rows[0]["Location"].ToString();
                DBConnection.oInvGenEntry.Lines.BatchNumbers.UserFields.Fields.Item("U_idu_kinlabel").Value = obj.Rows[0]["KindOfLabel"];
                DBConnection.oInvGenEntry.Lines.BatchNumbers.UserFields.Fields.Item("U_idu_coreid").Value = obj.Rows[0]["CoreID"];
                DBConnection.oInvGenEntry.Lines.BatchNumbers.Notes = obj.Rows[0]["Remark"].ToString();

                DBConnection.oInvGenEntry.Lines.BatchNumbers.SetCurrentLine(i);
                DBConnection.oInvGenEntry.Lines.BatchNumbers.Add();
            }
            DBConnection.oInvGenEntry.Lines.Quantity = Convert.ToDouble(obj.Rows[0]["Weight"]);
            //DBConnection.oInvGenEntry.Lines.AccountCode = 
            DBConnection.oInvGenEntry.Lines.CostingCode = obj.Rows[0]["CostCenter"].ToString();
            DBConnection.oInvGenEntry.Lines.CostingCode2 = obj.Rows[0]["Department"].ToString();
            DBConnection.oInvGenEntry.Lines.UserFields.Fields.Item("U_idu_rollqty").Value = "1";
            DBConnection.oInvGenEntry.UserFields.Fields.Item("U_idu_gr_stocktype").Value = "FG";
            if (obj.Rows[0]["WHDivision"].ToString() == "107")
            {
                DBConnection.oInvGenEntry.UserFields.Fields.Item("U_idu_in_purpose").Value = "1";
            }
            else if (obj.Rows[0]["WHDivision"].ToString() == "149")
            {
                DBConnection.oInvGenEntry.UserFields.Fields.Item("U_idu_in_purpose").Value = "2";
            }
            else
            {
                DBConnection.oInvGenEntry.UserFields.Fields.Item("U_idu_in_purpose").Value = "6";
            }
            DBConnection.oInvGenEntry.UserFields.Fields.Item("U_idu_tipegr").Value = "1";
            DBConnection.oInvGenEntry.UserFields.Fields.Item("U_idu_label").Value = obj.Rows[0]["KindOfLabel"];
            DBConnection.oInvGenEntry.UserFields.Fields.Item("U_idu_team").Value = obj.Rows[0]["Team"];
            DBConnection.oInvGenEntry.UserFields.Fields.Item("U_idu_user").Value = CurrentUser.UserID;
            DBConnection.oInvGenEntry.DocDate = Convert.ToDateTime(obj.Rows[0]["Tanggal"]);
            if (obj.Rows[0]["WHDivision"].ToString() == "88")
            {
                obj.Rows[0]["WHDivision"] = "888";
            }
            DBConnection.oInvGenEntry.UserFields.Fields.Item("U_idu_whsdiv").Value = obj.Rows[0]["WHDivision"].ToString();
            DBConnection.oInvGenEntry.Lines.ItemCode = obj.Rows[0]["ItemCode"].ToString();//DBConnection.oItems.ItemCode;
            DBConnection.oInvGenEntry.Lines.ItemDescription = obj.Rows[0]["ItemName"].ToString(); //DBConnection.oItems.ItemName;
            DBConnection.oInvGenEntry.Lines.ShipDate = DateTime.Now;
            DBConnection.oInvGenEntry.PaymentGroupCode = 12;
            DBConnection.oInvGenEntry.GroupNumber = 12;
            DBConnection.RetVal = DBConnection.oInvGenEntry.Add();
            string temp_string = DBConnection.tempStr;
            DBConnection.oCompany.GetNewObjectCode(out temp_string);
            var retval1 = DBConnection.RetVal;

            if (DBConnection.RetVal != 0)
            {
                int temp_int = DBConnection.ErrCode;
                string temp_string2 = DBConnection.ErrMsg;
                DBConnection.oCompany.GetLastError(out temp_int, out temp_string2);
                //MessageBox.Show("Goods Received Fail. Barcode : " + barcode);
                //MsgBoxLabel.Text = temp_int + " " + temp_string2;
                MessageBox.Show("1." + temp_int + " " + temp_string2);
            }
            ////else
            ////{
            ////    //MsgBoxLabel.Text = "The document of: " + DBConnection.oItems.ItemCode + " with Quantity=" + QuantityText.Text + " , price=" + PriceText.Text + " was added successfully";
            ////}


            DBConnection.oStockTransfer = (SAPbobsCOM.StockTransfer)DBConnection.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oStockTransfer);
            //int i;
            DBConnection.manBatchNumber = "xyz";
            DBConnection.totalNumber = (int)(System.Convert.ToDouble(1));
            obj = Utility.hanaConnection(string.Format(@"
            SELECT B.""ItemCode"" AS ""ItemCode""
            , B.""ItemName"" AS ""ItemName""
            , C.""ItmsGrpCod"" AS ""GroupItem""
            , C.""U_idu_prd"" AS ""TypeItem""
            , ""U_Thick1"" AS ""Thick""
            , ""U_Width1"" AS ""Width""
            , ""U_Length1"" AS ""Length""
            , B.""SWeight1"" AS ""Weight""
            , B.""U_beas_prccode"" AS ""CostCenter""
            , D.""U_idu_dept"" AS ""Department""
            , A.""U_Location"" AS ""Location""
            , A.""U_Remark1"" AS ""Remark""
            , TO_DATE(CASE
            	WHEN LEFT(""U_Barcode"", 1) LIKE 'G' THEN '2016'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'H' THEN '2017'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'I' THEN '2018'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'J' THEN '2019'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'K' THEN '2020'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'L' THEN '2021'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'M' THEN '2022'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'N' THEN '2023'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'O' THEN '2024'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'P' THEN '2025'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'Q' THEN '2026'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'R' THEN '2027'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'S' THEN '2028'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'T' THEN '2029'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'U' THEN '2030'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'V' THEN '2031'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'W' THEN '2032'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'X' THEN '2033'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'Y' THEN '2034'
                WHEN LEFT(""U_Barcode"", 1) LIKE 'Z' THEN '2035'
                WHEN LEFT(""U_Barcode"", 1) LIKE '1' THEN '2018'
                ELSE '2018'
              END ||
              CASE
                WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'A' THEN '10'
                WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'B' THEN '11'
                WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE 'C' THEN '12'
                ELSE(0 || CASE WHEN SUBSTRING(""U_Barcode"", 3, 1) LIKE '0' THEN '6' ELSE SUBSTRING(""U_Barcode"", 3, 1) END)
              END ||
              CASE WHEN SUBSTRING(""U_Barcode"", 4, 2) > '31' THEN '01' ELSE SUBSTRING(""U_Barcode"", 4, 2) END) AS ""Tanggal""
            FROM {1}.""@ITEMDETAIL"" A
                INNER JOIN {1}.OITM B ON ""U_ItemID"" = B.""ItemCode""
                INNER JOIN {1}.OITB C ON B.""ItmsGrpCod"" = C.""ItmsGrpCod""
                INNER JOIN {1}.OPRC D ON B.""U_beas_prccode"" = D.""PrcCode""
            WHERE A.""U_IsDeleted"" = 0
                AND A.""U_Barcode"" LIKE '{0}'
                AND A.""U_Status"" LIKE '0'", barcode, ConfigurationManager.AppSettings["SAPDatabase"]));
            if (obj.Rows.Count == 0)
                return "";
            for (i = 0; i <= DBConnection.totalNumber - 1; i++)
            {
                #region Not Used
                //if (obj.Rows[0]["TypeItem"].ToString() == "PET")
                //{
                //    DBConnection.oStockTransfer.Lines.BatchNumbers.Quantity = (int)Math.Floor((Convert.ToDouble(obj.Rows[0]["Thick"]) * Convert.ToDouble(obj.Rows[0]["Width"]) * Convert.ToDouble(obj.Rows[0]["Length"]) * 1.4 / 1000000) / 1);
                //    DBConnection.oStockTransfer.Lines.Quantity = (int)Math.Floor((Convert.ToDouble(obj.Rows[0]["Thick"]) * Convert.ToDouble(obj.Rows[0]["Width"]) * Convert.ToDouble(obj.Rows[0]["Length"]) * 1.4 / 1000000) / 1);
                //}
                //else
                //{
                //    DBConnection.oStockTransfer.Lines.BatchNumbers.Quantity = (int)Math.Floor((Convert.ToDouble(obj.Rows[0]["Thick"]) * Convert.ToDouble(obj.Rows[0]["Width"]) * Convert.ToDouble(obj.Rows[0]["Length"]) * 1.6 / 1000000) / 1);
                //    DBConnection.oStockTransfer.Lines.Quantity = (int)Math.Floor((Convert.ToDouble(obj.Rows[0]["Thick"]) * Convert.ToDouble(obj.Rows[0]["Width"]) * Convert.ToDouble(obj.Rows[0]["Length"]) * 1.6 / 1000000) / 1);
                //}
                #endregion
                DBConnection.oStockTransfer.Lines.BatchNumbers.Quantity = Convert.ToDouble(obj.Rows[0]["Weight"]);
                DBConnection.oStockTransfer.Lines.Quantity = Convert.ToDouble(obj.Rows[0]["Weight"]);
                //DBConnection.oStockTransfer.Lines.BatchNumbers.Quantity = 1;
                DBConnection.oStockTransfer.Lines.BatchNumbers.ManufacturerSerialNumber = DBConnection.manBatchNumber;
                DBConnection.oStockTransfer.Lines.BatchNumbers.InternalSerialNumber = DBConnection.interSerNumber;
                DBConnection.oStockTransfer.Lines.BatchNumbers.Location = obj.Rows[0]["Location"].ToString();
                DBConnection.oInvGenEntry.Lines.BatchNumbers.Notes = obj.Rows[0]["Remark"].ToString();
                //    BatchNumber must be unique
                DBConnection.oStockTransfer.Lines.BatchNumbers.BatchNumber = barcode;//DBConnection.batchNum + i.ToString();
                switch (obj.Rows[0]["GroupItem"].ToString())
                {
                    case "210":
                        DBConnection.oStockTransfer.Lines.WarehouseCode = "G16"; DBConnection.oStockTransfer.Lines.FromWarehouseCode = "G09";
                        DBConnection.oStockTransfer.ToWarehouse = "G16"; DBConnection.oStockTransfer.FromWarehouse = "G09";
                        break;
                    case "211":
                        DBConnection.oStockTransfer.Lines.WarehouseCode = "G17"; DBConnection.oStockTransfer.Lines.FromWarehouseCode = "G10";
                        DBConnection.oStockTransfer.ToWarehouse = "G17"; DBConnection.oStockTransfer.FromWarehouse = "G10";
                        break;
                    case "212":
                        DBConnection.oStockTransfer.Lines.WarehouseCode = "G18"; DBConnection.oStockTransfer.Lines.FromWarehouseCode = "G11";
                        DBConnection.oStockTransfer.ToWarehouse = "G18"; DBConnection.oStockTransfer.FromWarehouse = "G11";
                        break;
                }
                DBConnection.oStockTransfer.Lines.BatchNumbers.SetCurrentLine(i);
                DBConnection.oStockTransfer.Lines.BatchNumbers.Add();
            }
            DBConnection.oStockTransfer.Lines.UserFields.Fields.Item("U_idu_rollqty").Value = "1";
            //DBConnection.oStockTransfer.Lines.CostingCode = obj.Rows[0]["CostCenter"].ToString();
            //DBConnection.oStockTransfer.Lines.CostingCode2 = obj.Rows[0]["Department"].ToString();
            DBConnection.oStockTransfer.Lines.ItemCode = obj.Rows[0]["ItemCode"].ToString();//DBConnection.oItems.ItemCode;
            DBConnection.oStockTransfer.Lines.ItemDescription = obj.Rows[0]["ItemName"].ToString();//DBConnection.oItems.ItemName;
            DBConnection.oStockTransfer.PriceList = 12;
            DBConnection.oStockTransfer.DocDate = Convert.ToDateTime(obj.Rows[0]["Tanggal"]);
            DBConnection.RetVal = DBConnection.oStockTransfer.Add();
            temp_string = DBConnection.tempStr;
            DBConnection.oCompany.GetNewObjectCode(out temp_string);
            var retval2 = DBConnection.RetVal;
            if (retval1 == 0 && retval2 == 0)
            {
                Utility.GetObjects(string.Format("UPDATE \"@ITEMDETAIL\" SET \"U_Status\" = '1' WHERE \"U_IsDeleted\" = 0 AND \"U_Barcode\" LIKE '{0}'", barcode));
            }
            else
            {
                int temp_int = DBConnection.ErrCode;
                string temp_string2 = DBConnection.ErrMsg;
                DBConnection.oCompany.GetLastError(out temp_int, out temp_string2);
                MessageBox.Show("2." + temp_int + " " + temp_string2);
                //MessageBox.Show("Goods Received AND Item Transfer Fail. Barcode : " + barcode);
                return barcode + ", ";
            }
            return "";
        }
        
        public static DataRow insertDeliveryOrder(DataTable datatable, DataTable table2)
        {
            var cardCode = Utility.GetObjects(string.Format("SELECT \"CardCode\" FROM ODRF WHERE \"ObjType\" = 15 AND \"DocStatus\" = 'O' AND \"DocEntry\" LIKE '{0}'", datatable.Rows[0]["DocEntry"]));
           
            DBConnection.oDraft = (SAPbobsCOM.Documents)DBConnection.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oDrafts);

            DBConnection.oDraft.GetByKey(Convert.ToInt32(datatable.Rows[0]["DocEntry"]));
            if (table2.Columns["Tanda"] == null) table2.Columns.Add("Tanda", typeof(string));
            foreach (DataRow r in table2.Rows)
            {
                r["Tanda"] = null;
            }
            int i;
            string barcode = "";
            int x = 0;
            DBConnection.manBatchNumber = "xyz";
            foreach (DataRow r in datatable.Rows)
            {
                i = 0;
                //var row = Utility.GetObjects(string.Format("SELECT TOP {1} \"U_Barcode\" AS \"Barcode\" FROM \"@ITEMDETAIL\" WHERE \"U_IsDeleted\" = 0 AND \"U_ItemID\" LIKE '{0}' AND \"U_Status\" LIKE '1'", r["ItemID"], DBConnection.totalNumber));
                DBConnection.totalNumber = (int)(System.Convert.ToDouble(r["Qty"]));
                //DBConnection.oDraft.Lines.SetCurrentLine(Convert.ToInt32(r["LineNum"]));
                DBConnection.oDraft.Lines.SetCurrentLine(x);
                foreach (DataRow r1 in table2.Rows)
                {
                    #region #not used
                    //SELECT B.\"ItemCode\" AS \"ItemCode\", B.\"ItemName\" AS \"ItemName\", C.\"ItmsGrpCod\" AS \"GroupItem\", \"U_Thick1\" AS Thick, \"U_Width1\" AS Width, \"U_Length1\" AS Length 
                    //SELECT A.\"U_ItemID\" AS \"ItemID\", B.\"ItemCode\" AS \"ItemCode\", B.\"ItemName\" AS \"ItemName\", C.\"ItmsGrpCod\" AS \"GroupItem\", A.\"U_Thick1\" AS Thick, A.\"U_Width1\" AS Width, A.\"U_Length1\" AS Length FROM \"@ITEMDETAIL\" A INNER JOIN OITM B ON \"U_ItemID\" = B.\"ItemCode\" INNER JOIN OITB C ON B.\"ItmsGrpCod\" = C.\"ItmsGrpCod\" 
                    //var itemID = Utility.GetObjects(string.Format("SELECT \"U_ItemID\" AS \"ItemID\" FROM \"@ITEMDETAIL\" WHERE \"U_IsDeleted\" = 0 AND \"U_Status\" LIKE 1 AND \"U_Barcode\" LIKE '{0}'", r1["RawData"]));
                    #endregion
                    var itemID = Utility.GetObjects(string.Format("SELECT A.\"U_ItemID\" AS \"ItemID\", B.\"ItemCode\" AS \"ItemCode\", B.\"ItemName\" AS \"ItemName\", C.\"ItmsGrpCod\" AS \"GroupItem\", C.\"U_idu_prd\" AS \"TypeItem\", A.\"U_Thick1\" AS Thick, A.\"U_Width1\" AS Width, A.\"U_Length1\" AS Length, B.\"SWeight1\" AS \"Weight\", B.\"U_beas_prccode\" AS \"CostCenter\", D.\"U_idu_dept\" AS \"Department\" FROM \"@ITEMDETAIL\" A INNER JOIN OITM B ON \"U_ItemID\" = B.\"ItemCode\" INNER JOIN OITB C ON B.\"ItmsGrpCod\" = C.\"ItmsGrpCod\" INNER JOIN OPRC D ON B.\"U_beas_prccode\" = D.\"PrcCode\" WHERE A.\"U_IsDeleted\" = 0 AND A.\"U_Status\" LIKE 1 AND A.\"U_Barcode\" LIKE '{0}'", r1["RawData"]));
                    if (itemID.Rows.Count == 0)
                        continue;
                    if (r["ItemID"].ToString() == itemID.Rows[0]["ItemID"].ToString() && r1["Tanda"] == DBNull.Value)
                    {
                        //DBConnection.oDraft.Lines.BatchNumbers.SetCurrentLine(0);
                        //DBConnection.oDraft.Lines.BinAllocations.SerialAndBatchNumbersBaseLine = i;
                        DBConnection.oDraft.Lines.BatchNumbers.ManufacturerSerialNumber = DBConnection.manBatchNumber;
                        DBConnection.oDraft.Lines.BatchNumbers.InternalSerialNumber = DBConnection.interSerNumber;
                        DBConnection.oDraft.Lines.BatchNumbers.BatchNumber = r1["RawData"].ToString();
                        barcode = barcode + "'" + r1["RawData"].ToString() + "',";
                        #region Not Used
                        //if (itemID.Rows[0]["TypeItem"].ToString().Substring(0, 3) == "PET")
                        //{
                        //    DBConnection.oDraft.Lines.BatchNumbers.Quantity = (int)Math.Floor((Convert.ToDouble(itemID.Rows[0]["Thick"]) * Convert.ToDouble(itemID.Rows[0]["Width"]) * Convert.ToDouble(itemID.Rows[0]["Length"]) * 1.4 / 1000000) / 1);

                        //}
                        //else
                        //{
                        //    DBConnection.oDraft.Lines.BatchNumbers.Quantity = (int)Math.Floor((Convert.ToDouble(itemID.Rows[0]["Thick"]) * Convert.ToDouble(itemID.Rows[0]["Width"]) * Convert.ToDouble(itemID.Rows[0]["Length"]) * 1.6 / 1000000) / 1);
                        //}
                        #endregion
                        DBConnection.oDraft.Lines.BatchNumbers.Quantity = Convert.ToDouble(itemID.Rows[0]["Weight"]);
                        //DBConnection.oDraft.Lines.BatchNumbers.BaseLineNumber = Convert.ToInt32(r["LineNum"]);
                        DBConnection.oDraft.Lines.BatchNumbers.BaseLineNumber = x;
                        DBConnection.oDraft.Lines.BatchNumbers.SetCurrentLine(i);
                        DBConnection.oDraft.Lines.BatchNumbers.Add();
                        r1["Tanda"] = "1";
                        if (i + 1 == DBConnection.totalNumber)
                            break;
                        i++;
                    }
                }
                x++;
                DBConnection.oDraft.Lines.Add();
            }

            DBConnection.RetVal = DBConnection.oDraft.Update();

            DBConnection.oDraft.GetByKey(Convert.ToInt32(datatable.Rows[0]["DocEntry"]));

            DBConnection.RetVal = DBConnection.oDraft.SaveDraftToDocument();
            string temp_string = DBConnection.tempStr;
            DBConnection.oCompany.GetNewObjectCode(out temp_string);
            if (DBConnection.RetVal != 0)
            {
                int temp_int = DBConnection.ErrCode;
                string temp_string2 = DBConnection.ErrMsg;
                DBConnection.oCompany.GetLastError(out temp_int, out temp_string2);
                MessageBox.Show("Delivery Order Fail " + temp_int + " " + temp_string2);
            }
            else
            {
                Utility.GetObjects(string.Format("UPDATE \"@ITEMDETAIL\" SET \"U_Status\" = '-1' WHERE CAST(\"U_Barcode\" AS VARCHAR(40)) IN ({0})", barcode.Substring(0, barcode.Length - 1)));
            }
            return null;
        }

        public static DataTable insertRetur(DataTable table1, DataTable table2)
        {
            DBConnection.oRetur = (SAPbobsCOM.Documents)DBConnection.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oReturns);
            int i;
            int j = 0;
            string barcode = "";
            foreach (DataRow r in table2.Rows)
            {
                DBConnection.totalNumber = (int)(System.Convert.ToDouble(r["QtySystem"]));
                DBConnection.oRetur.Lines.SetCurrentLine(j);
                i = 0;
                foreach (DataRow r1 in table1.Rows)
                {
                    var itemID = Utility.GetObjects(string.Format("SELECT A.\"U_ItemID\" AS \"ItemID\", C.\"U_idu_prd\" AS \"TypeItem\", \"U_Thick1\" AS Thick, \"U_Width1\" AS Width, \"U_Length1\" AS Length, B.\"SWeight1\" AS \"Weight\", B.\"U_beas_prccode\" AS \"CostCenter\", D.\"U_idu_dept\" AS \"Department\" FROM \"@ITEMDETAIL\" A INNER JOIN OITM B ON \"U_ItemID\" = B.\"ItemCode\" INNER JOIN OITB C ON B.\"ItmsGrpCod\" = C.\"ItmsGrpCod\" INNER JOIN OPRC D ON B.\"U_beas_prccode\" = D.\"PrcCode\" WHERE A.\"U_IsDeleted\" = 0 AND A.\"U_Barcode\" LIKE '{0}'", r1["RawData"]));
                    if (itemID.Rows.Count == 0)
                        continue;
                    if (r["ItemID"].ToString() == itemID.Rows[0]["ItemID"].ToString())
                    {
                        DBConnection.oRetur.Lines.BatchNumbers.ManufacturerSerialNumber = DBConnection.manBatchNumber;
                        DBConnection.oRetur.Lines.BatchNumbers.InternalSerialNumber = DBConnection.interSerNumber;
                        DBConnection.oRetur.Lines.BatchNumbers.BatchNumber = r1["RawData"].ToString();//DBConnection.batchNum + i.ToString();
                        barcode = barcode + "'" + r1["RawData"].ToString() + "',";
                        #region Not Used
                        //if (itemID.Rows[0]["TypeItem"].ToString() == "PET")
                        //{
                        //    DBConnection.oRetur.Lines.BatchNumbers.Quantity = (int)Math.Floor((Convert.ToDouble(itemID.Rows[0]["Thick"]) * Convert.ToDouble(itemID.Rows[0]["Width"]) * Convert.ToDouble(itemID.Rows[0]["Length"]) * 1.4 / 1000000) / 1);
                        //    DBConnection.oRetur.Lines.Quantity = (int)Math.Floor((Convert.ToDouble(itemID.Rows[0]["Thick"]) * Convert.ToDouble(itemID.Rows[0]["Width"]) * Convert.ToDouble(itemID.Rows[0]["Length"]) * 1.4 / 1000000) / 1);
                        //}
                        //else
                        //{
                        //    DBConnection.oRetur.Lines.BatchNumbers.Quantity = (int)Math.Floor((Convert.ToDouble(itemID.Rows[0]["Thick"]) * Convert.ToDouble(itemID.Rows[0]["Width"]) * Convert.ToDouble(itemID.Rows[0]["Length"]) * 1.6 / 1000000) / 1);
                        //    DBConnection.oRetur.Lines.Quantity = (int)Math.Floor((Convert.ToDouble(itemID.Rows[0]["Thick"]) * Convert.ToDouble(itemID.Rows[0]["Width"]) * Convert.ToDouble(itemID.Rows[0]["Length"]) * 1.6 / 1000000) / 1);
                        //}
                        #endregion
                        DBConnection.oRetur.Lines.BatchNumbers.Quantity = Convert.ToDouble(itemID.Rows[0]["Weight"]);
                        DBConnection.oRetur.Lines.Quantity = Convert.ToDouble(itemID.Rows[0]["Weight"]);
                        DBConnection.oRetur.Lines.CostingCode = itemID.Rows[0]["CostCenter"].ToString();
                        DBConnection.oRetur.Lines.CostingCode2 = itemID.Rows[0]["Department"].ToString();
                        //DBConnection.oRetur.Lines.BatchNumbers.Quantity = 1;
                        DBConnection.oRetur.Lines.BatchNumbers.BaseLineNumber = Convert.ToInt32(r["LineNum"]);
                        DBConnection.oRetur.Lines.BatchNumbers.SetCurrentLine(i);
                        DBConnection.oRetur.Lines.BatchNumbers.Add();
                        if (i + 1 == DBConnection.totalNumber)
                            break;
                        i++;
                    }
                }
                //DBConnection.oRetur.Lines.Quantity = Convert.ToDouble(r["QtySystem"]);
                DBConnection.oRetur.Lines.ItemCode = r["ItemCode"].ToString();//DBConnection.oItems.ItemCode;
                DBConnection.oRetur.Lines.ItemDescription = r["ItemName"].ToString(); //DBConnection.oItems.ItemName;
                DBConnection.oRetur.Lines.ShipDate = DateTime.Now;
                DBConnection.oRetur.Lines.WarehouseCode = r["WhsCode"].ToString();
                //DBConnection.oRetur.Lines.UoMCode = 1;
                DBConnection.oRetur.Lines.UoMEntry = 1;
                DBConnection.oRetur.Comments = "Add_On";
                DBConnection.oRetur.Lines.UnitsOfMeasurment = Convert.ToDouble(1);
                DBConnection.oRetur.CardCode = r["CardCode"].ToString();
                DBConnection.oRetur.Lines.Add();
                j++;
            }
            DBConnection.RetVal = DBConnection.oRetur.Add();
            if (DBConnection.RetVal == 0)
            {
                Utility.GetObjects(string.Format("UPDATE \"@ITEMDETAIL\" SET \"U_Status\" = '1' WHERE CAST(\"U_Barcode\" AS VARCHAR(40)) IN ({0})", barcode.Substring(0, barcode.Length - 1)));
            }
            else
            {
                int temp_int = DBConnection.ErrCode;
                string temp_string2 = DBConnection.ErrMsg;
                DBConnection.oCompany.GetLastError(out temp_int, out temp_string2);
                //MessageBox.Show("Goods Received AND Item Transfer Fail. Barcode : " + barcode + " " + temp_int + " " + temp_string2);
                MessageBox.Show(temp_int + " " + temp_string2);
            }
            return null;
        }
        public static DataTable hanaConnection(string sql)
        {
            DataTable dt = new DataTable();
            HanaConnection conn = new HanaConnection(string.Format("Server={0};UserID={1};Password={2}", ConfigurationManager.AppSettings["SAPServer"], ConfigurationManager.AppSettings["SAPUsername"], ConfigurationManager.AppSettings["SAPPassword"]));
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(conn.State.ToString());
            }
            HanaDataAdapter dataAdapter = new HanaDataAdapter(sql, conn);
            try
            {
                dataAdapter.Fill(dt);
            }
            catch (Exception e)
            {
                dt = null;
                MessageBox.Show("Error Hana Connection");
            }
            conn.Close();

            return dt;

        }
        public static DataTable GetObjects(string sql)
        {
            var rs = (SAPbobsCOM.Recordset)DBConnection.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            rs.DoQuery(sql);

            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter();
            DataTable dt = new DataTable();

            for (int i = 0; i < ((dynamic)rs.Fields).Count; i++)
            {
                if (dt.Columns[rs.Fields.Item(i).Name] == null) dt.Columns.Add(rs.Fields.Item(i).Name);

            }

            while (!(rs.EoF))
            {
                var newrow = dt.NewRow();
                for (int i = 0; i < ((dynamic)rs.Fields).Count; i++)
                {
                    newrow[rs.Fields.Item(i).Name] = rs.Fields.Item(i).Value;
                }

                dt.Rows.Add(newrow);
                rs.MoveNext();
            }

            return dt;
        }

        public static void ConnectDB()
        {
            //LOCAL
            //DBConnection.conn = new System.Data.SqlClient.SqlConnection(GetConnectionString());
            //DBConnection.conn.Open();
            //return;

            DBConnection.oCompany = new SAPbobsCOM.Company();

            DBConnection.oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB ;
            DBConnection.oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English; // change to your language
            DBConnection.oCompany.UseTrusted = false;

            DBConnection.oCompany.Server = ConfigurationManager.AppSettings["SAPServer"]; // change to your company server
            DBConnection.oCompany.DbUserName = ConfigurationManager.AppSettings["SAPUsername"];
            DBConnection.oCompany.DbPassword = ConfigurationManager.AppSettings["SAPPassword"];
        }

        public static bool ValidateLogin(string username, string password)
        {
            //LOCAL
            //return true;

            if (DBConnection.oCompany == null) ConnectDB();

            DBConnection.oCompany.CompanyDB = ConfigurationManager.AppSettings["SAPDatabase"];
            DBConnection.oCompany.UserName = username;
            DBConnection.oCompany.Password = password;

            //Try to connect
            var lRetCode = DBConnection.oCompany.Connect();

            if (lRetCode != 0) // if the connection failed
            {
                int temp_int = DBConnection.ErrCode;
                string temp_string2 = DBConnection.ErrMsg;
                DBConnection.oCompany.GetLastError(out temp_int, out temp_string2);

                Interaction.MsgBox("Connection Failed", MsgBoxStyle.Exclamation, "Default Connection Failed");
                return false;
            }
            if (DBConnection.oCompany.Connected) // if connected
            {
                return true;
                //LoadGui(); // Load data for UI elements like combo boxes
            }
            return false;
        }

        public static string GetConnectionString(string server = "", string serverType = "", string database = "", string userID = "", string password = "")
        {
            if (string.IsNullOrEmpty(server))
                server = ConfigurationManager.AppSettings["Server"];
            if (string.IsNullOrEmpty(serverType))
                serverType = ConfigurationManager.AppSettings["ServerType"];
            if (string.IsNullOrEmpty(database))
                database = ConfigurationManager.AppSettings["Database"];
            if (string.IsNullOrEmpty(userID))
                userID = ConfigurationManager.AppSettings["UserID"];
            if (string.IsNullOrEmpty(password))
                password = ConfigurationManager.AppSettings["Password"];
            if (string.IsNullOrEmpty(server))
                return "";
            if (!string.IsNullOrEmpty(serverType) && !serverType.StartsWith("\\"))
                serverType = "\\" + serverType;

            if (string.IsNullOrEmpty(userID))
                return string.Format("Data Source=\"{0}{1}\"; Integrated Security=\"True\"; Initial Catalog=\"{2}\"; MultipleActiveResultSets=\"True\";", (object)server, (object)serverType, (object)database);
            return string.Format("Data Source=\"{0}{1}\"; Integrated Security=\"False\"; Initial Catalog=\"{2}\"; User ID=\"{3}\"; Password=\"{4}\"; MultipleActiveResultSets=\"True\";", (object)server, (object)serverType, (object)database, (object)userID, (object)password);
        }

        public static DataRow GetObject(string fields, string tableName, string condition, string groupBy, string having, string orderBy, SqlConnection conn = null, SqlTransaction trans = null)
        {
            using (DataTable objects = Utility.GetObjects(fields, tableName, condition, groupBy, having, orderBy, conn, trans, 0))
            {
                if (objects != null && objects.Rows.Count > 0)
                    return objects.Rows[0];
                return (DataRow)null;
            }
        }

        public static DataTable GetObjects(string fields, string tableName, string condition, string groupBy, string having, string orderBy, SqlConnection conn, SqlTransaction trans = null, int timeout = 0)
        {
            bool flag = false;
            SqlCommand selectCommand = (SqlCommand)null;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    flag = true;
                }
                selectCommand = new SqlCommand();
                selectCommand.Connection = conn;
                selectCommand.Transaction = trans;
                selectCommand.CommandText = string.Format("SELECT {0} FROM {1}", (object)fields, (object)tableName);
                if (!string.IsNullOrEmpty(condition))
                    selectCommand.CommandText = string.Format("{0} WHERE {1}", (object)selectCommand.CommandText, (object)condition);
                if (!string.IsNullOrEmpty(groupBy))
                    selectCommand.CommandText = string.Format("{0} GROUP BY {1}", (object)selectCommand.CommandText, (object)groupBy);
                if (!string.IsNullOrEmpty(having))
                    selectCommand.CommandText = string.Format("{0} HAVING {1}", (object)selectCommand.CommandText, (object)condition);
                if (!string.IsNullOrEmpty(orderBy))
                    selectCommand.CommandText = string.Format("{0} ORDER BY {1}", (object)selectCommand.CommandText, (object)orderBy);
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                    sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (flag)
                    conn.Close();
                if (selectCommand != null)
                    selectCommand.Dispose();
            }
        }

        public static object FindObject(string field, string tableName, string condition, string groupBy, string having, string orderBy, SqlConnection conn, SqlTransaction trans = null, int timeout = -1)
        {
            bool flag = false;
            SqlCommand sqlCommand = (SqlCommand)null;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    flag = true;
                }
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.Transaction = trans;
                if (timeout > -1)
                    sqlCommand.CommandTimeout = timeout;
                if (!field.Trim().ToUpper().StartsWith("TOP 1"))
                    field = string.Format("TOP 1 {0}", (object)field);
                sqlCommand.CommandText = string.Format("SELECT {0}", (object)field);
                if (!string.IsNullOrEmpty(tableName))
                    sqlCommand.CommandText = string.Format("{0} FROM {1}", (object)sqlCommand.CommandText, (object)tableName);
                if (!string.IsNullOrEmpty(condition))
                    sqlCommand.CommandText = string.Format("{0} WHERE {1}", (object)sqlCommand.CommandText, (object)condition);
                if (!string.IsNullOrEmpty(groupBy))
                    sqlCommand.CommandText = string.Format("{0} GROUP BY {1}", (object)sqlCommand.CommandText, (object)groupBy);
                if (!string.IsNullOrEmpty(having))
                    sqlCommand.CommandText = string.Format("{0} HAVING {1}", (object)sqlCommand.CommandText, (object)condition);
                if (!string.IsNullOrEmpty(orderBy))
                    sqlCommand.CommandText = string.Format("{0} ORDER BY {1}", (object)sqlCommand.CommandText, (object)orderBy);
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (flag)
                    conn.Close();
                if (sqlCommand != null)
                    sqlCommand.Dispose();
            }
        }
        public static DataTable GetObjects(string commandText, SqlConnection conn, SqlTransaction trans = null, int timeout = 0)
        {
            bool flag = false;
            SqlCommand selectCommand = (SqlCommand)null;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    flag = true;
                }
                selectCommand = new SqlCommand();
                selectCommand.Connection = conn;
                selectCommand.Transaction = trans;
                selectCommand.CommandText = commandText;
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                    sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (flag)
                    conn.Close();
                if (selectCommand != null)
                    selectCommand.Dispose();
            }
        }

        public static void StartService()
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Program Files (x86)\CASIO\LMWIN\lmwin32.exe");
            p.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\CASIO\LMWIN\lmwin32.exe";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();

            System.Threading.Thread.Sleep(10000);
        }

        public static DataTable GenerateData(DataTable tableDetail, string type)
        {
            tableDetail.Clear();

            var reader = new StreamReader(ConfigurationManager.AppSettings["ResultDAT"]);
            if (tableDetail.Columns["Type"] == null) tableDetail.Columns.Add("Type", typeof(string));
            if (tableDetail.Columns["Job"] == null) tableDetail.Columns.Add("Job", typeof(string));
            if (tableDetail.Columns["RawData"] == null) tableDetail.Columns.Add("RawData", typeof(string));

            while (!reader.EndOfStream)
            {
                var str = reader.ReadLine().ToString();
                var temp = str.Split('^');
                var newrow = tableDetail.NewRow();

                newrow["Type"] = type;
                newrow["Job"] = type == "IN" ? "IN" : str.ToString().Substring(2).Substring(0, 3);//temp[1]
                //newrow["RawData"] = str;
                newrow["RawData"] = type == "IN" ? str.ToString().Substring(2) : str.ToString().Substring(6);
                if (type == "IN")
                {
                    if (str.ToString().Substring(2).Length > 11)
                    {
                        MessageBox.Show(str.ToString().Substring(2) + " Lebih Dari 11 Digit");
                        tableDetail.Rows.Clear();
                        return tableDetail;
                    }
                }
                else
                {
                    if (str.ToString().Substring(2).Substring(0, 3) == "111")
                    {
                        newrow["Job"] = "Polyesther Factory";
                    }
                    else if (str.ToString().Substring(2).Substring(0, 3) == "222")
                    {
                        newrow["Job"] = "Nylon Film Factory";
                    }
                    else if (str.ToString().Substring(2).Substring(0, 3) == "333")
                    {
                        newrow["Job"] = "Nylon Film 2 Factory";
                    }
                        if (str.ToString().Substring(6).Length > 11)
                    {
                        MessageBox.Show(str.ToString().Substring(6) + " Lebih Dari 11 Digit");
                        tableDetail.Rows.Clear();
                        return tableDetail;
                    }
                }

                tableDetail.Rows.Add(newrow);
            }
            
            reader.Close();

            return tableDetail;
        }

        public static DataTable GeneratePrintData(string cmdText, string oid, SqlConnection conn = null)
        {
            bool flag = false;
            SqlCommand selectCommand = (SqlCommand)null;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    flag = true;
                }
                selectCommand = new SqlCommand();
                selectCommand.Connection = conn;
                selectCommand.CommandTimeout = 120;
                selectCommand.CommandText = cmdText;
                selectCommand.Parameters.Add("@Oid", SqlDbType.VarChar).Value = (object)oid;
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                    sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("Data Access Failure! Msg: " + ex.Message);
            }
            finally
            {
                if (flag)
                    conn.Close();
                if (selectCommand != null)
                    selectCommand.Dispose();
            }
        }

        public static void Print(string printCode, string oid, bool directPrint = false)
        {
            try
            {
                var obj = Utility.hanaConnection(string.Format("SELECT \"Name\", \"QUERY\" AS \"SQLQuery\", \"LAYOUT\" AS \"LAYOUT\" FROM {1}.\"@PRINTDOCUMENT\" WHERE \"Name\" LIKE '{0}' AND \"U_IsDeleted\" = 0", printCode, ConfigurationManager.AppSettings["SAPDatabase"]));
                if (obj.Rows.Count == 0)
                    throw new Exception("No Layout");
                DataRow dataRow = obj.Rows[0];

                //DataRow dataRow = Utility.GetObject("Name, SQLQuery, Layout", "PrintDocument", string.Format("Name= '{0}'", (object)printCode), "", "", "", Helper.DBConnection.conn);
                if (dataRow == null)
                    throw new Exception("No Document");
                if (dataRow["SQLQuery"] == null || dataRow["SQLQuery"] == DBNull.Value)
                {
                    int num1 = (int)XtraMessageBox.Show("No Result", "Kolon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (dataRow["Layout"] == null || dataRow["Layout"] == DBNull.Value)
                {
                    int num2 = (int)XtraMessageBox.Show("No Layout", "Kolon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string cmdText = Encoding.ASCII.GetString((byte[])dataRow["SQLQuery"]);
                    if (string.IsNullOrEmpty(cmdText))
                    {
                        int num3 = (int)XtraMessageBox.Show("No Result", "Kolon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        new XtraReport().LoadLayout((Stream)new MemoryStream((byte[])dataRow["Layout"]));
                        DataTable printData = Utility.hanaConnection(string.Format(cmdText, oid));
                        if (printData == null || printData.Rows.Count <= 0)
                        {
                            int num4 = (int)XtraMessageBox.Show("No Result", "Kolon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            XtraReport report = new XtraReport();
                            report.LoadLayout((Stream)new MemoryStream((byte[])dataRow["Layout"]));
                            report.DataSource = (object)printData;
                            report.DataMember = printData.TableName;
                            report.ShowPrintMarginsWarning = false;
                            report.PrintingSystem.ShowMarginsWarning = false;
                            report.CreateDocument(true);

                            if (directPrint)
                                report.Print();
                            else
                                report.ShowPreviewDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                int num = (int)XtraMessageBox.Show(string.Format("{0}\\r\\n{1}", (object)ex.Message, ex.InnerException == null ? (object)string.Empty : (object)ex.InnerException.Message), "Kolon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
