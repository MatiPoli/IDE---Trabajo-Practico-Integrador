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

            id = this.SelectedItem().Id;

            await DocenteCursoApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            DocenteCursoDetalle docenteCursoDetalle = new DocenteCursoDetalle();

            int id;

            id = this.SelectedItem().Id;

            Docente_Curso docenteCurso = await DocenteCursoApiClient.GetAsync(id);

            docenteCursoDetalle.EditMode = true;
            docenteCursoDetalle.Docente_Curso = docenteCurso;

            docenteCursoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void agregarButton_Click(object sender, EventArgs e)
        {
            DocenteCursoDetalle docenteCursoDetalle = new DocenteCursoDetalle();

            Docente_Curso docenteCursoNuevo = new Docente_Curso();

            docenteCursoDetalle.Docente_Curso = docenteCursoNuevo;

            docenteCursoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            DocenteCursoApiClient client = new DocenteCursoApiClient();

            this.docentesCursosDataGridView.DataSource = null;
            this.docentesCursosDataGridView.DataSource = await DocenteCursoApiClient.GetAllAsync();

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

        private Docente_Curso SelectedItem()
        {
            Docente_Curso docente_Curso;

            docente_Curso = (Docente_Curso)docentesCursosDataGridView.SelectedRows[0].DataBoundItem;

            return docente_Curso;
        }
    }
}
