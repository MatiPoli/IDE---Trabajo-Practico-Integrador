namespace WindowsForms
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            personasButton = new Button();
            planesButton = new Button();
            especialidadesButton = new Button();
            materiasButton = new Button();
            comisionesButton = new Button();
            cursosButton = new Button();
            inscripcionesButton = new Button();
            docenteCursoButton = new Button();
            SuspendLayout();
            // 
            // personasButton
            // 
            personasButton.Location = new Point(39, 34);
            personasButton.Name = "personasButton";
            personasButton.Size = new Size(138, 23);
            personasButton.TabIndex = 0;
            personasButton.Text = "Listado Personas";
            personasButton.UseVisualStyleBackColor = true;
            personasButton.Click += personasButton_Click;
            // 
            // planesButton
            // 
            planesButton.Location = new Point(39, 63);
            planesButton.Name = "planesButton";
            planesButton.Size = new Size(138, 23);
            planesButton.TabIndex = 1;
            planesButton.Text = "Listado Planes";
            planesButton.UseVisualStyleBackColor = true;
            planesButton.Click += planesButton_Click;
            // 
            // especialidadesButton
            // 
            especialidadesButton.Location = new Point(39, 92);
            especialidadesButton.Name = "especialidadesButton";
            especialidadesButton.Size = new Size(138, 23);
            especialidadesButton.TabIndex = 2;
            especialidadesButton.Text = "Listado Especialidades";
            especialidadesButton.UseVisualStyleBackColor = true;
            especialidadesButton.Click += especialidadesButton_Click;
            // 
            // materiasButton
            // 
            materiasButton.Location = new Point(39, 121);
            materiasButton.Name = "materiasButton";
            materiasButton.Size = new Size(138, 23);
            materiasButton.TabIndex = 3;
            materiasButton.Text = "Listado Materias";
            materiasButton.UseVisualStyleBackColor = true;
            materiasButton.Click += materiasButton_Click;
            // 
            // comisionesButton
            // 
            comisionesButton.Location = new Point(39, 150);
            comisionesButton.Name = "comisionesButton";
            comisionesButton.Size = new Size(138, 23);
            comisionesButton.TabIndex = 4;
            comisionesButton.Text = "Listado Comisiones";
            comisionesButton.UseVisualStyleBackColor = true;
            comisionesButton.Click += comisionesButton_Click;
            // 
            // cursosButton
            // 
            cursosButton.Location = new Point(39, 179);
            cursosButton.Name = "cursosButton";
            cursosButton.Size = new Size(138, 23);
            cursosButton.TabIndex = 5;
            cursosButton.Text = "Listado Cursos";
            cursosButton.UseVisualStyleBackColor = true;
            cursosButton.Click += cursosButton_Click;
            // 
            // inscripcionesButton
            // 
            inscripcionesButton.Location = new Point(39, 208);
            inscripcionesButton.Name = "inscripcionesButton";
            inscripcionesButton.Size = new Size(138, 23);
            inscripcionesButton.TabIndex = 6;
            inscripcionesButton.Text = "Listado Inscripciones";
            inscripcionesButton.UseVisualStyleBackColor = true;
            inscripcionesButton.Click += inscripcionesButton_Click;
            // 
            // docenteCursoButton
            // 
            docenteCursoButton.Location = new Point(39, 237);
            docenteCursoButton.Name = "docenteCursoButton";
            docenteCursoButton.Size = new Size(138, 23);
            docenteCursoButton.TabIndex = 7;
            docenteCursoButton.Text = "Listado Docente-Curso";
            docenteCursoButton.UseVisualStyleBackColor = true;
            docenteCursoButton.Click += docenteCursoButton_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 296);
            Controls.Add(docenteCursoButton);
            Controls.Add(inscripcionesButton);
            Controls.Add(cursosButton);
            Controls.Add(comisionesButton);
            Controls.Add(materiasButton);
            Controls.Add(especialidadesButton);
            Controls.Add(planesButton);
            Controls.Add(personasButton);
            Name = "MenuPrincipal";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button personasButton;
        private Button planesButton;
        private Button especialidadesButton;
        private Button materiasButton;
        private Button comisionesButton;
        private Button cursosButton;
        private Button inscripcionesButton;
        private Button docenteCursoButton;
    }
}