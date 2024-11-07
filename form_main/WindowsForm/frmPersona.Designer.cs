namespace form_main.WindowsForm
{
    partial class frmPersona
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMail = new TextBox();
            rbAl = new RadioButton();
            rbProf = new RadioButton();
            rbAdm = new RadioButton();
            button1 = new Button();
            mcNac = new MonthCalendar();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(104, 92);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(203, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(104, 148);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(275, 27);
            txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(104, 201);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(164, 27);
            txtTelefono.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 256);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 204);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(104, 253);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(203, 27);
            txtMail.TabIndex = 9;
            // 
            // rbAl
            // 
            rbAl.AutoSize = true;
            rbAl.Location = new Point(457, 41);
            rbAl.Name = "rbAl";
            rbAl.Size = new Size(82, 24);
            rbAl.TabIndex = 10;
            rbAl.TabStop = true;
            rbAl.Text = "Alumno";
            rbAl.UseVisualStyleBackColor = true;
            // 
            // rbProf
            // 
            rbProf.AutoSize = true;
            rbProf.Location = new Point(545, 41);
            rbProf.Name = "rbProf";
            rbProf.Size = new Size(85, 24);
            rbProf.TabIndex = 11;
            rbProf.TabStop = true;
            rbProf.Text = "Profesor";
            rbProf.UseVisualStyleBackColor = true;
            // 
            // rbAdm
            // 
            rbAdm.AutoSize = true;
            rbAdm.Location = new Point(636, 41);
            rbAdm.Name = "rbAdm";
            rbAdm.Size = new Size(121, 24);
            rbAdm.TabIndex = 12;
            rbAdm.TabStop = true;
            rbAdm.Text = "Adminstrador";
            rbAdm.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(663, 385);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mcNac
            // 
            mcNac.Location = new Point(467, 126);
            mcNac.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            mcNac.MaxSelectionCount = 1;
            mcNac.Name = "mcNac";
            mcNac.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 93);
            label6.Name = "label6";
            label6.Size = new Size(196, 20);
            label6.TabIndex = 15;
            label6.Text = "Ingrese fecha de nacimiento";
            // 
            // frmPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 426);
            Controls.Add(label6);
            Controls.Add(mcNac);
            Controls.Add(button1);
            Controls.Add(rbAdm);
            Controls.Add(rbProf);
            Controls.Add(rbAl);
            Controls.Add(txtMail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "frmPersona";
            Text = "frmPersona";
            Load += frmPersona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMail;
        private RadioButton rbAl;
        private RadioButton rbProf;
        private RadioButton rbAdm;
        private Button button1;
        private MonthCalendar mcNac;
        private Label label6;
    }
}