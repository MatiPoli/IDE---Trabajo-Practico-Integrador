using Domain.Models;

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

            var selectedItem = (dynamic)this.SelectedItem();

            id = selectedItem.Id;

            await PlanApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            PlanDetalle planDetalle = new PlanDetalle();

            int id;

            var selectedItem = (dynamic)this.SelectedItem();

            id = selectedItem.Id;

            Plan plan = await PlanApiClient.GetAsync(id);

            planDetalle.EditMode = true;
            planDetalle.Plan = plan;

            planDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            PlanDetalle planDetalle = new PlanDetalle();

            Plan planNuevo = new Plan();

            planDetalle.Plan = planNuevo;

            planDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            PlanApiClient client = new PlanApiClient();

            this.planesDataGridView.DataSource = null;

            var planes = await PlanApiClient.GetAllAsync();

            if (planes.Any())
            {
                var planesDisplay = planes.Select(p => new
                {
                    p.Id,
                    p.Descripcion,
                    Especialidad = p.Especialidad.Descripcion
                }).ToList();

                this.planesDataGridView.DataSource = planesDisplay;
            }
            
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

        private object SelectedItem()
        {
            return planesDataGridView.SelectedRows[0].DataBoundItem;
        }

        private void PlanLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
    }
}
