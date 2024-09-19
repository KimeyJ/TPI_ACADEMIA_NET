namespace form_main
{
    partial class form_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            toolStrip1 = new ToolStrip();
            tssbAlumno = new ToolStripSplitButton();
            inscripcionACursadoToolStripMenuItem = new ToolStripMenuItem();
            inscripcionAExamenToolStripMenuItem = new ToolStripMenuItem();
            tsddProfesor = new ToolStripDropDownButton();
            tsddPlan = new ToolStripDropDownButton();
            materiasDelPlanToolStripMenuItem = new ToolStripMenuItem();
            tslSalir = new ToolStripLabel();
            solicitudAlumnoRegularToolStripMenuItem = new ToolStripMenuItem();
            cambiarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            gestionesOnlineToolStripMenuItem = new ToolStripMenuItem();
            notasExamenToolStripMenuItem = new ToolStripMenuItem();
            estadoAcadémicoToolStripMenuItem = new ToolStripMenuItem();
            calendarioAcadémicoToolStripMenuItem = new ToolStripMenuItem();
            correlatividadParaRendirToolStripMenuItem = new ToolStripMenuItem();
            correlatividadParaCursarToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tssbAlumno, tsddProfesor, tsddPlan, tslSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(700, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tssbAlumno
            // 
            tssbAlumno.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tssbAlumno.DropDownItems.AddRange(new ToolStripItem[] { inscripcionACursadoToolStripMenuItem, inscripcionAExamenToolStripMenuItem, solicitudAlumnoRegularToolStripMenuItem, cambiarContraseñaToolStripMenuItem, gestionesOnlineToolStripMenuItem });
            tssbAlumno.Image = (Image)resources.GetObject("tssbAlumno.Image");
            tssbAlumno.ImageTransparentColor = Color.Magenta;
            tssbAlumno.Name = "tssbAlumno";
            tssbAlumno.Size = new Size(66, 22);
            tssbAlumno.Text = "Alumno";
            // 
            // inscripcionACursadoToolStripMenuItem
            // 
            inscripcionACursadoToolStripMenuItem.Name = "inscripcionACursadoToolStripMenuItem";
            inscripcionACursadoToolStripMenuItem.Size = new Size(209, 22);
            inscripcionACursadoToolStripMenuItem.Text = "Inscripcion a Cursado";
            // 
            // inscripcionAExamenToolStripMenuItem
            // 
            inscripcionAExamenToolStripMenuItem.Name = "inscripcionAExamenToolStripMenuItem";
            inscripcionAExamenToolStripMenuItem.Size = new Size(209, 22);
            inscripcionAExamenToolStripMenuItem.Text = "Inscripcion a Examen";
            // 
            // tsddProfesor
            // 
            tsddProfesor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsddProfesor.Image = (Image)resources.GetObject("tsddProfesor.Image");
            tsddProfesor.ImageTransparentColor = Color.Magenta;
            tsddProfesor.Name = "tsddProfesor";
            tsddProfesor.Size = new Size(64, 22);
            tsddProfesor.Text = "Profesor";
            // 
            // tsddPlan
            // 
            tsddPlan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsddPlan.DropDownItems.AddRange(new ToolStripItem[] { materiasDelPlanToolStripMenuItem, notasExamenToolStripMenuItem, estadoAcadémicoToolStripMenuItem, calendarioAcadémicoToolStripMenuItem, correlatividadParaRendirToolStripMenuItem, correlatividadParaCursarToolStripMenuItem });
            tsddPlan.Image = (Image)resources.GetObject("tsddPlan.Image");
            tsddPlan.ImageTransparentColor = Color.Magenta;
            tsddPlan.Name = "tsddPlan";
            tsddPlan.Size = new Size(43, 22);
            tsddPlan.Text = "Plan";
            // 
            // materiasDelPlanToolStripMenuItem
            // 
            materiasDelPlanToolStripMenuItem.Name = "materiasDelPlanToolStripMenuItem";
            materiasDelPlanToolStripMenuItem.Size = new Size(209, 22);
            materiasDelPlanToolStripMenuItem.Text = "Materias del Plan";
            materiasDelPlanToolStripMenuItem.Click += materiasDelPlanToolStripMenuItem_Click;
            // 
            // tslSalir
            // 
            tslSalir.Name = "tslSalir";
            tslSalir.Size = new Size(29, 22);
            tslSalir.Text = "Salir";
            tslSalir.Click += toolStripLabel1_Click;
            // 
            // solicitudAlumnoRegularToolStripMenuItem
            // 
            solicitudAlumnoRegularToolStripMenuItem.Name = "solicitudAlumnoRegularToolStripMenuItem";
            solicitudAlumnoRegularToolStripMenuItem.Size = new Size(209, 22);
            solicitudAlumnoRegularToolStripMenuItem.Text = "Solicitud Alumno Regular";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            cambiarContraseñaToolStripMenuItem.Size = new Size(209, 22);
            cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // gestionesOnlineToolStripMenuItem
            // 
            gestionesOnlineToolStripMenuItem.Name = "gestionesOnlineToolStripMenuItem";
            gestionesOnlineToolStripMenuItem.Size = new Size(209, 22);
            gestionesOnlineToolStripMenuItem.Text = "Gestiones Online";
            // 
            // notasExamenToolStripMenuItem
            // 
            notasExamenToolStripMenuItem.Name = "notasExamenToolStripMenuItem";
            notasExamenToolStripMenuItem.Size = new Size(209, 22);
            notasExamenToolStripMenuItem.Text = "Notas Examen";
            // 
            // estadoAcadémicoToolStripMenuItem
            // 
            estadoAcadémicoToolStripMenuItem.Name = "estadoAcadémicoToolStripMenuItem";
            estadoAcadémicoToolStripMenuItem.Size = new Size(209, 22);
            estadoAcadémicoToolStripMenuItem.Text = "Estado Académico";
            // 
            // calendarioAcadémicoToolStripMenuItem
            // 
            calendarioAcadémicoToolStripMenuItem.Name = "calendarioAcadémicoToolStripMenuItem";
            calendarioAcadémicoToolStripMenuItem.Size = new Size(209, 22);
            calendarioAcadémicoToolStripMenuItem.Text = "Calendario Académico";
            // 
            // correlatividadParaRendirToolStripMenuItem
            // 
            correlatividadParaRendirToolStripMenuItem.Name = "correlatividadParaRendirToolStripMenuItem";
            correlatividadParaRendirToolStripMenuItem.Size = new Size(209, 22);
            correlatividadParaRendirToolStripMenuItem.Text = "Correlatividad para rendir";
            // 
            // correlatividadParaCursarToolStripMenuItem
            // 
            correlatividadParaCursarToolStripMenuItem.Name = "correlatividadParaCursarToolStripMenuItem";
            correlatividadParaCursarToolStripMenuItem.Size = new Size(209, 22);
            correlatividadParaCursarToolStripMenuItem.Text = "Correlatividad para cursar";
            // 
            // form_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "form_main";
            Text = "Main";
            Load += form_main_Load;
            Shown += form_main_Shown;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel tslSalir;
        private ToolStripSplitButton tssbAlumno;
        private ToolStripMenuItem inscripcionACursadoToolStripMenuItem;
        private ToolStripMenuItem inscripcionAExamenToolStripMenuItem;
        private ToolStripDropDownButton tsddProfesor;
        private ToolStripDropDownButton tsddPlan;
        private ToolStripMenuItem materiasDelPlanToolStripMenuItem;
        private ToolStripMenuItem solicitudAlumnoRegularToolStripMenuItem;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private ToolStripMenuItem gestionesOnlineToolStripMenuItem;
        private ToolStripMenuItem notasExamenToolStripMenuItem;
        private ToolStripMenuItem estadoAcadémicoToolStripMenuItem;
        private ToolStripMenuItem calendarioAcadémicoToolStripMenuItem;
        private ToolStripMenuItem correlatividadParaRendirToolStripMenuItem;
        private ToolStripMenuItem correlatividadParaCursarToolStripMenuItem;
    }
}
