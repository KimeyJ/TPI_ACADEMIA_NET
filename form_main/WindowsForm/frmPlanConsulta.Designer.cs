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
            cmbEspecialidad = new ComboBox();
            label1 = new Label();
            planesDataGridView = new DataGridView();
            materiasDataGridView = new DataGridView();
            menuStrip1 = new MenuStrip();
            planesToolStripMenuItem = new ToolStripMenuItem();
            crearUnPlanToolStripMenuItem = new ToolStripMenuItem();
            modificarUnPlanToolStripMenuItem = new ToolStripMenuItem();
            eliminarPlanToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            crearUnaMateriaToolStripMenuItem = new ToolStripMenuItem();
            modifcarMateriaToolStripMenuItem = new ToolStripMenuItem();
            eliminarMateriaSeleccionadaToolStripMenuItem = new ToolStripMenuItem();
            comisionesToolStripMenuItem = new ToolStripMenuItem();
            crearComisionToolStripMenuItem = new ToolStripMenuItem();
            modificarComisionToolStripMenuItem = new ToolStripMenuItem();
            eliminarComisionToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            nuevoCursoToolStripMenuItem = new ToolStripMenuItem();
            modificarCursoToolStripMenuItem = new ToolStripMenuItem();
            eliminarCursoToolStripMenuItem = new ToolStripMenuItem();
            lblPlanes = new Label();
            label2 = new Label();
            label3 = new Label();
            cursosDataGridView = new DataGridView();
            label4 = new Label();
            comisionesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)planesApiClientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)planesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materiasDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cursosDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comisionesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(374, 21);
            cmbEspecialidad.Margin = new Padding(3, 2, 3, 2);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(133, 23);
            cmbEspecialidad.TabIndex = 4;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
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
            // planesDataGridView
            // 
            planesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            planesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planesDataGridView.Location = new Point(12, 79);
            planesDataGridView.MultiSelect = false;
            planesDataGridView.Name = "planesDataGridView";
            planesDataGridView.ReadOnly = true;
            planesDataGridView.RowHeadersWidth = 51;
            planesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planesDataGridView.Size = new Size(313, 326);
            planesDataGridView.TabIndex = 6;
            planesDataGridView.CellClick += planesDataGridView_CellClick;

            // 
            // materiasDataGridView
            // 
            materiasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            materiasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materiasDataGridView.Location = new Point(351, 255);
            materiasDataGridView.MultiSelect = false;
            materiasDataGridView.Name = "materiasDataGridView";
            materiasDataGridView.ReadOnly = true;
            materiasDataGridView.RowHeadersWidth = 51;
            materiasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            materiasDataGridView.Size = new Size(327, 150);
            materiasDataGridView.TabIndex = 10;
            materiasDataGridView.CellClick += materiasDataGridView_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { planesToolStripMenuItem, materiasToolStripMenuItem, comisionesToolStripMenuItem, cursosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1055, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // planesToolStripMenuItem
            // 
            planesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearUnPlanToolStripMenuItem, modificarUnPlanToolStripMenuItem, eliminarPlanToolStripMenuItem });
            planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            planesToolStripMenuItem.Size = new Size(53, 20);
            planesToolStripMenuItem.Text = "Planes";
            // 
            // crearUnPlanToolStripMenuItem
            // 
            crearUnPlanToolStripMenuItem.Name = "crearUnPlanToolStripMenuItem";
            crearUnPlanToolStripMenuItem.Size = new Size(180, 22);
            crearUnPlanToolStripMenuItem.Text = "Crear un Plan";
            crearUnPlanToolStripMenuItem.Click += crearUnPlanToolStripMenuItem_Click;
            // 
            // modificarUnPlanToolStripMenuItem
            // 
            modificarUnPlanToolStripMenuItem.Name = "modificarUnPlanToolStripMenuItem";
            modificarUnPlanToolStripMenuItem.Size = new Size(180, 22);
            modificarUnPlanToolStripMenuItem.Text = "Modificar un Plan";
            modificarUnPlanToolStripMenuItem.Click += modificarUnPlanToolStripMenuItem_Click;
            // 
            // eliminarPlanToolStripMenuItem
            // 
            eliminarPlanToolStripMenuItem.Name = "eliminarPlanToolStripMenuItem";
            eliminarPlanToolStripMenuItem.Size = new Size(180, 22);
            eliminarPlanToolStripMenuItem.Text = "Eliminar Plan";
            eliminarPlanToolStripMenuItem.Click += eliminarPlanToolStripMenuItem_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearUnaMateriaToolStripMenuItem, modifcarMateriaToolStripMenuItem, eliminarMateriaSeleccionadaToolStripMenuItem });
            materiasToolStripMenuItem.Enabled = false;
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(64, 20);
            materiasToolStripMenuItem.Text = "Materias";
            // 
            // crearUnaMateriaToolStripMenuItem
            // 
            crearUnaMateriaToolStripMenuItem.Name = "crearUnaMateriaToolStripMenuItem";
            crearUnaMateriaToolStripMenuItem.Size = new Size(168, 22);
            crearUnaMateriaToolStripMenuItem.Text = "Crear una Materia";
            crearUnaMateriaToolStripMenuItem.Click += crearUnaMateriaToolStripMenuItem_Click;
            // 
            // modifcarMateriaToolStripMenuItem
            // 
            modifcarMateriaToolStripMenuItem.Name = "modifcarMateriaToolStripMenuItem";
            modifcarMateriaToolStripMenuItem.Size = new Size(168, 22);
            modifcarMateriaToolStripMenuItem.Text = "Modifcar Materia";
            modifcarMateriaToolStripMenuItem.Click += modifcarMateriaToolStripMenuItem_Click;
            // 
            // eliminarMateriaSeleccionadaToolStripMenuItem
            // 
            eliminarMateriaSeleccionadaToolStripMenuItem.Name = "eliminarMateriaSeleccionadaToolStripMenuItem";
            eliminarMateriaSeleccionadaToolStripMenuItem.Size = new Size(168, 22);
            eliminarMateriaSeleccionadaToolStripMenuItem.Text = "Eliminar Materia";
            eliminarMateriaSeleccionadaToolStripMenuItem.Click += eliminarMateriaSeleccionadaToolStripMenuItem_Click;
            // 
            // comisionesToolStripMenuItem
            // 
            comisionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearComisionToolStripMenuItem, modificarComisionToolStripMenuItem, eliminarComisionToolStripMenuItem });
            comisionesToolStripMenuItem.Enabled = false;
            comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            comisionesToolStripMenuItem.Size = new Size(81, 20);
            comisionesToolStripMenuItem.Text = "Comisiones";
            // 
            // crearComisionToolStripMenuItem
            // 
            crearComisionToolStripMenuItem.Name = "crearComisionToolStripMenuItem";
            crearComisionToolStripMenuItem.Size = new Size(179, 22);
            crearComisionToolStripMenuItem.Text = "Crear Comision";
            crearComisionToolStripMenuItem.Click += crearComisionToolStripMenuItem_Click;
            // 
            // modificarComisionToolStripMenuItem
            // 
            modificarComisionToolStripMenuItem.Name = "modificarComisionToolStripMenuItem";
            modificarComisionToolStripMenuItem.Size = new Size(179, 22);
            modificarComisionToolStripMenuItem.Text = "Modificar Comision";
            modificarComisionToolStripMenuItem.Click += modificarComisionToolStripMenuItem_Click;
            // 
            // eliminarComisionToolStripMenuItem
            // 
            eliminarComisionToolStripMenuItem.Name = "eliminarComisionToolStripMenuItem";
            eliminarComisionToolStripMenuItem.Size = new Size(179, 22);
            eliminarComisionToolStripMenuItem.Text = "Eliminar Comision";
            eliminarComisionToolStripMenuItem.Click += eliminarComisionToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoCursoToolStripMenuItem, modificarCursoToolStripMenuItem, eliminarCursoToolStripMenuItem });
            cursosToolStripMenuItem.Enabled = false;
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(55, 20);
            cursosToolStripMenuItem.Text = "Cursos";
            // 
            // nuevoCursoToolStripMenuItem
            // 
            nuevoCursoToolStripMenuItem.Name = "nuevoCursoToolStripMenuItem";
            nuevoCursoToolStripMenuItem.Size = new Size(159, 22);
            nuevoCursoToolStripMenuItem.Text = "Nuevo Curso";
            nuevoCursoToolStripMenuItem.Click += nuevoCursoToolStripMenuItem_Click;
            // 
            // modificarCursoToolStripMenuItem
            // 
            modificarCursoToolStripMenuItem.Name = "modificarCursoToolStripMenuItem";
            modificarCursoToolStripMenuItem.Size = new Size(159, 22);
            modificarCursoToolStripMenuItem.Text = "Modificar Curso";
            modificarCursoToolStripMenuItem.Click += modificarCursoToolStripMenuItem_Click;
            // 
            // eliminarCursoToolStripMenuItem
            // 
            eliminarCursoToolStripMenuItem.Name = "eliminarCursoToolStripMenuItem";
            eliminarCursoToolStripMenuItem.Size = new Size(159, 22);
            eliminarCursoToolStripMenuItem.Text = "Eliminar Curso";
            eliminarCursoToolStripMenuItem.Click += eliminarCursoToolStripMenuItem_Click;
            // 
            // lblPlanes
            // 
            lblPlanes.AutoSize = true;
            lblPlanes.Location = new Point(12, 61);
            lblPlanes.Name = "lblPlanes";
            lblPlanes.Size = new Size(41, 15);
            lblPlanes.TabIndex = 13;
            lblPlanes.Text = "Planes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 408);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 14;
            label2.Text = "Materias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 61);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 15;
            label3.Text = "Comisiones";
            // 
            // cursosDataGridView
            // 
            cursosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cursosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosDataGridView.Location = new Point(710, 79);
            cursosDataGridView.MultiSelect = false;
            cursosDataGridView.Name = "cursosDataGridView";
            cursosDataGridView.ReadOnly = true;
            cursosDataGridView.RowHeadersWidth = 51;
            cursosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursosDataGridView.Size = new Size(327, 326);
            cursosDataGridView.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(720, 60);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 17;
            label4.Text = "Cursos";
            // 
            // comisionesDataGridView
            // 
            comisionesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            comisionesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comisionesDataGridView.Location = new Point(351, 79);
            comisionesDataGridView.MultiSelect = false;
            comisionesDataGridView.Name = "comisionesDataGridView";
            comisionesDataGridView.ReadOnly = true;
            comisionesDataGridView.RowHeadersWidth = 51;
            comisionesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comisionesDataGridView.Size = new Size(327, 150);
            comisionesDataGridView.TabIndex = 18;
            comisionesDataGridView.CellClick += comisionesDataGridView_CellClick;
            // 
            // frmPlanConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 434);
            Controls.Add(comisionesDataGridView);
            Controls.Add(label4);
            Controls.Add(cursosDataGridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblPlanes);
            Controls.Add(materiasDataGridView);
            Controls.Add(planesDataGridView);
            Controls.Add(label1);
            Controls.Add(cmbEspecialidad);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPlanConsulta";
            Text = "frmPlanConsulta";
            Load += frmPlanConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)planesApiClientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)planesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)materiasDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cursosDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)comisionesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource planesApiClientBindingSource;
        private ComboBox cmbEspecialidad;
        private Label label1;
        private DataGridView planesDataGridView;
        private DataGridView materiasDataGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem planesToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem comisionesToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem crearUnPlanToolStripMenuItem;
        private ToolStripMenuItem modificarUnPlanToolStripMenuItem;
        private ToolStripMenuItem eliminarPlanToolStripMenuItem;
        private ToolStripMenuItem crearUnaMateriaToolStripMenuItem;
        private ToolStripMenuItem modifcarMateriaToolStripMenuItem;
        private ToolStripMenuItem eliminarMateriaSeleccionadaToolStripMenuItem;
        private ToolStripMenuItem crearComisionToolStripMenuItem;
        private ToolStripMenuItem modificarComisionToolStripMenuItem;
        private ToolStripMenuItem eliminarComisionToolStripMenuItem;
        private ToolStripMenuItem nuevoCursoToolStripMenuItem;
        private ToolStripMenuItem modificarCursoToolStripMenuItem;
        private ToolStripMenuItem eliminarCursoToolStripMenuItem;
        private Label lblPlanes;
        private Label label2;
        private Label label3;
        private DataGridView cursosDataGridView;
        private Label label4;
        private DataGridView comisionesDataGridView;
    }
}