namespace WindowsForms.Alumno_Folder
{
    partial class InscripcionAlumno
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
            cursosDataGridView = new DataGridView();
            inscribirseButton = new Button();
            cancelarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cursosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // cursosDataGridView
            // 
            cursosDataGridView.AllowUserToAddRows = false;
            cursosDataGridView.AllowUserToDeleteRows = false;
            cursosDataGridView.AllowUserToResizeRows = false;
            cursosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cursosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosDataGridView.Location = new Point(12, 12);
            cursosDataGridView.MultiSelect = false;
            cursosDataGridView.Name = "cursosDataGridView";
            cursosDataGridView.ReadOnly = true;
            cursosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursosDataGridView.Size = new Size(760, 408);
            cursosDataGridView.TabIndex = 3;
            // 
            // inscribirseButton
            // 
            inscribirseButton.Location = new Point(697, 426);
            inscribirseButton.Name = "inscribirseButton";
            inscribirseButton.Size = new Size(75, 23);
            inscribirseButton.TabIndex = 2;
            inscribirseButton.Text = "Inscribirse";
            inscribirseButton.UseVisualStyleBackColor = true;
            inscribirseButton.Click += seleccionarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(616, 426);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 9;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // InscripcionAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(cancelarButton);
            Controls.Add(inscribirseButton);
            Controls.Add(cursosDataGridView);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "InscripcionAlumno";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cursos Disponibles";
            Load += Inscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)cursosDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView cursosDataGridView;
        private Button inscribirseButton;
        private Button cancelarButton;
    }
}