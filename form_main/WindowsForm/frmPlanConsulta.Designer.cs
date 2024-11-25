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
            dataGridView1 = new DataGridView();
            planesApiClientBindingSource = new BindingSource(components);
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)planesApiClientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = planesApiClientBindingSource;
            dataGridView1.Location = new Point(128, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(425, 188);
            dataGridView1.TabIndex = 0;
            // 
            // planesApiClientBindingSource
            // 
            planesApiClientBindingSource.DataSource = typeof(WindowsForm.PlanesApiClient);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(247, 368);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "button1";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(402, 366);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "button2";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(595, 363);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "button3";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(579, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(436, 21);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 5;
            label1.Text = "Especialidad";
            // 
            // frmPlanConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Name = "frmPlanConsulta";
            Text = "frmPlanConsulta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)planesApiClientBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource planesApiClientBindingSource;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ComboBox comboBox1;
        private Label label1;
    }
}