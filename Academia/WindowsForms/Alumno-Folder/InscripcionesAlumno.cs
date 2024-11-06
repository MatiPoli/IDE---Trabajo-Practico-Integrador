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

namespace WindowsForms.Alumno_Folder
{
    public partial class InscripcionesAlumno : Form
    {
        private Usuario usuario;
        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
            }
        }

        public InscripcionesAlumno()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void InscripcionesAlumno_Load(object sender, EventArgs e)
        {
            InscripcionApiClient client = new InscripcionApiClient();

            this.inscripcionesDataGridView.DataSource = null;

            var inscripciones = await InscripcionApiClient.GetAllByAlumno(this.usuario.Id);

            if (inscripciones.Any())
            {
                var inscripcionesDisplay = inscripciones.Select(i => new
                {
                    i.Id,
                    i.Condicion,
                    i.Nota,
                    Curso = i.Curso.Anio_Calendario + "-" + i.Curso.Materia.Descripcion + "-" + i.Curso.Comision.Descripcion
                }).ToList();

                this.inscripcionesDataGridView.DataSource = inscripcionesDisplay;
            }

        }
    }
}
