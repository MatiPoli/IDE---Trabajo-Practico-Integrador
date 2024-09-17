using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Especialidad_Folder
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

        public void SetEspecialidad()
        {
            if (this.EditMode)
            {
                this.descripcionTextBox.Text = this.especialidad.Descripcion;
            }

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            EspecialidadApiClient client = new EspecialidadApiClient();

            if (this.ValidateEspecialidad())
            {
                this.especialidad.Descripcion = this.descripcionTextBox.Text;

                if (this.EditMode)
                {
                    await EspecialidadApiClient.UpdateAsync(this.Especialidad);
                }
                else
                {
                    await EspecialidadApiClient.AddAsync(this.Especialidad);
                }

                this.Close();
            }
        }

        private bool ValidateEspecialidad()
        {
            bool isValid = true;

            errorProvider.SetError(descripcionTextBox, string.Empty);


            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "La Descripción es Requerida");
            }

            return isValid;
        }

        private void cancelarButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
