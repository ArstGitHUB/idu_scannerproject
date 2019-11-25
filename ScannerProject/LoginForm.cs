using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraLayout;
using DevExpress.XtraTab;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ScannerProject
{
    public partial class LoginForm : RibbonForm
    {
        public LoginForm()
        {
            this.InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //this.Text = "Mixtra Inti Tekindo";

            this.teUserName.EditValue = "";
            this.tePassword.EditValue = "";
        }
        void login()
        {
            if (CurrentUser.Login(teUserName.Text, tePassword.EditValue.ToString()))
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                return;
            }

            Interaction.MsgBox("Login Failed", MsgBoxStyle.Exclamation, "Login & Connection Failed");
        }

        private void sbLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void TePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
          
        }
    }
}
