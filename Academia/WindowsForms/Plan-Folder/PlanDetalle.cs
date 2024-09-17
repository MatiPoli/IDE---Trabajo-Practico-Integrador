using Domain.Models;
using System.Windows.Forms;
using WindowsForms.Especialidad_Folder;


namespace WindowsForms
{
    public partial class PlanDetalle : Form
    {
        private Plan plan;
        private IEnumerable<Especialidad> especialidades;

        public Plan Plan
        {
            get { return plan; }
            set
            {
                plan = value;
                this.SetPlan();
            }
        }
        public bool EditMode { get; set; } = false;
        public PlanDetalle()
        {
            InitializeComponent();
        }

        public void SetPlan()
        {
            if(this.EditMode)
            {
                this.descripcionTextBox.Text = this.plan.Descripcion;
                this.especialidadesComboBox.Text = this.plan.Especialidad.Descripcion;
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            PlanApiClient client = new PlanApiClient();

            if (this.ValidatePlan())
            {
                this.plan.Descripcion = this.descripcionTextBox.Text;
                this.plan.Especialidad = this.especialidades.ElementAt(especialidadesComboBox.SelectedIndex);

                if (this.EditMode)
                {
                    await PlanApiClient.UpdateAsync(this.Plan);
                }
                else
                {
                    await PlanApiClient.AddAsync(this.Plan);
                }

                this.Close();
            }
        }

        private bool ValidatePlan()
        {
            bool isValid = true;

            errorProvider.SetError(descripcionTextBox, string.Empty);
            errorProvider.SetError(especialidadesComboBox, string.Empty);


            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "La Descripcíón es Requerida");
            }
            if (this.especialidadesComboBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(especialidadesComboBox, "La Especialidad es Requerida");
            }

            return isValid;
        }

        private async void PlanDetalle_Load(object sender, EventArgs e)
        {
            EspecialidadApiClient clientEspecialidad = new EspecialidadApiClient();

            this.especialidades = await EspecialidadApiClient.GetAllAsync();
            foreach (Especialidad especialidad in this.especialidades)
            {
                this.especialidadesComboBox.Items.Add(especialidad.Descripcion);
            }
        }
    }
}
