using Domain.Models;
using System.Globalization;

namespace WindowsForms
{
    public partial class PersonaDetalle : Form
    {
        private Persona persona;
        private IEnumerable<Plan> planes;

        public Persona Persona
        {
            get { return persona; }
            set
            {
                persona = value;
                this.SetPersona();
            }
        }
        public bool EditMode { get; set; } = false;
        public PersonaDetalle()
        {
            InitializeComponent();
        }

        public async void SetPersona()
        {
            PlanApiClient clientPlan = new PlanApiClient();

            this.planes = await PlanApiClient.GetAllAsync();
            foreach (Plan plan in this.planes)
            {
                this.planesComboBox.Items.Add(plan.Descripcion);
            }

            if (this.EditMode)
            {
                this.nombreTextBox.Text = this.persona.Nombre;
                this.apellidoTextBox.Text = this.persona.Apellido;
                this.direccionTextBox.Text = this.persona.Direccion;
                this.emailTextBox.Text = this.persona.Email;
                this.telefonoTextBox.Text = this.persona.Telefono;
                this.legajoTextBox.Text = this.persona.Legajo;
                this.planesComboBox.Text = this.persona.Plan.Descripcion;
                this.planesComboBox.SelectedIndex = this.planes.ToList().FindIndex(p => p.Id == this.persona.Plan.Id);


                if (DateTime.TryParse(this.persona.Fecha_Nac, out DateTime fechaNac))
                {
                    this.fechaNacDateTimePicker.Value = fechaNac;
                }
            }

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            PersonaApiClient client = new PersonaApiClient();

            if (this.ValidatePersona())
            {
                this.Persona.Nombre = this.nombreTextBox.Text;
                this.Persona.Apellido = this.apellidoTextBox.Text;
                this.Persona.Direccion = this.direccionTextBox.Text;
                this.Persona.Email = this.emailTextBox.Text;
                this.Persona.Telefono = this.telefonoTextBox.Text;
                this.Persona.Legajo = this.legajoTextBox.Text;
                this.Persona.Fecha_Nac = this.fechaNacDateTimePicker.Value.ToString("yyyy-MM-dd");
                this.Persona.Plan = this.planes.ElementAt(planesComboBox.SelectedIndex);

                if (this.EditMode)
                {
                    await PersonaApiClient.UpdateAsync(this.Persona);
                }
                else
                {
                    await PersonaApiClient.AddAsync(this.Persona);
                }

                this.Close();
            }
        }

        private bool ValidatePersona()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(apellidoTextBox, string.Empty);
            errorProvider.SetError(direccionTextBox, string.Empty);
            errorProvider.SetError(emailTextBox, string.Empty);
            errorProvider.SetError(telefonoTextBox, string.Empty);
            errorProvider.SetError(legajoTextBox, string.Empty);
            errorProvider.SetError(fechaNacDateTimePicker, string.Empty);
            errorProvider.SetError(planesComboBox, string.Empty);


            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }
            if (this.apellidoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(apellidoTextBox, "El Apellido es Requerido");
            }
            if (this.direccionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(direccionTextBox, "La Dirección es Requerida");
            }
            if (this.emailTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "El Email es Requerido");
            }
            if (this.telefonoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(telefonoTextBox, "El Teléfono es Requerido");
            }
            if (this.legajoTextBox.Text.Length != 5)
            {
                isValid = false;
                errorProvider.SetError(legajoTextBox, "El Legajo tiene un largo incorrecto");
            }
            if (this.legajoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(legajoTextBox, "El Legajo es Requerido");
            }
            if (this.fechaNacDateTimePicker.Value == null)
            {
                isValid = false;
                errorProvider.SetError(fechaNacDateTimePicker, "La Fecha de Nacimiento es Requerida");
            }
            if (this.planesComboBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(planesComboBox, "El Plan es Requerido");
            }

            return isValid;
        }

    }
}
