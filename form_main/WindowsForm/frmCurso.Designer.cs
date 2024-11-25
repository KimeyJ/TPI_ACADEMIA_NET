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
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 47);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 185);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(500, 120);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 102);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "Cupo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 154);
            label3.Name = "label3";
            label3.Size = new Size(206, 20);
            label3.TabIndex = 5;
            label3.Text = "Ingrese una breve descripcion";
            // 
            // button1
            // 
            button1.Location = new Point(391, 399);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Crear Curso";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(355, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 48);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 8;
            label4.Text = "Comision";
            // 
            // frmCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 450);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "frmCurso";
            Text = "frmCurso";
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
        private ComboBox comboBox1;
        private Label label4;
    }
}