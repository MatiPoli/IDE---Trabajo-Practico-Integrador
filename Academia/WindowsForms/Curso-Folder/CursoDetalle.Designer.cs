namespace WindowsForms.Curso_Folder
{
    partial class CursoDetalle
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
            comisionesComboBox = new ComboBox();
            label4 = new Label();
            materiasComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cupoNumericUpDown = new NumericUpDown();
            label1 = new Label();
            anioCalendarioNumericUpDown = new NumericUpDown();
            cancelarButton = new Button();
            aceptarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cupoNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)anioCalendarioNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // comisionesComboBox
            // 
            comisionesComboBox.FormattingEnabled = true;
            comisionesComboBox.ItemHeight = 15;
            comisionesComboBox.Location = new Point(116, 127);
            comisionesComboBox.Name = "comisionesComboBox";
            comisionesComboBox.Size = new Size(145, 23);
            comisionesComboBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 130);
            label4.Margin = new Padding(3, 0, 3, 20);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 28;
            label4.Text = "Comisión";
            // 
            // materiasComboBox
            // 
            materiasComboBox.FormattingEnabled = true;
            materiasComboBox.ItemHeight = 15;
            materiasComboBox.Location = new Point(116, 92);
            materiasComboBox.Name = "materiasComboBox";
            materiasComboBox.Size = new Size(145, 23);
            materiasComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 95);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 27;
            label2.Text = "Materia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 60);
            label3.Margin = new Padding(3, 0, 3, 20);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 30;
            label3.Text = "Cupo";
            // 
            // cupoNumericUpDown
            // 
            cupoNumericUpDown.Location = new Point(116, 58);
            cupoNumericUpDown.Name = "cupoNumericUpDown";
            cupoNumericUpDown.Size = new Size(145, 23);
            cupoNumericUpDown.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 32;
            label1.Text = "Año Calendario";
            // 
            // anioCalendarioNumericUpDown
            // 
            anioCalendarioNumericUpDown.Location = new Point(116, 23);
            anioCalendarioNumericUpDown.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            anioCalendarioNumericUpDown.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            anioCalendarioNumericUpDown.Name = "anioCalendarioNumericUpDown";
            anioCalendarioNumericUpDown.Size = new Size(145, 23);
            anioCalendarioNumericUpDown.TabIndex = 1;
            anioCalendarioNumericUpDown.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Bottom;
            cancelarButton.Location = new Point(186, 165);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 6;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.Anchor = AnchorStyles.Bottom;
            aceptarButton.Location = new Point(23, 165);
            aceptarButton.Margin = new Padding(3, 3, 20, 3);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 5;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += this.aceptarButton_Click;
            // 
            // CursoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 211);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(label1);
            Controls.Add(anioCalendarioNumericUpDown);
            Controls.Add(label3);
            Controls.Add(cupoNumericUpDown);
            Controls.Add(comisionesComboBox);
            Controls.Add(label4);
            Controls.Add(materiasComboBox);
            Controls.Add(label2);
            MaximumSize = new Size(300, 250);
            MinimumSize = new Size(300, 250);
            Name = "CursoDetalle";
            Padding = new Padding(20);
            Text = "Curso Detalle";
            ((System.ComponentModel.ISupportInitialize)cupoNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)anioCalendarioNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comisionesComboBox;
        private Label label4;
        private ComboBox materiasComboBox;
        private Label label2;
        private Label label3;
        private NumericUpDown cupoNumericUpDown;
        private Label label1;
        private NumericUpDown anioCalendarioNumericUpDown;
        private Button cancelarButton;
        private Button aceptarButton;
    }
}