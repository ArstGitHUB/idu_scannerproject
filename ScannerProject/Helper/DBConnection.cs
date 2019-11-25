using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace ScannerProject.Helper
{
    sealed class DBConnection
    {
        public static DataTable TableLines; // the datasource of the datagrid called DataLines.
        public static SAPbobsCOM.Documents oOrder; // Order object
        public static SAPbobsCOM.Documents oInvGenEntry;
        public static SAPbobsCOM.StockTransfer  oStockTransfer;
        public static SAPbobsCOM.Documents oInvoice; // Invoice Object
        public static SAPbobsCOM.Documents oRetur; // Retur Object
        public static SAPbobsCOM.Documents oDelivery; // Delivery Object
        public static SAPbobsCOM.Documents oDraft; // Draft Object
        public static SAPbobsCOM.Recordset oRecordSet; // A recordset object
        public static SAPbobsCOM.Company oCompany; // The company object
        public static bool flagBatch;
        public static string manBatchNumber;
        public static int totalNumber;
        public static string interSerNumber;
        public static string batchNum;

        public static bool flag;
        public static string tempStr = null;
        public static string manSerialNumber;
        public static SAPbobsCOM.Items oItems;
        public static int RetVal;
        public static string ErrMsg;
        public static int ErrCode;


        public static SqlConnection conn;
    }
}
