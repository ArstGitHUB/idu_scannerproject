using Sap.Data.Hana;
using ScannerProject.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerProject.Model
{
    public static class PrintDocumentModel
    {
        public static string InsertUpdatePrintDocument(string name, string group,
            string sqlQuery, string printDocumentID,
            DateTime? modifiedDate = null)
        {
            var cmd = "";
            var isInsert = false;
            if (printDocumentID == "" || printDocumentID == "0")
            {
                var printID = Utility.hanaConnection(string.Format("SELECT TOP 1 \"Code\" FROM {0}.\"@PRINTDOCUMENT\" ORDER BY \"Code\" * 1 DESC", System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]));
                if (printID == null)
                    printDocumentID = "1";
                else
                {
                    if (printID.Rows.Count == 0)
                    {
                        printDocumentID = "1";
                    }
                    else
                    {
                        printDocumentID = (Convert.ToDecimal(printID.Rows[0]["Code"]) + 1).ToString();
                    }
                }

                HanaConnection conn = new HanaConnection(string.Format("Server={0};UserID={1};Password={2}", ConfigurationManager.AppSettings["SAPServer"], ConfigurationManager.AppSettings["SAPUsername"], ConfigurationManager.AppSettings["SAPPassword"]));
                conn.Open();
                HanaCommand insertCmd = new HanaCommand(string.Format("INSERT INTO {0}.\"@PRINTDOCUMENT\" (\"Name\", \"QUERY\", \"Code\", \"GROUP\", \"PRINTNAME\", \"U_IsDeleted\") VALUES ( ?, ?, ?, ?, ?, 0)", System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]), conn);
                HanaParameter parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarChar;
                insertCmd.Parameters.Add(parm);
                parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarBinary;
                insertCmd.Parameters.Add(parm);
                parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarChar;
                insertCmd.Parameters.Add(parm);
                parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarChar;
                insertCmd.Parameters.Add(parm);
                parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarChar;
                insertCmd.Parameters.Add(parm);

                insertCmd.Parameters[0].Value = group + ' ' + name;
                insertCmd.Parameters[1].Value = System.Text.Encoding.ASCII.GetBytes(sqlQuery);
                insertCmd.Parameters[2].Value = printDocumentID;
                insertCmd.Parameters[3].Value = group;
                insertCmd.Parameters[4].Value = name;
                int recordsAffected = insertCmd.ExecuteNonQuery();
                conn.Close();

                isInsert = true;
            }
            else
            {
                HanaConnection conn = new HanaConnection(string.Format("Server={0};UserID={1};Password={2}", ConfigurationManager.AppSettings["SAPServer"], ConfigurationManager.AppSettings["SAPUsername"], ConfigurationManager.AppSettings["SAPPassword"]));
                conn.Open();
                HanaCommand insertCmd = new HanaCommand(string.Format("UPDATE {0}.\"@PRINTDOCUMENT\" SET \"Name\" = ?, \"QUERY\" = ?, \"GROUP\" = ?, \"PRINTNAME\" = ? WHERE \"Code\" = ?", System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]), conn);
                HanaParameter parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarChar;
                insertCmd.Parameters.Add(parm);
                parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarBinary;
                insertCmd.Parameters.Add(parm);
                parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarChar;
                insertCmd.Parameters.Add(parm);
                parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarChar;
                insertCmd.Parameters.Add(parm);
                parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarChar;
                insertCmd.Parameters.Add(parm);

                insertCmd.Parameters[0].Value = group + ' ' + name;
                insertCmd.Parameters[1].Value = System.Text.Encoding.ASCII.GetBytes(sqlQuery);
                insertCmd.Parameters[2].Value = group;
                insertCmd.Parameters[3].Value = name;
                insertCmd.Parameters[4].Value = printDocumentID;
                int recordsAffected = insertCmd.ExecuteNonQuery();
                conn.Close();
            }

            if (isInsert)
            {
                var obj = Utility.hanaConnection(string.Format("SELECT \"Code\" FROM {1}.\"@PRINTDOCUMENT\" WHERE \"U_IsDeleted\" = 0 AND \"Name\" LIKE '{0}'", group + ' ' + name, System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]));
                printDocumentID = obj == null || obj.Rows.Count == 0 ? "0" : obj.Rows[0]["Code"].ToString();
            }
            return printDocumentID;
        }

        public static void SaveLayout(System.IO.MemoryStream stream, string id)
        {
            try
            {
                HanaConnection conn = new HanaConnection(string.Format("Server={0};UserID={1};Password={2}", ConfigurationManager.AppSettings["SAPServer"], ConfigurationManager.AppSettings["SAPUsername"], ConfigurationManager.AppSettings["SAPPassword"]));
                conn.Open();
                HanaCommand insertCmd = new HanaCommand(string.Format("UPDATE {0}.\"@PRINTDOCUMENT\" SET \"LAYOUT\" = ? WHERE \"Code\" LIKE ?", System.Configuration.ConfigurationManager.AppSettings["SAPDatabase"]), conn);
                HanaParameter parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarBinary;
                insertCmd.Parameters.Add(parm);
                parm = new HanaParameter();
                parm.HanaDbType = HanaDbType.VarChar;
                insertCmd.Parameters.Add(parm);

                insertCmd.Parameters[0].Value = stream.ToArray();
                insertCmd.Parameters[1].Value = id;
                int recordsAffected = insertCmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void deletePrintDocument(string printDocumentID)
        {

        }
    }
}
