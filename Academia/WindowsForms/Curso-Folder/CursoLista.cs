using Domain.Models;

namespace WindowsForms.Curso_Folder
{
    public partial class CursoLista : Form
    {
        public CursoLista()
        {
            InitializeComponent();
        }

        private void CursoLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            var selectedItem = (dynamic)this.SelectedItem();

            id = selectedItem.Id;

            await CursoApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            CursoDetalle cursoDetalle = new CursoDetalle();

            int id;

            var selectedItem = (dynamic)this.SelectedItem();

            id = selectedItem.Id;

            Curso curso = await CursoApiClient.GetAsync(id);

            cursoDetalle.EditMode = true;
            cursoDetalle.Curso = curso;

            cursoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            CursoDetalle cursoDetalle = new CursoDetalle();

            Curso cursoNuevo = new Curso();

            cursoDetalle.Curso = cursoNuevo;

            cursoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            CursoApiClient client = new CursoApiClient();

            this.cursosDataGridView.DataSource = null;

            var cursos = await CursoApiClient.GetAllAsync();

            var cursosDisplay = cursos.Select(c => new
            {
                c.Id,
                c.Anio_Calendario,
                c.Cupo,
                Materia = c.Materia.Descripcion + "-" + c.Materia.Plan.Descripcion + "-" + c.Materia.Plan.Especialidad.Descripcion,
                Comision = c.Comision.Descripcion + "-" + c.Comision.Anio
            }).ToList();

            this.cursosDataGridView.DataSource = cursosDisplay;

            if (this.cursosDataGridView.Rows.Count > 0)
            {
                this.cursosDataGridView.Rows[0].Selected = true;
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
            return cursosDataGridView.SelectedRows[0].DataBoundItem;
        }
    }
}
