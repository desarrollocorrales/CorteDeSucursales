namespace CorteDeSucursales.GUIs
{
    partial class FrmDetallesCxCIngresos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetallesCxCIngresos));
            this.gridCxC = new DevExpress.XtraGrid.GridControl();
            this.doctosCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvCxC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIngresos = new DevExpress.XtraGrid.GridControl();
            this.doctosPVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvIngresos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblDiferencia = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridCxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctosCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctosPVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCxC
            // 
            this.gridCxC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridCxC.DataSource = this.doctosCCBindingSource;
            this.gridCxC.Location = new System.Drawing.Point(12, 94);
            this.gridCxC.MainView = this.gvCxC;
            this.gridCxC.Name = "gridCxC";
            this.gridCxC.Size = new System.Drawing.Size(469, 432);
            this.gridCxC.TabIndex = 0;
            this.gridCxC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCxC});
            // 
            // doctosCCBindingSource
            // 
            this.doctosCCBindingSource.DataSource = typeof(CorteDeSucursales.Modelos.DoctosCC);
            // 
            // gvCxC
            // 
            this.gvCxC.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCxC.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCxC.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCxC.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCxC.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCxC.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCxC.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCxC.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCxC.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvCxC.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCxC.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCxC.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCxC.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCxC.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCxC.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvCxC.Appearance.Empty.Options.UseBackColor = true;
            this.gvCxC.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvCxC.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCxC.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCxC.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCxC.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCxC.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCxC.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCxC.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCxC.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCxC.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCxC.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCxC.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvCxC.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCxC.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCxC.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvCxC.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCxC.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvCxC.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCxC.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCxC.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvCxC.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvCxC.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvCxC.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvCxC.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCxC.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCxC.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCxC.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCxC.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCxC.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCxC.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCxC.Appearance.FooterPanel.Options.UseFont = true;
            this.gvCxC.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCxC.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCxC.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCxC.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCxC.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCxC.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvCxC.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCxC.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCxC.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCxC.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCxC.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCxC.Appearance.GroupFooter.Options.UseFont = true;
            this.gvCxC.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCxC.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCxC.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCxC.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCxC.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCxC.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCxC.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCxC.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvCxC.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvCxC.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvCxC.Appearance.GroupRow.Options.UseFont = true;
            this.gvCxC.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCxC.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCxC.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCxC.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCxC.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCxC.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCxC.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCxC.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCxC.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvCxC.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvCxC.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvCxC.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCxC.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCxC.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvCxC.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvCxC.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCxC.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCxC.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvCxC.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvCxC.Appearance.Preview.Options.UseBackColor = true;
            this.gvCxC.Appearance.Preview.Options.UseForeColor = true;
            this.gvCxC.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvCxC.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvCxC.Appearance.Row.Options.UseBackColor = true;
            this.gvCxC.Appearance.Row.Options.UseForeColor = true;
            this.gvCxC.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvCxC.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCxC.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvCxC.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvCxC.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvCxC.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCxC.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCxC.Appearance.VertLine.Options.UseBackColor = true;
            this.gvCxC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsFolio,
            this.colsConcepto,
            this.coldTotal});
            this.gvCxC.GridControl = this.gridCxC;
            this.gvCxC.Name = "gvCxC";
            this.gvCxC.OptionsBehavior.Editable = false;
            this.gvCxC.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCxC.OptionsView.EnableAppearanceOddRow = true;
            this.gvCxC.OptionsView.ShowFooter = true;
            this.gvCxC.OptionsView.ShowGroupPanel = false;
            // 
            // colsFolio
            // 
            this.colsFolio.Caption = "Folio";
            this.colsFolio.FieldName = "sFolio";
            this.colsFolio.Name = "colsFolio";
            this.colsFolio.Visible = true;
            this.colsFolio.VisibleIndex = 0;
            // 
            // colsConcepto
            // 
            this.colsConcepto.Caption = "Concepto";
            this.colsConcepto.FieldName = "sConcepto";
            this.colsConcepto.Name = "colsConcepto";
            this.colsConcepto.Visible = true;
            this.colsConcepto.VisibleIndex = 1;
            // 
            // coldTotal
            // 
            this.coldTotal.Caption = "Importe";
            this.coldTotal.DisplayFormat.FormatString = "c";
            this.coldTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldTotal.FieldName = "dTotal";
            this.coldTotal.Name = "coldTotal";
            this.coldTotal.OptionsColumn.ReadOnly = true;
            this.coldTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dTotal", "{0:$#,0.00}")});
            this.coldTotal.Visible = true;
            this.coldTotal.VisibleIndex = 2;
            // 
            // gridIngresos
            // 
            this.gridIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridIngresos.DataSource = this.doctosPVBindingSource;
            this.gridIngresos.Location = new System.Drawing.Point(503, 94);
            this.gridIngresos.MainView = this.gvIngresos;
            this.gridIngresos.Name = "gridIngresos";
            this.gridIngresos.Size = new System.Drawing.Size(469, 432);
            this.gridIngresos.TabIndex = 1;
            this.gridIngresos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIngresos});
            // 
            // doctosPVBindingSource
            // 
            this.doctosPVBindingSource.DataSource = typeof(CorteDeSucursales.Modelos.DoctosPV);
            // 
            // gvIngresos
            // 
            this.gvIngresos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvIngresos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvIngresos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvIngresos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvIngresos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvIngresos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvIngresos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvIngresos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvIngresos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvIngresos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvIngresos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvIngresos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvIngresos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvIngresos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvIngresos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvIngresos.Appearance.Empty.Options.UseBackColor = true;
            this.gvIngresos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvIngresos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvIngresos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvIngresos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvIngresos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvIngresos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvIngresos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvIngresos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvIngresos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvIngresos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvIngresos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvIngresos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvIngresos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvIngresos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvIngresos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvIngresos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvIngresos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvIngresos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvIngresos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvIngresos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvIngresos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvIngresos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvIngresos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvIngresos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvIngresos.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvIngresos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvIngresos.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvIngresos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvIngresos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvIngresos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvIngresos.Appearance.FooterPanel.Options.UseFont = true;
            this.gvIngresos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvIngresos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvIngresos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvIngresos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvIngresos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvIngresos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvIngresos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvIngresos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvIngresos.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvIngresos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvIngresos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvIngresos.Appearance.GroupFooter.Options.UseFont = true;
            this.gvIngresos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvIngresos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvIngresos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvIngresos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvIngresos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvIngresos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvIngresos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvIngresos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvIngresos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvIngresos.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvIngresos.Appearance.GroupRow.Options.UseFont = true;
            this.gvIngresos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvIngresos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvIngresos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvIngresos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvIngresos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvIngresos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvIngresos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvIngresos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvIngresos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvIngresos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvIngresos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvIngresos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvIngresos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvIngresos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvIngresos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvIngresos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvIngresos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvIngresos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvIngresos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvIngresos.Appearance.Preview.Options.UseBackColor = true;
            this.gvIngresos.Appearance.Preview.Options.UseForeColor = true;
            this.gvIngresos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvIngresos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvIngresos.Appearance.Row.Options.UseBackColor = true;
            this.gvIngresos.Appearance.Row.Options.UseForeColor = true;
            this.gvIngresos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvIngresos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvIngresos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvIngresos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvIngresos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvIngresos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvIngresos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvIngresos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvIngresos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreCaja,
            this.colTotal});
            this.gvIngresos.GridControl = this.gridIngresos;
            this.gvIngresos.Name = "gvIngresos";
            this.gvIngresos.OptionsBehavior.Editable = false;
            this.gvIngresos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvIngresos.OptionsView.EnableAppearanceOddRow = true;
            this.gvIngresos.OptionsView.ShowFooter = true;
            this.gvIngresos.OptionsView.ShowGroupPanel = false;
            // 
            // colNombreCaja
            // 
            this.colNombreCaja.Caption = "Folio";
            this.colNombreCaja.FieldName = "NombreCaja";
            this.colNombreCaja.Name = "colNombreCaja";
            this.colNombreCaja.Visible = true;
            this.colNombreCaja.VisibleIndex = 0;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Importe";
            this.colTotal.DisplayFormat.FormatString = "c";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:$#,0.00}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(469, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Cuentas por Cobrar";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(454, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 23);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Detalles";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(341, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(302, 23);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Cuentas por Cobrar vs Ingresos";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(503, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(469, 18);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Ingresos";
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDiferencia.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDiferencia.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblDiferencia.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDiferencia.Location = new System.Drawing.Point(12, 532);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(960, 20);
            this.lblDiferencia.TabIndex = 7;
            this.lblDiferencia.Text = "Diferencia: $0.00";
            // 
            // FrmDetallesCxCIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.lblDiferencia);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridIngresos);
            this.Controls.Add(this.gridCxC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDetallesCxCIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carnicería Los Corrales -  Detalles CxC vs Ingresos";
            this.Load += new System.EventHandler(this.FrmDetallesCxCIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctosCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctosPVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCxC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCxC;
        private DevExpress.XtraGrid.GridControl gridIngresos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIngresos;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource doctosCCBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colsFolio;
        private DevExpress.XtraGrid.Columns.GridColumn coldTotal;
        private System.Windows.Forms.BindingSource doctosPVBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colsConcepto;
        private DevExpress.XtraEditors.LabelControl lblDiferencia;
    }
}