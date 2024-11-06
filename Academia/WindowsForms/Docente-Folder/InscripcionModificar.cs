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
using WindowsForms.Inscripcion_Folder;

namespace WindowsForms.Docente_Folder
{
    public partial class InscripcionModificar : Form
    {
        private Inscripcion inscripcion;
        public Inscripcion Inscripcion
        {
            get { return inscripcion; }
            set
            {
                inscripcion = value;
                this.SetInscripcion();
            }
        }
        public InscripcionModificar()
        {
            InitializeComponent();
        }

        public async void SetInscripcion()
        {
            this.condicionComboBox.Text = this.inscripcion.Condicion;
            this.notaNumericUpDown.Value = this.inscripcion.Nota;
            this.alumnoText.Text = this.inscripcion.Alumno.Legajo + " - " + this.inscripcion.Alumno.Apellido + " " + this.inscripcion.Alumno.Nombre;
            this.cursoText.Text = this.inscripcion.Curso.Anio_Calendario + " - " + this.inscripcion.Curso.Materia.Descripcion + " - " + this.inscripcion.Curso.Comision.Descripcion;
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            InscripcionApiClient client = new InscripcionApiClient();

            if ( this.ValidateInscripcion())
            {
                this.inscripcion.Condicion = this.condicionComboBox.Text;
                this.inscripcion.Nota = (int)this.notaNumericUpDown.Value;

                await InscripcionApiClient.UpdateAsync(this.inscripcion);

                this.Close();
            }
        }

        private bool ValidateInscripcion()
        {
            bool isValid = true;

            errorProvider.SetError(condicionComboBox, string.Empty);


            if (this.condicionComboBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(condicionComboBox, "La Condicíón es Requerida");
            }

            return isValid;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
