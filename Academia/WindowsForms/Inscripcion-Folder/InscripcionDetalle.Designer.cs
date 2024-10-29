namespace WindowsForms.Inscripcion_Folder
{
    partial class InscripcionDetalle
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            condicionComboBox = new ComboBox();
            label3 = new Label();
            notaNumericUpDown = new NumericUpDown();
            alumnosComboBox = new ComboBox();
            label2 = new Label();
            cursosComboBox = new ComboBox();
            label4 = new Label();
            cancelarButton = new Button();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)notaNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Condición";
            // 
            // condicionComboBox
            // 
            condicionComboBox.FormattingEnabled = true;
            condicionComboBox.Items.AddRange(new object[] { "Sin Condición", "Regular", "Aprobación Directa", "Desaprobado" });
            condicionComboBox.Location = new Point(116, 23);
            condicionComboBox.Name = "condicionComboBox";
            condicionComboBox.Size = new Size(145, 23);
            condicionComboBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 61);
            label3.Margin = new Padding(3, 0, 3, 20);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 20;
            label3.Text = "Nota";
            // 
            // notaNumericUpDown
            // 
            notaNumericUpDown.Location = new Point(116, 59);
            notaNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            notaNumericUpDown.Name = "notaNumericUpDown";
            notaNumericUpDown.Size = new Size(145, 23);
            notaNumericUpDown.TabIndex = 2;
            // 
            // alumnosComboBox
            // 
            alumnosComboBox.FormattingEnabled = true;
            alumnosComboBox.ItemHeight = 15;
            alumnosComboBox.Location = new Point(116, 93);
            alumnosComboBox.Name = "alumnosComboBox";
            alumnosComboBox.Size = new Size(145, 23);
            alumnosComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 96);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 22;
            label2.Text = "Alumno";
            // 
            // cursosComboBox
            // 
            cursosComboBox.FormattingEnabled = true;
            cursosComboBox.ItemHeight = 15;
            cursosComboBox.Location = new Point(116, 128);
            cursosComboBox.Name = "cursosComboBox";
            cursosComboBox.Size = new Size(145, 23);
            cursosComboBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 131);
            label4.Margin = new Padding(3, 0, 3, 20);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 24;
            label4.Text = "Curso";
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Bottom;
            cancelarButton.Location = new Point(186, 168);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 26;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.Anchor = AnchorStyles.Bottom;
            aceptarButton.Location = new Point(23, 168);
            aceptarButton.Margin = new Padding(3, 3, 20, 3);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 25;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // InscripcionDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 214);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(cursosComboBox);
            Controls.Add(label4);
            Controls.Add(alumnosComboBox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(notaNumericUpDown);
            Controls.Add(condicionComboBox);
            Controls.Add(label1);
            MaximumSize = new Size(300, 253);
            MinimumSize = new Size(300, 253);
            Name = "InscripcionDetalle";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inscripcion Detalle";
            Load += InscripcionDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)notaNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox condicionComboBox;
        private Label label3;
        private NumericUpDown notaNumericUpDown;
        private ComboBox alumnosComboBox;
        private Label label2;
        private ComboBox cursosComboBox;
        private Label label4;
        private Button cancelarButton;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
    }
}