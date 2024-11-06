using Domain.Models;
using System.Data;
using WindowsForms.Curso_Folder;
using WindowsForms.Inscripcion_Folder;

namespace WindowsForms.Alumno_Folder
{
    public partial class InscripcionAlumno : Form
    {
        private Inscripcion inscripcion = new Inscripcion();
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
            }
        }
        public InscripcionAlumno()
        {
            InitializeComponent();
        }

        private async void seleccionarButton_Click(object sender, EventArgs e)
        {
            InscripcionApiClient client = new InscripcionApiClient();
            CursoApiClient clientCurso = new CursoApiClient();

            if (await this.ValidateInscripcion())
            {

                this.inscripcion.Alumno = this.usuario;

                var selectedItem = (dynamic)this.SelectedItem();
                var id = selectedItem.Id;
                Curso curso = await CursoApiClient.GetAsync(id);
                this.inscripcion.Curso = curso;

                await InscripcionApiClient.AddAsync(this.inscripcion);


                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            InscripcionApiClient client = new InscripcionApiClient();

            this.cursosDataGridView.DataSource = null;

            var cursos = await InscripcionApiClient.GetCursosWithCupoAsync(this.Usuario.Id);

            if (cursos.Any())
            {
                var cursosDisplay = cursos.Select(c => new
                {
                    c.Id,
                    c.Anio_Calendario,
                    c.Cupo,
                    Materia = c.Materia.Descripcion + "-" + c.Materia.Plan.Descripcion + "-" + c.Materia.Plan.Especialidad.Descripcion,
                    Comision = c.Comision.Descripcion + "-" + c.Comision.Anio
                }).ToList();

                this.cursosDataGridView.DataSource = cursosDisplay;
            }


            if (this.cursosDataGridView.Rows.Count > 0)
            {
                this.cursosDataGridView.Rows[0].Selected = true;
                this.inscribirseButton.Enabled = true;
            }
            else
            {
                this.inscribirseButton.Enabled = false;
            }
        }

        private object SelectedItem()
        {
            return cursosDataGridView.SelectedRows[0].DataBoundItem;
        }

        private async Task<bool> ValidateInscripcion()
        {
            bool isValid = true;

            var selectedItem = (dynamic)this.SelectedItem();

            var id = selectedItem.Id;
            if (!await InscripcionApiClient.ThereIsCupo(id))
            {
                isValid = false;
                MessageBox.Show("No hay cupo disponible para el curso seleccionado");
            }

            return isValid;
        }
    }
}
