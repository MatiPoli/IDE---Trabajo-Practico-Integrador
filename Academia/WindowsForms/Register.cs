using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Register : Form
    {
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
            }
        }
        public Register()
        {
            InitializeComponent();
        }

        private void legajoTextBox_TextChanged(object sender, EventArgs e)
        {

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
                this.usuario.Fecha_Nac = this.fechaNacDateTimePicker.Value.ToString("yyyy-MM-dd");

                await UsuarioApiClient.AddAsync(this.usuario);

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
            if (this.fechaNacDateTimePicker.Value == null)
            {
                isValid = false;
                errorProvider.SetError(fechaNacDateTimePicker, "La Fecha de Nacimiento es Requerida");
            }

            return isValid;
        }

    }
}

