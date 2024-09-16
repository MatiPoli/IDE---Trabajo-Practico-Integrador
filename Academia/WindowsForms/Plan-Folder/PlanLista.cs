using Domain.Models;
using WindowsForms.Shared;


namespace WindowsForms
{
    public partial class PlanLista : Form
    {
        public PlanLista()
        {
            InitializeComponent();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;

            ApiClient<Plan> client = new ApiClient<Plan>("planes");
            await client.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            PlanDetalle planDetalle = new PlanDetalle();

            int id;

            id = this.SelectedItem().Id;

            ApiClient<Plan> client = new ApiClient<Plan>("planes");
            Plan plan = await client.GetAsync(id);

            planDetalle.EditMode = true;
            planDetalle.Plan = plan;

            planDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void agregarButton_Click(object sender, EventArgs e)
        {
            PlanDetalle planDetalle = new PlanDetalle();

            Plan planNuevo = new Plan();

            planDetalle.Plan = planNuevo;

            planDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            ApiClient<Plan> client = new ApiClient<Plan>("planes");

            this.planesDataGridView.DataSource = null;
            this.planesDataGridView.DataSource = await client.GetAllAsync();

            if (this.planesDataGridView.Rows.Count > 0)
            {
                this.planesDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Plan SelectedItem()
        {
            Plan plan;

            plan = (Plan)planesDataGridView.SelectedRows[0].DataBoundItem;

            return plan;
        }

        private void PlanLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
    }
}
