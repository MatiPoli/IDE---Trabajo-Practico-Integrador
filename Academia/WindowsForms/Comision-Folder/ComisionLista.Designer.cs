namespace WindowsForms.Comision_Folder
{
    partial class ComisionLista
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
            comisionesDataGridView = new DataGridView();
            eliminarButton = new Button();
            modificarButton = new Button();
            agregarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)comisionesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // comisionesDataGridView
            // 
            comisionesDataGridView.AllowUserToAddRows = false;
            comisionesDataGridView.AllowUserToDeleteRows = false;
            comisionesDataGridView.AllowUserToResizeRows = false;
            comisionesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comisionesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comisionesDataGridView.Location = new Point(12, 12);
            comisionesDataGridView.MultiSelect = false;
            comisionesDataGridView.Name = "comisionesDataGridView";
            comisionesDataGridView.ReadOnly = true;
            comisionesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comisionesDataGridView.Size = new Size(760, 408);
            comisionesDataGridView.TabIndex = 2;
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
            // ComisionLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(comisionesDataGridView);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "ComisionLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado Comisiones";
            Load += ComisionLista_Load;
            ((System.ComponentModel.ISupportInitialize)comisionesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView comisionesDataGridView;
        private Button eliminarButton;
        private Button modificarButton;
        private Button agregarButton;
    }
}