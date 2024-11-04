using Domain.Models;

namespace WindowsForms.DocenteCurso_Folder
{
    public partial class DocenteCursoLista : Form
    {
        public DocenteCursoLista()
        {
            InitializeComponent();
        }

        private void DocenteCursoLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            var selectedItem = (dynamic)this.SelectedItem();

            id = selectedItem.Id;

            await DocenteCursoApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            DocenteCursoDetalle docenteCursoDetalle = new DocenteCursoDetalle();

            int id;

            var selectedItem = (dynamic)this.SelectedItem();

            id = selectedItem.Id;

            Docente_Curso docenteCurso = await DocenteCursoApiClient.GetAsync(id);

            docenteCursoDetalle.EditMode = true;
            docenteCursoDetalle.DocenteCurso = docenteCurso;

            docenteCursoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            DocenteCursoDetalle docenteCursoDetalle = new DocenteCursoDetalle();

            Docente_Curso docenteCursoNuevo = new Docente_Curso();

            docenteCursoDetalle.DocenteCurso = docenteCursoNuevo;

            docenteCursoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            DocenteCursoApiClient client = new DocenteCursoApiClient();

            this.docentesCursosDataGridView.DataSource = null;

            var docentesCursos = await DocenteCursoApiClient.GetAllAsync();

            if (docentesCursos.Any())
            {
                var docentesCursosDisplay = docentesCursos.Select(dc => new
                {
                    dc.Id,
                    dc.Curso.Anio_Calendario,
                    Curso = dc.Curso.Anio_Calendario + "-" + dc.Curso.Materia.Descripcion + "-" + dc.Curso.Comision.Descripcion,
                    Docente = dc.Docente.Legajo + "-" + dc.Docente.Apellido + " " + dc.Docente.Nombre,
                    dc.Cargo
                }).ToList();

                this.docentesCursosDataGridView.DataSource = docentesCursosDisplay;
            }

            if (this.docentesCursosDataGridView.Rows.Count > 0)
            {
                this.docentesCursosDataGridView.Rows[0].Selected = true;
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
            return docentesCursosDataGridView.SelectedRows[0].DataBoundItem;

        }
    }
}
