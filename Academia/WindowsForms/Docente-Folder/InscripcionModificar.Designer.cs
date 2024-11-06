namespace WindowsForms.Docente_Folder
{
    partial class InscripcionModificar
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
            label4 = new Label();
            label2 = new Label();
            alumnoText = new Label();
            cursoText = new Label();
            label3 = new Label();
            notaNumericUpDown = new NumericUpDown();
            condicionComboBox = new ComboBox();
            label1 = new Label();
            cancelarButton = new Button();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)notaNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 55);
            label4.Margin = new Padding(3, 0, 3, 20);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 28;
            label4.Text = "Curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 20);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 27;
            label2.Text = "Alumno";
            // 
            // alumnoText
            // 
            alumnoText.AutoSize = true;
            alumnoText.Location = new Point(116, 20);
            alumnoText.Name = "alumnoText";
            alumnoText.Size = new Size(69, 15);
            alumnoText.TabIndex = 29;
            alumnoText.Text = "alumnoText";
            // 
            // cursoText
            // 
            cursoText.AutoSize = true;
            cursoText.Location = new Point(116, 55);
            cursoText.Name = "cursoText";
            cursoText.Size = new Size(57, 15);
            cursoText.TabIndex = 30;
            cursoText.Text = "cursoText";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 125);
            label3.Margin = new Padding(3, 0, 3, 20);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 34;
            label3.Text = "Nota";
            // 
            // notaNumericUpDown
            // 
            notaNumericUpDown.Location = new Point(116, 123);
            notaNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            notaNumericUpDown.Name = "notaNumericUpDown";
            notaNumericUpDown.Size = new Size(145, 23);
            notaNumericUpDown.TabIndex = 32;
            // 
            // condicionComboBox
            // 
            condicionComboBox.FormattingEnabled = true;
            condicionComboBox.Items.AddRange(new object[] { "Sin Condición", "Regular", "Aprobación Directa", "Desaprobado" });
            condicionComboBox.Location = new Point(116, 87);
            condicionComboBox.Name = "condicionComboBox";
            condicionComboBox.Size = new Size(145, 23);
            condicionComboBox.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 90);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 33;
            label1.Text = "Condición";
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Bottom;
            cancelarButton.Location = new Point(186, 168);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 36;
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
            aceptarButton.TabIndex = 35;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // InscripcionModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 214);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(label3);
            Controls.Add(notaNumericUpDown);
            Controls.Add(condicionComboBox);
            Controls.Add(label1);
            Controls.Add(cursoText);
            Controls.Add(alumnoText);
            Controls.Add(label4);
            Controls.Add(label2);
            MaximumSize = new Size(300, 253);
            MinimumSize = new Size(300, 253);
            Name = "InscripcionModificar";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro Nota";
            ((System.ComponentModel.ISupportInitialize)notaNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label alumnoText;
        private Label cursoText;
        private Label label3;
        private NumericUpDown notaNumericUpDown;
        private ComboBox condicionComboBox;
        private Label label1;
        private Button cancelarButton;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
    }
}