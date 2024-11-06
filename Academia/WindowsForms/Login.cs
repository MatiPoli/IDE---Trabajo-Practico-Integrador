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
using WindowsForms.Alumno_Folder;
using WindowsForms.Docente_Folder;

namespace WindowsForms
{
    public partial class Login : Form
    {
        private string Email;
        private string Clave;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private async void ingresarButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            UsuarioApiClient client = new UsuarioApiClient();

            if (this.ValidateUsuario())
            {
                this.Email = this.emailTextBox.Text;
                this.Clave = this.claveTextBox.Text;

                Usuario usuario = new Usuario();
                usuario = await UsuarioApiClient.LoginAsync(this.Email, this.Clave);

                if (usuario != null)
                {
                    if (usuario.Tipo_Persona == "Admin")
                    {
                        MenuAdmin menuAdmin = new MenuAdmin();
                        //menuAdmin.FormClosed += (s, args) => this.Close(); 
                        menuAdmin.ShowDialog();
                        Cursor.Current = Cursors.Default;
                        //this.Hide();
                    }
                    else if (usuario.Tipo_Persona == "Docente")
                    {
                        MenuDocente menuDocente = new MenuDocente();
                        menuDocente.Usuario = usuario;
                        //menuDocente.FormClosed += (s, args) => this.Close(); 
                        menuDocente.ShowDialog();
                        Cursor.Current = Cursors.Default;
                        //this.Hide();
                    }
                    else
                    {
                        MenuAlumno menuAlumno = new MenuAlumno();
                        menuAlumno.Usuario = usuario;
                        //menuAlumno.FormClosed += (s, args) => this.Close(); 
                        menuAlumno.ShowDialog();
                        Cursor.Current = Cursors.Default;
                        //this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Clave Incorrecta");
                }
            }
        }

        private void registrarseButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            Usuario usuarioNuevo = new Usuario();

            register.Usuario = usuarioNuevo;

            register.ShowDialog();

        }

        private bool ValidateUsuario()
        {
            bool isValid = true;


            errorProvider.SetError(emailTextBox, string.Empty);
            errorProvider.SetError(claveTextBox, string.Empty);


            if (this.claveTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(claveTextBox, "La Clave es Requerida");
            }

            if (this.emailTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "El Email es Requerido");
            }

            return isValid;
        }

        private void claveTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
