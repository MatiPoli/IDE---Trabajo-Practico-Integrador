namespace WindowsForms.Alumno_Folder
{
    partial class InscripcionesAlumno
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
            inscripcionesDataGridView = new DataGridView();
            cancelarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inscripcionesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // inscripcionesDataGridView
            // 
            inscripcionesDataGridView.AllowUserToAddRows = false;
            inscripcionesDataGridView.AllowUserToDeleteRows = false;
            inscripcionesDataGridView.AllowUserToResizeRows = false;
            inscripcionesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inscripcionesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inscripcionesDataGridView.Location = new Point(12, 12);
            inscripcionesDataGridView.MultiSelect = false;
            inscripcionesDataGridView.Name = "inscripcionesDataGridView";
            inscripcionesDataGridView.ReadOnly = true;
            inscripcionesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inscripcionesDataGridView.Size = new Size(760, 408);
            inscripcionesDataGridView.TabIndex = 4;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(697, 426);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 1;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // InscripcionesAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(cancelarButton);
            Controls.Add(inscripcionesDataGridView);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "InscripcionesAlumno";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mis Inscripciones";
            Load += InscripcionesAlumno_Load;
            ((System.ComponentModel.ISupportInitialize)inscripcionesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView inscripcionesDataGridView;
        private Button cancelarButton;
    }
}