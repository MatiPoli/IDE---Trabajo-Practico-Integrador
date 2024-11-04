using Domain.Models;

namespace WindowsForms.Materia_Folder
{
    public partial class MateriaLista : Form
    {
        public MateriaLista()
        {
            InitializeComponent();
        }

        private void MateriaLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            var selectedItem = (dynamic)this.SelectedItem();

            id = selectedItem.Id;

            await MateriaApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            MateriaDetalle materiaDetalle = new MateriaDetalle();

            int id;

            var selectedItem = (dynamic)this.SelectedItem();

            id = selectedItem.Id;

            Materia materia = await MateriaApiClient.GetAsync(id);

            materiaDetalle.EditMode = true;
            materiaDetalle.Materia = materia;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            MateriaDetalle materiaDetalle = new MateriaDetalle();

            Materia materiaNuevo = new Materia();

            materiaDetalle.Materia = materiaNuevo;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            MateriaApiClient client = new MateriaApiClient();

            this.materiasDataGridView.DataSource = null;

            var materias = await MateriaApiClient.GetAllAsync();

            if ( materias.Any())
            {
                var materiasDisplay = materias.Select(m => new
                {
                    m.Id,
                    m.Descripcion,
                    m.Hs_Semanales,
                    m.Hs_Totales,
                    Plan = m.Plan.Descripcion + "-" + m.Plan.Especialidad.Descripcion
                }).ToList();

                this.materiasDataGridView.DataSource = materiasDisplay;
            }

            if (this.materiasDataGridView.Rows.Count > 0)
            {
                this.materiasDataGridView.Rows[0].Selected = true;
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
            return materiasDataGridView.SelectedRows[0].DataBoundItem;
        }
    }
}
