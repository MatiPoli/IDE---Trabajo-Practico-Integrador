
using WindowsForms.Comision_Folder;
using WindowsForms.Curso_Folder;
using WindowsForms.DocenteCurso_Folder;
using WindowsForms.Especialidad_Folder;
using WindowsForms.Inscripcion_Folder;
using WindowsForms.Materia_Folder;

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

        private void materiasButton_Click(object sender, EventArgs e)
        {
            MateriaLista materiaLista = new MateriaLista();
            materiaLista.ShowDialog();
        }

        private void comisionesButton_Click(object sender, EventArgs e)
        {
            ComisionLista comisionLista = new ComisionLista();
            comisionLista.ShowDialog();
        }

        private void cursosButton_Click(object sender, EventArgs e)
        {
            CursoLista cursoLista = new CursoLista();
            cursoLista.ShowDialog();
        }

        private void inscripcionesButton_Click(object sender, EventArgs e)
        {
            InscripcionLista inscripcionLista = new InscripcionLista();
            inscripcionLista.ShowDialog();
        }

        private void docenteCursoButton_Click(object sender, EventArgs e)
        {
            DocenteCursoLista docenteCursoLista = new DocenteCursoLista();
            docenteCursoLista.ShowDialog();
        }
    }
}
