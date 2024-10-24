namespace form_main.WindowsForm
{
    partial class frmPersonaDetalle
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtMail = new TextBox();
            txtLegajo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rbProfesor = new RadioButton();
            rbAlumno = new RadioButton();
            rbAdm = new RadioButton();
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(147, 68);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(147, 109);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(118, 23);
            txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(147, 151);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 3;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(147, 189);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(191, 23);
            txtMail.TabIndex = 4;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(147, 227);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(73, 23);
            txtLegajo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 76);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 117);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 159);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 9;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 197);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 10;
            label5.Text = "Correo Electronico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 235);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Legajo";
            // 
            // rbProfesor
            // 
            rbProfesor.AutoSize = true;
            rbProfesor.Location = new Point(451, 65);
            rbProfesor.Name = "rbProfesor";
            rbProfesor.Size = new Size(69, 19);
            rbProfesor.TabIndex = 12;
            rbProfesor.TabStop = true;
            rbProfesor.Text = "Profesor";
            rbProfesor.UseVisualStyleBackColor = true;
            // 
            // rbAlumno
            // 
            rbAlumno.AutoSize = true;
            rbAlumno.Location = new Point(526, 65);
            rbAlumno.Name = "rbAlumno";
            rbAlumno.Size = new Size(68, 19);
            rbAlumno.TabIndex = 13;
            rbAlumno.TabStop = true;
            rbAlumno.Text = "Alumno";
            rbAlumno.UseVisualStyleBackColor = true;
            // 
            // rbAdm
            // 
            rbAdm.AutoSize = true;
            rbAdm.Location = new Point(600, 65);
            rbAdm.Name = "rbAdm";
            rbAdm.Size = new Size(103, 19);
            rbAdm.TabIndex = 14;
            rbAdm.TabStop = true;
            rbAdm.Text = "Administrativo";
            rbAdm.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(474, 361);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(120, 23);
            btnRegistro.TabIndex = 15;
            btnRegistro.Text = "Registrar Persona";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // frmPersonaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistro);
            Controls.Add(rbAdm);
            Controls.Add(rbAlumno);
            Controls.Add(rbProfesor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLegajo);
            Controls.Add(txtMail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "frmPersonaDetalle";
            Text = "frmPersonaDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private TextBox txtLegajo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton rbProfesor;
        private RadioButton rbAlumno;
        private RadioButton rbAdm;
        private Button btnRegistro;
    }
}