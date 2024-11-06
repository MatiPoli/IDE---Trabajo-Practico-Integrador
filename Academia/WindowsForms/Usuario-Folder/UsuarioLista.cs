using Domain.Models;
namespace WindowsForms
{
    public partial class UsuarioLista : Form
    {
        public UsuarioLista()
        {
            InitializeComponent();
        }


        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;

            await UsuarioApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            UsuarioDetalle usuarioDetalle = new UsuarioDetalle();

            int id;

            id = this.SelectedItem().Id;

            Usuario usuario = await UsuarioApiClient.GetAsync(id);

            usuarioDetalle.EditMode = true;
            usuarioDetalle.Usuario = usuario;

            usuarioDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            UsuarioDetalle usuarioDetalle = new UsuarioDetalle();

            Usuario usuarioNuevo = new Usuario();

            usuarioDetalle.Usuario = usuarioNuevo;

            usuarioDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad(string filtro = "")
        {
            UsuarioApiClient client = new UsuarioApiClient();
            this.usuariosDataGridView.DataSource = null;
            var usuarios = await UsuarioApiClient.GetAllAsync();

            if (!string.IsNullOrEmpty(filtro))
            {
                usuarios = usuarios.Where(u =>
                    u.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    u.Apellido.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    u.Email.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                .ToList();
            }
            this.usuariosDataGridView.DataSource = usuarios;
            if (this.usuariosDataGridView.Rows.Count > 0)
            {
                this.usuariosDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Usuario SelectedItem()
        {
            Usuario usuario;

            usuario = (Usuario)usuariosDataGridView.SelectedRows[0].DataBoundItem;

            return usuario;
        }

        private void UsuarioLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void filtroTextBox_TextChanged(object sender, EventArgs e)
        {
            this.GetAllAndLoad(this.filtroTextBox.Text);
        }
    }
}
