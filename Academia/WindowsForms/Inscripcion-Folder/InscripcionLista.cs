using Domain.Models;

namespace WindowsForms.Inscripcion_Folder
{
    public partial class InscripcionLista : Form
    {
        public InscripcionLista()
        {
            InitializeComponent();
        }

        private void InscripcionLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;

            await InscripcionApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            InscripcionDetalle inscripcionDetalle = new InscripcionDetalle();

            int id;

            id = this.SelectedItem().Id;

            Inscripcion inscripcion = await InscripcionApiClient.GetAsync(id);

            inscripcionDetalle.EditMode = true;
            inscripcionDetalle.Inscripcion = inscripcion;

            inscripcionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void agregarButton_Click(object sender, EventArgs e)
        {
            InscripcionDetalle inscripcionDetalle = new InscripcionDetalle();

            Inscripcion inscripcionNuevo = new Inscripcion();

            inscripcionDetalle.Inscripcion = inscripcionNuevo;

            inscripcionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            InscripcionApiClient client = new InscripcionApiClient();

            this.inscripcionesDataGridView.DataSource = null;
            this.inscripcionesDataGridView.DataSource = await InscripcionApiClient.GetAllAsync();

            if (this.inscripcionesDataGridView.Rows.Count > 0)
            {
                this.inscripcionesDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Inscripcion SelectedItem()
        {
            Inscripcion inscripcion;

            inscripcion = (Inscripcion)inscripcionesDataGridView.SelectedRows[0].DataBoundItem;

            return inscripcion;
        }
    }
}
