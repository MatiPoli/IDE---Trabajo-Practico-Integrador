namespace WindowsForms.Docente_Folder
{
    partial class AlumnosCurso
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
            cancelarButton = new Button();
            inscripcionesDataGridView = new DataGridView();
            cursosComboBox = new ComboBox();
            modificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inscripcionesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(411, 426);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
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
            inscripcionesDataGridView.TabIndex = 8;
            // 
            // cursosComboBox
            // 
            cursosComboBox.FormattingEnabled = true;
            cursosComboBox.Location = new Point(573, 426);
            cursosComboBox.Name = "cursosComboBox";
            cursosComboBox.Size = new Size(199, 23);
            cursosComboBox.TabIndex = 2;
            cursosComboBox.SelectedIndexChanged += cursosComboBox_SelectedIndexChanged;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(492, 426);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(75, 23);
            modificarButton.TabIndex = 1;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // AlumnosCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(modificarButton);
            Controls.Add(cursosComboBox);
            Controls.Add(cancelarButton);
            Controls.Add(inscripcionesDataGridView);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "AlumnosCurso";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alumnos por Cursos Asignados";
            Load += AlumnosCurso_Load;
            ((System.ComponentModel.ISupportInitialize)inscripcionesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cancelarButton;
        private DataGridView inscripcionesDataGridView;
        private ComboBox cursosComboBox;
        private Button modificarButton;
    }
}