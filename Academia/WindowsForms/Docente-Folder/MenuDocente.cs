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

namespace WindowsForms.Docente_Folder
{
    public partial class MenuDocente : Form
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
        public MenuDocente()
        {
            InitializeComponent();
        }

        private void cursosButton_Click(object sender, EventArgs e)
        {
            CursosDocente cursosDocente = new CursosDocente();
            cursosDocente.Usuario = this.usuario;
            cursosDocente.ShowDialog();
        }

        private void alumnosButton_Click(object sender, EventArgs e)
        {
            AlumnosCurso alumnosCurso = new AlumnosCurso();
            alumnosCurso.Usuario = this.usuario;
            alumnosCurso.ShowDialog();
        }
    }
}
