namespace CorteDeSucursales.GUIs
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txbUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txbContraseña = new DevExpress.XtraEditors.TextEdit();
            this.btnEntrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfigurar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbContraseña.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(440, 156);
            this.pictureEdit1.TabIndex = 1;
            // 
            // txbUsuario
            // 
            this.txbUsuario.EditValue = "";
            this.txbUsuario.Location = new System.Drawing.Point(108, 174);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Properties.Appearance.Options.UseFont = true;
            this.txbUsuario.Size = new System.Drawing.Size(333, 25);
            this.txbUsuario.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(49, 177);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Usuario:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(23, 208);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Contraseña:";
            // 
            // txbContraseña
            // 
            this.txbContraseña.EditValue = "";
            this.txbContraseña.Location = new System.Drawing.Point(108, 205);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña.Properties.Appearance.Options.UseFont = true;
            this.txbContraseña.Properties.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(333, 25);
            this.txbContraseña.TabIndex = 4;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Appearance.Options.UseFont = true;
            this.btnEntrar.Location = new System.Drawing.Point(192, 236);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(80, 30);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurar.Appearance.Options.UseFont = true;
            this.btnConfigurar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfigurar.Location = new System.Drawing.Point(0, 277);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(464, 25);
            this.btnConfigurar.TabIndex = 7;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // FrmLogin
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 302);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txbUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(480, 340);
            this.MinimumSize = new System.Drawing.Size(480, 340);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carnicería Los Corrales - Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbContraseña.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txbUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txbContraseña;
        private DevExpress.XtraEditors.SimpleButton btnEntrar;
        private DevExpress.XtraEditors.SimpleButton btnConfigurar;
    }
}