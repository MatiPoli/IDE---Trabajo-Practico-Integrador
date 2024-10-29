using Domain.Models;


namespace WindowsForms.Materia_Folder
{
    public partial class MateriaDetalle : Form
    {
        private Materia materia;
        private IEnumerable<Plan> planes;

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;
                this.SetMateria();

            }
        }
        public bool EditMode { get; set; } = false;
        public MateriaDetalle()
        {
            InitializeComponent();
        }

        public async void SetMateria()
        {
            PlanApiClient clientPlan = new PlanApiClient();

            this.planes = await PlanApiClient.GetAllAsync();
            foreach (Plan plan in this.planes)
            {
                this.planesComboBox.Items.Add(plan.Descripcion);
            }

            if (this.EditMode)
            {
                this.descripcionTextBox.Text = this.materia.Descripcion;
                this.planesComboBox.Text = this.materia.Plan.Descripcion;
                this.planesComboBox.SelectedIndex = this.planes.ToList().FindIndex(e => e.Id == this.materia.Plan.Id);
            }
        }

        private void MateriaDetalle_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            MateriaApiClient client = new MateriaApiClient();

            if (this.ValidateMateria())
            {
                this.materia.Descripcion = this.descripcionTextBox.Text;
                this.materia.Hs_Semanales = (int)this.hsSemanalesNumericUpDown.Value;
                this.materia.Hs_Totales = (int)this.hsTotalesNumericUpDown.Value;
                this.materia.Plan = this.planes.ElementAt(planesComboBox.SelectedIndex);

                if (this.EditMode)
                {
                    await MateriaApiClient.UpdateAsync(this.materia);
                }
                else
                {
                    await MateriaApiClient.AddAsync(this.materia);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateMateria()
        {
            bool isValid = true;

            errorProvider.SetError(descripcionTextBox, string.Empty);
            errorProvider.SetError(hsSemanalesNumericUpDown, string.Empty);
            errorProvider.SetError(hsTotalesNumericUpDown, string.Empty);
            errorProvider.SetError(planesComboBox, string.Empty);


            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "La Descripcíón es Requerida");
            }
            if (this.planesComboBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(planesComboBox, "El Plan es Requerido");
            }
            if (this.hsSemanalesNumericUpDown.Value > this.hsTotalesNumericUpDown.Value)
            {
                isValid = false;
                errorProvider.SetError(hsSemanalesNumericUpDown, "Las horas semanales no pueden ser mayores a las horas totales");
            }

            return isValid;
        }
    }
}
