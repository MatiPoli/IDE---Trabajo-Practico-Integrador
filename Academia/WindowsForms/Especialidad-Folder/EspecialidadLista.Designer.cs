namespace WindowsForms.Especialidad_Folder
{
    partial class EspecialidadLista
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
            especialidadesDataGridView = new DataGridView();
            agregarButton = new Button();
            modificarButton = new Button();
            eliminarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)especialidadesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // especialidadesDataGridView
            // 
            especialidadesDataGridView.AllowUserToAddRows = false;
            especialidadesDataGridView.AllowUserToDeleteRows = false;
            especialidadesDataGridView.AllowUserToResizeRows = false;
            especialidadesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            especialidadesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            especialidadesDataGridView.Location = new Point(12, 12);
            especialidadesDataGridView.MultiSelect = false;
            especialidadesDataGridView.Name = "especialidadesDataGridView";
            especialidadesDataGridView.ReadOnly = true;
            especialidadesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            especialidadesDataGridView.Size = new Size(760, 408);
            especialidadesDataGridView.TabIndex = 1;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(697, 426);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(75, 23);
            agregarButton.TabIndex = 2;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(616, 426);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(75, 23);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(535, 426);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(75, 23);
            eliminarButton.TabIndex = 4;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // EspecialidadLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(especialidadesDataGridView);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "EspecialidadLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado Especialidades";
            Load += EspecialidadLista_Load;
            ((System.ComponentModel.ISupportInitialize)especialidadesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView especialidadesDataGridView;
        private Button agregarButton;
        private Button modificarButton;
        private Button eliminarButton;
    }
}