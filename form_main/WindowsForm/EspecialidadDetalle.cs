using Domain.Model;
using form_main.APIs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class EspecialidadDetalle : Form
    {
        private Especialidad especialidad;

        public Especialidad Especialidad
        {
            get { return especialidad; }
            set
            {
                especialidad = value;
                this.SetEspecialidad();
            }
        }

        public bool EditMode { get; set; } = false;

        public EspecialidadDetalle()
        {
            InitializeComponent();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            EspecialidadesApiClient client = new EspecialidadesApiClient();

            if (this.ValidateEspecialidad())
            {
                this.Especialidad.Descripcion = descripcionTextBox.Text;

                if (this.EditMode)
                {
                    await EspecialidadesApiClient.UpdateAsync(this.Especialidad);
                }
                else
                {
                    await EspecialidadesApiClient.AddAsync(this.Especialidad);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetEspecialidad()
        {
            this.descripcionTextBox.Text = this.Especialidad.Descripcion;
        }

        private bool ValidateEspecialidad()
        {
            bool isValid = true;

            errorProvider.SetError(descripcionTextBox, string.Empty);

            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "La descripcion es Requerida");
            }

            return isValid;
        }

    }
}
