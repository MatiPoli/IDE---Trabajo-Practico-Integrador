using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Especialidad_Folder;

namespace WindowsForms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void personasButton_Click(object sender, EventArgs e)
        {
            PersonaLista personaLista = new PersonaLista();
            personaLista.ShowDialog();
        }

        private void planesButton_Click(object sender, EventArgs e)
        {
            PlanLista planLista = new PlanLista();
            planLista.ShowDialog();
        }

        private void especialidadesButton_Click(object sender, EventArgs e)
        {
            EspecialidadLista especialidadLista = new EspecialidadLista();
            especialidadLista.ShowDialog();
        }
    }
}
