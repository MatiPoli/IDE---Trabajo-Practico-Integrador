using Domain.Models;
using WindowsForms.Shared;

namespace WindowsForms
{
    public partial class PersonaLista : Form
    {
        public PersonaLista()
        {
            InitializeComponent();
        }


        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;

            ApiClient<Persona> client = new ApiClient<Persona>("personas");
            await client.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            PersonaDetalle personaDetalle = new PersonaDetalle();

            int id;

            id = this.SelectedItem().Id;

            ApiClient<Persona> client = new ApiClient<Persona>("personas");
            Persona persona = await client.GetAsync(id);

            personaDetalle.EditMode = true;
            personaDetalle.Persona = persona;

            personaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void agregarButton_Click(object sender, EventArgs e)
        {
            PersonaDetalle personaDetalle = new PersonaDetalle();

            Persona personaNuevo = new Persona();

            personaDetalle.Persona = personaNuevo;

            personaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            ApiClient<Persona> client = new ApiClient<Persona>("personas");
            this.personasDataGridView.DataSource = null;
            this.personasDataGridView.DataSource = await client.GetAllAsync();

            if (this.personasDataGridView.Rows.Count > 0)
            {
                this.personasDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Persona SelectedItem()
        {
            Persona persona;

            persona = (Persona)personasDataGridView.SelectedRows[0].DataBoundItem;

            return persona;
        }

        private void PersonaLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
    }
}
