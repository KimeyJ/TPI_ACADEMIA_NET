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
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)planesApiClientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.Enabled = false;
            btnAgregar.Location = new Point(14, 309);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 33);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Nuevo Plan";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = true;
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(129, 309);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(115, 33);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar Plan";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(269, 309);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 33);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Plan";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(427, 28);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(151, 28);
            cmbEspecialidad.TabIndex = 4;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            cmbEspecialidad.SelectionChangeCommitted += cmbEspecialidad_SelectionChangeCommitted;
            cmbEspecialidad.TextUpdate += cmbEspecialidad_TextUpdate;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 31);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 5;
            label1.Text = "Especialidad";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 80);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(657, 200);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.CursorChanged += dataGridView1_CursorChanged;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Enabled = false;
            button1.Location = new Point(394, 310);
            button1.Name = "button1";
            button1.Size = new Size(101, 30);
            button1.TabIndex = 7;
            button1.Text = "Ver Materias";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Enabled = false;
            button2.Location = new Point(518, 310);
            button2.Name = "button2";
            button2.Size = new Size(120, 30);
            button2.TabIndex = 8;
            button2.Text = "Ver Comisiones";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmPlanConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 367);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(cmbEspecialidad);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
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
        private Button button1;
        private Button button2;
    }
}