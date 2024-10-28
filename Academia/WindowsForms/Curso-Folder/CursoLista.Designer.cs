namespace WindowsForms.Curso_Folder
{
    partial class CursoLista
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
            eliminarButton = new Button();
            modificarButton = new Button();
            agregarButton = new Button();
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
            cursosDataGridView.TabIndex = 2;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(535, 426);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(75, 23);
            eliminarButton.TabIndex = 9;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(616, 426);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(75, 23);
            modificarButton.TabIndex = 8;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(697, 426);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(75, 23);
            agregarButton.TabIndex = 7;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // CursoLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(cursosDataGridView);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "CursoLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado Cursos";
            Load += CursoLista_Load;
            ((System.ComponentModel.ISupportInitialize)cursosDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView cursosDataGridView;
        private Button eliminarButton;
        private Button modificarButton;
        private Button agregarButton;
    }
}