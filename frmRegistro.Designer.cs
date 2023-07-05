namespace RaoIEFI3
{
    partial class frmRegistro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcRegistrar = new System.Windows.Forms.TabControl();
            this.tbcRegistro = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cdrNombApell = new System.Windows.Forms.GroupBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cdrSexo = new System.Windows.Forms.GroupBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.tbpAgregarPais = new System.Windows.Forms.TabPage();
            this.txtAgregaraPais = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblQuePais = new System.Windows.Forms.Label();
            this.tbcRegistrar.SuspendLayout();
            this.tbcRegistro.SuspendLayout();
            this.cdrNombApell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.cdrSexo.SuspendLayout();
            this.tbpAgregarPais.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcRegistrar
            // 
            this.tbcRegistrar.Controls.Add(this.tbcRegistro);
            this.tbcRegistrar.Controls.Add(this.tbpAgregarPais);
            this.tbcRegistrar.Location = new System.Drawing.Point(12, 12);
            this.tbcRegistrar.Name = "tbcRegistrar";
            this.tbcRegistrar.SelectedIndex = 0;
            this.tbcRegistrar.Size = new System.Drawing.Size(400, 307);
            this.tbcRegistrar.TabIndex = 2;
            // 
            // tbcRegistro
            // 
            this.tbcRegistro.Controls.Add(this.btnRegistrar);
            this.tbcRegistro.Controls.Add(this.cdrNombApell);
            this.tbcRegistro.Controls.Add(this.lblBienvenido);
            this.tbcRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbcRegistro.Name = "tbcRegistro";
            this.tbcRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbcRegistro.Size = new System.Drawing.Size(392, 281);
            this.tbcRegistro.TabIndex = 0;
            this.tbcRegistro.Text = "Registro";
            this.tbcRegistro.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(301, 244);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cdrNombApell
            // 
            this.cdrNombApell.Controls.Add(this.numEdad);
            this.cdrNombApell.Controls.Add(this.cmbPais);
            this.cdrNombApell.Controls.Add(this.cdrSexo);
            this.cdrNombApell.Controls.Add(this.txtPuntaje);
            this.cdrNombApell.Controls.Add(this.txtImporte);
            this.cdrNombApell.Controls.Add(this.txtApellido);
            this.cdrNombApell.Controls.Add(this.txtNombre);
            this.cdrNombApell.Controls.Add(this.lblImporte);
            this.cdrNombApell.Controls.Add(this.lblPuntaje);
            this.cdrNombApell.Controls.Add(this.lblEdad);
            this.cdrNombApell.Controls.Add(this.lblNacionalidad);
            this.cdrNombApell.Controls.Add(this.lblApellido);
            this.cdrNombApell.Controls.Add(this.lblNombre);
            this.cdrNombApell.Location = new System.Drawing.Point(1, 41);
            this.cdrNombApell.Name = "cdrNombApell";
            this.cdrNombApell.Size = new System.Drawing.Size(375, 197);
            this.cdrNombApell.TabIndex = 5;
            this.cdrNombApell.TabStop = false;
            this.cdrNombApell.Text = "Neceistamos que nos proporcione algunos datos personales ";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(81, 167);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(100, 20);
            this.numEdad.TabIndex = 13;
            this.numEdad.ValueChanged += new System.EventHandler(this.numEdad_ValueChanged);
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(81, 126);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(100, 21);
            this.cmbPais.TabIndex = 3;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // cdrSexo
            // 
            this.cdrSexo.Controls.Add(this.rdbFemenino);
            this.cdrSexo.Controls.Add(this.rdbMasculino);
            this.cdrSexo.Location = new System.Drawing.Point(211, 26);
            this.cdrSexo.Name = "cdrSexo";
            this.cdrSexo.Size = new System.Drawing.Size(146, 76);
            this.cdrSexo.TabIndex = 12;
            this.cdrSexo.TabStop = false;
            this.cdrSexo.Text = "Sexo";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(6, 53);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 19);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Location = new System.Drawing.Point(257, 167);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(100, 20);
            this.txtPuntaje.TabIndex = 11;
            this.txtPuntaje.TextChanged += new System.EventHandler(this.txtPuntaje_TextChanged);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(257, 126);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 10;
            this.txtImporte.TextChanged += new System.EventHandler(this.txtImporte_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(81, 82);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(208, 129);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(45, 13);
            this.lblImporte.TabIndex = 5;
            this.lblImporte.Text = "Importe ";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(208, 170);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(43, 13);
            this.lblPuntaje.TabIndex = 4;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(18, 170);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(23, 129);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(27, 13);
            this.lblNacionalidad.TabIndex = 2;
            this.lblNacionalidad.Text = "Pais";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 85);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(6, 3);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(363, 20);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "¡Bienvendo a la pagina de registros del club!";
            // 
            // tbpAgregarPais
            // 
            this.tbpAgregarPais.Controls.Add(this.txtAgregaraPais);
            this.tbpAgregarPais.Controls.Add(this.btnAgregar);
            this.tbpAgregarPais.Controls.Add(this.lblQuePais);
            this.tbpAgregarPais.Location = new System.Drawing.Point(4, 22);
            this.tbpAgregarPais.Name = "tbpAgregarPais";
            this.tbpAgregarPais.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAgregarPais.Size = new System.Drawing.Size(392, 281);
            this.tbpAgregarPais.TabIndex = 1;
            this.tbpAgregarPais.Text = "Agregar Pais";
            this.tbpAgregarPais.UseVisualStyleBackColor = true;
            // 
            // txtAgregaraPais
            // 
            this.txtAgregaraPais.Location = new System.Drawing.Point(179, 114);
            this.txtAgregaraPais.Name = "txtAgregaraPais";
            this.txtAgregaraPais.Size = new System.Drawing.Size(150, 20);
            this.txtAgregaraPais.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(311, 252);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Pais";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblQuePais
            // 
            this.lblQuePais.AutoSize = true;
            this.lblQuePais.Location = new System.Drawing.Point(44, 117);
            this.lblQuePais.Name = "lblQuePais";
            this.lblQuePais.Size = new System.Drawing.Size(129, 13);
            this.lblQuePais.TabIndex = 3;
            this.lblQuePais.Text = "Que pais desea agregar? ";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 327);
            this.Controls.Add(this.tbcRegistrar);
            this.Name = "frmRegistro";
            this.Text = "Registro de Socios";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.tbcRegistrar.ResumeLayout(false);
            this.tbcRegistro.ResumeLayout(false);
            this.tbcRegistro.PerformLayout();
            this.cdrNombApell.ResumeLayout(false);
            this.cdrNombApell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.cdrSexo.ResumeLayout(false);
            this.cdrSexo.PerformLayout();
            this.tbpAgregarPais.ResumeLayout(false);
            this.tbpAgregarPais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcRegistrar;
        private System.Windows.Forms.TabPage tbcRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox cdrNombApell;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.GroupBox cdrSexo;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.TabPage tbpAgregarPais;
        private System.Windows.Forms.TextBox txtAgregaraPais;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblQuePais;
    }
}

