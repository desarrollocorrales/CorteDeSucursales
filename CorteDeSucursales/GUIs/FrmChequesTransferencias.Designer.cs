namespace CorteDeSucursales.GUIs
{
    partial class FrmChequesTransferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChequesTransferencias));
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpCheques = new System.Windows.Forms.TabPage();
            this.btnEliminarCheque = new System.Windows.Forms.Button();
            this.btnAgregarCheque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCheques = new DevExpress.XtraGrid.GridControl();
            this.chequeTransferenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvCheques = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdentificador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpTransferencias = new System.Windows.Forms.TabPage();
            this.btnEliminarTransfer = new System.Windows.Forms.Button();
            this.btnAgregarTransfer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridTransferencias = new DevExpress.XtraGrid.GridControl();
            this.gvTransferencias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdentificador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpCheques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeTransferenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheques)).BeginInit();
            this.tpTransferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencias)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(241, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cheques y Transferencias";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpCheques);
            this.tabControl.Controls.Add(this.tpTransferencias);
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 473);
            this.tabControl.TabIndex = 2;
            // 
            // tpCheques
            // 
            this.tpCheques.Controls.Add(this.btnEliminarCheque);
            this.tpCheques.Controls.Add(this.btnAgregarCheque);
            this.tpCheques.Controls.Add(this.label1);
            this.tpCheques.Controls.Add(this.gridCheques);
            this.tpCheques.Location = new System.Drawing.Point(4, 25);
            this.tpCheques.Name = "tpCheques";
            this.tpCheques.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheques.Size = new System.Drawing.Size(776, 444);
            this.tpCheques.TabIndex = 0;
            this.tpCheques.Text = "Cheques";
            this.tpCheques.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCheque
            // 
            this.btnEliminarCheque.Location = new System.Drawing.Point(693, 58);
            this.btnEliminarCheque.Name = "btnEliminarCheque";
            this.btnEliminarCheque.Size = new System.Drawing.Size(75, 28);
            this.btnEliminarCheque.TabIndex = 7;
            this.btnEliminarCheque.Text = "Eliminar";
            this.btnEliminarCheque.UseVisualStyleBackColor = true;
            this.btnEliminarCheque.Click += new System.EventHandler(this.btnEliminarCheque_Click);
            // 
            // btnAgregarCheque
            // 
            this.btnAgregarCheque.Location = new System.Drawing.Point(693, 24);
            this.btnAgregarCheque.Name = "btnAgregarCheque";
            this.btnAgregarCheque.Size = new System.Drawing.Size(75, 28);
            this.btnAgregarCheque.TabIndex = 6;
            this.btnAgregarCheque.Text = "Agregar";
            this.btnAgregarCheque.UseVisualStyleBackColor = true;
            this.btnAgregarCheque.Click += new System.EventHandler(this.btnAgregarCheque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Información de Cheques";
            // 
            // gridCheques
            // 
            this.gridCheques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCheques.DataSource = this.chequeTransferenciaBindingSource;
            this.gridCheques.Location = new System.Drawing.Point(8, 24);
            this.gridCheques.MainView = this.gvCheques;
            this.gridCheques.Name = "gridCheques";
            this.gridCheques.Size = new System.Drawing.Size(679, 414);
            this.gridCheques.TabIndex = 0;
            this.gridCheques.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCheques});
            // 
            // chequeTransferenciaBindingSource
            // 
            this.chequeTransferenciaBindingSource.DataSource = typeof(CorteDeSucursales.Modelos.ChequeTransferencia);
            // 
            // gvCheques
            // 
            this.gvCheques.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentificador,
            this.colCliente,
            this.colBanco,
            this.colImporte});
            this.gvCheques.GridControl = this.gridCheques;
            this.gvCheques.Name = "gvCheques";
            this.gvCheques.OptionsView.ShowFooter = true;
            this.gvCheques.OptionsView.ShowGroupPanel = false;
            // 
            // colIdentificador
            // 
            this.colIdentificador.FieldName = "Identificador";
            this.colIdentificador.Name = "colIdentificador";
            this.colIdentificador.Visible = true;
            this.colIdentificador.VisibleIndex = 0;
            // 
            // colCliente
            // 
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 1;
            // 
            // colBanco
            // 
            this.colBanco.FieldName = "Banco";
            this.colBanco.Name = "colBanco";
            this.colBanco.Visible = true;
            this.colBanco.VisibleIndex = 2;
            // 
            // colImporte
            // 
            this.colImporte.DisplayFormat.FormatString = "c";
            this.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:$#,0.00}")});
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 3;
            // 
            // tpTransferencias
            // 
            this.tpTransferencias.Controls.Add(this.btnEliminarTransfer);
            this.tpTransferencias.Controls.Add(this.btnAgregarTransfer);
            this.tpTransferencias.Controls.Add(this.label2);
            this.tpTransferencias.Controls.Add(this.gridTransferencias);
            this.tpTransferencias.Location = new System.Drawing.Point(4, 25);
            this.tpTransferencias.Name = "tpTransferencias";
            this.tpTransferencias.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransferencias.Size = new System.Drawing.Size(776, 444);
            this.tpTransferencias.TabIndex = 1;
            this.tpTransferencias.Text = "Transferencias";
            this.tpTransferencias.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTransfer
            // 
            this.btnEliminarTransfer.Location = new System.Drawing.Point(693, 58);
            this.btnEliminarTransfer.Name = "btnEliminarTransfer";
            this.btnEliminarTransfer.Size = new System.Drawing.Size(75, 28);
            this.btnEliminarTransfer.TabIndex = 5;
            this.btnEliminarTransfer.Text = "Eliminar";
            this.btnEliminarTransfer.UseVisualStyleBackColor = true;
            this.btnEliminarTransfer.Click += new System.EventHandler(this.btnEliminarTransfer_Click);
            // 
            // btnAgregarTransfer
            // 
            this.btnAgregarTransfer.Location = new System.Drawing.Point(693, 24);
            this.btnAgregarTransfer.Name = "btnAgregarTransfer";
            this.btnAgregarTransfer.Size = new System.Drawing.Size(75, 28);
            this.btnAgregarTransfer.TabIndex = 4;
            this.btnAgregarTransfer.Text = "Agregar";
            this.btnAgregarTransfer.UseVisualStyleBackColor = true;
            this.btnAgregarTransfer.Click += new System.EventHandler(this.btnAgregarTransfer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Información de Transferencias";
            // 
            // gridTransferencias
            // 
            this.gridTransferencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTransferencias.DataSource = this.chequeTransferenciaBindingSource;
            this.gridTransferencias.Location = new System.Drawing.Point(8, 24);
            this.gridTransferencias.MainView = this.gvTransferencias;
            this.gridTransferencias.Name = "gridTransferencias";
            this.gridTransferencias.Size = new System.Drawing.Size(679, 414);
            this.gridTransferencias.TabIndex = 2;
            this.gridTransferencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransferencias});
            // 
            // gvTransferencias
            // 
            this.gvTransferencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentificador1,
            this.colCliente1,
            this.colBanco1,
            this.colImporte1});
            this.gvTransferencias.GridControl = this.gridTransferencias;
            this.gvTransferencias.Name = "gvTransferencias";
            this.gvTransferencias.OptionsView.ShowFooter = true;
            this.gvTransferencias.OptionsView.ShowGroupPanel = false;
            // 
            // colIdentificador1
            // 
            this.colIdentificador1.FieldName = "Identificador";
            this.colIdentificador1.Name = "colIdentificador1";
            this.colIdentificador1.Visible = true;
            this.colIdentificador1.VisibleIndex = 0;
            // 
            // colCliente1
            // 
            this.colCliente1.FieldName = "Cliente";
            this.colCliente1.Name = "colCliente1";
            this.colCliente1.Visible = true;
            this.colCliente1.VisibleIndex = 1;
            // 
            // colBanco1
            // 
            this.colBanco1.FieldName = "Banco";
            this.colBanco1.Name = "colBanco1";
            this.colBanco1.Visible = true;
            this.colBanco1.VisibleIndex = 2;
            // 
            // colImporte1
            // 
            this.colImporte1.DisplayFormat.FormatString = "c";
            this.colImporte1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporte1.FieldName = "Importe";
            this.colImporte1.Name = "colImporte1";
            this.colImporte1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:$#,0.00}")});
            this.colImporte1.Visible = true;
            this.colImporte1.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 41);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmChequesTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChequesTransferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura de cheques y transferencias";
            this.Load += new System.EventHandler(this.FrmChequesTransferencias_Load);
            this.tabControl.ResumeLayout(false);
            this.tpCheques.ResumeLayout(false);
            this.tpCheques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeTransferenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheques)).EndInit();
            this.tpTransferencias.ResumeLayout(false);
            this.tpTransferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpCheques;
        private System.Windows.Forms.TabPage tpTransferencias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridCheques;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCheques;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridTransferencias;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransferencias;
        private System.Windows.Forms.Button btnEliminarCheque;
        private System.Windows.Forms.Button btnAgregarCheque;
        private System.Windows.Forms.BindingSource chequeTransferenciaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificador;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private System.Windows.Forms.Button btnEliminarTransfer;
        private System.Windows.Forms.Button btnAgregarTransfer;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificador1;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente1;
        private DevExpress.XtraGrid.Columns.GridColumn colBanco1;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte1;
        private System.Windows.Forms.Button button1;
    }
}