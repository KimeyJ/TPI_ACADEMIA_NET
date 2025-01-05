namespace form_main.WindowsForm
{
    partial class frmCurso
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
            textBox1 = new TextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            profDataGridView = new DataGridView();
            profDataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)profDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(11, 373);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(785, 120);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 31);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "Cupo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(41, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 343);
            label3.Name = "label3";
            label3.Size = new Size(206, 20);
            label3.TabIndex = 5;
            label3.Text = "Ingrese una breve descripcion";
            // 
            // button1
            // 
            button1.Location = new Point(703, 517);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Crear Curso";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 83);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 8;
            label4.Text = "Profesor de Teoria";
            // 
            // profDataGridView
            // 
            profDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            profDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            profDataGridView.Location = new Point(11, 127);
            profDataGridView.Margin = new Padding(3, 4, 3, 4);
            profDataGridView.MultiSelect = false;
            profDataGridView.Name = "profDataGridView";
            profDataGridView.ReadOnly = true;
            profDataGridView.RowHeadersWidth = 51;
            profDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            profDataGridView.Size = new Size(381, 200);
            profDataGridView.TabIndex = 19;
            // 
            // profDataGridView1
            // 
            profDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            profDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            profDataGridView1.Location = new Point(416, 127);
            profDataGridView1.Margin = new Padding(3, 4, 3, 4);
            profDataGridView1.MultiSelect = false;
            profDataGridView1.Name = "profDataGridView1";
            profDataGridView1.ReadOnly = true;
            profDataGridView1.RowHeadersWidth = 51;
            profDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            profDataGridView1.Size = new Size(381, 200);
            profDataGridView1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 83);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 21;
            label5.Text = "Profesor de Practica";
            // 
            // frmCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 553);
            Controls.Add(label5);
            Controls.Add(profDataGridView1);
            Controls.Add(profDataGridView);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "frmCurso";
            Text = "frmCurso";
            Load += frmCurso_Load;
            ((System.ComponentModel.ISupportInitialize)profDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)profDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Label label4;
        private DataGridView profDataGridView;
        private DataGridView profDataGridView1;
        private Label label5;
    }
}