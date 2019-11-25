namespace ScannerProject
{
    partial class BarcodePaletView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodePaletView));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.sbAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colBarcodeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKindOfLabel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sbExport = new DevExpress.XtraEditors.SimpleButton();
            this.lciExport = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExport)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(105, 77);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup1.Size = new System.Drawing.Size(105, 77);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.sbExport);
            this.layoutControl2.Controls.Add(this.sbAddNew);
            this.layoutControl2.Controls.Add(this.gc);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(876, 540, 500, 700);
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(748, 636);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // sbAddNew
            // 
            this.sbAddNew.Image = ((System.Drawing.Image)(resources.GetObject("sbAddNew.Image")));
            this.sbAddNew.Location = new System.Drawing.Point(13, 13);
            this.sbAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.sbAddNew.Name = "sbAddNew";
            this.sbAddNew.Size = new System.Drawing.Size(205, 27);
            this.sbAddNew.StyleController = this.layoutControl2;
            this.sbAddNew.TabIndex = 5;
            this.sbAddNew.Text = "Add New";
            this.sbAddNew.Click += new System.EventHandler(this.sbAddNew_Click);
            // 
            // gc
            // 
            this.gc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gc.Location = new System.Drawing.Point(13, 46);
            this.gc.MainView = this.gv;
            this.gc.Margin = new System.Windows.Forms.Padding(2);
            this.gc.Name = "gc";
            this.gc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDelete});
            this.gc.Size = new System.Drawing.Size(722, 577);
            this.gc.TabIndex = 4;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAction,
            this.colBarcodeID,
            this.colSerialNumber,
            this.colKindOfLabel,
            this.colItemName,
            this.colBarcode});
            this.gv.GridControl = this.gc;
            this.gv.Name = "gv";
            this.gv.OptionsFind.AlwaysVisible = true;
            this.gv.OptionsFind.ShowClearButton = false;
            this.gv.OptionsFind.ShowCloseButton = false;
            this.gv.OptionsView.ShowGroupPanel = false;
            this.gv.OptionsView.ShowIndicator = false;
            this.gv.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // colAction
            // 
            this.colAction.Caption = "gridColumn1";
            this.colAction.ColumnEdit = this.repDelete;
            this.colAction.Name = "colAction";
            this.colAction.OptionsColumn.FixedWidth = true;
            this.colAction.OptionsColumn.ReadOnly = true;
            this.colAction.OptionsColumn.ShowCaption = false;
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 0;
            this.colAction.Width = 35;
            // 
            // repDelete
            // 
            this.repDelete.AutoHeight = false;
            this.repDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repDelete.Name = "repDelete";
            this.repDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repDelete_ButtonClick);
            // 
            // colBarcodeID
            // 
            this.colBarcodeID.Caption = "Barcode ID";
            this.colBarcodeID.FieldName = "BarcodeID";
            this.colBarcodeID.Name = "colBarcodeID";
            this.colBarcodeID.OptionsColumn.AllowFocus = false;
            this.colBarcodeID.OptionsColumn.ReadOnly = true;
            this.colBarcodeID.OptionsColumn.ShowCaption = false;
            this.colBarcodeID.OptionsColumn.TabStop = false;
            this.colBarcodeID.Width = 591;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Caption = "Serial Number";
            this.colSerialNumber.FieldName = "SerialNumber";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.OptionsColumn.AllowFocus = false;
            this.colSerialNumber.OptionsColumn.ReadOnly = true;
            this.colSerialNumber.OptionsColumn.ShowCaption = false;
            this.colSerialNumber.OptionsColumn.TabStop = false;
            this.colSerialNumber.Width = 594;
            // 
            // colKindOfLabel
            // 
            this.colKindOfLabel.Caption = "Kind Of Label";
            this.colKindOfLabel.FieldName = "KindOfLabel";
            this.colKindOfLabel.Name = "colKindOfLabel";
            this.colKindOfLabel.OptionsColumn.AllowEdit = false;
            this.colKindOfLabel.OptionsColumn.AllowFocus = false;
            this.colKindOfLabel.OptionsColumn.ReadOnly = true;
            this.colKindOfLabel.OptionsColumn.TabStop = false;
            this.colKindOfLabel.Visible = true;
            this.colKindOfLabel.VisibleIndex = 2;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Item Name";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.OptionsColumn.AllowFocus = false;
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.OptionsColumn.TabStop = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "Barcode";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.OptionsColumn.AllowEdit = false;
            this.colBarcode.OptionsColumn.AllowFocus = false;
            this.colBarcode.OptionsColumn.ReadOnly = true;
            this.colBarcode.OptionsColumn.TabStop = false;
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 3;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.lciExport});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlGroup2.Size = new System.Drawing.Size(748, 636);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(728, 583);
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbAddNew;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(211, 33);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(211, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(366, 33);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // sbExport
            // 
            this.sbExport.Location = new System.Drawing.Point(590, 13);
            this.sbExport.Name = "sbExport";
            this.sbExport.Size = new System.Drawing.Size(145, 27);
            this.sbExport.StyleController = this.layoutControl2;
            this.sbExport.TabIndex = 6;
            this.sbExport.Text = "Excel";
            this.sbExport.Click += new System.EventHandler(this.sbExport_Click);
            // 
            // lciExport
            // 
            this.lciExport.Control = this.sbExport;
            this.lciExport.Location = new System.Drawing.Point(577, 0);
            this.lciExport.Name = "lciExport";
            this.lciExport.Size = new System.Drawing.Size(151, 33);
            this.lciExport.TextSize = new System.Drawing.Size(0, 0);
            this.lciExport.TextVisible = false;
            // 
            // BarcodePaletView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BarcodePaletView";
            this.Size = new System.Drawing.Size(748, 636);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.SimpleButton sbAddNew;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcodeID;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colKindOfLabel;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraEditors.SimpleButton sbExport;
        private DevExpress.XtraLayout.LayoutControlItem lciExport;
    }
}
