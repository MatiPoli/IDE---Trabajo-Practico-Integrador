using Domain.Models;
using WindowsForms.Curso_Folder;

namespace WindowsForms.Inscripcion_Folder
{
    public partial class InscripcionDetalle : Form
    {
        private Inscripcion inscripcion;
        private IEnumerable<Persona> alumnos;
        private IEnumerable<Curso> cursos;

        public Inscripcion Inscripcion
        {
            get { return inscripcion; }
            set
            {
                inscripcion = value;
                this.SetInscripcion();
            }
        }
        public bool EditMode { get; set; } = false;
        public InscripcionDetalle()
        {
            InitializeComponent();
        }

        private void InscripcionDetalle_Load(object sender, EventArgs e)
        {

        }
        public async void SetInscripcion()
        {
            PersonaApiClient clientPersona = new PersonaApiClient();
            CursoApiClient clientCurso = new CursoApiClient();

            this.alumnos = await PersonaApiClient.GetAllAlumnosAsync();
            foreach (Persona alumno in this.alumnos)
            {
                this.alumnosComboBox.Items.Add(alumno.Legajo + "-" + alumno.Apellido + " " + alumno.Nombre);
            }

            this.cursos = await CursoApiClient.GetAllAsync();
            foreach (Curso curso in this.cursos)
            {
                this.cursosComboBox.Items.Add(curso.Anio_Calendario + "-" + curso.Materia.Descripcion + "-" + curso.Comision.Descripcion);
            }

            if (this.EditMode)
            {
                this.condicionComboBox.Text = this.inscripcion.Condicion;
                this.notaNumericUpDown.Value = this.inscripcion.Nota;
                this.alumnosComboBox.Text = this.inscripcion.Alumno.Legajo + "-" + this.inscripcion.Alumno.Apellido + " " + this.inscripcion.Alumno.Nombre;
                this.alumnosComboBox.SelectedIndex = this.alumnos.ToList().FindIndex(e => e.Id == this.inscripcion.Alumno.Id);
                this.cursosComboBox.Text = this.inscripcion.Curso.Anio_Calendario + "-" + this.inscripcion.Curso.Materia.Descripcion + "-" + this.inscripcion.Curso.Comision.Descripcion;
                this.cursosComboBox.SelectedIndex = this.cursos.ToList().FindIndex(e => e.Id == this.inscripcion.Curso.Id);
            }
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            InscripcionApiClient client = new InscripcionApiClient();

            if (this.ValidateInscripcion())
            {
                this.inscripcion.Condicion = this.condicionComboBox.Text;
                this.inscripcion.Nota = (int)this.notaNumericUpDown.Value;
                this.inscripcion.Alumno = this.alumnos.ElementAt(alumnosComboBox.SelectedIndex);
                this.inscripcion.Curso = this.cursos.ElementAt(cursosComboBox.SelectedIndex);


                if (this.EditMode)
                {
                    await InscripcionApiClient.UpdateAsync(this.inscripcion);
                }
                else
                {
                    await InscripcionApiClient.AddAsync(this.inscripcion);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInscripcion()
        {
            bool isValid = true;

            errorProvider.SetError(condicionComboBox, string.Empty);
            errorProvider.SetError(notaNumericUpDown, string.Empty);
            errorProvider.SetError(alumnosComboBox, string.Empty);
            errorProvider.SetError(cursosComboBox, string.Empty);


            if (this.condicionComboBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(condicionComboBox, "La Condicíón es Requerida");
            }
            if (this.alumnosComboBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(alumnosComboBox, "El Alumno es Requerido");
            }
            if (this.cursosComboBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(cursosComboBox, "El Curso es Requerido");
            }

            return isValid;
        }
    }
}
