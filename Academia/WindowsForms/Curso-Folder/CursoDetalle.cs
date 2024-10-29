using Domain.Models;
using WindowsForms.Comision_Folder;
using WindowsForms.Materia_Folder;

namespace WindowsForms.Curso_Folder
{
    public partial class CursoDetalle : Form
    {
        private Curso curso;
        private IEnumerable<Materia> materias;
        private IEnumerable<Comision> comisiones;

        public Curso Curso
        {
            get { return curso; }
            set
            {
                curso = value;
                this.SetCurso();
            }
        }
        public bool EditMode { get; set; } = false;
        public CursoDetalle()
        {
            InitializeComponent();
        }
        public async void SetCurso()
        {
            MateriaApiClient clientMateria = new MateriaApiClient();
            ComisionApiClient clientComision = new ComisionApiClient();

            this.comisiones = await ComisionApiClient.GetAllAsync();
            foreach (Comision comision in this.comisiones)
            {
                this.comisionesComboBox.Items.Add(comision.Descripcion);
            }

            this.materias = await MateriaApiClient.GetAllAsync();
            foreach (Materia materia in this.materias)
            {
                this.materiasComboBox.Items.Add(materia.Descripcion);
            }

            if (this.EditMode)
            {
                this.anioCalendarioNumericUpDown.Value = this.curso.Anio_Calendario;
                this.cupoNumericUpDown.Value = this.curso.Cupo;
                this.materiasComboBox.Text = this.curso.Materia.Descripcion;
                this.materiasComboBox.SelectedIndex = this.materias.ToList().FindIndex(e => e.Id == this.curso.Materia.Id);
                this.comisionesComboBox.Text = this.curso.Comision.Descripcion;
                this.comisionesComboBox.SelectedIndex = this.comisiones.ToList().FindIndex(e => e.Id == this.curso.Comision.Id);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            CursoApiClient client = new CursoApiClient();

            if (this.ValidateCurso())
            {
                this.curso.Anio_Calendario = (int)this.anioCalendarioNumericUpDown.Value;
                this.curso.Cupo = (int)this.cupoNumericUpDown.Value;
                this.curso.Materia = this.materias.ElementAt(materiasComboBox.SelectedIndex);
                this.curso.Comision = this.comisiones.ElementAt(comisionesComboBox.SelectedIndex);

                if (this.EditMode)
                {
                    await CursoApiClient.UpdateAsync(this.curso);
                }
                else
                {
                    await CursoApiClient.AddAsync(this.curso);
                }

                this.Close();
            }
        }
        private bool ValidateCurso()
        {
            bool isValid = true;

            errorProvider.SetError(materiasComboBox, string.Empty);
            errorProvider.SetError(comisionesComboBox, string.Empty);

            if (this.materiasComboBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(materiasComboBox, "La Materia es Requerida");
            }
            if (this.comisionesComboBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(comisionesComboBox, "La Comisión es Requerida");
            }

            return isValid;
        }
    }
}
