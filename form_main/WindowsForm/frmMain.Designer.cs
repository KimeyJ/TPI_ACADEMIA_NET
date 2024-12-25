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
            solicitudAlumnoRegularToolStripMenuItem = new ToolStripMenuItem();
            cambiarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            gestionesOnlineToolStripMenuItem = new ToolStripMenuItem();
            agregarUnAlumnoToolStripMenuItem = new ToolStripMenuItem();
            consultaAlumnosToolStripMenuItem = new ToolStripMenuItem();
            tsddProfesor = new ToolStripDropDownButton();
            agregarUnProfesorToolStripMenuItem = new ToolStripMenuItem();
            consultaProfesoresToolStripMenuItem = new ToolStripMenuItem();
            tsddPlan = new ToolStripDropDownButton();
            notasExamenToolStripMenuItem = new ToolStripMenuItem();
            estadoAcadémicoToolStripMenuItem = new ToolStripMenuItem();
            calendarioAcadémicoToolStripMenuItem = new ToolStripMenuItem();
            correlatividadParaRendirToolStripMenuItem = new ToolStripMenuItem();
            correlatividadParaCursarToolStripMenuItem = new ToolStripMenuItem();
            planesToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            moficarDatosPersonalesToolStripMenuItem = new ToolStripMenuItem();
            modifcarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            toolStripLabel1 = new ToolStripLabel();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            anotarseAUnCursoToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tssbAlumno, tsddProfesor, tsddPlan, toolStripDropDownButton1, toolStripLabel1, toolStripDropDownButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(700, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tssbAlumno
            // 
            tssbAlumno.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tssbAlumno.DropDownItems.AddRange(new ToolStripItem[] { inscripcionACursadoToolStripMenuItem, inscripcionAExamenToolStripMenuItem, solicitudAlumnoRegularToolStripMenuItem, cambiarContraseñaToolStripMenuItem, gestionesOnlineToolStripMenuItem, agregarUnAlumnoToolStripMenuItem, consultaAlumnosToolStripMenuItem });
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
            // agregarUnAlumnoToolStripMenuItem
            // 
            agregarUnAlumnoToolStripMenuItem.Name = "agregarUnAlumnoToolStripMenuItem";
            agregarUnAlumnoToolStripMenuItem.Size = new Size(209, 22);
            agregarUnAlumnoToolStripMenuItem.Text = "Agregar un Alumno";
            agregarUnAlumnoToolStripMenuItem.Click += agregarUnAlumnoToolStripMenuItem_Click;
            // 
            // consultaAlumnosToolStripMenuItem
            // 
            consultaAlumnosToolStripMenuItem.Name = "consultaAlumnosToolStripMenuItem";
            consultaAlumnosToolStripMenuItem.Size = new Size(209, 22);
            consultaAlumnosToolStripMenuItem.Text = "Consulta Alumnos";
            consultaAlumnosToolStripMenuItem.Click += consultaAlumnosToolStripMenuItem_Click;
            // 
            // tsddProfesor
            // 
            tsddProfesor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsddProfesor.DropDownItems.AddRange(new ToolStripItem[] { agregarUnProfesorToolStripMenuItem, consultaProfesoresToolStripMenuItem });
            tsddProfesor.Image = (Image)resources.GetObject("tsddProfesor.Image");
            tsddProfesor.ImageTransparentColor = Color.Magenta;
            tsddProfesor.Name = "tsddProfesor";
            tsddProfesor.Size = new Size(64, 22);
            tsddProfesor.Text = "Profesor";
            // 
            // agregarUnProfesorToolStripMenuItem
            // 
            agregarUnProfesorToolStripMenuItem.Name = "agregarUnProfesorToolStripMenuItem";
            agregarUnProfesorToolStripMenuItem.Size = new Size(180, 22);
            agregarUnProfesorToolStripMenuItem.Text = "Agregar un Profesor";
            agregarUnProfesorToolStripMenuItem.Click += agregarUnProfesorToolStripMenuItem_Click;
            // 
            // consultaProfesoresToolStripMenuItem
            // 
            consultaProfesoresToolStripMenuItem.Name = "consultaProfesoresToolStripMenuItem";
            consultaProfesoresToolStripMenuItem.Size = new Size(180, 22);
            consultaProfesoresToolStripMenuItem.Text = "Consulta Profesores";
            consultaProfesoresToolStripMenuItem.Click += consultaProfesoresToolStripMenuItem_Click;
            // 
            // tsddPlan
            // 
            tsddPlan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsddPlan.DropDownItems.AddRange(new ToolStripItem[] { notasExamenToolStripMenuItem, estadoAcadémicoToolStripMenuItem, calendarioAcadémicoToolStripMenuItem, correlatividadParaRendirToolStripMenuItem, correlatividadParaCursarToolStripMenuItem, planesToolStripMenuItem });
            tsddPlan.Image = (Image)resources.GetObject("tsddPlan.Image");
            tsddPlan.ImageTransparentColor = Color.Magenta;
            tsddPlan.Name = "tsddPlan";
            tsddPlan.Size = new Size(43, 22);
            tsddPlan.Text = "Plan";
            tsddPlan.Click += tsddPlan_Click;
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
            // planesToolStripMenuItem
            // 
            planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            planesToolStripMenuItem.Size = new Size(209, 22);
            planesToolStripMenuItem.Text = "Planes";
            planesToolStripMenuItem.Click += planesToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { moficarDatosPersonalesToolStripMenuItem, modifcarUsuarioToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(75, 22);
            toolStripDropDownButton1.Text = "Mi Cuenta";
            // 
            // moficarDatosPersonalesToolStripMenuItem
            // 
            moficarDatosPersonalesToolStripMenuItem.Name = "moficarDatosPersonalesToolStripMenuItem";
            moficarDatosPersonalesToolStripMenuItem.Size = new Size(216, 22);
            moficarDatosPersonalesToolStripMenuItem.Text = "Modificar datos personales";
            moficarDatosPersonalesToolStripMenuItem.Click += moficarDatosPersonalesToolStripMenuItem_Click;
            // 
            // modifcarUsuarioToolStripMenuItem
            // 
            modifcarUsuarioToolStripMenuItem.Name = "modifcarUsuarioToolStripMenuItem";
            modifcarUsuarioToolStripMenuItem.Size = new Size(216, 22);
            modifcarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            modifcarUsuarioToolStripMenuItem.Click += modifcarUsuarioToolStripMenuItem_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(83, 22);
            toolStripLabel1.Text = "Especialidades";
            toolStripLabel1.Click += toolStripLabel1_Click_1;
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { anotarseAUnCursoToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(56, 22);
            toolStripDropDownButton2.Text = "Cursos";
            // 
            // anotarseAUnCursoToolStripMenuItem
            // 
            anotarseAUnCursoToolStripMenuItem.Name = "anotarseAUnCursoToolStripMenuItem";
            anotarseAUnCursoToolStripMenuItem.Size = new Size(181, 22);
            anotarseAUnCursoToolStripMenuItem.Text = "Anotarse a un Curso";
            anotarseAUnCursoToolStripMenuItem.Click += anotarseAUnCursoToolStripMenuItem_Click;
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
        private ToolStripSplitButton tssbAlumno;
        private ToolStripMenuItem inscripcionACursadoToolStripMenuItem;
        private ToolStripMenuItem inscripcionAExamenToolStripMenuItem;
        private ToolStripDropDownButton tsddProfesor;
        private ToolStripDropDownButton tsddPlan;
        private ToolStripMenuItem solicitudAlumnoRegularToolStripMenuItem;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private ToolStripMenuItem gestionesOnlineToolStripMenuItem;
        private ToolStripMenuItem notasExamenToolStripMenuItem;
        private ToolStripMenuItem estadoAcadémicoToolStripMenuItem;
        private ToolStripMenuItem calendarioAcadémicoToolStripMenuItem;
        private ToolStripMenuItem correlatividadParaRendirToolStripMenuItem;
        private ToolStripMenuItem correlatividadParaCursarToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem moficarDatosPersonalesToolStripMenuItem;
        private ToolStripMenuItem modifcarUsuarioToolStripMenuItem;
        private ToolStripMenuItem agregarUnAlumnoToolStripMenuItem;
        private ToolStripMenuItem agregarUnProfesorToolStripMenuItem;
        private ToolStripMenuItem consultaAlumnosToolStripMenuItem;
        private ToolStripMenuItem consultaProfesoresToolStripMenuItem;
        private ToolStripLabel toolStripLabel1;
        private ToolStripMenuItem planesToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem anotarseAUnCursoToolStripMenuItem;
    }
}
