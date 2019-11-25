using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraLayout;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ScannerProject
{
    partial class LabelList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelList));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lc = new DevExpress.XtraLayout.LayoutControl();
            this.sbSelect = new DevExpress.XtraEditors.SimpleButton();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.lcg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnl = new DevExpress.XtraEditors.PanelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).BeginInit();
            this.lc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(877, 34);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // lc
            // 
            this.lc.Controls.Add(this.sbSelect);
            this.lc.Controls.Add(this.gc);
            this.lc.Controls.Add(this.sbAddNew);
            this.lc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc.Location = new System.Drawing.Point(0, 34);
            this.lc.Name = "lc";
            this.lc.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1107, 664, 500, 700);
            this.lc.Root = this.lcg;
            this.lc.Size = new System.Drawing.Size(877, 661);
            this.lc.TabIndex = 2;
            this.lc.Text = "layoutControl1";
            // 
            // sbSelect
            // 
            this.sbSelect.Image = ((System.Drawing.Image)(resources.GetObject("sbSelect.Image")));
            this.sbSelect.Location = new System.Drawing.Point(16, 618);
            this.sbSelect.Margin = new System.Windows.Forms.Padding(2);
            this.sbSelect.Name = "sbSelect";
            this.sbSelect.Size = new System.Drawing.Size(419, 27);
            this.sbSelect.StyleController = this.lc;
            this.sbSelect.TabIndex = 7;
            this.sbSelect.Text = "Select";
            this.sbSelect.Click += new System.EventHandler(this.sbSelect_Click);
            // 
            // gc
            // 
            this.gc.Location = new System.Drawing.Point(16, 16);
            this.gc.MainView = this.gv;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(845, 596);
            this.gc.TabIndex = 6;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colGroup});
            this.gv.GridControl = this.gc;
            this.gv.GroupCount = 1;
            this.gv.Name = "gv";
            this.gv.OptionsFind.AlwaysVisible = true;
            this.gv.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gv.OptionsView.ShowGroupPanel = false;
            this.gv.OptionsView.ShowIndicator = false;
            this.gv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroup, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.OptionsColumn.TabStop = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colGroup
            // 
            this.colGroup.Caption = "Group";
            this.colGroup.FieldName = "Group";
            this.colGroup.Name = "colGroup";
            this.colGroup.OptionsColumn.AllowEdit = false;
            this.colGroup.OptionsColumn.AllowFocus = false;
            this.colGroup.OptionsColumn.ReadOnly = true;
            this.colGroup.OptionsColumn.TabStop = false;
            this.colGroup.Visible = true;
            this.colGroup.VisibleIndex = 1;
            // 
            // sbAddNew
            // 
            this.sbAddNew.Image = ((System.Drawing.Image)(resources.GetObject("sbAddNew.Image")));
            this.sbAddNew.Location = new System.Drawing.Point(441, 618);
            this.sbAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.sbAddNew.Name = "sbAddNew";
            this.sbAddNew.Size = new System.Drawing.Size(420, 27);
            this.sbAddNew.StyleController = this.lc;
            this.sbAddNew.TabIndex = 5;
            this.sbAddNew.Text = "Cancel";
            this.sbAddNew.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // lcg
            // 
            this.lcg.CustomizationFormText = "lcg";
            this.lcg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcg.GroupBordersVisible = false;
            this.lcg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.lcg.Location = new System.Drawing.Point(0, 0);
            this.lcg.Name = "Root";
            this.lcg.Size = new System.Drawing.Size(877, 661);
            this.lcg.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(851, 602);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbAddNew;
            this.layoutControlItem2.Location = new System.Drawing.Point(425, 602);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(426, 33);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbSelect;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 602);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(425, 33);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // pnl
            // 
            this.pnl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl.Location = new System.Drawing.Point(0, 695);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(877, 0);
            this.pnl.TabIndex = 3;
            this.pnl.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LabelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 695);
            this.Controls.Add(this.lc);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LabelList";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).EndInit();
            this.lc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private IContainer components = (IContainer)null;
        public BaseEdit firstController;
        private DXValidationProvider dxValidationProvider;
        protected LayoutControl lc;
        protected LayoutControlGroup lcg;
        protected PanelControl pnl;
        protected RibbonControl ribbon;
        private ContextMenuStrip contextMenuStrip1;
        private SimpleButton sbAddNew;
        private LayoutControlItem layoutControlItem2;
        private SimpleButton sbSelect;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private LayoutControlItem layoutControlItem1;
        private LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup;
    }
}