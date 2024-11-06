namespace WindowsForms.Docente_Folder
{
    partial class MenuDocente
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
            label1 = new Label();
            alumnosButton = new Button();
            cursosButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 20);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 4;
            label1.Text = "Menú Docente";
            // 
            // alumnosButton
            // 
            alumnosButton.Location = new Point(37, 97);
            alumnosButton.Name = "alumnosButton";
            alumnosButton.Size = new Size(138, 23);
            alumnosButton.TabIndex = 2;
            alumnosButton.Text = "Alumnos por Curso";
            alumnosButton.UseVisualStyleBackColor = true;
            alumnosButton.Click += alumnosButton_Click;
            // 
            // cursosButton
            // 
            cursosButton.Location = new Point(37, 55);
            cursosButton.Name = "cursosButton";
            cursosButton.Size = new Size(138, 23);
            cursosButton.TabIndex = 1;
            cursosButton.Text = "Mis Cursos";
            cursosButton.UseVisualStyleBackColor = true;
            cursosButton.Click += cursosButton_Click;
            // 
            // MenuDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 155);
            Controls.Add(alumnosButton);
            Controls.Add(cursosButton);
            Controls.Add(label1);
            MaximumSize = new Size(231, 194);
            MinimumSize = new Size(231, 194);
            Name = "MenuDocente";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button alumnosButton;
        private Button cursosButton;
    }
}