using Domain.Models;
using WindowsForms.Curso_Folder;


namespace WindowsForms.DocenteCurso_Folder
{
    public partial class DocenteCursoDetalle : Form
    {
        private Docente_Curso docenteCurso;
        private IEnumerable<Curso> cursos;
        private IEnumerable<Persona> docentes;
        public Docente_Curso DocenteCurso
        {
            get { return docenteCurso; }
            set
            {
                docenteCurso = value;
                this.SetDocenteCurso();
            }
        }
        public bool EditMode { get; set; } = false;
        public DocenteCursoDetalle()
        {
            InitializeComponent();
        }

        public async void SetDocenteCurso()
        {
            CursoApiClient clientCurso = new CursoApiClient();
            PersonaApiClient clientPersona = new PersonaApiClient();

            this.cursos = await CursoApiClient.GetAllAsync();
            foreach (Curso curso in this.cursos)
            {
                this.cursosComboBox.Items.Add(curso.Anio_Calendario + "-" + curso.Materia.Descripcion + "-" + curso.Comision.Descripcion);
            }
            this.docentes = await PersonaApiClient.GetAllDocentesAsync();
            foreach (Persona docente in this.docentes)
            {
                this.docentesComboBox.Items.Add(docente.Legajo + "-" + docente.Apellido + " " + docente.Nombre);
            }

            if (this.EditMode)
            {
                this.cargoComboBox.Text = this.docenteCurso.Cargo;
                this.docentesComboBox.Text = this.docenteCurso.Docente.Legajo + "-" + this.docenteCurso.Docente.Apellido + " " + this.docenteCurso.Docente.Nombre;
                this.docentesComboBox.SelectedIndex = this.docentes.ToList().FindIndex(e => e.Id == this.docenteCurso.Docente.Id);
                this.cursosComboBox.Text = this.docenteCurso.Curso.Anio_Calendario + "-" + this.docenteCurso.Curso.Materia.Descripcion + "-" + this.docenteCurso.Curso.Comision.Descripcion;
                this.cursosComboBox.SelectedIndex = this.cursos.ToList().FindIndex(e => e.Id == this.docenteCurso.Curso.Id);
            }
        }

        private void cursosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            DocenteCursoApiClient client = new DocenteCursoApiClient();

            if (this.ValidateDocenteCurso())
            {
                this.docenteCurso.Cargo = this.cargoComboBox.Text;
                this.docenteCurso.Docente = this.docentes.ElementAt(docentesComboBox.SelectedIndex);
                this.docenteCurso.Curso = this.cursos.ElementAt(cursosComboBox.SelectedIndex);


                if (this.EditMode)
                {
                    await DocenteCursoApiClient.UpdateAsync(this.docenteCurso);
                }
                else
                {
                    await DocenteCursoApiClient.AddAsync(this.docenteCurso);
                }

                this.Close();
            }
        }

        private bool ValidateDocenteCurso()
        {
            bool isValid = true;

            errorProvider.SetError(cargoComboBox, string.Empty);
            errorProvider.SetError(cursosComboBox, string.Empty);
            errorProvider.SetError(docentesComboBox, string.Empty);


            if (this.cargoComboBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(cargoComboBox, "El Cargo es Requerido");
            }
            if (this.docentesComboBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(docentesComboBox, "El Docente es Requerido");
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
