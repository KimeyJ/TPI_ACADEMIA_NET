namespace form_main.WindowsForm
{
    partial class frmPlan
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 34);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 1;
            label1.Text = "Año";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 78);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Especialidad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(81, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(295, 160);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Crear Plan";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 210);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "frmPlan";
            Text = "frmPlan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}