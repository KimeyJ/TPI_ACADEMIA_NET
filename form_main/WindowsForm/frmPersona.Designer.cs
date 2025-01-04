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
            button1 = new Button();
            mcNac = new MonthCalendar();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbPlan = new ComboBox();
            cmbEspecialidad = new ComboBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 72);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(144, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(91, 113);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(178, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(91, 155);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(241, 23);
            txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(91, 195);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(144, 23);
            txtTelefono.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 75);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 115);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 157);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 236);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 197);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(91, 234);
            txtMail.Margin = new Padding(3, 2, 3, 2);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(178, 23);
            txtMail.TabIndex = 9;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(554, 239);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 25);
            button1.TabIndex = 13;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mcNac
            // 
            mcNac.Location = new Point(409, 52);
            mcNac.Margin = new Padding(8, 7, 8, 7);
            mcNac.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            mcNac.MaxSelectionCount = 1;
            mcNac.Name = "mcNac";
            mcNac.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 27);
            label6.Name = "label6";
            label6.Size = new Size(156, 15);
            label6.TabIndex = 15;
            label6.Text = "Ingrese fecha de nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 27);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 16;
            label7.Text = "Especialidad";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(228, 27);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 17;
            label8.Text = "Plan";
            label8.Visible = false;
            // 
            // cmbPlan
            // 
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Location = new Point(264, 24);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(121, 23);
            cmbPlan.TabIndex = 18;
            cmbPlan.Visible = false;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(90, 24);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(121, 23);
            cmbEspecialidad.TabIndex = 19;
            cmbEspecialidad.Visible = false;
            cmbEspecialidad.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // frmPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 272);
            Controls.Add(cmbEspecialidad);
            Controls.Add(cmbPlan);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(mcNac);
            Controls.Add(button1);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button button1;
        private MonthCalendar mcNac;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbPlan;
        private ComboBox cmbEspecialidad;
    }
}