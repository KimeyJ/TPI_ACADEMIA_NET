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
            personasApiClientBindingSource = new BindingSource(components);
            btnFilter = new Button();
            btnModifcar = new Button();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)personasApiClientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // personasApiClientBindingSource
            // 
            personasApiClientBindingSource.DataSource = typeof(PersonasApiClient);
            // 
            // btnFilter
            // 
            btnFilter.AutoSize = true;
            btnFilter.Location = new Point(373, 393);
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
            btnModifcar.Click += btnModifcar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(691, 394);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(773, 345);
            dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(512, 393);
            button1.Name = "button1";
            button1.Size = new Size(73, 30);
            button1.TabIndex = 5;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmConsultaPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModifcar);
            Controls.Add(btnFilter);
            Name = "frmConsultaPersona";
            Text = "frmConsultaPersona";
            Load += frmConsultaPersona_Load;
            ((System.ComponentModel.ISupportInitialize)personasApiClientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFilter;
        private Button btnModifcar;
        private Button btnEliminar;
        private BindingSource personasApiClientBindingSource;
        private DataGridView dataGridView1;
        private Button button1;
    }
}