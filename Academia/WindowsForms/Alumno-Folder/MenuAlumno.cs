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

namespace WindowsForms.Alumno_Folder
{
    public partial class MenuAlumno : Form
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
        public MenuAlumno()
        {
            InitializeComponent();
        }

        private void inscripcionButton_Click(object sender, EventArgs e)
        {
            InscripcionAlumno inscripcionAlumno = new InscripcionAlumno();
            inscripcionAlumno.Usuario = this.usuario;
            inscripcionAlumno.ShowDialog();
        }

        private void cursosButton_Click(object sender, EventArgs e)
        {
            InscripcionesAlumno inscripcionesAlumno = new InscripcionesAlumno();
            inscripcionesAlumno.Usuario = this.usuario;
            inscripcionesAlumno.ShowDialog();
        }
    }
}
