namespace FormulariosGraficos
{
    partial class frmEmpleado
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
            this.LblDatosBasicos = new System.Windows.Forms.Label();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.dtpFechaNaci = new System.Windows.Forms.DateTimePicker();
            this.cBoxCiudad = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaNaci = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.grbHobbies = new System.Windows.Forms.GroupBox();
            this.chkEstudiar = new System.Windows.Forms.CheckBox();
            this.chkDormir = new System.Windows.Forms.CheckBox();
            this.chkBailar = new System.Windows.Forms.CheckBox();
            this.chkCine = new System.Windows.Forms.CheckBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbSexo.SuspendLayout();
            this.grbHobbies.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDatosBasicos
            // 
            this.LblDatosBasicos.AutoSize = true;
            this.LblDatosBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatosBasicos.Location = new System.Drawing.Point(278, 9);
            this.LblDatosBasicos.Name = "LblDatosBasicos";
            this.LblDatosBasicos.Size = new System.Drawing.Size(167, 20);
            this.LblDatosBasicos.TabIndex = 0;
            this.LblDatosBasicos.Text = "Datos Básicos Empleados";
            this.LblDatosBasicos.UseCompatibleTextRendering = true;
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.rdbFemenino);
            this.grbSexo.Controls.Add(this.rdbMasculino);
            this.grbSexo.Location = new System.Drawing.Point(173, 175);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(191, 78);
            this.grbSexo.TabIndex = 13;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // dtpFechaNaci
            // 
            this.dtpFechaNaci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNaci.Location = new System.Drawing.Point(419, 149);
            this.dtpFechaNaci.Name = "dtpFechaNaci";
            this.dtpFechaNaci.Size = new System.Drawing.Size(184, 20);
            this.dtpFechaNaci.TabIndex = 36;
            this.dtpFechaNaci.Value = new System.DateTime(2020, 5, 5, 0, 0, 0, 0);
            // 
            // cBoxCiudad
            // 
            this.cBoxCiudad.FormattingEnabled = true;
            this.cBoxCiudad.Items.AddRange(new object[] {
            "Medellin",
            "Cali",
            "Bogota",
            "Ibague"});
            this.cBoxCiudad.Location = new System.Drawing.Point(173, 148);
            this.cBoxCiudad.Name = "cBoxCiudad";
            this.cBoxCiudad.Size = new System.Drawing.Size(185, 21);
            this.cBoxCiudad.TabIndex = 35;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(419, 107);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(184, 20);
            this.txtCorreo.TabIndex = 34;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(173, 107);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(185, 20);
            this.txtDocumento.TabIndex = 33;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(418, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(184, 20);
            this.txtApellido.TabIndex = 32;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 31;
            // 
            // lblFechaNaci
            // 
            this.lblFechaNaci.AutoSize = true;
            this.lblFechaNaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNaci.Location = new System.Drawing.Point(416, 130);
            this.lblFechaNaci.Name = "lblFechaNaci";
            this.lblFechaNaci.Size = new System.Drawing.Size(127, 15);
            this.lblFechaNaci.TabIndex = 30;
            this.lblFechaNaci.Text = "Fecha Nacimiento:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(416, 48);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(77, 15);
            this.lblApellido.TabIndex = 29;
            this.lblApellido.Text = "Apellido:  *";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.Location = new System.Drawing.Point(416, 89);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(64, 15);
            this.LblCorreo.TabIndex = 28;
            this.LblCorreo.Text = "Correo: *";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(170, 89);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(94, 15);
            this.lblDocumento.TabIndex = 27;
            this.lblDocumento.Text = "Documento: *";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(170, 130);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(56, 15);
            this.lblCiudad.TabIndex = 26;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(170, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 15);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre: *";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 31);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(112, 31);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // grbHobbies
            // 
            this.grbHobbies.Controls.Add(this.chkCine);
            this.grbHobbies.Controls.Add(this.chkBailar);
            this.grbHobbies.Controls.Add(this.chkDormir);
            this.grbHobbies.Controls.Add(this.chkEstudiar);
            this.grbHobbies.Location = new System.Drawing.Point(419, 175);
            this.grbHobbies.Name = "grbHobbies";
            this.grbHobbies.Size = new System.Drawing.Size(184, 78);
            this.grbHobbies.TabIndex = 37;
            this.grbHobbies.TabStop = false;
            this.grbHobbies.Text = "Hobbies";
            // 
            // chkEstudiar
            // 
            this.chkEstudiar.AutoSize = true;
            this.chkEstudiar.Location = new System.Drawing.Point(17, 19);
            this.chkEstudiar.Name = "chkEstudiar";
            this.chkEstudiar.Size = new System.Drawing.Size(64, 17);
            this.chkEstudiar.TabIndex = 0;
            this.chkEstudiar.Text = "Estudiar";
            this.chkEstudiar.UseVisualStyleBackColor = true;
            // 
            // chkDormir
            // 
            this.chkDormir.AutoSize = true;
            this.chkDormir.Location = new System.Drawing.Point(105, 19);
            this.chkDormir.Name = "chkDormir";
            this.chkDormir.Size = new System.Drawing.Size(56, 17);
            this.chkDormir.TabIndex = 1;
            this.chkDormir.Text = "Dormir";
            this.chkDormir.UseVisualStyleBackColor = true;
            // 
            // chkBailar
            // 
            this.chkBailar.AutoSize = true;
            this.chkBailar.Location = new System.Drawing.Point(17, 42);
            this.chkBailar.Name = "chkBailar";
            this.chkBailar.Size = new System.Drawing.Size(52, 17);
            this.chkBailar.TabIndex = 2;
            this.chkBailar.Text = "Bailar";
            this.chkBailar.UseVisualStyleBackColor = true;
            // 
            // chkCine
            // 
            this.chkCine.AutoSize = true;
            this.chkCine.Location = new System.Drawing.Point(105, 42);
            this.chkCine.Name = "chkCine";
            this.chkCine.Size = new System.Drawing.Size(47, 17);
            this.chkCine.TabIndex = 3;
            this.chkCine.Text = "Cine";
            this.chkCine.UseVisualStyleBackColor = true;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(170, 256);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(85, 15);
            this.lblComentario.TabIndex = 38;
            this.lblComentario.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(173, 274);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(430, 98);
            this.txtComentario.TabIndex = 39;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(173, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 30);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(261, 405);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 30);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(349, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 30);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.grbHobbies);
            this.Controls.Add(this.dtpFechaNaci);
            this.Controls.Add(this.cBoxCiudad);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFechaNaci);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.LblDatosBasicos);
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleado";
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.grbHobbies.ResumeLayout(false);
            this.grbHobbies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDatosBasicos;
        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.DateTimePicker dtpFechaNaci;
        private System.Windows.Forms.ComboBox cBoxCiudad;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaNaci;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbHobbies;
        private System.Windows.Forms.CheckBox chkCine;
        private System.Windows.Forms.CheckBox chkBailar;
        private System.Windows.Forms.CheckBox chkDormir;
        private System.Windows.Forms.CheckBox chkEstudiar;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}