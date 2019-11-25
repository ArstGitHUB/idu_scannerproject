using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

using ScannerProject.Helper;

namespace ScannerProject
{
    public partial class InventoryTransferView : UserControl
    {
        DataTable tableDetail = new DataTable();
        public InventoryTransferView()
        {
            InitializeComponent();
            
        }
        
        private void sbGenerate_Click(object sender, EventArgs e)
        {
            sbGenerate.Enabled = false;

            Utility.StartService();

            sbGenerate.Enabled = true;

            gridControl2.DataSource = Utility.GenerateData(tableDetail, "IN");
            
        }
    }
}
