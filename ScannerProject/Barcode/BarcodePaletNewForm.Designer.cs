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
    partial class BarcodePaletNewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodePaletNewForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lc = new DevExpress.XtraLayout.LayoutControl();
            this.sbNewPalet = new DevExpress.XtraEditors.SimpleButton();
            this.lueFactory = new DevExpress.XtraEditors.LookUpEdit();
            this.teChemicalTreatment = new DevExpress.XtraEditors.TextEdit();
            this.sbTPLPalletNum = new DevExpress.XtraEditors.SimpleButton();
            this.tePalletNumber3 = new DevExpress.XtraEditors.TextEdit();
            this.tePalletNumber4 = new DevExpress.XtraEditors.TextEdit();
            this.tePalletNumber6 = new DevExpress.XtraEditors.TextEdit();
            this.tePalletNumber5 = new DevExpress.XtraEditors.TextEdit();
            this.tePalletNumber8 = new DevExpress.XtraEditors.TextEdit();
            this.tePalletNumber7 = new DevExpress.XtraEditors.TextEdit();
            this.tePalletNumber2 = new DevExpress.XtraEditors.TextEdit();
            this.tePalletNumber1 = new DevExpress.XtraEditors.TextEdit();
            this.teJobNo = new DevExpress.XtraEditors.TextEdit();
            this.teNetWeight = new DevExpress.XtraEditors.TextEdit();
            this.sbToLeft = new DevExpress.XtraEditors.SimpleButton();
            this.sbToRight = new DevExpress.XtraEditors.SimpleButton();
            this.gc2 = new DevExpress.XtraGrid.GridControl();
            this.gv2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRollNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teTPLArticle = new DevExpress.XtraEditors.TextEdit();
            this.teCoronaTreatement = new DevExpress.XtraEditors.TextEdit();
            this.tePONumber = new DevExpress.XtraEditors.TextEdit();
            this.teCoreID = new DevExpress.XtraEditors.TextEdit();
            this.gc1 = new DevExpress.XtraGrid.GridControl();
            this.gv1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRollNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWHDivision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChemical = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPONumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTPLArticle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teRollNo = new DevExpress.XtraEditors.TextEdit();
            this.lueItem = new DevExpress.XtraEditors.LookUpEdit();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.teLength1 = new DevExpress.XtraEditors.TextEdit();
            this.teWidth1 = new DevExpress.XtraEditors.TextEdit();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.teThick = new DevExpress.XtraEditors.TextEdit();
            this.teType = new DevExpress.XtraEditors.TextEdit();
            this.lueKindOfLabel = new DevExpress.XtraEditors.LookUpEdit();
            this.lcg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciKindOfLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciThick = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciWidth = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLength = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCoreID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPONumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCoronaTreatment = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciNetWeight = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciJobNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPalletNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTPLArticle = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChemicalTreatment = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFactory = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRollNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciNewPalet = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).BeginInit();
            this.lc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueFactory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teChemicalTreatment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNetWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTPLArticle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCoronaTreatement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePONumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCoreID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRollNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLength1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWidth1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teThick.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKindOfLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKindOfLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciThick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoreID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPONumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoronaTreatment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNetWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPalletNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTPLArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChemicalTreatment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRollNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewPalet)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1618, 34);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // lc
            // 
            this.lc.Controls.Add(this.sbNewPalet);
            this.lc.Controls.Add(this.lueFactory);
            this.lc.Controls.Add(this.teChemicalTreatment);
            this.lc.Controls.Add(this.sbTPLPalletNum);
            this.lc.Controls.Add(this.tePalletNumber3);
            this.lc.Controls.Add(this.tePalletNumber4);
            this.lc.Controls.Add(this.tePalletNumber6);
            this.lc.Controls.Add(this.tePalletNumber5);
            this.lc.Controls.Add(this.tePalletNumber8);
            this.lc.Controls.Add(this.tePalletNumber7);
            this.lc.Controls.Add(this.tePalletNumber2);
            this.lc.Controls.Add(this.tePalletNumber1);
            this.lc.Controls.Add(this.teJobNo);
            this.lc.Controls.Add(this.teNetWeight);
            this.lc.Controls.Add(this.sbToLeft);
            this.lc.Controls.Add(this.sbToRight);
            this.lc.Controls.Add(this.gc2);
            this.lc.Controls.Add(this.teTPLArticle);
            this.lc.Controls.Add(this.teCoronaTreatement);
            this.lc.Controls.Add(this.tePONumber);
            this.lc.Controls.Add(this.teCoreID);
            this.lc.Controls.Add(this.gc1);
            this.lc.Controls.Add(this.teRollNo);
            this.lc.Controls.Add(this.lueItem);
            this.lc.Controls.Add(this.sbCancel);
            this.lc.Controls.Add(this.teLength1);
            this.lc.Controls.Add(this.teWidth1);
            this.lc.Controls.Add(this.sbSave);
            this.lc.Controls.Add(this.teThick);
            this.lc.Controls.Add(this.teType);
            this.lc.Controls.Add(this.lueKindOfLabel);
            this.lc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc.Location = new System.Drawing.Point(0, 34);
            this.lc.Name = "lc";
            this.lc.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(907, 1022, 500, 700);
            this.lc.Root = this.lcg;
            this.lc.Size = new System.Drawing.Size(1618, 541);
            this.lc.TabIndex = 2;
            this.lc.Text = "layoutControl1";
            // 
            // sbNewPalet
            // 
            this.sbNewPalet.Image = ((System.Drawing.Image)(resources.GetObject("sbNewPalet.Image")));
            this.sbNewPalet.Location = new System.Drawing.Point(16, 498);
            this.sbNewPalet.Name = "sbNewPalet";
            this.sbNewPalet.Size = new System.Drawing.Size(133, 27);
            this.sbNewPalet.StyleController = this.lc;
            this.sbNewPalet.TabIndex = 31;
            this.sbNewPalet.Text = "New Palet";
            this.sbNewPalet.Click += new System.EventHandler(this.sbNewPalet_Click);
            // 
            // lueFactory
            // 
            this.lueFactory.Location = new System.Drawing.Point(99, 44);
            this.lueFactory.MenuManager = this.ribbon;
            this.lueFactory.Name = "lueFactory";
            this.lueFactory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueFactory.Size = new System.Drawing.Size(324, 22);
            this.lueFactory.StyleController = this.lc;
            this.lueFactory.TabIndex = 30;
            // 
            // teChemicalTreatment
            // 
            this.teChemicalTreatment.Location = new System.Drawing.Point(759, 417);
            this.teChemicalTreatment.MenuManager = this.ribbon;
            this.teChemicalTreatment.Name = "teChemicalTreatment";
            this.teChemicalTreatment.Size = new System.Drawing.Size(85, 22);
            this.teChemicalTreatment.StyleController = this.lc;
            this.teChemicalTreatment.TabIndex = 29;
            // 
            // sbTPLPalletNum
            // 
            this.sbTPLPalletNum.Location = new System.Drawing.Point(716, 455);
            this.sbTPLPalletNum.Name = "sbTPLPalletNum";
            this.sbTPLPalletNum.Size = new System.Drawing.Size(144, 27);
            this.sbTPLPalletNum.StyleController = this.lc;
            this.sbTPLPalletNum.TabIndex = 28;
            this.sbTPLPalletNum.Text = "TPL Pallet Num";
            this.sbTPLPalletNum.Click += new System.EventHandler(this.sbTPLPalletNum_Click);
            // 
            // tePalletNumber3
            // 
            this.tePalletNumber3.Location = new System.Drawing.Point(211, 455);
            this.tePalletNumber3.MenuManager = this.ribbon;
            this.tePalletNumber3.Name = "tePalletNumber3";
            this.tePalletNumber3.Properties.MaxLength = 1;
            this.tePalletNumber3.Size = new System.Drawing.Size(50, 22);
            this.tePalletNumber3.StyleController = this.lc;
            this.tePalletNumber3.TabIndex = 20;
            // 
            // tePalletNumber4
            // 
            this.tePalletNumber4.Location = new System.Drawing.Point(267, 455);
            this.tePalletNumber4.MenuManager = this.ribbon;
            this.tePalletNumber4.Name = "tePalletNumber4";
            this.tePalletNumber4.Properties.MaxLength = 2;
            this.tePalletNumber4.Size = new System.Drawing.Size(63, 22);
            this.tePalletNumber4.StyleController = this.lc;
            this.tePalletNumber4.TabIndex = 21;
            // 
            // tePalletNumber6
            // 
            this.tePalletNumber6.Location = new System.Drawing.Point(416, 455);
            this.tePalletNumber6.MenuManager = this.ribbon;
            this.tePalletNumber6.Name = "tePalletNumber6";
            this.tePalletNumber6.Properties.MaxLength = 4;
            this.tePalletNumber6.Size = new System.Drawing.Size(94, 22);
            this.tePalletNumber6.StyleController = this.lc;
            this.tePalletNumber6.TabIndex = 23;
            // 
            // tePalletNumber5
            // 
            this.tePalletNumber5.Location = new System.Drawing.Point(336, 455);
            this.tePalletNumber5.MenuManager = this.ribbon;
            this.tePalletNumber5.Name = "tePalletNumber5";
            this.tePalletNumber5.Properties.MaxLength = 2;
            this.tePalletNumber5.Size = new System.Drawing.Size(74, 22);
            this.tePalletNumber5.StyleController = this.lc;
            this.tePalletNumber5.TabIndex = 22;
            // 
            // tePalletNumber8
            // 
            this.tePalletNumber8.Location = new System.Drawing.Point(616, 455);
            this.tePalletNumber8.MenuManager = this.ribbon;
            this.tePalletNumber8.Name = "tePalletNumber8";
            this.tePalletNumber8.Properties.MaxLength = 3;
            this.tePalletNumber8.Size = new System.Drawing.Size(94, 22);
            this.tePalletNumber8.StyleController = this.lc;
            this.tePalletNumber8.TabIndex = 25;
            // 
            // tePalletNumber7
            // 
            this.tePalletNumber7.Location = new System.Drawing.Point(516, 455);
            this.tePalletNumber7.MenuManager = this.ribbon;
            this.tePalletNumber7.Name = "tePalletNumber7";
            this.tePalletNumber7.Properties.MaxLength = 2;
            this.tePalletNumber7.Size = new System.Drawing.Size(94, 22);
            this.tePalletNumber7.StyleController = this.lc;
            this.tePalletNumber7.TabIndex = 24;
            // 
            // tePalletNumber2
            // 
            this.tePalletNumber2.Location = new System.Drawing.Point(155, 455);
            this.tePalletNumber2.MenuManager = this.ribbon;
            this.tePalletNumber2.Name = "tePalletNumber2";
            this.tePalletNumber2.Properties.MaxLength = 1;
            this.tePalletNumber2.Size = new System.Drawing.Size(50, 22);
            this.tePalletNumber2.StyleController = this.lc;
            this.tePalletNumber2.TabIndex = 19;
            // 
            // tePalletNumber1
            // 
            this.tePalletNumber1.Location = new System.Drawing.Point(99, 455);
            this.tePalletNumber1.MenuManager = this.ribbon;
            this.tePalletNumber1.Name = "tePalletNumber1";
            this.tePalletNumber1.Properties.MaxLength = 1;
            this.tePalletNumber1.Size = new System.Drawing.Size(50, 22);
            this.tePalletNumber1.StyleController = this.lc;
            this.tePalletNumber1.TabIndex = 18;
            // 
            // teJobNo
            // 
            this.teJobNo.Location = new System.Drawing.Point(1297, 16);
            this.teJobNo.MenuManager = this.ribbon;
            this.teJobNo.Name = "teJobNo";
            this.teJobNo.Size = new System.Drawing.Size(305, 22);
            this.teJobNo.StyleController = this.lc;
            this.teJobNo.TabIndex = 3;
            // 
            // teNetWeight
            // 
            this.teNetWeight.Location = new System.Drawing.Point(1297, 432);
            this.teNetWeight.MenuManager = this.ribbon;
            this.teNetWeight.Name = "teNetWeight";
            this.teNetWeight.Size = new System.Drawing.Size(305, 22);
            this.teNetWeight.StyleController = this.lc;
            this.teNetWeight.TabIndex = 13;
            // 
            // sbToLeft
            // 
            this.sbToLeft.Location = new System.Drawing.Point(1174, 214);
            this.sbToLeft.Name = "sbToLeft";
            this.sbToLeft.Size = new System.Drawing.Size(34, 27);
            this.sbToLeft.StyleController = this.lc;
            this.sbToLeft.TabIndex = 12;
            this.sbToLeft.Text = "<<";
            this.sbToLeft.Click += new System.EventHandler(this.sbToLeft_Click);
            // 
            // sbToRight
            // 
            this.sbToRight.Location = new System.Drawing.Point(1174, 89);
            this.sbToRight.Name = "sbToRight";
            this.sbToRight.Size = new System.Drawing.Size(34, 27);
            this.sbToRight.StyleController = this.lc;
            this.sbToRight.TabIndex = 10;
            this.sbToRight.Text = ">>";
            this.sbToRight.Click += new System.EventHandler(this.sbToRight_Click);
            // 
            // gc2
            // 
            this.gc2.Location = new System.Drawing.Point(1214, 44);
            this.gc2.MainView = this.gv2;
            this.gc2.MenuManager = this.ribbon;
            this.gc2.Name = "gc2";
            this.gc2.Size = new System.Drawing.Size(388, 382);
            this.gc2.TabIndex = 8;
            this.gc2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv2});
            // 
            // gv2
            // 
            this.gv2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRollNumber});
            this.gv2.GridControl = this.gc2;
            this.gv2.Name = "gv2";
            this.gv2.OptionsView.ShowGroupPanel = false;
            this.gv2.OptionsView.ShowIndicator = false;
            // 
            // colRollNumber
            // 
            this.colRollNumber.Caption = "Roll Number";
            this.colRollNumber.FieldName = "RollNumber";
            this.colRollNumber.Name = "colRollNumber";
            this.colRollNumber.OptionsColumn.AllowEdit = false;
            this.colRollNumber.OptionsColumn.AllowFocus = false;
            this.colRollNumber.OptionsColumn.ReadOnly = true;
            this.colRollNumber.OptionsColumn.TabStop = false;
            this.colRollNumber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetWeigth", "SUM={0:0.##}")});
            this.colRollNumber.Visible = true;
            this.colRollNumber.VisibleIndex = 0;
            // 
            // teTPLArticle
            // 
            this.teTPLArticle.Location = new System.Drawing.Point(933, 417);
            this.teTPLArticle.MenuManager = this.ribbon;
            this.teTPLArticle.Name = "teTPLArticle";
            this.teTPLArticle.Size = new System.Drawing.Size(235, 22);
            this.teTPLArticle.StyleController = this.lc;
            this.teTPLArticle.TabIndex = 17;
            // 
            // teCoronaTreatement
            // 
            this.teCoronaTreatement.Location = new System.Drawing.Point(585, 417);
            this.teCoronaTreatement.MenuManager = this.ribbon;
            this.teCoronaTreatement.Name = "teCoronaTreatement";
            this.teCoronaTreatement.Size = new System.Drawing.Size(85, 22);
            this.teCoronaTreatement.StyleController = this.lc;
            this.teCoronaTreatement.TabIndex = 16;
            // 
            // tePONumber
            // 
            this.tePONumber.Location = new System.Drawing.Point(328, 417);
            this.tePONumber.MenuManager = this.ribbon;
            this.tePONumber.Name = "tePONumber";
            this.tePONumber.Size = new System.Drawing.Size(168, 22);
            this.tePONumber.StyleController = this.lc;
            this.tePONumber.TabIndex = 15;
            // 
            // teCoreID
            // 
            this.teCoreID.Location = new System.Drawing.Point(99, 417);
            this.teCoreID.MenuManager = this.ribbon;
            this.teCoreID.Name = "teCoreID";
            this.teCoreID.Size = new System.Drawing.Size(140, 22);
            this.teCoreID.StyleController = this.lc;
            this.teCoreID.TabIndex = 14;
            this.teCoreID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.teCoreID_KeyUp);
            // 
            // gc1
            // 
            this.gc1.Location = new System.Drawing.Point(16, 138);
            this.gc1.MainView = this.gv1;
            this.gc1.MenuManager = this.ribbon;
            this.gc1.Name = "gc1";
            this.gc1.Size = new System.Drawing.Size(1152, 273);
            this.gc1.TabIndex = 11;
            this.gc1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv1});
            // 
            // gv1
            // 
            this.gv1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInDate,
            this.colRollNo,
            this.colType,
            this.colSpec,
            this.colGr,
            this.colWeight,
            this.colWHDivision,
            this.colLocation,
            this.colCorona,
            this.colChemical,
            this.colPONumber,
            this.colTPLArticle});
            this.gv1.GridControl = this.gc1;
            this.gv1.Name = "gv1";
            this.gv1.OptionsView.ShowGroupPanel = false;
            this.gv1.OptionsView.ShowIndicator = false;
            this.gv1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gv1_RowStyle);
            // 
            // colInDate
            // 
            this.colInDate.Caption = "In Date";
            this.colInDate.DisplayFormat.FormatString = "yyyMMdd";
            this.colInDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colInDate.FieldName = "InDate";
            this.colInDate.Name = "colInDate";
            this.colInDate.OptionsColumn.AllowEdit = false;
            this.colInDate.OptionsColumn.AllowFocus = false;
            this.colInDate.OptionsColumn.ReadOnly = true;
            this.colInDate.OptionsColumn.TabStop = false;
            this.colInDate.Visible = true;
            this.colInDate.VisibleIndex = 0;
            this.colInDate.Width = 300;
            // 
            // colRollNo
            // 
            this.colRollNo.Caption = "Roll No";
            this.colRollNo.FieldName = "RollNo";
            this.colRollNo.Name = "colRollNo";
            this.colRollNo.OptionsColumn.AllowEdit = false;
            this.colRollNo.OptionsColumn.AllowFocus = false;
            this.colRollNo.OptionsColumn.ReadOnly = true;
            this.colRollNo.OptionsColumn.TabStop = false;
            this.colRollNo.Visible = true;
            this.colRollNo.VisibleIndex = 1;
            this.colRollNo.Width = 300;
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowEdit = false;
            this.colType.OptionsColumn.AllowFocus = false;
            this.colType.OptionsColumn.ReadOnly = true;
            this.colType.OptionsColumn.TabStop = false;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            this.colType.Width = 300;
            // 
            // colSpec
            // 
            this.colSpec.Caption = "Spec";
            this.colSpec.FieldName = "Spec";
            this.colSpec.Name = "colSpec";
            this.colSpec.OptionsColumn.AllowEdit = false;
            this.colSpec.OptionsColumn.AllowFocus = false;
            this.colSpec.OptionsColumn.ReadOnly = true;
            this.colSpec.OptionsColumn.TabStop = false;
            this.colSpec.Visible = true;
            this.colSpec.VisibleIndex = 3;
            this.colSpec.Width = 300;
            // 
            // colGr
            // 
            this.colGr.Caption = "Gr";
            this.colGr.FieldName = "Gr";
            this.colGr.Name = "colGr";
            this.colGr.OptionsColumn.AllowEdit = false;
            this.colGr.OptionsColumn.AllowFocus = false;
            this.colGr.OptionsColumn.ReadOnly = true;
            this.colGr.OptionsColumn.TabStop = false;
            this.colGr.Visible = true;
            this.colGr.VisibleIndex = 4;
            this.colGr.Width = 300;
            // 
            // colWeight
            // 
            this.colWeight.Caption = "Weight";
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.OptionsColumn.AllowEdit = false;
            this.colWeight.OptionsColumn.AllowFocus = false;
            this.colWeight.OptionsColumn.ReadOnly = true;
            this.colWeight.OptionsColumn.TabStop = false;
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 5;
            this.colWeight.Width = 300;
            // 
            // colWHDivision
            // 
            this.colWHDivision.Caption = "W/H Division";
            this.colWHDivision.FieldName = "WHDivision";
            this.colWHDivision.Name = "colWHDivision";
            this.colWHDivision.OptionsColumn.AllowEdit = false;
            this.colWHDivision.OptionsColumn.AllowFocus = false;
            this.colWHDivision.OptionsColumn.ReadOnly = true;
            this.colWHDivision.OptionsColumn.TabStop = false;
            this.colWHDivision.Visible = true;
            this.colWHDivision.VisibleIndex = 6;
            this.colWHDivision.Width = 300;
            // 
            // colLocation
            // 
            this.colLocation.Caption = "Location";
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.OptionsColumn.AllowEdit = false;
            this.colLocation.OptionsColumn.AllowFocus = false;
            this.colLocation.OptionsColumn.ReadOnly = true;
            this.colLocation.OptionsColumn.TabStop = false;
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 7;
            this.colLocation.Width = 300;
            // 
            // colCorona
            // 
            this.colCorona.Caption = "Corona";
            this.colCorona.FieldName = "Corona";
            this.colCorona.Name = "colCorona";
            this.colCorona.OptionsColumn.AllowEdit = false;
            this.colCorona.OptionsColumn.AllowFocus = false;
            this.colCorona.OptionsColumn.ReadOnly = true;
            this.colCorona.OptionsColumn.TabStop = false;
            this.colCorona.Visible = true;
            this.colCorona.VisibleIndex = 8;
            this.colCorona.Width = 300;
            // 
            // colChemical
            // 
            this.colChemical.Caption = "Chemical";
            this.colChemical.FieldName = "Chemical";
            this.colChemical.Name = "colChemical";
            this.colChemical.OptionsColumn.AllowEdit = false;
            this.colChemical.OptionsColumn.AllowFocus = false;
            this.colChemical.OptionsColumn.ReadOnly = true;
            this.colChemical.OptionsColumn.TabStop = false;
            this.colChemical.Visible = true;
            this.colChemical.VisibleIndex = 9;
            this.colChemical.Width = 300;
            // 
            // colPONumber
            // 
            this.colPONumber.Caption = "PO Number";
            this.colPONumber.FieldName = "PONumber";
            this.colPONumber.Name = "colPONumber";
            this.colPONumber.OptionsColumn.AllowEdit = false;
            this.colPONumber.OptionsColumn.AllowFocus = false;
            this.colPONumber.OptionsColumn.ReadOnly = true;
            this.colPONumber.OptionsColumn.TabStop = false;
            this.colPONumber.Visible = true;
            this.colPONumber.VisibleIndex = 10;
            this.colPONumber.Width = 300;
            // 
            // colTPLArticle
            // 
            this.colTPLArticle.Caption = "TPL Article";
            this.colTPLArticle.FieldName = "TPLArticle";
            this.colTPLArticle.Name = "colTPLArticle";
            this.colTPLArticle.OptionsColumn.AllowEdit = false;
            this.colTPLArticle.OptionsColumn.AllowFocus = false;
            this.colTPLArticle.OptionsColumn.ReadOnly = true;
            this.colTPLArticle.OptionsColumn.TabStop = false;
            this.colTPLArticle.Visible = true;
            this.colTPLArticle.VisibleIndex = 11;
            this.colTPLArticle.Width = 300;
            // 
            // teRollNo
            // 
            this.teRollNo.Location = new System.Drawing.Point(522, 44);
            this.teRollNo.MenuManager = this.ribbon;
            this.teRollNo.Name = "teRollNo";
            this.teRollNo.Size = new System.Drawing.Size(211, 22);
            this.teRollNo.StyleController = this.lc;
            this.teRollNo.TabIndex = 2;
            this.teRollNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.teRollNo_KeyUp);
            // 
            // lueItem
            // 
            this.lueItem.Location = new System.Drawing.Point(99, 16);
            this.lueItem.MenuManager = this.ribbon;
            this.lueItem.Name = "lueItem";
            this.lueItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.lueItem.Size = new System.Drawing.Size(634, 22);
            this.lueItem.StyleController = this.lc;
            this.lueItem.TabIndex = 0;
            this.lueItem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueItem_ButtonClick);
            this.lueItem.EditValueChanged += new System.EventHandler(this.lueItem_EditValueChanged);
            // 
            // sbCancel
            // 
            this.sbCancel.Image = ((System.Drawing.Image)(resources.GetObject("sbCancel.Image")));
            this.sbCancel.Location = new System.Drawing.Point(1369, 498);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(233, 27);
            this.sbCancel.StyleController = this.lc;
            this.sbCancel.TabIndex = 27;
            this.sbCancel.Text = "Cancel";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // teLength1
            // 
            this.teLength1.Location = new System.Drawing.Point(566, 72);
            this.teLength1.Margin = new System.Windows.Forms.Padding(2);
            this.teLength1.MenuManager = this.ribbon;
            this.teLength1.Name = "teLength1";
            this.teLength1.Size = new System.Drawing.Size(144, 22);
            this.teLength1.StyleController = this.lc;
            this.teLength1.TabIndex = 7;
            // 
            // teWidth1
            // 
            this.teWidth1.Location = new System.Drawing.Point(416, 72);
            this.teWidth1.Margin = new System.Windows.Forms.Padding(2);
            this.teWidth1.MenuManager = this.ribbon;
            this.teWidth1.Name = "teWidth1";
            this.teWidth1.Size = new System.Drawing.Size(144, 22);
            this.teWidth1.StyleController = this.lc;
            this.teWidth1.TabIndex = 6;
            // 
            // sbSave
            // 
            this.sbSave.Image = ((System.Drawing.Image)(resources.GetObject("sbSave.Image")));
            this.sbSave.Location = new System.Drawing.Point(1121, 498);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(242, 27);
            this.sbSave.StyleController = this.lc;
            this.sbSave.TabIndex = 26;
            this.sbSave.Text = "Save";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // teThick
            // 
            this.teThick.Location = new System.Drawing.Point(299, 72);
            this.teThick.Margin = new System.Windows.Forms.Padding(2);
            this.teThick.MenuManager = this.ribbon;
            this.teThick.Name = "teThick";
            this.teThick.Size = new System.Drawing.Size(111, 22);
            this.teThick.StyleController = this.lc;
            this.teThick.TabIndex = 5;
            // 
            // teType
            // 
            this.teType.Location = new System.Drawing.Point(99, 72);
            this.teType.Margin = new System.Windows.Forms.Padding(2);
            this.teType.MenuManager = this.ribbon;
            this.teType.Name = "teType";
            this.teType.Size = new System.Drawing.Size(111, 22);
            this.teType.StyleController = this.lc;
            this.teType.TabIndex = 4;
            // 
            // lueKindOfLabel
            // 
            this.lueKindOfLabel.Location = new System.Drawing.Point(99, 100);
            this.lueKindOfLabel.Margin = new System.Windows.Forms.Padding(2);
            this.lueKindOfLabel.MenuManager = this.ribbon;
            this.lueKindOfLabel.Name = "lueKindOfLabel";
            this.lueKindOfLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.lueKindOfLabel.Properties.NullText = "";
            this.lueKindOfLabel.Size = new System.Drawing.Size(1069, 22);
            this.lueKindOfLabel.StyleController = this.lc;
            this.lueKindOfLabel.TabIndex = 9;
            this.lueKindOfLabel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueKindOfLabel_ButtonClick);
            // 
            // lcg
            // 
            this.lcg.CustomizationFormText = "lcg";
            this.lcg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcg.GroupBordersVisible = false;
            this.lcg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciKindOfLabel,
            this.lciType,
            this.lciThick,
            this.lciWidth,
            this.lciLength,
            this.layoutControlItem3,
            this.lciCoreID,
            this.lciPONumber,
            this.lciCoronaTreatment,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.lciNetWeight,
            this.lciJobNo,
            this.lciPalletNumber,
            this.emptySpaceItem5,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.emptySpaceItem4,
            this.emptySpaceItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.layoutControlItem9,
            this.lciTPLArticle,
            this.emptySpaceItem7,
            this.emptySpaceItem9,
            this.emptySpaceItem10,
            this.layoutControlItem14,
            this.lciChemicalTreatment,
            this.lciFactory,
            this.lciRollNo,
            this.emptySpaceItem12,
            this.emptySpaceItem11,
            this.emptySpaceItem8,
            this.lciItem,
            this.emptySpaceItem13,
            this.lciNewPalet});
            this.lcg.Location = new System.Drawing.Point(0, 0);
            this.lcg.Name = "Root";
            this.lcg.Size = new System.Drawing.Size(1618, 541);
            this.lcg.TextVisible = false;
            // 
            // lciKindOfLabel
            // 
            this.lciKindOfLabel.Control = this.lueKindOfLabel;
            this.lciKindOfLabel.Location = new System.Drawing.Point(0, 84);
            this.lciKindOfLabel.Name = "lciKindOfLabel";
            this.lciKindOfLabel.Size = new System.Drawing.Size(1158, 28);
            this.lciKindOfLabel.Text = "Kind Of Label";
            this.lciKindOfLabel.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciType
            // 
            this.lciType.Control = this.teType;
            this.lciType.Location = new System.Drawing.Point(0, 56);
            this.lciType.MaxSize = new System.Drawing.Size(200, 28);
            this.lciType.MinSize = new System.Drawing.Size(139, 28);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(200, 28);
            this.lciType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciType.Text = "Type";
            this.lciType.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciThick
            // 
            this.lciThick.Control = this.teThick;
            this.lciThick.Location = new System.Drawing.Point(200, 56);
            this.lciThick.MaxSize = new System.Drawing.Size(200, 28);
            this.lciThick.MinSize = new System.Drawing.Size(139, 28);
            this.lciThick.Name = "lciThick";
            this.lciThick.Size = new System.Drawing.Size(200, 28);
            this.lciThick.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciThick.Text = "Spec";
            this.lciThick.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciWidth
            // 
            this.lciWidth.Control = this.teWidth1;
            this.lciWidth.Location = new System.Drawing.Point(400, 56);
            this.lciWidth.MaxSize = new System.Drawing.Size(150, 28);
            this.lciWidth.MinSize = new System.Drawing.Size(56, 28);
            this.lciWidth.Name = "lciWidth";
            this.lciWidth.Size = new System.Drawing.Size(150, 28);
            this.lciWidth.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciWidth.TextSize = new System.Drawing.Size(0, 0);
            this.lciWidth.TextVisible = false;
            // 
            // lciLength
            // 
            this.lciLength.Control = this.teLength1;
            this.lciLength.Location = new System.Drawing.Point(550, 56);
            this.lciLength.MaxSize = new System.Drawing.Size(150, 28);
            this.lciLength.MinSize = new System.Drawing.Size(56, 28);
            this.lciLength.Name = "lciLength";
            this.lciLength.Size = new System.Drawing.Size(150, 28);
            this.lciLength.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciLength.TextSize = new System.Drawing.Size(0, 0);
            this.lciLength.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gc1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1158, 279);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // lciCoreID
            // 
            this.lciCoreID.Control = this.teCoreID;
            this.lciCoreID.Location = new System.Drawing.Point(0, 401);
            this.lciCoreID.Name = "lciCoreID";
            this.lciCoreID.Size = new System.Drawing.Size(229, 28);
            this.lciCoreID.Text = "Core ID";
            this.lciCoreID.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciPONumber
            // 
            this.lciPONumber.Control = this.tePONumber;
            this.lciPONumber.Location = new System.Drawing.Point(229, 401);
            this.lciPONumber.Name = "lciPONumber";
            this.lciPONumber.Size = new System.Drawing.Size(257, 28);
            this.lciPONumber.Text = "PO Number";
            this.lciPONumber.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciCoronaTreatment
            // 
            this.lciCoronaTreatment.Control = this.teCoronaTreatement;
            this.lciCoronaTreatment.Location = new System.Drawing.Point(486, 401);
            this.lciCoronaTreatment.Name = "lciCoronaTreatment";
            this.lciCoronaTreatment.Size = new System.Drawing.Size(174, 28);
            this.lciCoronaTreatment.Text = "Corona";
            this.lciCoronaTreatment.TextSize = new System.Drawing.Size(80, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gc2;
            this.layoutControlItem4.Location = new System.Drawing.Point(1198, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(394, 388);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbToRight;
            this.layoutControlItem5.Location = new System.Drawing.Point(1158, 73);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(40, 33);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.sbToLeft;
            this.layoutControlItem6.Location = new System.Drawing.Point(1158, 198);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(40, 33);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(1158, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(40, 73);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(1158, 106);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(40, 92);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(1158, 231);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(40, 0);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(40, 241);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciNetWeight
            // 
            this.lciNetWeight.Control = this.teNetWeight;
            this.lciNetWeight.Location = new System.Drawing.Point(1198, 416);
            this.lciNetWeight.Name = "lciNetWeight";
            this.lciNetWeight.Size = new System.Drawing.Size(394, 28);
            this.lciNetWeight.Text = "Net Weight";
            this.lciNetWeight.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciJobNo
            // 
            this.lciJobNo.Control = this.teJobNo;
            this.lciJobNo.Location = new System.Drawing.Point(1198, 0);
            this.lciJobNo.Name = "lciJobNo";
            this.lciJobNo.Size = new System.Drawing.Size(394, 28);
            this.lciJobNo.Text = "Job No";
            this.lciJobNo.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciPalletNumber
            // 
            this.lciPalletNumber.Control = this.tePalletNumber1;
            this.lciPalletNumber.Location = new System.Drawing.Point(0, 439);
            this.lciPalletNumber.MaxSize = new System.Drawing.Size(150, 28);
            this.lciPalletNumber.MinSize = new System.Drawing.Size(139, 28);
            this.lciPalletNumber.Name = "lciPalletNumber";
            this.lciPalletNumber.Size = new System.Drawing.Size(139, 33);
            this.lciPalletNumber.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciPalletNumber.Text = "Pallet Number";
            this.lciPalletNumber.TextSize = new System.Drawing.Size(80, 16);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 472);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(1592, 10);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbCancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(1353, 482);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(239, 33);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(1105, 482);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(248, 33);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(139, 482);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(966, 33);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(1198, 444);
            this.emptySpaceItem6.MaxSize = new System.Drawing.Size(0, 28);
            this.emptySpaceItem6.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(394, 28);
            this.emptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.tePalletNumber2;
            this.layoutControlItem7.Location = new System.Drawing.Point(139, 439);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(150, 28);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(56, 28);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(56, 33);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.tePalletNumber7;
            this.layoutControlItem8.Location = new System.Drawing.Point(500, 439);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(100, 28);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(56, 28);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(100, 33);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.tePalletNumber5;
            this.layoutControlItem10.Location = new System.Drawing.Point(320, 439);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(100, 28);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(56, 28);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(80, 33);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.tePalletNumber6;
            this.layoutControlItem11.Location = new System.Drawing.Point(400, 439);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(100, 28);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(56, 28);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(100, 33);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.tePalletNumber4;
            this.layoutControlItem12.Location = new System.Drawing.Point(251, 439);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(100, 28);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(56, 28);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(69, 33);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.tePalletNumber3;
            this.layoutControlItem13.Location = new System.Drawing.Point(195, 439);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(150, 28);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(56, 28);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(56, 33);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.tePalletNumber8;
            this.layoutControlItem9.Location = new System.Drawing.Point(600, 439);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(100, 28);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(56, 28);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(100, 33);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // lciTPLArticle
            // 
            this.lciTPLArticle.Control = this.teTPLArticle;
            this.lciTPLArticle.Location = new System.Drawing.Point(834, 401);
            this.lciTPLArticle.Name = "lciTPLArticle";
            this.lciTPLArticle.Size = new System.Drawing.Size(324, 28);
            this.lciTPLArticle.Text = "TPL Article";
            this.lciTPLArticle.TextSize = new System.Drawing.Size(80, 16);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(850, 439);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(308, 33);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(0, 429);
            this.emptySpaceItem9.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem9.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(1158, 10);
            this.emptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(700, 56);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(458, 28);
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.sbTPLPalletNum;
            this.layoutControlItem14.Location = new System.Drawing.Point(700, 439);
            this.layoutControlItem14.MaxSize = new System.Drawing.Size(150, 33);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(105, 33);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(150, 33);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // lciChemicalTreatment
            // 
            this.lciChemicalTreatment.Control = this.teChemicalTreatment;
            this.lciChemicalTreatment.Location = new System.Drawing.Point(660, 401);
            this.lciChemicalTreatment.Name = "lciChemicalTreatment";
            this.lciChemicalTreatment.Size = new System.Drawing.Size(174, 28);
            this.lciChemicalTreatment.Text = "Chemical";
            this.lciChemicalTreatment.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciFactory
            // 
            this.lciFactory.Control = this.lueFactory;
            this.lciFactory.Location = new System.Drawing.Point(0, 28);
            this.lciFactory.Name = "lciFactory";
            this.lciFactory.Size = new System.Drawing.Size(413, 28);
            this.lciFactory.Text = "Factory";
            this.lciFactory.TextSize = new System.Drawing.Size(80, 16);
            // 
            // lciRollNo
            // 
            this.lciRollNo.Control = this.teRollNo;
            this.lciRollNo.Location = new System.Drawing.Point(423, 28);
            this.lciRollNo.MaxSize = new System.Drawing.Size(300, 28);
            this.lciRollNo.MinSize = new System.Drawing.Size(139, 28);
            this.lciRollNo.Name = "lciRollNo";
            this.lciRollNo.Size = new System.Drawing.Size(300, 28);
            this.lciRollNo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciRollNo.Text = "Roll No";
            this.lciRollNo.TextSize = new System.Drawing.Size(80, 16);
            // 
            // emptySpaceItem12
            // 
            this.emptySpaceItem12.AllowHotTrack = false;
            this.emptySpaceItem12.Location = new System.Drawing.Point(0, 112);
            this.emptySpaceItem12.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem12.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem12.Name = "emptySpaceItem12";
            this.emptySpaceItem12.Size = new System.Drawing.Size(1158, 10);
            this.emptySpaceItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem12.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.AllowHotTrack = false;
            this.emptySpaceItem11.Location = new System.Drawing.Point(413, 28);
            this.emptySpaceItem11.MaxSize = new System.Drawing.Size(10, 0);
            this.emptySpaceItem11.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(723, 28);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(435, 28);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciItem
            // 
            this.lciItem.Control = this.lueItem;
            this.lciItem.Location = new System.Drawing.Point(0, 0);
            this.lciItem.Name = "lciItem";
            this.lciItem.Size = new System.Drawing.Size(723, 28);
            this.lciItem.Text = "Item";
            this.lciItem.TextSize = new System.Drawing.Size(80, 16);
            // 
            // emptySpaceItem13
            // 
            this.emptySpaceItem13.AllowHotTrack = false;
            this.emptySpaceItem13.Location = new System.Drawing.Point(723, 0);
            this.emptySpaceItem13.Name = "emptySpaceItem13";
            this.emptySpaceItem13.Size = new System.Drawing.Size(435, 28);
            this.emptySpaceItem13.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciNewPalet
            // 
            this.lciNewPalet.Control = this.sbNewPalet;
            this.lciNewPalet.Location = new System.Drawing.Point(0, 482);
            this.lciNewPalet.Name = "lciNewPalet";
            this.lciNewPalet.Size = new System.Drawing.Size(139, 33);
            this.lciNewPalet.TextSize = new System.Drawing.Size(0, 0);
            this.lciNewPalet.TextVisible = false;
            // 
            // pnl
            // 
            this.pnl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl.Location = new System.Drawing.Point(0, 575);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1618, 0);
            this.pnl.TabIndex = 3;
            this.pnl.Visible = false;
            // 
            // BarcodePaletNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 575);
            this.Controls.Add(this.lc);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarcodePaletNewForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).EndInit();
            this.lc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueFactory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teChemicalTreatment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePalletNumber1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJobNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNetWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTPLArticle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCoronaTreatement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePONumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCoreID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRollNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLength1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWidth1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teThick.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKindOfLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKindOfLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciThick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoreID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPONumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoronaTreatment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNetWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJobNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPalletNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTPLArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChemicalTreatment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRollNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewPalet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private IContainer components = (IContainer)null;
        public BaseEdit firstController;
        protected LayoutControl lc;
        protected LayoutControlGroup lcg;
        protected PanelControl pnl;
        protected RibbonControl ribbon;
        private LookUpEdit lueKindOfLabel;
        private LayoutControlItem lciKindOfLabel;
        private TextEdit teWidth1;
        private TextEdit teLength1;
        private TextEdit teThick;
        private TextEdit teType;
        private SimpleButton sbCancel;
        private SimpleButton sbSave;
        private LayoutControlItem layoutControlItem1;
        private LayoutControlItem layoutControlItem2;
        private EmptySpaceItem emptySpaceItem4;
        private LookUpEdit lueItem;
        private LayoutControlItem lciItem;
        private EmptySpaceItem emptySpaceItem8;
        private TextEdit teRollNo;
        private LayoutControlItem lciRollNo;
        private TextEdit teCoreID;
        private DevExpress.XtraGrid.GridControl gc1;
        private DevExpress.XtraGrid.Views.Grid.GridView gv1;
        private LayoutControlItem lciType;
        private LayoutControlItem lciThick;
        private LayoutControlItem lciWidth;
        private LayoutControlItem lciLength;
        private LayoutControlItem layoutControlItem3;
        private LayoutControlItem lciCoreID;
        private TextEdit teTPLArticle;
        private TextEdit teCoronaTreatement;
        private TextEdit tePONumber;
        private LayoutControlItem lciPONumber;
        private LayoutControlItem lciCoronaTreatment;
        private LayoutControlItem lciTPLArticle;
        private TextEdit teNetWeight;
        private SimpleButton sbToLeft;
        private SimpleButton sbToRight;
        private DevExpress.XtraGrid.GridControl gc2;
        private DevExpress.XtraGrid.Views.Grid.GridView gv2;
        private LayoutControlItem layoutControlItem4;
        private LayoutControlItem layoutControlItem5;
        private LayoutControlItem layoutControlItem6;
        private EmptySpaceItem emptySpaceItem2;
        private EmptySpaceItem emptySpaceItem1;
        private EmptySpaceItem emptySpaceItem3;
        private LayoutControlItem lciNetWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colRollNumber;
        private TextEdit teJobNo;
        private LayoutControlItem lciJobNo;
        private TextEdit tePalletNumber1;
        private LayoutControlItem lciPalletNumber;
        private EmptySpaceItem emptySpaceItem5;
        private EmptySpaceItem emptySpaceItem6;
        private TextEdit tePalletNumber3;
        private TextEdit tePalletNumber4;
        private TextEdit tePalletNumber6;
        private TextEdit tePalletNumber5;
        private TextEdit tePalletNumber8;
        private TextEdit tePalletNumber7;
        private TextEdit tePalletNumber2;
        private LayoutControlItem layoutControlItem7;
        private LayoutControlItem layoutControlItem8;
        private LayoutControlItem layoutControlItem10;
        private LayoutControlItem layoutControlItem11;
        private LayoutControlItem layoutControlItem12;
        private LayoutControlItem layoutControlItem13;
        private LayoutControlItem layoutControlItem9;
        private EmptySpaceItem emptySpaceItem7;
        private EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraGrid.Columns.GridColumn colInDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRollNo;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colGr;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colWHDivision;
        private EmptySpaceItem emptySpaceItem10;
        private EmptySpaceItem emptySpaceItem11;
        private SimpleButton sbTPLPalletNum;
        private LayoutControlItem layoutControlItem14;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colCorona;
        private DevExpress.XtraGrid.Columns.GridColumn colChemical;
        private DevExpress.XtraGrid.Columns.GridColumn colPONumber;
        private DevExpress.XtraGrid.Columns.GridColumn colTPLArticle;
        private TextEdit teChemicalTreatment;
        private LayoutControlItem lciChemicalTreatment;
        private LookUpEdit lueFactory;
        private LayoutControlItem lciFactory;
        private EmptySpaceItem emptySpaceItem12;
        private EmptySpaceItem emptySpaceItem13;
        private SimpleButton sbNewPalet;
        private LayoutControlItem lciNewPalet;
    }
}