using Domain.Models;
using System.Windows.Forms;
using WindowsForms.Shared;


namespace WindowsForms
{
    public partial class PlanDetalle : Form
    {
        private Plan plan;

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
            this.descripcionTextBox.Text = this.plan.Descripcion;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            ApiClient<Plan> client = new ApiClient<Plan>("planes");

            if (this.ValidatePlan())
            {
                this.plan.Descripcion = this.descripcionTextBox.Text;

                if (this.EditMode)
                {
                    await client.UpdateAsync(this.Plan);
                }
                else
                {
                    await client.AddAsync(this.Plan);
                }

                this.Close();
            }
        }

        private bool ValidatePlan()
        {
            bool isValid = true;

            errorProvider.SetError(descripcionTextBox, string.Empty);
    

            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "La Descripcíón es Requerida");
            }  

            return isValid;
        }
    }
}
