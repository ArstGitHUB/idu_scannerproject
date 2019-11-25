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
    partial class SearchBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBarcode));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lc = new DevExpress.XtraLayout.LayoutControl();
            this.teBarcode = new DevExpress.XtraEditors.TextEdit();
            this.sbReprint = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.lcg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBarcode = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnl = new DevExpress.XtraEditors.PanelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lueLabel = new DevExpress.XtraEditors.LookUpEdit();
            this.teLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).BeginInit();
            this.lc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(664, 34);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // lc
            // 
            this.lc.Controls.Add(this.lueLabel);
            this.lc.Controls.Add(this.teBarcode);
            this.lc.Controls.Add(this.sbReprint);
            this.lc.Controls.Add(this.sbAddNew);
            this.lc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc.Location = new System.Drawing.Point(0, 34);
            this.lc.Name = "lc";
            this.lc.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1107, 664, 500, 700);
            this.lc.Root = this.lcg;
            this.lc.Size = new System.Drawing.Size(664, 172);
            this.lc.TabIndex = 2;
            this.lc.Text = "layoutControl1";
            // 
            // teBarcode
            // 
            this.teBarcode.Location = new System.Drawing.Point(89, 16);
            this.teBarcode.MenuManager = this.ribbon;
            this.teBarcode.Name = "teBarcode";
            this.teBarcode.Size = new System.Drawing.Size(559, 22);
            this.teBarcode.StyleController = this.lc;
            this.teBarcode.TabIndex = 8;
            // 
            // sbReprint
            // 
            this.sbReprint.Image = ((System.Drawing.Image)(resources.GetObject("sbReprint.Image")));
            this.sbReprint.Location = new System.Drawing.Point(16, 82);
            this.sbReprint.Margin = new System.Windows.Forms.Padding(2);
            this.sbReprint.Name = "sbReprint";
            this.sbReprint.Size = new System.Drawing.Size(313, 27);
            this.sbReprint.StyleController = this.lc;
            this.sbReprint.TabIndex = 7;
            this.sbReprint.Text = "Re-Print";
            this.sbReprint.Click += new System.EventHandler(this.sbSelect_Click);
            // 
            // sbAddNew
            // 
            this.sbAddNew.Image = ((System.Drawing.Image)(resources.GetObject("sbAddNew.Image")));
            this.sbAddNew.Location = new System.Drawing.Point(335, 82);
            this.sbAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.sbAddNew.Name = "sbAddNew";
            this.sbAddNew.Size = new System.Drawing.Size(313, 27);
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
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.lciBarcode,
            this.teLabel,
            this.emptySpaceItem1});
            this.lcg.Location = new System.Drawing.Point(0, 0);
            this.lcg.Name = "Root";
            this.lcg.Size = new System.Drawing.Size(664, 172);
            this.lcg.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbAddNew;
            this.layoutControlItem2.Location = new System.Drawing.Point(319, 66);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(319, 80);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbReprint;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(319, 80);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // lciBarcode
            // 
            this.lciBarcode.Control = this.teBarcode;
            this.lciBarcode.Location = new System.Drawing.Point(0, 0);
            this.lciBarcode.Name = "lciBarcode";
            this.lciBarcode.Size = new System.Drawing.Size(638, 28);
            this.lciBarcode.Text = "Roll Number";
            this.lciBarcode.TextSize = new System.Drawing.Size(70, 16);
            // 
            // pnl
            // 
            this.pnl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl.Location = new System.Drawing.Point(0, 206);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(664, 0);
            this.pnl.TabIndex = 3;
            this.pnl.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lueLabel
            // 
            this.lueLabel.Location = new System.Drawing.Point(89, 44);
            this.lueLabel.MenuManager = this.ribbon;
            this.lueLabel.Name = "lueLabel";
            this.lueLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lueLabel.Size = new System.Drawing.Size(559, 22);
            this.lueLabel.StyleController = this.lc;
            this.lueLabel.TabIndex = 9;
            this.lueLabel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueLabel_ButtonClick);
            // 
            // teLabel
            // 
            this.teLabel.Control = this.lueLabel;
            this.teLabel.Location = new System.Drawing.Point(0, 28);
            this.teLabel.Name = "teLabel";
            this.teLabel.Size = new System.Drawing.Size(638, 28);
            this.teLabel.Text = "Label";
            this.teLabel.TextSize = new System.Drawing.Size(70, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 56);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(638, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SearchBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 206);
            this.Controls.Add(this.lc);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchBarcode";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).EndInit();
            this.lc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
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
        private SimpleButton sbReprint;
        private LayoutControlItem layoutControlItem3;
        private TextEdit teBarcode;
        private LayoutControlItem lciBarcode;
        private LookUpEdit lueLabel;
        private LayoutControlItem teLabel;
        private EmptySpaceItem emptySpaceItem1;
    }
}