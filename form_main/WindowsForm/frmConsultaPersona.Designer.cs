using form_main.APIs;

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
            // btnModifcar
            // 
            btnModifcar.Location = new Point(517, 296);
            btnModifcar.Margin = new Padding(3, 2, 3, 2);
            btnModifcar.Name = "btnModifcar";
            btnModifcar.Size = new Size(82, 22);
            btnModifcar.TabIndex = 2;
            btnModifcar.Text = "Modificar";
            btnModifcar.UseVisualStyleBackColor = true;
            btnModifcar.Click += btnModifcar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(605, 296);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(676, 259);
            dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(448, 295);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(59, 25);
            button1.TabIndex = 5;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmConsultaPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModifcar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmConsultaPersona";
            Text = "frmConsultaPersona";
            Load += frmConsultaPersona_Load;
            ((System.ComponentModel.ISupportInitialize)personasApiClientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnModifcar;
        private Button btnEliminar;
        private BindingSource personasApiClientBindingSource;
        private DataGridView dataGridView1;
        private Button button1;
    }
}