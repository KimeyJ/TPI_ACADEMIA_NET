namespace form_main
{
    partial class form_login
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
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            linkForgotPass = new LinkLabel();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 90);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 169);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(350, 218);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(188, 87);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(256, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(256, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // linkForgotPass
            // 
            linkForgotPass.AutoSize = true;
            linkForgotPass.Location = new Point(12, 268);
            linkForgotPass.Name = "linkForgotPass";
            linkForgotPass.Size = new Size(149, 20);
            linkForgotPass.TabIndex = 5;
            linkForgotPass.TabStop = true;
            linkForgotPass.Text = "Olvide mi contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(166, 31);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 6;
            label3.Text = "Inicio de Sesion";
            label3.Click += label3_Click;
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 308);
            Controls.Add(label3);
            Controls.Add(linkForgotPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "form_login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private LinkLabel linkForgotPass;
        private Label label3;
    }
}