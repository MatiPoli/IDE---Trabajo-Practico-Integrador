using Domain.Models;
using System.Numerics;
using WindowsForms.Especialidad_Folder;

namespace WindowsForms.Comision_Folder
{
    public partial class ComisionDetalle : Form
    {
        private Comision comision;
        private IEnumerable<Plan> planes;
        public Comision Comision
        {
            get { return comision; }
            set
            {
                comision = value;
                this.SetComision();
            }
        }
        public bool EditMode { get; set; } = false;
        public ComisionDetalle()
        {
            InitializeComponent();
        }
        public async void SetComision()
        {
            if (this.EditMode)
            {
                this.descripcionTextBox.Text = this.comision.Descripcion;
                this.anioNumericUpDown.Value = this.comision.Anio;
            }
        }
        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            ComisionApiClient client = new ComisionApiClient();

            if (this.ValidateComision())
            {
                this.comision.Descripcion = this.descripcionTextBox.Text;
                this.comision.Anio = (int)this.anioNumericUpDown.Value;

                if (this.EditMode)
                {
                    await ComisionApiClient.UpdateAsync(this.comision);
                }
                else
                {
                    await ComisionApiClient.AddAsync(this.comision);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateComision()
        {
            bool isValid = true;

            errorProvider.SetError(descripcionTextBox, string.Empty);


            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "La Descripcíón es Requerida");
            }

            return isValid;
        }
    }
}
