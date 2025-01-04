namespace form_main.WindowsForm
{
    partial class frmInscripcion
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
            btnAceptar = new Button();
            cursosDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)cursosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(447, 355);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cursosDataGridView
            // 
            cursosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosDataGridView.Location = new Point(12, 170);
            cursosDataGridView.Name = "cursosDataGridView";
            cursosDataGridView.Size = new Size(495, 150);
            cursosDataGridView.TabIndex = 2;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 414);
            Controls.Add(btnAceptar);
            Controls.Add(cursosDataGridView);
            Name = "frmInscripcion";
            Text = "frmInscripcion";
            Load += frmInscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)cursosDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAceptar;
        private DataGridView cursosDataGridView;
    }
}