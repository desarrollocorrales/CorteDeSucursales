namespace CorteDeSucursales.GUIs
{
    partial class FrmConfigurar
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
            this.tbControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabUsuarios = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGuardarUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txbNombreUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txbContraseña2 = new DevExpress.XtraEditors.TextEdit();
            this.txbNombreCompleto = new DevExpress.XtraEditors.TextEdit();
            this.txbContraseña1 = new DevExpress.XtraEditors.TextEdit();
            this.gcUsuarios = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.tabMicrosip = new DevExpress.XtraTab.XtraTabPage();
            this.btnGuardarMicrosip = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txbPuerto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txbContraseña = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txbUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txbBaseDeDatos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txbServidor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbTitulo = new DevExpress.XtraEditors.LabelControl();
            this.pnlTitulo = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbNombreUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbContraseña2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbNombreCompleto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbContraseña1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            this.gcUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.tabMicrosip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPuerto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBaseDeDatos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbServidor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControl.Appearance.Options.UseFont = true;
            this.tbControl.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControl.AppearancePage.Header.Options.UseFont = true;
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(0, 70);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedTabPage = this.tabUsuarios;
            this.tbControl.Size = new System.Drawing.Size(720, 447);
            this.tbControl.TabIndex = 0;
            this.tbControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabUsuarios,
            this.tabMicrosip});
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.panelControl1);
            this.tabUsuarios.Controls.Add(this.gcUsuarios);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(714, 416);
            this.tabUsuarios.Text = "Usuarios";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btnGuardarUsuario);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.txbNombreUsuario);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txbContraseña2);
            this.panelControl1.Controls.Add(this.txbNombreCompleto);
            this.panelControl1.Controls.Add(this.txbContraseña1);
            this.panelControl1.Location = new System.Drawing.Point(215, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(492, 378);
            this.panelControl1.TabIndex = 26;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.Appearance.Options.UseFont = true;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(209, 308);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 30);
            this.btnGuardarUsuario.TabIndex = 23;
            this.btnGuardarUsuario.Text = "Guardar";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(46, 237);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(169, 18);
            this.labelControl10.TabIndex = 20;
            this.labelControl10.Text = "Confirmar Contraseña:";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(46, 111);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(148, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Nombre de Usuario:";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(46, 174);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(90, 18);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Contraseña:";
            // 
            // txbNombreUsuario
            // 
            this.txbNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNombreUsuario.Location = new System.Drawing.Point(46, 135);
            this.txbNombreUsuario.Name = "txbNombreUsuario";
            this.txbNombreUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreUsuario.Properties.Appearance.Options.UseFont = true;
            this.txbNombreUsuario.Size = new System.Drawing.Size(200, 25);
            this.txbNombreUsuario.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(46, 48);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(138, 18);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Nombre Completo:";
            // 
            // txbContraseña2
            // 
            this.txbContraseña2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbContraseña2.Location = new System.Drawing.Point(46, 261);
            this.txbContraseña2.Name = "txbContraseña2";
            this.txbContraseña2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña2.Properties.Appearance.Options.UseFont = true;
            this.txbContraseña2.Size = new System.Drawing.Size(200, 25);
            this.txbContraseña2.TabIndex = 21;
            // 
            // txbNombreCompleto
            // 
            this.txbNombreCompleto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNombreCompleto.Location = new System.Drawing.Point(46, 72);
            this.txbNombreCompleto.Name = "txbNombreCompleto";
            this.txbNombreCompleto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreCompleto.Properties.Appearance.Options.UseFont = true;
            this.txbNombreCompleto.Size = new System.Drawing.Size(400, 25);
            this.txbNombreCompleto.TabIndex = 15;
            // 
            // txbContraseña1
            // 
            this.txbContraseña1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbContraseña1.Location = new System.Drawing.Point(46, 198);
            this.txbContraseña1.Name = "txbContraseña1";
            this.txbContraseña1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña1.Properties.Appearance.Options.UseFont = true;
            this.txbContraseña1.Size = new System.Drawing.Size(200, 25);
            this.txbContraseña1.TabIndex = 19;
            // 
            // gcUsuarios
            // 
            this.gcUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcUsuarios.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcUsuarios.AppearanceCaption.Options.UseFont = true;
            this.gcUsuarios.Controls.Add(this.listBoxControl1);
            this.gcUsuarios.Location = new System.Drawing.Point(11, 29);
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.Size = new System.Drawing.Size(200, 380);
            this.gcUsuarios.TabIndex = 25;
            this.gcUsuarios.Text = "Lista de Usuarios";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxControl1.Appearance.Options.UseFont = true;
            this.listBoxControl1.Appearance.Options.UseTextOptions = true;
            this.listBoxControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl1.Location = new System.Drawing.Point(2, 27);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(196, 351);
            this.listBoxControl1.TabIndex = 24;
            // 
            // tabMicrosip
            // 
            this.tabMicrosip.Controls.Add(this.btnGuardarMicrosip);
            this.tabMicrosip.Controls.Add(this.labelControl6);
            this.tabMicrosip.Controls.Add(this.txbPuerto);
            this.tabMicrosip.Controls.Add(this.labelControl5);
            this.tabMicrosip.Controls.Add(this.txbContraseña);
            this.tabMicrosip.Controls.Add(this.labelControl4);
            this.tabMicrosip.Controls.Add(this.txbUsuario);
            this.tabMicrosip.Controls.Add(this.labelControl3);
            this.tabMicrosip.Controls.Add(this.txbBaseDeDatos);
            this.tabMicrosip.Controls.Add(this.labelControl2);
            this.tabMicrosip.Controls.Add(this.txbServidor);
            this.tabMicrosip.Name = "tabMicrosip";
            this.tabMicrosip.Size = new System.Drawing.Size(714, 416);
            this.tabMicrosip.Text = "Microsip";
            // 
            // btnGuardarMicrosip
            // 
            this.btnGuardarMicrosip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarMicrosip.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMicrosip.Appearance.Options.UseFont = true;
            this.btnGuardarMicrosip.Location = new System.Drawing.Point(317, 363);
            this.btnGuardarMicrosip.Name = "btnGuardarMicrosip";
            this.btnGuardarMicrosip.Size = new System.Drawing.Size(80, 30);
            this.btnGuardarMicrosip.TabIndex = 22;
            this.btnGuardarMicrosip.Text = "Guardar";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(113, 300);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 18);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Puerto:";
            // 
            // txbPuerto
            // 
            this.txbPuerto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPuerto.Location = new System.Drawing.Point(113, 324);
            this.txbPuerto.Name = "txbPuerto";
            this.txbPuerto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPuerto.Properties.Appearance.Options.UseFont = true;
            this.txbPuerto.Size = new System.Drawing.Size(184, 25);
            this.txbPuerto.TabIndex = 21;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(113, 237);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 18);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Contraseña:";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbContraseña.Location = new System.Drawing.Point(113, 261);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña.Properties.Appearance.Options.UseFont = true;
            this.txbContraseña.Size = new System.Drawing.Size(321, 25);
            this.txbContraseña.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(113, 166);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 18);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Usuario:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbUsuario.Location = new System.Drawing.Point(113, 190);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Properties.Appearance.Options.UseFont = true;
            this.txbUsuario.Size = new System.Drawing.Size(321, 25);
            this.txbUsuario.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(113, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 18);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Base de datos:";
            // 
            // txbBaseDeDatos
            // 
            this.txbBaseDeDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbBaseDeDatos.Location = new System.Drawing.Point(113, 119);
            this.txbBaseDeDatos.Name = "txbBaseDeDatos";
            this.txbBaseDeDatos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBaseDeDatos.Properties.Appearance.Options.UseFont = true;
            this.txbBaseDeDatos.Size = new System.Drawing.Size(489, 25);
            this.txbBaseDeDatos.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(113, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 18);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Servidor:";
            // 
            // txbServidor
            // 
            this.txbServidor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbServidor.Location = new System.Drawing.Point(113, 48);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbServidor.Properties.Appearance.Options.UseFont = true;
            this.txbServidor.Size = new System.Drawing.Size(489, 25);
            this.txbServidor.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(290, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 29);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Configuración";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(256, 5);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(209, 29);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Corte de Sucursal";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lbTitulo);
            this.pnlTitulo.Controls.Add(this.labelControl1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(720, 70);
            this.pnlTitulo.TabIndex = 4;
            // 
            // FrmConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 517);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "FrmConfigurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carnicería Los Corrales - Corte de Sucursal - Configurar";
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbNombreUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbContraseña2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbNombreCompleto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbContraseña1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            this.gcUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.tabMicrosip.ResumeLayout(false);
            this.tabMicrosip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPuerto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBaseDeDatos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbServidor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tbControl;
        private DevExpress.XtraTab.XtraTabPage tabUsuarios;
        private DevExpress.XtraTab.XtraTabPage tabMicrosip;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbTitulo;
        private DevExpress.XtraEditors.PanelControl pnlTitulo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuardarUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txbNombreUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txbContraseña2;
        private DevExpress.XtraEditors.TextEdit txbNombreCompleto;
        private DevExpress.XtraEditors.TextEdit txbContraseña1;
        private DevExpress.XtraEditors.GroupControl gcUsuarios;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuardarMicrosip;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txbPuerto;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txbContraseña;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txbUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txbBaseDeDatos;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txbServidor;
    }
}