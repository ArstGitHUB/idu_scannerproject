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
    partial class BarcodePrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodePrintForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lc = new DevExpress.XtraLayout.LayoutControl();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbDesigner = new DevExpress.XtraEditors.SimpleButton();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.meQuery = new DevExpress.XtraEditors.MemoEdit();
            this.lcg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciName = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciQuery = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnl = new DevExpress.XtraEditors.PanelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teGroup = new DevExpress.XtraEditors.TextEdit();
            this.lciGroup = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).BeginInit();
            this.lc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGroup)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(670, 34);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // lc
            // 
            this.lc.Controls.Add(this.teGroup);
            this.lc.Controls.Add(this.sbSave);
            this.lc.Controls.Add(this.sbDesigner);
            this.lc.Controls.Add(this.teName);
            this.lc.Controls.Add(this.meQuery);
            this.lc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc.Location = new System.Drawing.Point(0, 34);
            this.lc.Name = "lc";
            this.lc.Root = this.lcg;
            this.lc.Size = new System.Drawing.Size(670, 635);
            this.lc.TabIndex = 2;
            this.lc.Text = "layoutControl1";
            // 
            // sbSave
            // 
            this.sbSave.Location = new System.Drawing.Point(436, 49);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(218, 27);
            this.sbSave.StyleController = this.lc;
            this.sbSave.TabIndex = 20;
            this.sbSave.Text = "Save";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // sbDesigner
            // 
            this.sbDesigner.Image = ((System.Drawing.Image)(resources.GetObject("sbDesigner.Image")));
            this.sbDesigner.Location = new System.Drawing.Point(436, 16);
            this.sbDesigner.Margin = new System.Windows.Forms.Padding(7);
            this.sbDesigner.Name = "sbDesigner";
            this.sbDesigner.Size = new System.Drawing.Size(218, 27);
            this.sbDesigner.StyleController = this.lc;
            this.sbDesigner.TabIndex = 19;
            this.sbDesigner.Text = "Designer";
            this.sbDesigner.Click += new System.EventHandler(this.sbDesigner_Click);
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(62, 44);
            this.teName.Margin = new System.Windows.Forms.Padding(7);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(288, 22);
            this.teName.StyleController = this.lc;
            this.teName.TabIndex = 13;
            // 
            // meQuery
            // 
            this.meQuery.Location = new System.Drawing.Point(16, 101);
            this.meQuery.Margin = new System.Windows.Forms.Padding(7);
            this.meQuery.Name = "meQuery";
            this.meQuery.Properties.AcceptsTab = true;
            this.meQuery.Size = new System.Drawing.Size(638, 518);
            this.meQuery.StyleController = this.lc;
            this.meQuery.TabIndex = 0;
            // 
            // lcg
            // 
            this.lcg.CustomizationFormText = "lcg";
            this.lcg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcg.GroupBordersVisible = false;
            this.lcg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciName,
            this.emptySpaceItem1,
            this.lciQuery,
            this.layoutControlItem1,
            this.lciGroup,
            this.layoutControlItem2});
            this.lcg.Location = new System.Drawing.Point(0, 0);
            this.lcg.Name = "lcg";
            this.lcg.Size = new System.Drawing.Size(670, 635);
            this.lcg.TextVisible = false;
            // 
            // lciName
            // 
            this.lciName.Control = this.teName;
            this.lciName.CustomizationFormText = "Name :";
            this.lciName.Location = new System.Drawing.Point(0, 28);
            this.lciName.Name = "lciName";
            this.lciName.Size = new System.Drawing.Size(340, 38);
            this.lciName.Text = "Name :";
            this.lciName.TextSize = new System.Drawing.Size(43, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(340, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(80, 66);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciQuery
            // 
            this.lciQuery.Control = this.meQuery;
            this.lciQuery.CustomizationFormText = "Query :";
            this.lciQuery.Location = new System.Drawing.Point(0, 66);
            this.lciQuery.Name = "lciQuery";
            this.lciQuery.Size = new System.Drawing.Size(644, 543);
            this.lciQuery.Text = "Query :";
            this.lciQuery.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciQuery.TextSize = new System.Drawing.Size(43, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbDesigner;
            this.layoutControlItem1.Location = new System.Drawing.Point(420, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(224, 33);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(420, 33);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(224, 33);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // pnl
            // 
            this.pnl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl.Location = new System.Drawing.Point(0, 669);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(670, 0);
            this.pnl.TabIndex = 3;
            this.pnl.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // teGroup
            // 
            this.teGroup.Location = new System.Drawing.Point(62, 16);
            this.teGroup.MenuManager = this.ribbon;
            this.teGroup.Name = "teGroup";
            this.teGroup.Size = new System.Drawing.Size(288, 22);
            this.teGroup.StyleController = this.lc;
            this.teGroup.TabIndex = 21;
            // 
            // lciGroup
            // 
            this.lciGroup.Control = this.teGroup;
            this.lciGroup.Location = new System.Drawing.Point(0, 0);
            this.lciGroup.Name = "lciGroup";
            this.lciGroup.Size = new System.Drawing.Size(340, 28);
            this.lciGroup.Text = "Group :";
            this.lciGroup.TextSize = new System.Drawing.Size(43, 16);
            // 
            // BarcodePrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 669);
            this.Controls.Add(this.lc);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarcodePrintForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).EndInit();
            this.lc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGroup)).EndInit();
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
        private SimpleButton sbDesigner;
        private TextEdit teName;
        private MemoEdit meQuery;
        private LayoutControlItem lciName;
        private EmptySpaceItem emptySpaceItem1;
        private LayoutControlItem lciQuery;
        private LayoutControlItem layoutControlItem1;
        private SimpleButton sbSave;
        private LayoutControlItem layoutControlItem2;
        private TextEdit teGroup;
        private LayoutControlItem lciGroup;
    }
}