namespace form_main.WindowsForm
{
    partial class frmConsultaPersona
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
            components = new System.ComponentModel.Container();
            personasDataGridView = new DataGridView();
            btnFilter = new Button();
            btnModifcar = new Button();
            btnEliminar = new Button();
            personasApiClientBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)personasDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasApiClientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // personasDataGridView
            // 
            personasDataGridView.AutoGenerateColumns = false;
            personasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personasDataGridView.DataSource = personasApiClientBindingSource;
            personasDataGridView.Location = new Point(12, 12);
            personasDataGridView.Name = "personasDataGridView";
            personasDataGridView.RowHeadersWidth = 51;
            personasDataGridView.Size = new Size(776, 324);
            personasDataGridView.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.AutoSize = true;
            btnFilter.Location = new Point(452, 393);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(133, 30);
            btnFilter.TabIndex = 1;
            btnFilter.Text = "Filtrar Resultados";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnModifcar
            // 
            btnModifcar.Location = new Point(591, 394);
            btnModifcar.Name = "btnModifcar";
            btnModifcar.Size = new Size(94, 29);
            btnModifcar.TabIndex = 2;
            btnModifcar.Text = "Modificar";
            btnModifcar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(691, 394);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // personasApiClientBindingSource
            // 
            personasApiClientBindingSource.DataSource = typeof(PersonasApiClient);
            // 
            // frmConsultaPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModifcar);
            Controls.Add(btnFilter);
            Controls.Add(personasDataGridView);
            Name = "frmConsultaPersona";
            Text = "frmConsultaPersona";
            Load += frmConsultaPersona_Load;
            ((System.ComponentModel.ISupportInitialize)personasDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasApiClientBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView personasDataGridView;
        private Button btnFilter;
        private Button btnModifcar;
        private Button btnEliminar;
        private BindingSource personasApiClientBindingSource;
    }
}