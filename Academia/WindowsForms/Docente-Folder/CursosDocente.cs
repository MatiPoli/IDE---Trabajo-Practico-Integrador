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
using WindowsForms.DocenteCurso_Folder;

namespace WindowsForms.Docente_Folder
{
    public partial class CursosDocente : Form
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
        public CursosDocente()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void CursosDocente_Load(object sender, EventArgs e)
        {
            DocenteCursoApiClient client = new DocenteCursoApiClient();

            this.cursosDataGridView.DataSource = null;

            var docentesCursos = await DocenteCursoApiClient.GetAllAsyncByDocente(this.usuario.Id);

            if (docentesCursos.Any())
            {
                var docentesCursosDisplay = docentesCursos.Select(dc => new
                {
                    dc.Id,
                    dc.Curso.Anio_Calendario,
                    Curso = dc.Curso.Anio_Calendario + "-" + dc.Curso.Materia.Descripcion + "-" + dc.Curso.Comision.Descripcion,
                    dc.Cargo
                }).ToList();

                this.cursosDataGridView.DataSource = docentesCursosDisplay;
            }
        }
    }
}
