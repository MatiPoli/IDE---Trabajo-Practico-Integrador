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
using WindowsForms.Curso_Folder;
using WindowsForms.DocenteCurso_Folder;
using WindowsForms.Inscripcion_Folder;

namespace WindowsForms.Docente_Folder
{
    public partial class AlumnosCurso : Form
    {
        private IEnumerable<Docente_Curso> dc;

        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
            }
        }
        public AlumnosCurso()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void AlumnosCurso_Load(object sender, EventArgs e)
        {
            this.dc = await DocenteCursoApiClient.GetAllAsyncByDocente(this.usuario.Id);
            foreach (Docente_Curso dc in this.dc)
            {
                this.cursosComboBox.Items.Add(dc.Curso.Anio_Calendario + "-" + dc.Curso.Materia.Descripcion + "-" + dc.Curso.Comision.Descripcion);
            }
            if (dc.Any())
            {
                this.cursosComboBox.SelectedIndex = 0;
            }
        }

        private void cursosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            InscripcionModificar inscripcionModificar = new InscripcionModificar();

            int id;

            var selectedItem = (dynamic)this.SelectedItem();

            id = selectedItem.Id;

            Inscripcion inscripcion = await InscripcionApiClient.GetAsync(id);

            inscripcionModificar.Inscripcion = inscripcion;

            inscripcionModificar.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            Curso curso = this.dc.ElementAt(cursosComboBox.SelectedIndex).Curso;
            InscripcionApiClient client = new InscripcionApiClient();

            this.inscripcionesDataGridView.DataSource = null;

            var inscripciones = await InscripcionApiClient.GetAllByCurso(curso.Id);

            if (inscripciones.Any())
            {
                var inscripcionesDisplay = inscripciones.Select(i => new
                {
                    i.Id,
                    Nombre = i.Alumno.Nombre,
                    Apellido = i.Alumno.Apellido,
                    Legajo = i.Alumno.Legajo,
                    i.Condicion,
                    i.Nota,
                }).ToList();

                this.inscripcionesDataGridView.DataSource = inscripcionesDisplay;
            }
        }

        private object SelectedItem()
        {
            return inscripcionesDataGridView.SelectedRows[0].DataBoundItem;
        }
    }
}
