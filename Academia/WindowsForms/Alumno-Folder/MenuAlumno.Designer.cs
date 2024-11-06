namespace WindowsForms.Alumno_Folder
{
    partial class MenuAlumno
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
            inscripcionButton = new Button();
            cursosButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // inscripcionButton
            // 
            inscripcionButton.Location = new Point(38, 58);
            inscripcionButton.Name = "inscripcionButton";
            inscripcionButton.Size = new Size(138, 23);
            inscripcionButton.TabIndex = 1;
            inscripcionButton.Text = "Inscribirse a Curso";
            inscripcionButton.UseVisualStyleBackColor = true;
            inscripcionButton.Click += inscripcionButton_Click;
            // 
            // cursosButton
            // 
            cursosButton.Location = new Point(38, 100);
            cursosButton.Name = "cursosButton";
            cursosButton.Size = new Size(138, 23);
            cursosButton.TabIndex = 2;
            cursosButton.Text = "Mis Inscripciones";
            cursosButton.UseVisualStyleBackColor = true;
            cursosButton.Click += cursosButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Menú Alumno";
            // 
            // MenuAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 155);
            Controls.Add(label1);
            Controls.Add(cursosButton);
            Controls.Add(inscripcionButton);
            MaximumSize = new Size(231, 194);
            MinimumSize = new Size(231, 194);
            Name = "MenuAlumno";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inscripcionButton;
        private Button cursosButton;
        private Label label1;
    }
}