using Domain.Models;
using System.Globalization;

namespace WindowsForms
{
    public partial class UsuarioDetalle : Form
    {
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                this.SetPersona();
            }
        }
        public bool EditMode { get; set; } = false;
        public UsuarioDetalle()
        {
            InitializeComponent();
        }

        public async void SetPersona()
        {

            if (this.EditMode)
            {
                this.nombreTextBox.Text = this.usuario.Nombre;
                this.apellidoTextBox.Text = this.usuario.Apellido;
                this.direccionTextBox.Text = this.usuario.Direccion;
                this.emailTextBox.Text = this.usuario.Email;
                this.claveTextBox.Text = this.usuario.Clave;
                this.telefonoTextBox.Text = this.usuario.Telefono;
                this.legajoTextBox.Text = this.usuario.Legajo;
                this.tipoPersonaComboBox.Text = this.usuario.Tipo_Persona;

                if (DateTime.TryParse(this.usuario.Fecha_Nac, out DateTime fechaNac))
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
            UsuarioApiClient client = new UsuarioApiClient();

            if (this.ValidateUsuario())
            {
                this.usuario.Nombre = this.nombreTextBox.Text;
                this.usuario.Apellido = this.apellidoTextBox.Text;
                this.usuario.Direccion = this.direccionTextBox.Text;
                this.usuario.Email = this.emailTextBox.Text;
                this.usuario.Clave = this.claveTextBox.Text;
                this.usuario.Telefono = this.telefonoTextBox.Text;
                this.usuario.Legajo = this.legajoTextBox.Text;
                this.usuario.Fecha_Nac = this.fechaNacDateTimePicker.Value.ToString("yyyy-MM-dd");
                this.usuario.Tipo_Persona = this.tipoPersonaComboBox.Text;

                if (this.EditMode)
                {
                    await UsuarioApiClient.UpdateAsync(this.usuario);
                }
                else
                {
                    await UsuarioApiClient.AddAsync(this.usuario);
                }

                this.Close();
            }
        }

        private bool ValidateUsuario()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(apellidoTextBox, string.Empty);
            errorProvider.SetError(direccionTextBox, string.Empty);
            errorProvider.SetError(emailTextBox, string.Empty);
            errorProvider.SetError(claveTextBox, string.Empty);
            errorProvider.SetError(telefonoTextBox, string.Empty);
            errorProvider.SetError(legajoTextBox, string.Empty);
            errorProvider.SetError(fechaNacDateTimePicker, string.Empty);


            if (this.claveTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(claveTextBox, "La Clave es Requerida");
            }
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

            return isValid;
        }

    }
}
