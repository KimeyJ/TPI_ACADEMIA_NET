namespace form_main
{
    partial class frmUsuarios
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
            txtUsername = new TextBox();
            txtPass1 = new TextBox();
            txtPass2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            lblPersona = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(183, 44);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPass1
            // 
            txtPass1.Location = new Point(183, 90);
            txtPass1.Name = "txtPass1";
            txtPass1.Size = new Size(125, 27);
            txtPass1.TabIndex = 1;
            // 
            // txtPass2
            // 
            txtPass2.Location = new Point(183, 141);
            txtPass2.Name = "txtPass2";
            txtPass2.Size = new Size(125, 27);
            txtPass2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 47);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 93);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 5;
            label2.Text = "Ingrese un Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 144);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 6;
            label3.Text = "Confirme Contraseña";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(214, 226);
            button1.Name = "button1";
            button1.Size = new Size(117, 30);
            button1.TabIndex = 7;
            button1.Text = "Crear Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.BackColor = SystemColors.ActiveCaption;
            lblPersona.Location = new Point(22, 9);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(50, 20);
            lblPersona.TabIndex = 8;
            lblPersona.Text = "label4";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 288);
            Controls.Add(lblPersona);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass2);
            Controls.Add(txtPass1);
            Controls.Add(txtUsername);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPass1;
        private TextBox txtPass2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label lblPersona;
    }
}