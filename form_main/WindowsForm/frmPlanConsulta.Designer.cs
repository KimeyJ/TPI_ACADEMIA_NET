namespace form_main.WindowsForm
{
    partial class frmPlanConsulta
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
            planesApiClientBindingSource = new BindingSource(components);
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            cmbEspecialidad = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)planesApiClientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.Location = new Point(12, 232);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 25);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Nuevo Plan";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = true;
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(113, 232);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 25);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar Plan";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(235, 232);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 25);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Plan";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(365, 20);
            cmbEspecialidad.Margin = new Padding(3, 2, 3, 2);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(133, 23);
            cmbEspecialidad.TabIndex = 4;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            cmbEspecialidad.SelectionChangeCommitted += cmbEspecialidad_SelectionChangeCommitted;
            cmbEspecialidad.TextUpdate += cmbEspecialidad_TextUpdate;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 5;
            label1.Text = "Especialidad";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(575, 150);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.CursorChanged += dataGridView1_CursorChanged;
            // 
            // frmPlanConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 275);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(cmbEspecialidad);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPlanConsulta";
            Text = "frmPlanConsulta";
            Load += frmPlanConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)planesApiClientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource planesApiClientBindingSource;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ComboBox cmbEspecialidad;
        private Label label1;
        private DataGridView dataGridView1;
    }
}