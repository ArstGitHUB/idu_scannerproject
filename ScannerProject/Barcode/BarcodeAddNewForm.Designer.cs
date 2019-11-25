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
    partial class BarcodeAddNewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeAddNewForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lc = new DevExpress.XtraLayout.LayoutControl();
            this.teTPLArticle = new DevExpress.XtraEditors.TextEdit();
            this.tePONumber = new DevExpress.XtraEditors.TextEdit();
            this.sbPrint = new DevExpress.XtraEditors.SimpleButton();
            this.sbNewBarcode = new DevExpress.XtraEditors.SimpleButton();
            this.teSlittingOrder = new DevExpress.XtraEditors.TextEdit();
            this.lueItem = new DevExpress.XtraEditors.LookUpEdit();
            this.rgLabelSize = new DevExpress.XtraEditors.RadioGroup();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.rgAutomatic = new DevExpress.XtraEditors.RadioGroup();
            this.teRemark2 = new DevExpress.XtraEditors.TextEdit();
            this.teRemark1 = new DevExpress.XtraEditors.TextEdit();
            this.teYear = new DevExpress.XtraEditors.TextEdit();
            this.teLine = new DevExpress.XtraEditors.TextEdit();
            this.teMon = new DevExpress.XtraEditors.TextEdit();
            this.teDay = new DevExpress.XtraEditors.TextEdit();
            this.teMillRollNo = new DevExpress.XtraEditors.TextEdit();
            this.teSlitterNo = new DevExpress.XtraEditors.TextEdit();
            this.teDoffingNo = new DevExpress.XtraEditors.TextEdit();
            this.ceKoreaType = new DevExpress.XtraEditors.CheckEdit();
            this.ceLabelPrint = new DevExpress.XtraEditors.CheckEdit();
            this.teMachineDesc = new DevExpress.XtraEditors.TextEdit();
            this.teLocation = new DevExpress.XtraEditors.TextEdit();
            this.lueCoreIDLength = new DevExpress.XtraEditors.LookUpEdit();
            this.lueGrade = new DevExpress.XtraEditors.LookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.teChemical = new DevExpress.XtraEditors.TextEdit();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.teNP = new DevExpress.XtraEditors.TextEdit();
            this.teType2 = new DevExpress.XtraEditors.TextEdit();
            this.teNWeight1 = new DevExpress.XtraEditors.TextEdit();
            this.teWidth1 = new DevExpress.XtraEditors.TextEdit();
            this.teLength1 = new DevExpress.XtraEditors.TextEdit();
            this.teThick = new DevExpress.XtraEditors.TextEdit();
            this.teType = new DevExpress.XtraEditors.TextEdit();
            this.teCorona = new DevExpress.XtraEditors.TextEdit();
            this.teWidth2 = new DevExpress.XtraEditors.CalcEdit();
            this.teLength2 = new DevExpress.XtraEditors.CalcEdit();
            this.teNWeight2 = new DevExpress.XtraEditors.CalcEdit();
            this.teThick2 = new DevExpress.XtraEditors.CalcEdit();
            this.caSplices = new DevExpress.XtraEditors.CalcEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciThick = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciThick2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciWidth1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLength1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNWeight1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTreate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciWidth2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLength2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNWeight2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciType2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNP = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChemical = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSplices = new DevExpress.XtraLayout.LayoutControlItem();
            this.ceSumitomo = new DevExpress.XtraEditors.CheckEdit();
            this.lueKindOfLabel = new DevExpress.XtraEditors.LookUpEdit();
            this.lueWHInDivision = new DevExpress.XtraEditors.LookUpEdit();
            this.lueMachineNo = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTeam = new DevExpress.XtraEditors.LookUpEdit();
            this.lueArmNo = new DevExpress.XtraEditors.LookUpEdit();
            this.teBoxType = new DevExpress.XtraEditors.TextEdit();
            this.lcg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSumitomo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciGrade = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLabelPrint = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciKoreaType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciYear = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLine = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMon = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDay = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciMillRollNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTeam = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSlitterNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDoffingNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciArmNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCoreIDLength = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRemark1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRemark2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAutomatic = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciKindOfLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciWHInDivision = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBoxType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLocation = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMachineNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciMachineDesc = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSlittingOrder = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTPLArticle = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciPONumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciLabelSize = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciNewBarcode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).BeginInit();
            this.lc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTPLArticle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePONumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSlittingOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgLabelSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgAutomatic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRemark2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRemark1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMillRollNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSlitterNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDoffingNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceKoreaType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceLabelPrint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMachineDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCoreIDLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrade.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teChemical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teType2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNWeight1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWidth1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLength1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teThick.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCorona.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWidth2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLength2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNWeight2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teThick2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caSplices.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciThick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciThick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWidth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLength1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWidth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLength2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNWeight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSplices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSumitomo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKindOfLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueWHInDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMachineNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueArmNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBoxType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSumitomo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKoreaType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMillRollNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSlitterNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoffingNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArmNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoreIDLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemark1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemark2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAutomatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKindOfLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWHInDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBoxType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMachineNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMachineDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSlittingOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTPLArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPONumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(994, 34);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // lc
            // 
            this.lc.Controls.Add(this.teTPLArticle);
            this.lc.Controls.Add(this.tePONumber);
            this.lc.Controls.Add(this.sbPrint);
            this.lc.Controls.Add(this.sbNewBarcode);
            this.lc.Controls.Add(this.teSlittingOrder);
            this.lc.Controls.Add(this.lueItem);
            this.lc.Controls.Add(this.rgLabelSize);
            this.lc.Controls.Add(this.sbCancel);
            this.lc.Controls.Add(this.sbSave);
            this.lc.Controls.Add(this.rgAutomatic);
            this.lc.Controls.Add(this.teRemark2);
            this.lc.Controls.Add(this.teRemark1);
            this.lc.Controls.Add(this.teYear);
            this.lc.Controls.Add(this.teLine);
            this.lc.Controls.Add(this.teMon);
            this.lc.Controls.Add(this.teDay);
            this.lc.Controls.Add(this.teMillRollNo);
            this.lc.Controls.Add(this.teSlitterNo);
            this.lc.Controls.Add(this.teDoffingNo);
            this.lc.Controls.Add(this.ceKoreaType);
            this.lc.Controls.Add(this.ceLabelPrint);
            this.lc.Controls.Add(this.teMachineDesc);
            this.lc.Controls.Add(this.teLocation);
            this.lc.Controls.Add(this.lueCoreIDLength);
            this.lc.Controls.Add(this.lueGrade);
            this.lc.Controls.Add(this.panel1);
            this.lc.Controls.Add(this.ceSumitomo);
            this.lc.Controls.Add(this.lueKindOfLabel);
            this.lc.Controls.Add(this.lueWHInDivision);
            this.lc.Controls.Add(this.lueMachineNo);
            this.lc.Controls.Add(this.lueTeam);
            this.lc.Controls.Add(this.lueArmNo);
            this.lc.Controls.Add(this.teBoxType);
            this.lc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc.Location = new System.Drawing.Point(0, 34);
            this.lc.Name = "lc";
            this.lc.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(907, 1022, 500, 700);
            this.lc.Root = this.lcg;
            this.lc.Size = new System.Drawing.Size(994, 574);
            this.lc.TabIndex = 2;
            this.lc.Text = "layoutControl1";
            // 
            // teTPLArticle
            // 
            this.teTPLArticle.Location = new System.Drawing.Point(608, 488);
            this.teTPLArticle.MenuManager = this.ribbon;
            this.teTPLArticle.Name = "teTPLArticle";
            this.teTPLArticle.Size = new System.Drawing.Size(355, 22);
            this.teTPLArticle.StyleController = this.lc;
            this.teTPLArticle.TabIndex = 45;
            // 
            // tePONumber
            // 
            this.tePONumber.Location = new System.Drawing.Point(132, 488);
            this.tePONumber.MenuManager = this.ribbon;
            this.tePONumber.Name = "tePONumber";
            this.tePONumber.Size = new System.Drawing.Size(359, 22);
            this.tePONumber.StyleController = this.lc;
            this.tePONumber.TabIndex = 44;
            // 
            // sbPrint
            // 
            this.sbPrint.Image = ((System.Drawing.Image)(resources.GetObject("sbPrint.Image")));
            this.sbPrint.Location = new System.Drawing.Point(617, 531);
            this.sbPrint.Name = "sbPrint";
            this.sbPrint.Size = new System.Drawing.Size(117, 27);
            this.sbPrint.StyleController = this.lc;
            this.sbPrint.TabIndex = 43;
            this.sbPrint.Text = "Print";
            this.sbPrint.Click += new System.EventHandler(this.sbPrint_Click_1);
            // 
            // sbNewBarcode
            // 
            this.sbNewBarcode.Image = ((System.Drawing.Image)(resources.GetObject("sbNewBarcode.Image")));
            this.sbNewBarcode.Location = new System.Drawing.Point(16, 531);
            this.sbNewBarcode.Name = "sbNewBarcode";
            this.sbNewBarcode.Size = new System.Drawing.Size(143, 27);
            this.sbNewBarcode.StyleController = this.lc;
            this.sbNewBarcode.TabIndex = 42;
            this.sbNewBarcode.Text = "New Barcode";
            this.sbNewBarcode.Click += new System.EventHandler(this.sbNewBarcode_Click);
            // 
            // teSlittingOrder
            // 
            this.teSlittingOrder.Location = new System.Drawing.Point(608, 460);
            this.teSlittingOrder.MenuManager = this.ribbon;
            this.teSlittingOrder.Name = "teSlittingOrder";
            this.teSlittingOrder.Size = new System.Drawing.Size(355, 22);
            this.teSlittingOrder.StyleController = this.lc;
            this.teSlittingOrder.TabIndex = 41;
            // 
            // lueItem
            // 
            this.lueItem.Location = new System.Drawing.Point(117, 16);
            this.lueItem.MenuManager = this.ribbon;
            this.lueItem.Name = "lueItem";
            this.lueItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.lueItem.Size = new System.Drawing.Size(372, 22);
            this.lueItem.StyleController = this.lc;
            this.lueItem.TabIndex = 40;
            this.lueItem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueItem_ButtonClick);
            this.lueItem.EditValueChanged += new System.EventHandler(this.lueItem_EditValueChanged);
            // 
            // rgLabelSize
            // 
            this.rgLabelSize.Location = new System.Drawing.Point(800, 265);
            this.rgLabelSize.MenuManager = this.ribbon;
            this.rgLabelSize.Name = "rgLabelSize";
            this.rgLabelSize.Size = new System.Drawing.Size(178, 90);
            this.rgLabelSize.StyleController = this.lc;
            this.rgLabelSize.TabIndex = 39;
            // 
            // sbCancel
            // 
            this.sbCancel.Image = ((System.Drawing.Image)(resources.GetObject("sbCancel.Image")));
            this.sbCancel.Location = new System.Drawing.Point(853, 531);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(125, 27);
            this.sbCancel.StyleController = this.lc;
            this.sbCancel.TabIndex = 38;
            this.sbCancel.Text = "Cancel";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // sbSave
            // 
            this.sbSave.Image = ((System.Drawing.Image)(resources.GetObject("sbSave.Image")));
            this.sbSave.Location = new System.Drawing.Point(740, 531);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(107, 27);
            this.sbSave.StyleController = this.lc;
            this.sbSave.TabIndex = 37;
            this.sbSave.Text = "Save";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // rgAutomatic
            // 
            this.rgAutomatic.Location = new System.Drawing.Point(322, 44);
            this.rgAutomatic.MenuManager = this.ribbon;
            this.rgAutomatic.Name = "rgAutomatic";
            this.rgAutomatic.Size = new System.Drawing.Size(299, 22);
            this.rgAutomatic.StyleController = this.lc;
            this.rgAutomatic.TabIndex = 36;
            this.rgAutomatic.SelectedIndexChanged += new System.EventHandler(this.rgAutoOrManual_SelectedIndexChanged);
            // 
            // teRemark2
            // 
            this.teRemark2.Location = new System.Drawing.Point(584, 361);
            this.teRemark2.MenuManager = this.ribbon;
            this.teRemark2.Name = "teRemark2";
            this.teRemark2.Size = new System.Drawing.Size(394, 22);
            this.teRemark2.StyleController = this.lc;
            this.teRemark2.TabIndex = 35;
            // 
            // teRemark1
            // 
            this.teRemark1.Location = new System.Drawing.Point(117, 361);
            this.teRemark1.MenuManager = this.ribbon;
            this.teRemark1.Name = "teRemark1";
            this.teRemark1.Size = new System.Drawing.Size(461, 22);
            this.teRemark1.StyleController = this.lc;
            this.teRemark1.TabIndex = 34;
            // 
            // teYear
            // 
            this.teYear.Location = new System.Drawing.Point(20, 317);
            this.teYear.Margin = new System.Windows.Forms.Padding(2);
            this.teYear.MenuManager = this.ribbon;
            this.teYear.Name = "teYear";
            this.teYear.Properties.MaxLength = 1;
            this.teYear.Size = new System.Drawing.Size(54, 22);
            this.teYear.StyleController = this.lc;
            this.teYear.TabIndex = 33;
            this.teYear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.teYear_KeyUp);
            // 
            // teLine
            // 
            this.teLine.Location = new System.Drawing.Point(80, 317);
            this.teLine.Margin = new System.Windows.Forms.Padding(2);
            this.teLine.MenuManager = this.ribbon;
            this.teLine.Name = "teLine";
            this.teLine.Properties.MaxLength = 1;
            this.teLine.Size = new System.Drawing.Size(54, 22);
            this.teLine.StyleController = this.lc;
            this.teLine.TabIndex = 32;
            this.teLine.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.teLine_PreviewKeyDown);
            // 
            // teMon
            // 
            this.teMon.Location = new System.Drawing.Point(140, 317);
            this.teMon.Margin = new System.Windows.Forms.Padding(2);
            this.teMon.MenuManager = this.ribbon;
            this.teMon.Name = "teMon";
            this.teMon.Properties.MaxLength = 1;
            this.teMon.Size = new System.Drawing.Size(54, 22);
            this.teMon.StyleController = this.lc;
            this.teMon.TabIndex = 31;
            // 
            // teDay
            // 
            this.teDay.Location = new System.Drawing.Point(200, 317);
            this.teDay.Margin = new System.Windows.Forms.Padding(2);
            this.teDay.MenuManager = this.ribbon;
            this.teDay.Name = "teDay";
            this.teDay.Properties.MaxLength = 2;
            this.teDay.Size = new System.Drawing.Size(54, 22);
            this.teDay.StyleController = this.lc;
            this.teDay.TabIndex = 30;
            // 
            // teMillRollNo
            // 
            this.teMillRollNo.Location = new System.Drawing.Point(270, 317);
            this.teMillRollNo.Margin = new System.Windows.Forms.Padding(2);
            this.teMillRollNo.MenuManager = this.ribbon;
            this.teMillRollNo.Name = "teMillRollNo";
            this.teMillRollNo.Properties.MaxLength = 2;
            this.teMillRollNo.Size = new System.Drawing.Size(99, 22);
            this.teMillRollNo.StyleController = this.lc;
            this.teMillRollNo.TabIndex = 29;
            // 
            // teSlitterNo
            // 
            this.teSlitterNo.Location = new System.Drawing.Point(480, 317);
            this.teSlitterNo.Margin = new System.Windows.Forms.Padding(2);
            this.teSlitterNo.MenuManager = this.ribbon;
            this.teSlitterNo.Name = "teSlitterNo";
            this.teSlitterNo.Properties.MaxLength = 1;
            this.teSlitterNo.Size = new System.Drawing.Size(99, 22);
            this.teSlitterNo.StyleController = this.lc;
            this.teSlitterNo.TabIndex = 27;
            this.teSlitterNo.EditValueChanged += new System.EventHandler(this.teSlitterNo_EditValueChanged);
            // 
            // teDoffingNo
            // 
            this.teDoffingNo.Location = new System.Drawing.Point(585, 317);
            this.teDoffingNo.Margin = new System.Windows.Forms.Padding(2);
            this.teDoffingNo.MenuManager = this.ribbon;
            this.teDoffingNo.Name = "teDoffingNo";
            this.teDoffingNo.Properties.MaxLength = 1;
            this.teDoffingNo.Size = new System.Drawing.Size(99, 22);
            this.teDoffingNo.StyleController = this.lc;
            this.teDoffingNo.TabIndex = 24;
            // 
            // ceKoreaType
            // 
            this.ceKoreaType.Location = new System.Drawing.Point(673, 237);
            this.ceKoreaType.Margin = new System.Windows.Forms.Padding(2);
            this.ceKoreaType.MenuManager = this.ribbon;
            this.ceKoreaType.Name = "ceKoreaType";
            this.ceKoreaType.Properties.Caption = "Korea Type";
            this.ceKoreaType.Size = new System.Drawing.Size(167, 20);
            this.ceKoreaType.StyleController = this.lc;
            this.ceKoreaType.TabIndex = 23;
            // 
            // ceLabelPrint
            // 
            this.ceLabelPrint.Location = new System.Drawing.Point(846, 237);
            this.ceLabelPrint.Margin = new System.Windows.Forms.Padding(2);
            this.ceLabelPrint.MenuManager = this.ribbon;
            this.ceLabelPrint.Name = "ceLabelPrint";
            this.ceLabelPrint.Properties.Caption = "Label Print";
            this.ceLabelPrint.Size = new System.Drawing.Size(132, 20);
            this.ceLabelPrint.StyleController = this.lc;
            this.ceLabelPrint.TabIndex = 22;
            // 
            // teMachineDesc
            // 
            this.teMachineDesc.Location = new System.Drawing.Point(132, 460);
            this.teMachineDesc.Margin = new System.Windows.Forms.Padding(2);
            this.teMachineDesc.MenuManager = this.ribbon;
            this.teMachineDesc.Name = "teMachineDesc";
            this.teMachineDesc.Size = new System.Drawing.Size(359, 22);
            this.teMachineDesc.StyleController = this.lc;
            this.teMachineDesc.TabIndex = 15;
            // 
            // teLocation
            // 
            this.teLocation.Location = new System.Drawing.Point(608, 432);
            this.teLocation.Margin = new System.Windows.Forms.Padding(2);
            this.teLocation.MenuManager = this.ribbon;
            this.teLocation.Name = "teLocation";
            this.teLocation.Size = new System.Drawing.Size(355, 22);
            this.teLocation.StyleController = this.lc;
            this.teLocation.TabIndex = 13;
            // 
            // lueCoreIDLength
            // 
            this.lueCoreIDLength.Location = new System.Drawing.Point(456, 237);
            this.lueCoreIDLength.Margin = new System.Windows.Forms.Padding(2);
            this.lueCoreIDLength.MenuManager = this.ribbon;
            this.lueCoreIDLength.Name = "lueCoreIDLength";
            this.lueCoreIDLength.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCoreIDLength.Properties.NullText = "";
            this.lueCoreIDLength.Size = new System.Drawing.Size(201, 22);
            this.lueCoreIDLength.StyleController = this.lc;
            this.lueCoreIDLength.TabIndex = 11;
            // 
            // lueGrade
            // 
            this.lueGrade.Location = new System.Drawing.Point(117, 237);
            this.lueGrade.Margin = new System.Windows.Forms.Padding(2);
            this.lueGrade.MenuManager = this.ribbon;
            this.lueGrade.Name = "lueGrade";
            this.lueGrade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGrade.Properties.NullText = "";
            this.lueGrade.Size = new System.Drawing.Size(222, 22);
            this.lueGrade.StyleController = this.lc;
            this.lueGrade.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.layoutControl1);
            this.panel1.Location = new System.Drawing.Point(16, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 129);
            this.panel1.TabIndex = 9;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teChemical);
            this.layoutControl1.Controls.Add(this.teName);
            this.layoutControl1.Controls.Add(this.teNP);
            this.layoutControl1.Controls.Add(this.teType2);
            this.layoutControl1.Controls.Add(this.teNWeight1);
            this.layoutControl1.Controls.Add(this.teWidth1);
            this.layoutControl1.Controls.Add(this.teLength1);
            this.layoutControl1.Controls.Add(this.teThick);
            this.layoutControl1.Controls.Add(this.teType);
            this.layoutControl1.Controls.Add(this.teCorona);
            this.layoutControl1.Controls.Add(this.teWidth2);
            this.layoutControl1.Controls.Add(this.teLength2);
            this.layoutControl1.Controls.Add(this.teNWeight2);
            this.layoutControl1.Controls.Add(this.teThick2);
            this.layoutControl1.Controls.Add(this.caSplices);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(958, 46, 500, 700);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(962, 129);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teChemical
            // 
            this.teChemical.Location = new System.Drawing.Point(723, 3);
            this.teChemical.MenuManager = this.ribbon;
            this.teChemical.Name = "teChemical";
            this.teChemical.Size = new System.Drawing.Size(236, 22);
            this.teChemical.StyleController = this.layoutControl1;
            this.teChemical.TabIndex = 17;
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(658, 87);
            this.teName.MenuManager = this.ribbon;
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(301, 22);
            this.teName.StyleController = this.layoutControl1;
            this.teName.TabIndex = 16;
            // 
            // teNP
            // 
            this.teNP.Location = new System.Drawing.Point(586, 87);
            this.teNP.Margin = new System.Windows.Forms.Padding(2);
            this.teNP.MenuManager = this.ribbon;
            this.teNP.Name = "teNP";
            this.teNP.Size = new System.Drawing.Size(66, 22);
            this.teNP.StyleController = this.layoutControl1;
            this.teNP.TabIndex = 15;
            // 
            // teType2
            // 
            this.teType2.Location = new System.Drawing.Point(108, 87);
            this.teType2.Margin = new System.Windows.Forms.Padding(2);
            this.teType2.MenuManager = this.ribbon;
            this.teType2.Name = "teType2";
            this.teType2.Size = new System.Drawing.Size(127, 22);
            this.teType2.StyleController = this.layoutControl1;
            this.teType2.TabIndex = 14;
            // 
            // teNWeight1
            // 
            this.teNWeight1.Location = new System.Drawing.Point(845, 31);
            this.teNWeight1.Margin = new System.Windows.Forms.Padding(2);
            this.teNWeight1.MenuManager = this.ribbon;
            this.teNWeight1.Name = "teNWeight1";
            this.teNWeight1.Size = new System.Drawing.Size(114, 22);
            this.teNWeight1.StyleController = this.layoutControl1;
            this.teNWeight1.TabIndex = 13;
            this.teNWeight1.EditValueChanged += new System.EventHandler(this.teNWeight1_EditValueChanged);
            // 
            // teWidth1
            // 
            this.teWidth1.Location = new System.Drawing.Point(346, 31);
            this.teWidth1.Margin = new System.Windows.Forms.Padding(2);
            this.teWidth1.MenuManager = this.ribbon;
            this.teWidth1.Name = "teWidth1";
            this.teWidth1.Size = new System.Drawing.Size(119, 22);
            this.teWidth1.StyleController = this.layoutControl1;
            this.teWidth1.TabIndex = 10;
            this.teWidth1.EditValueChanged += new System.EventHandler(this.teWidth1_EditValueChanged);
            // 
            // teLength1
            // 
            this.teLength1.Location = new System.Drawing.Point(586, 31);
            this.teLength1.Margin = new System.Windows.Forms.Padding(2);
            this.teLength1.MenuManager = this.ribbon;
            this.teLength1.Name = "teLength1";
            this.teLength1.Size = new System.Drawing.Size(148, 22);
            this.teLength1.StyleController = this.layoutControl1;
            this.teLength1.TabIndex = 9;
            this.teLength1.EditValueChanged += new System.EventHandler(this.teLength1_EditValueChanged);
            // 
            // teThick
            // 
            this.teThick.Location = new System.Drawing.Point(108, 31);
            this.teThick.Margin = new System.Windows.Forms.Padding(2);
            this.teThick.MenuManager = this.ribbon;
            this.teThick.Name = "teThick";
            this.teThick.Size = new System.Drawing.Size(127, 22);
            this.teThick.StyleController = this.layoutControl1;
            this.teThick.TabIndex = 6;
            this.teThick.EditValueChanged += new System.EventHandler(this.teThick_EditValueChanged);
            // 
            // teType
            // 
            this.teType.Location = new System.Drawing.Point(108, 3);
            this.teType.Margin = new System.Windows.Forms.Padding(2);
            this.teType.MenuManager = this.ribbon;
            this.teType.Name = "teType";
            this.teType.Size = new System.Drawing.Size(357, 22);
            this.teType.StyleController = this.layoutControl1;
            this.teType.TabIndex = 5;
            // 
            // teCorona
            // 
            this.teCorona.Location = new System.Drawing.Point(586, 3);
            this.teCorona.Margin = new System.Windows.Forms.Padding(2);
            this.teCorona.MenuManager = this.ribbon;
            this.teCorona.Name = "teCorona";
            this.teCorona.Size = new System.Drawing.Size(131, 22);
            this.teCorona.StyleController = this.layoutControl1;
            this.teCorona.TabIndex = 4;
            // 
            // teWidth2
            // 
            this.teWidth2.Location = new System.Drawing.Point(346, 59);
            this.teWidth2.Margin = new System.Windows.Forms.Padding(2);
            this.teWidth2.MenuManager = this.ribbon;
            this.teWidth2.Name = "teWidth2";
            this.teWidth2.Properties.DisplayFormat.FormatString = "#,##0.0";
            this.teWidth2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.teWidth2.Properties.EditFormat.FormatString = "#,##0.0";
            this.teWidth2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.teWidth2.Properties.Mask.EditMask = "N1";
            this.teWidth2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.teWidth2.Properties.ReadOnly = true;
            this.teWidth2.Size = new System.Drawing.Size(119, 22);
            this.teWidth2.StyleController = this.layoutControl1;
            this.teWidth2.TabIndex = 12;
            // 
            // teLength2
            // 
            this.teLength2.Location = new System.Drawing.Point(586, 59);
            this.teLength2.Margin = new System.Windows.Forms.Padding(2);
            this.teLength2.MenuManager = this.ribbon;
            this.teLength2.Name = "teLength2";
            this.teLength2.Properties.DisplayFormat.FormatString = "#,##0.0";
            this.teLength2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.teLength2.Properties.EditFormat.FormatString = "#,##0.0";
            this.teLength2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.teLength2.Properties.Mask.EditMask = "N1";
            this.teLength2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.teLength2.Properties.ReadOnly = true;
            this.teLength2.Size = new System.Drawing.Size(148, 22);
            this.teLength2.StyleController = this.layoutControl1;
            this.teLength2.TabIndex = 11;
            // 
            // teNWeight2
            // 
            this.teNWeight2.Location = new System.Drawing.Point(845, 59);
            this.teNWeight2.Margin = new System.Windows.Forms.Padding(2);
            this.teNWeight2.MenuManager = this.ribbon;
            this.teNWeight2.Name = "teNWeight2";
            this.teNWeight2.Properties.DisplayFormat.FormatString = "#,##0.0";
            this.teNWeight2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.teNWeight2.Properties.EditFormat.FormatString = "#,##0.0";
            this.teNWeight2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.teNWeight2.Properties.Mask.EditMask = "N1";
            this.teNWeight2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.teNWeight2.Properties.ReadOnly = true;
            this.teNWeight2.Size = new System.Drawing.Size(114, 22);
            this.teNWeight2.StyleController = this.layoutControl1;
            this.teNWeight2.TabIndex = 8;
            // 
            // teThick2
            // 
            this.teThick2.Location = new System.Drawing.Point(108, 59);
            this.teThick2.Margin = new System.Windows.Forms.Padding(2);
            this.teThick2.MenuManager = this.ribbon;
            this.teThick2.Name = "teThick2";
            this.teThick2.Properties.DisplayFormat.FormatString = "#,##0.0";
            this.teThick2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.teThick2.Properties.EditFormat.FormatString = "#,##0.0";
            this.teThick2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.teThick2.Properties.Mask.EditMask = "N0";
            this.teThick2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.teThick2.Properties.ReadOnly = true;
            this.teThick2.Size = new System.Drawing.Size(127, 22);
            this.teThick2.StyleController = this.layoutControl1;
            this.teThick2.TabIndex = 7;
            // 
            // caSplices
            // 
            this.caSplices.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.caSplices.Location = new System.Drawing.Point(346, 87);
            this.caSplices.MenuManager = this.ribbon;
            this.caSplices.Name = "caSplices";
            this.caSplices.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.caSplices.Properties.DisplayFormat.FormatString = "#,##0";
            this.caSplices.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.caSplices.Properties.EditFormat.FormatString = "#,##0";
            this.caSplices.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.caSplices.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.caSplices.Properties.Mask.EditMask = "N0";
            this.caSplices.Size = new System.Drawing.Size(119, 22);
            this.caSplices.StyleController = this.layoutControl1;
            this.caSplices.TabIndex = 18;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciThick,
            this.lciThick2,
            this.lciWidth1,
            this.lciLength1,
            this.lciNWeight1,
            this.lciType,
            this.lciTreate,
            this.lciWidth2,
            this.lciLength2,
            this.lciNWeight2,
            this.lciType2,
            this.lciNP,
            this.emptySpaceItem3,
            this.lciName,
            this.lciChemical,
            this.lciSplices});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(962, 129);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciThick
            // 
            this.lciThick.Control = this.teThick;
            this.lciThick.Location = new System.Drawing.Point(0, 28);
            this.lciThick.Name = "lciThick";
            this.lciThick.Size = new System.Drawing.Size(238, 28);
            this.lciThick.Text = "Thick (micro m)";
            this.lciThick.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciThick.TextSize = new System.Drawing.Size(100, 20);
            this.lciThick.TextToControlDistance = 5;
            // 
            // lciThick2
            // 
            this.lciThick2.Control = this.teThick2;
            this.lciThick2.Location = new System.Drawing.Point(0, 56);
            this.lciThick2.Name = "lciThick2";
            this.lciThick2.Size = new System.Drawing.Size(238, 28);
            this.lciThick2.Text = "Thick (gauge)";
            this.lciThick2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciThick2.TextSize = new System.Drawing.Size(100, 20);
            this.lciThick2.TextToControlDistance = 5;
            // 
            // lciWidth1
            // 
            this.lciWidth1.Control = this.teWidth1;
            this.lciWidth1.Location = new System.Drawing.Point(238, 28);
            this.lciWidth1.Name = "lciWidth1";
            this.lciWidth1.Size = new System.Drawing.Size(230, 28);
            this.lciWidth1.Text = "Width (mm)";
            this.lciWidth1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciWidth1.TextSize = new System.Drawing.Size(100, 20);
            this.lciWidth1.TextToControlDistance = 5;
            // 
            // lciLength1
            // 
            this.lciLength1.Control = this.teLength1;
            this.lciLength1.Location = new System.Drawing.Point(478, 28);
            this.lciLength1.Name = "lciLength1";
            this.lciLength1.Size = new System.Drawing.Size(259, 28);
            this.lciLength1.Text = "Length (m)";
            this.lciLength1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciLength1.TextSize = new System.Drawing.Size(100, 20);
            this.lciLength1.TextToControlDistance = 5;
            // 
            // lciNWeight1
            // 
            this.lciNWeight1.Control = this.teNWeight1;
            this.lciNWeight1.Location = new System.Drawing.Point(737, 28);
            this.lciNWeight1.Name = "lciNWeight1";
            this.lciNWeight1.Size = new System.Drawing.Size(225, 28);
            this.lciNWeight1.Text = "Net Weight (Kg)";
            this.lciNWeight1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciNWeight1.TextSize = new System.Drawing.Size(100, 20);
            this.lciNWeight1.TextToControlDistance = 5;
            // 
            // lciType
            // 
            this.lciType.Control = this.teType;
            this.lciType.Location = new System.Drawing.Point(0, 0);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(468, 28);
            this.lciType.Text = "Type";
            this.lciType.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciType.TextSize = new System.Drawing.Size(100, 20);
            this.lciType.TextToControlDistance = 5;
            // 
            // lciTreate
            // 
            this.lciTreate.Control = this.teCorona;
            this.lciTreate.Location = new System.Drawing.Point(478, 0);
            this.lciTreate.Name = "lciTreate";
            this.lciTreate.Size = new System.Drawing.Size(242, 28);
            this.lciTreate.Text = "Treate";
            this.lciTreate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciTreate.TextSize = new System.Drawing.Size(100, 20);
            this.lciTreate.TextToControlDistance = 5;
            // 
            // lciWidth2
            // 
            this.lciWidth2.Control = this.teWidth2;
            this.lciWidth2.Location = new System.Drawing.Point(238, 56);
            this.lciWidth2.Name = "lciWidth2";
            this.lciWidth2.Size = new System.Drawing.Size(230, 28);
            this.lciWidth2.Text = "Width (inch)";
            this.lciWidth2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciWidth2.TextSize = new System.Drawing.Size(100, 20);
            this.lciWidth2.TextToControlDistance = 5;
            // 
            // lciLength2
            // 
            this.lciLength2.Control = this.teLength2;
            this.lciLength2.Location = new System.Drawing.Point(478, 56);
            this.lciLength2.Name = "lciLength2";
            this.lciLength2.Size = new System.Drawing.Size(259, 28);
            this.lciLength2.Text = "Length (ft)";
            this.lciLength2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciLength2.TextSize = new System.Drawing.Size(100, 20);
            this.lciLength2.TextToControlDistance = 5;
            // 
            // lciNWeight2
            // 
            this.lciNWeight2.Control = this.teNWeight2;
            this.lciNWeight2.Location = new System.Drawing.Point(737, 56);
            this.lciNWeight2.Name = "lciNWeight2";
            this.lciNWeight2.Size = new System.Drawing.Size(225, 28);
            this.lciNWeight2.Text = "Net Weight (Lb)";
            this.lciNWeight2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciNWeight2.TextSize = new System.Drawing.Size(100, 20);
            this.lciNWeight2.TextToControlDistance = 5;
            // 
            // lciType2
            // 
            this.lciType2.Control = this.teType2;
            this.lciType2.Location = new System.Drawing.Point(0, 84);
            this.lciType2.Name = "lciType2";
            this.lciType2.Size = new System.Drawing.Size(238, 45);
            this.lciType2.Text = "Type2";
            this.lciType2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciType2.TextSize = new System.Drawing.Size(100, 20);
            this.lciType2.TextToControlDistance = 5;
            // 
            // lciNP
            // 
            this.lciNP.Control = this.teNP;
            this.lciNP.Location = new System.Drawing.Point(478, 84);
            this.lciNP.Name = "lciNP";
            this.lciNP.Size = new System.Drawing.Size(177, 45);
            this.lciNP.Text = "N/P";
            this.lciNP.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciNP.TextSize = new System.Drawing.Size(100, 25);
            this.lciNP.TextToControlDistance = 5;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(468, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(10, 129);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciName
            // 
            this.lciName.Control = this.teName;
            this.lciName.Location = new System.Drawing.Point(655, 84);
            this.lciName.Name = "lciName";
            this.lciName.Size = new System.Drawing.Size(307, 45);
            this.lciName.TextSize = new System.Drawing.Size(0, 0);
            this.lciName.TextVisible = false;
            // 
            // lciChemical
            // 
            this.lciChemical.Control = this.teChemical;
            this.lciChemical.Location = new System.Drawing.Point(720, 0);
            this.lciChemical.Name = "lciChemical";
            this.lciChemical.Size = new System.Drawing.Size(242, 28);
            this.lciChemical.TextSize = new System.Drawing.Size(0, 0);
            this.lciChemical.TextVisible = false;
            // 
            // lciSplices
            // 
            this.lciSplices.Control = this.caSplices;
            this.lciSplices.Location = new System.Drawing.Point(238, 84);
            this.lciSplices.Name = "lciSplices";
            this.lciSplices.Size = new System.Drawing.Size(230, 45);
            this.lciSplices.Text = "Splices";
            this.lciSplices.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciSplices.TextSize = new System.Drawing.Size(100, 16);
            this.lciSplices.TextToControlDistance = 5;
            // 
            // ceSumitomo
            // 
            this.ceSumitomo.Location = new System.Drawing.Point(627, 44);
            this.ceSumitomo.Margin = new System.Windows.Forms.Padding(2);
            this.ceSumitomo.MenuManager = this.ribbon;
            this.ceSumitomo.Name = "ceSumitomo";
            this.ceSumitomo.Properties.Caption = "Sumitomo";
            this.ceSumitomo.Size = new System.Drawing.Size(351, 20);
            this.ceSumitomo.StyleController = this.lc;
            this.ceSumitomo.TabIndex = 7;
            // 
            // lueKindOfLabel
            // 
            this.lueKindOfLabel.Location = new System.Drawing.Point(117, 44);
            this.lueKindOfLabel.Margin = new System.Windows.Forms.Padding(2);
            this.lueKindOfLabel.MenuManager = this.ribbon;
            this.lueKindOfLabel.Name = "lueKindOfLabel";
            this.lueKindOfLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.lueKindOfLabel.Properties.NullText = "";
            this.lueKindOfLabel.Size = new System.Drawing.Size(199, 22);
            this.lueKindOfLabel.StyleController = this.lc;
            this.lueKindOfLabel.TabIndex = 4;
            this.lueKindOfLabel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueKindOfLabel_ButtonClick);
            this.lueKindOfLabel.EditValueChanged += new System.EventHandler(this.lueKindOfLabel_EditValueChanged);
            // 
            // lueWHInDivision
            // 
            this.lueWHInDivision.Location = new System.Drawing.Point(132, 404);
            this.lueWHInDivision.Margin = new System.Windows.Forms.Padding(2);
            this.lueWHInDivision.MenuManager = this.ribbon;
            this.lueWHInDivision.Name = "lueWHInDivision";
            this.lueWHInDivision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueWHInDivision.Properties.NullText = "";
            this.lueWHInDivision.Size = new System.Drawing.Size(359, 22);
            this.lueWHInDivision.StyleController = this.lc;
            this.lueWHInDivision.TabIndex = 17;
            // 
            // lueMachineNo
            // 
            this.lueMachineNo.Location = new System.Drawing.Point(132, 432);
            this.lueMachineNo.Margin = new System.Windows.Forms.Padding(2);
            this.lueMachineNo.MenuManager = this.ribbon;
            this.lueMachineNo.Name = "lueMachineNo";
            this.lueMachineNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMachineNo.Properties.NullText = "";
            this.lueMachineNo.Size = new System.Drawing.Size(359, 22);
            this.lueMachineNo.StyleController = this.lc;
            this.lueMachineNo.TabIndex = 12;
            this.lueMachineNo.EditValueChanged += new System.EventHandler(this.lueMachineNo_EditValueChanged);
            // 
            // lueTeam
            // 
            this.lueTeam.Location = new System.Drawing.Point(375, 317);
            this.lueTeam.Margin = new System.Windows.Forms.Padding(2);
            this.lueTeam.MenuManager = this.ribbon;
            this.lueTeam.Name = "lueTeam";
            this.lueTeam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTeam.Properties.NullText = "";
            this.lueTeam.Size = new System.Drawing.Size(99, 22);
            this.lueTeam.StyleController = this.lc;
            this.lueTeam.TabIndex = 28;
            // 
            // lueArmNo
            // 
            this.lueArmNo.Location = new System.Drawing.Point(690, 317);
            this.lueArmNo.Margin = new System.Windows.Forms.Padding(2);
            this.lueArmNo.MenuManager = this.ribbon;
            this.lueArmNo.Name = "lueArmNo";
            this.lueArmNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueArmNo.Properties.NullText = "";
            this.lueArmNo.Size = new System.Drawing.Size(100, 22);
            this.lueArmNo.StyleController = this.lc;
            this.lueArmNo.TabIndex = 25;
            // 
            // teBoxType
            // 
            this.teBoxType.Location = new System.Drawing.Point(608, 404);
            this.teBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.teBoxType.MenuManager = this.ribbon;
            this.teBoxType.Name = "teBoxType";
            this.teBoxType.Size = new System.Drawing.Size(355, 22);
            this.teBoxType.StyleController = this.lc;
            this.teBoxType.TabIndex = 18;
            // 
            // lcg
            // 
            this.lcg.CustomizationFormText = "lcg";
            this.lcg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcg.GroupBordersVisible = false;
            this.lcg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSumitomo,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.lciGrade,
            this.lciLabelPrint,
            this.lciKoreaType,
            this.layoutControlGroup2,
            this.lciCoreIDLength,
            this.lciRemark1,
            this.lciRemark2,
            this.lciAutomatic,
            this.lciSave,
            this.layoutControlItem2,
            this.emptySpaceItem4,
            this.lciKindOfLabel,
            this.layoutControlGroup3,
            this.emptySpaceItem2,
            this.emptySpaceItem7,
            this.lciLabelSize,
            this.lciItem,
            this.emptySpaceItem8,
            this.lciNewBarcode,
            this.layoutControlItem1});
            this.lcg.Location = new System.Drawing.Point(0, 0);
            this.lcg.Name = "Root";
            this.lcg.Size = new System.Drawing.Size(994, 574);
            this.lcg.TextVisible = false;
            // 
            // lciSumitomo
            // 
            this.lciSumitomo.Control = this.ceSumitomo;
            this.lciSumitomo.Location = new System.Drawing.Point(611, 28);
            this.lciSumitomo.Name = "lciSumitomo";
            this.lciSumitomo.Size = new System.Drawing.Size(357, 28);
            this.lciSumitomo.Text = "Sumitomo";
            this.lciSumitomo.TextSize = new System.Drawing.Size(0, 0);
            this.lciSumitomo.TextVisible = false;
            this.lciSumitomo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 56);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(968, 11);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem6.Control = this.panel1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 67);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(968, 154);
            this.layoutControlItem6.Text = "Item Detail";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(98, 16);
            // 
            // lciGrade
            // 
            this.lciGrade.Control = this.lueGrade;
            this.lciGrade.Location = new System.Drawing.Point(0, 221);
            this.lciGrade.Name = "lciGrade";
            this.lciGrade.Size = new System.Drawing.Size(329, 28);
            this.lciGrade.Text = "Grade";
            this.lciGrade.TextSize = new System.Drawing.Size(98, 16);
            // 
            // lciLabelPrint
            // 
            this.lciLabelPrint.Control = this.ceLabelPrint;
            this.lciLabelPrint.Location = new System.Drawing.Point(830, 221);
            this.lciLabelPrint.Name = "lciLabelPrint";
            this.lciLabelPrint.Size = new System.Drawing.Size(138, 28);
            this.lciLabelPrint.TextSize = new System.Drawing.Size(0, 0);
            this.lciLabelPrint.TextVisible = false;
            this.lciLabelPrint.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciKoreaType
            // 
            this.lciKoreaType.Control = this.ceKoreaType;
            this.lciKoreaType.Location = new System.Drawing.Point(657, 221);
            this.lciKoreaType.Name = "lciKoreaType";
            this.lciKoreaType.Size = new System.Drawing.Size(173, 28);
            this.lciKoreaType.TextSize = new System.Drawing.Size(0, 0);
            this.lciKoreaType.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Options.UseTextOptions = true;
            this.layoutControlGroup2.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciYear,
            this.lciLine,
            this.lciMon,
            this.lciDay,
            this.emptySpaceItem5,
            this.lciMillRollNo,
            this.lciTeam,
            this.lciSlitterNo,
            this.lciDoffingNo,
            this.lciArmNo});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 249);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(784, 96);
            this.layoutControlGroup2.Text = "Barcode Detail";
            // 
            // lciYear
            // 
            this.lciYear.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciYear.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciYear.Control = this.teYear;
            this.lciYear.Location = new System.Drawing.Point(0, 0);
            this.lciYear.MaxSize = new System.Drawing.Size(60, 65);
            this.lciYear.MinSize = new System.Drawing.Size(60, 65);
            this.lciYear.Name = "lciYear";
            this.lciYear.Size = new System.Drawing.Size(60, 65);
            this.lciYear.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciYear.Text = "Year";
            this.lciYear.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciYear.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciYear.TextSize = new System.Drawing.Size(10, 20);
            this.lciYear.TextToControlDistance = 5;
            // 
            // lciLine
            // 
            this.lciLine.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciLine.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciLine.Control = this.teLine;
            this.lciLine.Location = new System.Drawing.Point(60, 0);
            this.lciLine.MaxSize = new System.Drawing.Size(60, 65);
            this.lciLine.MinSize = new System.Drawing.Size(60, 65);
            this.lciLine.Name = "lciLine";
            this.lciLine.Size = new System.Drawing.Size(60, 65);
            this.lciLine.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciLine.Text = "Line";
            this.lciLine.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciLine.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciLine.TextSize = new System.Drawing.Size(10, 20);
            this.lciLine.TextToControlDistance = 5;
            // 
            // lciMon
            // 
            this.lciMon.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciMon.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciMon.Control = this.teMon;
            this.lciMon.Location = new System.Drawing.Point(120, 0);
            this.lciMon.MaxSize = new System.Drawing.Size(60, 65);
            this.lciMon.MinSize = new System.Drawing.Size(60, 65);
            this.lciMon.Name = "lciMon";
            this.lciMon.Size = new System.Drawing.Size(60, 65);
            this.lciMon.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciMon.Text = "Mon";
            this.lciMon.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciMon.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciMon.TextSize = new System.Drawing.Size(10, 20);
            this.lciMon.TextToControlDistance = 5;
            // 
            // lciDay
            // 
            this.lciDay.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciDay.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciDay.Control = this.teDay;
            this.lciDay.Location = new System.Drawing.Point(180, 0);
            this.lciDay.MaxSize = new System.Drawing.Size(60, 65);
            this.lciDay.MinSize = new System.Drawing.Size(60, 65);
            this.lciDay.Name = "lciDay";
            this.lciDay.Size = new System.Drawing.Size(60, 65);
            this.lciDay.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDay.Text = "Day";
            this.lciDay.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciDay.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciDay.TextSize = new System.Drawing.Size(10, 20);
            this.lciDay.TextToControlDistance = 5;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(240, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(10, 65);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciMillRollNo
            // 
            this.lciMillRollNo.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciMillRollNo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciMillRollNo.Control = this.teMillRollNo;
            this.lciMillRollNo.Location = new System.Drawing.Point(250, 0);
            this.lciMillRollNo.MaxSize = new System.Drawing.Size(120, 65);
            this.lciMillRollNo.MinSize = new System.Drawing.Size(100, 65);
            this.lciMillRollNo.Name = "lciMillRollNo";
            this.lciMillRollNo.Size = new System.Drawing.Size(105, 65);
            this.lciMillRollNo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciMillRollNo.Text = "Mill Roll No";
            this.lciMillRollNo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciMillRollNo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciMillRollNo.TextSize = new System.Drawing.Size(10, 20);
            this.lciMillRollNo.TextToControlDistance = 5;
            // 
            // lciTeam
            // 
            this.lciTeam.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciTeam.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciTeam.Control = this.lueTeam;
            this.lciTeam.Location = new System.Drawing.Point(355, 0);
            this.lciTeam.MinSize = new System.Drawing.Size(50, 25);
            this.lciTeam.Name = "lciTeam";
            this.lciTeam.Size = new System.Drawing.Size(105, 65);
            this.lciTeam.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTeam.Text = "Team";
            this.lciTeam.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciTeam.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciTeam.TextSize = new System.Drawing.Size(10, 20);
            this.lciTeam.TextToControlDistance = 5;
            // 
            // lciSlitterNo
            // 
            this.lciSlitterNo.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciSlitterNo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciSlitterNo.Control = this.teSlitterNo;
            this.lciSlitterNo.Location = new System.Drawing.Point(460, 0);
            this.lciSlitterNo.MaxSize = new System.Drawing.Size(120, 65);
            this.lciSlitterNo.MinSize = new System.Drawing.Size(100, 65);
            this.lciSlitterNo.Name = "lciSlitterNo";
            this.lciSlitterNo.Size = new System.Drawing.Size(105, 65);
            this.lciSlitterNo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSlitterNo.Text = "SlitterNo";
            this.lciSlitterNo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciSlitterNo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciSlitterNo.TextSize = new System.Drawing.Size(10, 20);
            this.lciSlitterNo.TextToControlDistance = 5;
            // 
            // lciDoffingNo
            // 
            this.lciDoffingNo.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciDoffingNo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciDoffingNo.Control = this.teDoffingNo;
            this.lciDoffingNo.Location = new System.Drawing.Point(565, 0);
            this.lciDoffingNo.MaxSize = new System.Drawing.Size(120, 65);
            this.lciDoffingNo.MinSize = new System.Drawing.Size(100, 65);
            this.lciDoffingNo.Name = "lciDoffingNo";
            this.lciDoffingNo.Size = new System.Drawing.Size(105, 65);
            this.lciDoffingNo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDoffingNo.Text = "DoffingNo";
            this.lciDoffingNo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciDoffingNo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciDoffingNo.TextSize = new System.Drawing.Size(10, 20);
            this.lciDoffingNo.TextToControlDistance = 5;
            // 
            // lciArmNo
            // 
            this.lciArmNo.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciArmNo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciArmNo.Control = this.lueArmNo;
            this.lciArmNo.Location = new System.Drawing.Point(670, 0);
            this.lciArmNo.MinSize = new System.Drawing.Size(50, 25);
            this.lciArmNo.Name = "lciArmNo";
            this.lciArmNo.Size = new System.Drawing.Size(106, 65);
            this.lciArmNo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciArmNo.Text = "ArmNo";
            this.lciArmNo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciArmNo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciArmNo.TextSize = new System.Drawing.Size(10, 20);
            this.lciArmNo.TextToControlDistance = 5;
            // 
            // lciCoreIDLength
            // 
            this.lciCoreIDLength.Control = this.lueCoreIDLength;
            this.lciCoreIDLength.Location = new System.Drawing.Point(339, 221);
            this.lciCoreIDLength.Name = "lciCoreIDLength";
            this.lciCoreIDLength.Size = new System.Drawing.Size(308, 28);
            this.lciCoreIDLength.Text = "Core ID && Length";
            this.lciCoreIDLength.TextSize = new System.Drawing.Size(98, 16);
            // 
            // lciRemark1
            // 
            this.lciRemark1.Control = this.teRemark1;
            this.lciRemark1.Location = new System.Drawing.Point(0, 345);
            this.lciRemark1.Name = "lciRemark1";
            this.lciRemark1.Size = new System.Drawing.Size(568, 28);
            this.lciRemark1.Text = "Remark";
            this.lciRemark1.TextSize = new System.Drawing.Size(98, 16);
            // 
            // lciRemark2
            // 
            this.lciRemark2.Control = this.teRemark2;
            this.lciRemark2.Location = new System.Drawing.Point(568, 345);
            this.lciRemark2.Name = "lciRemark2";
            this.lciRemark2.Size = new System.Drawing.Size(400, 28);
            this.lciRemark2.TextSize = new System.Drawing.Size(0, 0);
            this.lciRemark2.TextVisible = false;
            // 
            // lciAutomatic
            // 
            this.lciAutomatic.Control = this.rgAutomatic;
            this.lciAutomatic.Location = new System.Drawing.Point(306, 28);
            this.lciAutomatic.Name = "lciAutomatic";
            this.lciAutomatic.Size = new System.Drawing.Size(305, 28);
            this.lciAutomatic.TextSize = new System.Drawing.Size(0, 0);
            this.lciAutomatic.TextVisible = false;
            // 
            // lciSave
            // 
            this.lciSave.Control = this.sbSave;
            this.lciSave.Location = new System.Drawing.Point(724, 515);
            this.lciSave.Name = "lciSave";
            this.lciSave.Size = new System.Drawing.Size(113, 33);
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbCancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(837, 515);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(131, 33);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(149, 515);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(452, 33);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciKindOfLabel
            // 
            this.lciKindOfLabel.Control = this.lueKindOfLabel;
            this.lciKindOfLabel.Location = new System.Drawing.Point(0, 28);
            this.lciKindOfLabel.Name = "lciKindOfLabel";
            this.lciKindOfLabel.Size = new System.Drawing.Size(306, 28);
            this.lciKindOfLabel.Text = "Kind Of Label";
            this.lciKindOfLabel.TextSize = new System.Drawing.Size(98, 16);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciWHInDivision,
            this.lciBoxType,
            this.lciLocation,
            this.lciMachineNo,
            this.emptySpaceItem6,
            this.lciMachineDesc,
            this.lciSlittingOrder,
            this.lciTPLArticle,
            this.emptySpaceItem9,
            this.lciPONumber});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 373);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(968, 142);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // lciWHInDivision
            // 
            this.lciWHInDivision.Control = this.lueWHInDivision;
            this.lciWHInDivision.Location = new System.Drawing.Point(0, 0);
            this.lciWHInDivision.Name = "lciWHInDivision";
            this.lciWHInDivision.Size = new System.Drawing.Size(466, 28);
            this.lciWHInDivision.Text = "W/H In Division";
            this.lciWHInDivision.TextSize = new System.Drawing.Size(98, 16);
            // 
            // lciBoxType
            // 
            this.lciBoxType.Control = this.teBoxType;
            this.lciBoxType.Location = new System.Drawing.Point(476, 0);
            this.lciBoxType.Name = "lciBoxType";
            this.lciBoxType.Size = new System.Drawing.Size(462, 28);
            this.lciBoxType.Text = "Box Type";
            this.lciBoxType.TextSize = new System.Drawing.Size(98, 16);
            // 
            // lciLocation
            // 
            this.lciLocation.Control = this.teLocation;
            this.lciLocation.Location = new System.Drawing.Point(476, 28);
            this.lciLocation.Name = "lciLocation";
            this.lciLocation.Size = new System.Drawing.Size(462, 28);
            this.lciLocation.Text = "Location";
            this.lciLocation.TextSize = new System.Drawing.Size(98, 16);
            // 
            // lciMachineNo
            // 
            this.lciMachineNo.Control = this.lueMachineNo;
            this.lciMachineNo.Location = new System.Drawing.Point(0, 28);
            this.lciMachineNo.Name = "lciMachineNo";
            this.lciMachineNo.Size = new System.Drawing.Size(466, 28);
            this.lciMachineNo.Text = "Machine No";
            this.lciMachineNo.TextSize = new System.Drawing.Size(98, 16);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(466, 0);
            this.emptySpaceItem6.MaxSize = new System.Drawing.Size(10, 0);
            this.emptySpaceItem6.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(10, 84);
            this.emptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciMachineDesc
            // 
            this.lciMachineDesc.Control = this.teMachineDesc;
            this.lciMachineDesc.Location = new System.Drawing.Point(0, 56);
            this.lciMachineDesc.Name = "lciMachineDesc";
            this.lciMachineDesc.Size = new System.Drawing.Size(466, 28);
            this.lciMachineDesc.Text = "Machine Desc";
            this.lciMachineDesc.TextSize = new System.Drawing.Size(98, 16);
            // 
            // lciSlittingOrder
            // 
            this.lciSlittingOrder.Control = this.teSlittingOrder;
            this.lciSlittingOrder.Location = new System.Drawing.Point(476, 56);
            this.lciSlittingOrder.Name = "lciSlittingOrder";
            this.lciSlittingOrder.Size = new System.Drawing.Size(462, 28);
            this.lciSlittingOrder.Text = "Slitting Order";
            this.lciSlittingOrder.TextSize = new System.Drawing.Size(98, 16);
            // 
            // lciTPLArticle
            // 
            this.lciTPLArticle.Control = this.teTPLArticle;
            this.lciTPLArticle.Location = new System.Drawing.Point(476, 84);
            this.lciTPLArticle.Name = "lciTPLArticle";
            this.lciTPLArticle.Size = new System.Drawing.Size(462, 28);
            this.lciTPLArticle.Text = "TPL Article";
            this.lciTPLArticle.TextSize = new System.Drawing.Size(98, 16);
            this.lciTPLArticle.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(466, 84);
            this.emptySpaceItem9.MaxSize = new System.Drawing.Size(10, 0);
            this.emptySpaceItem9.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciPONumber
            // 
            this.lciPONumber.Control = this.tePONumber;
            this.lciPONumber.Location = new System.Drawing.Point(0, 84);
            this.lciPONumber.Name = "lciPONumber";
            this.lciPONumber.Size = new System.Drawing.Size(466, 28);
            this.lciPONumber.Text = "PO Number";
            this.lciPONumber.TextSize = new System.Drawing.Size(98, 16);
            this.lciPONumber.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(329, 221);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(647, 221);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciLabelSize
            // 
            this.lciLabelSize.Control = this.rgLabelSize;
            this.lciLabelSize.Location = new System.Drawing.Point(784, 249);
            this.lciLabelSize.Name = "lciLabelSize";
            this.lciLabelSize.Size = new System.Drawing.Size(184, 96);
            this.lciLabelSize.TextSize = new System.Drawing.Size(0, 0);
            this.lciLabelSize.TextVisible = false;
            this.lciLabelSize.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciItem
            // 
            this.lciItem.Control = this.lueItem;
            this.lciItem.Location = new System.Drawing.Point(0, 0);
            this.lciItem.Name = "lciItem";
            this.lciItem.Size = new System.Drawing.Size(479, 28);
            this.lciItem.Text = "Item";
            this.lciItem.TextSize = new System.Drawing.Size(98, 16);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(479, 0);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(489, 28);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciNewBarcode
            // 
            this.lciNewBarcode.Control = this.sbNewBarcode;
            this.lciNewBarcode.Location = new System.Drawing.Point(0, 515);
            this.lciNewBarcode.Name = "lciNewBarcode";
            this.lciNewBarcode.Size = new System.Drawing.Size(149, 33);
            this.lciNewBarcode.TextSize = new System.Drawing.Size(0, 0);
            this.lciNewBarcode.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbPrint;
            this.layoutControlItem1.Location = new System.Drawing.Point(601, 515);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(123, 33);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // pnl
            // 
            this.pnl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl.Location = new System.Drawing.Point(0, 608);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(994, 0);
            this.pnl.TabIndex = 3;
            this.pnl.Visible = false;
            // 
            // BarcodeAddNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 608);
            this.Controls.Add(this.lc);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarcodeAddNewForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).EndInit();
            this.lc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teTPLArticle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePONumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSlittingOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgLabelSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgAutomatic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRemark2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRemark1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMillRollNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSlitterNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDoffingNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceKoreaType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceLabelPrint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMachineDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCoreIDLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrade.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teChemical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teType2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNWeight1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWidth1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLength1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teThick.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCorona.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teWidth2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLength2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNWeight2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teThick2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caSplices.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciThick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciThick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWidth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLength1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWidth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLength2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNWeight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSplices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSumitomo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKindOfLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueWHInDivision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMachineNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueArmNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBoxType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSumitomo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKoreaType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMillRollNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSlitterNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoffingNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciArmNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoreIDLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemark1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemark2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAutomatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKindOfLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWHInDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBoxType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMachineNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMachineDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSlittingOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTPLArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPONumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private CheckEdit ceSumitomo;
        private LayoutControlItem lciSumitomo;
        private Panel panel1;
        private LayoutControl layoutControl1;
        private TextEdit teNP;
        private TextEdit teType2;
        private TextEdit teNWeight1;
        private TextEdit teWidth1;
        private TextEdit teLength1;
        private TextEdit teThick;
        private TextEdit teType;
        private TextEdit teCorona;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem lciThick;
        private LayoutControlItem lciThick2;
        private LayoutControlItem lciWidth1;
        private LayoutControlItem lciLength1;
        private LayoutControlItem lciNWeight1;
        private LayoutControlItem lciType;
        private LayoutControlItem lciTreate;
        private LayoutControlItem lciWidth2;
        private LayoutControlItem lciLength2;
        private LayoutControlItem lciNWeight2;
        private LayoutControlItem lciType2;
        private LayoutControlItem lciNP;
        private EmptySpaceItem emptySpaceItem1;
        private LayoutControlItem layoutControlItem6;
        private LookUpEdit lueCoreIDLength;
        private LookUpEdit lueGrade;
        private LayoutControlItem lciGrade;
        private LayoutControlItem lciCoreIDLength;
        private TextEdit teMachineDesc;
        private TextEdit teLocation;
        private LayoutControlItem lciMachineNo;
        private LayoutControlItem lciLocation;
        private LayoutControlItem lciMachineDesc;
        private LayoutControlItem lciWHInDivision;
        private LayoutControlItem lciBoxType;
        private CheckEdit ceKoreaType;
        private CheckEdit ceLabelPrint;
        private LayoutControlItem lciLabelPrint;
        private LayoutControlItem lciKoreaType;
        private TextEdit teYear;
        private TextEdit teLine;
        private TextEdit teMon;
        private TextEdit teDay;
        private TextEdit teMillRollNo;
        private TextEdit teSlitterNo;
        private TextEdit teDoffingNo;
        private LayoutControlItem lciDoffingNo;
        private LayoutControlItem lciArmNo;
        private LayoutControlItem lciSlitterNo;
        private LayoutControlItem lciTeam;
        private LayoutControlItem lciMillRollNo;
        private LayoutControlItem lciDay;
        private LayoutControlItem lciMon;
        private LayoutControlItem lciLine;
        private LayoutControlItem lciYear;
        private EmptySpaceItem emptySpaceItem5;
        private LayoutControlGroup layoutControlGroup2;
        private TextEdit teRemark2;
        private TextEdit teRemark1;
        private LayoutControlItem lciRemark1;
        private LayoutControlItem lciRemark2;
        private LookUpEdit lueWHInDivision;
        private LookUpEdit lueMachineNo;
        private RadioGroup rgAutomatic;
        private LayoutControlItem lciAutomatic;
        private SimpleButton sbCancel;
        private SimpleButton sbSave;
        private LayoutControlItem lciSave;
        private LayoutControlItem layoutControlItem2;
        private EmptySpaceItem emptySpaceItem4;
        private LayoutControlGroup layoutControlGroup3;
        private EmptySpaceItem emptySpaceItem3;
        private EmptySpaceItem emptySpaceItem6;
        private EmptySpaceItem emptySpaceItem2;
        private EmptySpaceItem emptySpaceItem7;
        private RadioGroup rgLabelSize;
        private LayoutControlItem lciLabelSize;
        private LookUpEdit lueItem;
        private LayoutControlItem lciItem;
        private EmptySpaceItem emptySpaceItem8;
        private TextEdit teSlittingOrder;
        private LayoutControlItem lciSlittingOrder;
        private TextEdit teName;
        private LayoutControlItem lciName;
        private TextEdit teChemical;
        private LayoutControlItem lciChemical;
        private LookUpEdit lueTeam;
        private LookUpEdit lueArmNo;
        private TextEdit teBoxType;
        private CalcEdit teWidth2;
        private CalcEdit teLength2;
        private CalcEdit teNWeight2;
        private CalcEdit teThick2;
        private LayoutControlItem lciSplices;
        private CalcEdit caSplices;
        private SimpleButton sbNewBarcode;
        private LayoutControlItem lciNewBarcode;
        private SimpleButton sbPrint;
        private LayoutControlItem layoutControlItem1;
        private TextEdit teTPLArticle;
        private TextEdit tePONumber;
        private LayoutControlItem lciPONumber;
        private LayoutControlItem lciTPLArticle;
        private EmptySpaceItem emptySpaceItem9;
    }
}