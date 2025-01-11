namespace form_main.WindowsForm
{
    partial class frmCursoConsulta
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
            cursoDataGridView = new DataGridView();
            alumnoDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)cursoDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // cursoDataGridView
            // 
            cursoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursoDataGridView.Location = new Point(12, 23);
            cursoDataGridView.MultiSelect = false;
            cursoDataGridView.Name = "cursoDataGridView";
            cursoDataGridView.ReadOnly = true;
            cursoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursoDataGridView.Size = new Size(383, 316);
            cursoDataGridView.TabIndex = 0;
            // 
            // alumnoDataGridView
            // 
            alumnoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alumnoDataGridView.Location = new Point(418, 23);
            alumnoDataGridView.MultiSelect = false;
            alumnoDataGridView.Name = "alumnoDataGridView";
            alumnoDataGridView.ReadOnly = true;
            alumnoDataGridView.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            alumnoDataGridView.Size = new Size(370, 316);
            alumnoDataGridView.TabIndex = 1;
            alumnoDataGridView.CellContentClick += alumnoDataGridView_CellContentClick;
            // 
            // frmCursoConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 378);
            Controls.Add(alumnoDataGridView);
            Controls.Add(cursoDataGridView);
            Name = "frmCursoConsulta";
            Text = "frmCursoConsulta";
            Load += frmCursoConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)cursoDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnoDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView cursoDataGridView;
        private DataGridView alumnoDataGridView;
    }
}