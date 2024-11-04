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

            var selectedItem = (dynamic)this.SelectedItem();

            id = selectedItem.Id;

            await InscripcionApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            InscripcionDetalle inscripcionDetalle = new InscripcionDetalle();

            int id;

            var selectedItem = (dynamic)this.SelectedItem();

            id = selectedItem.Id;

            Inscripcion inscripcion = await InscripcionApiClient.GetAsync(id);

            inscripcionDetalle.EditMode = true;
            inscripcionDetalle.Inscripcion = inscripcion;

            inscripcionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
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

            var inscripciones = await InscripcionApiClient.GetAllAsync();

            if (inscripciones.Any())
            {
                var inscripcionesDisplay = inscripciones.Select(i => new
                {
                    i.Id,
                    i.Condicion,
                    i.Nota,
                    Alumno = i.Alumno.Legajo + "-" + i.Alumno.Apellido + " " + i.Alumno.Nombre,
                    Curso = i.Curso.Anio_Calendario + "-" + i.Curso.Materia.Descripcion + "-" + i.Curso.Comision.Descripcion
                }).ToList();

                this.inscripcionesDataGridView.DataSource = inscripcionesDisplay;
            }
            
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

        private object SelectedItem()
        {
            return inscripcionesDataGridView.SelectedRows[0].DataBoundItem;
        }
    }
}
