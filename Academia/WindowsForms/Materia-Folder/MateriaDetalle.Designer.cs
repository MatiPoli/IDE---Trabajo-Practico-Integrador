namespace WindowsForms.Materia_Folder
{
    partial class MateriaDetalle
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
            planesComboBox = new ComboBox();
            label2 = new Label();
            descripcionTextBox = new TextBox();
            label1 = new Label();
            hsSemanalesNumericUpDown = new NumericUpDown();
            errorProvider = new ErrorProvider(components);
            label3 = new Label();
            label4 = new Label();
            hsTotalesNumericUpDown = new NumericUpDown();
            cancelarButton = new Button();
            aceptarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)hsSemanalesNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hsTotalesNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // planesComboBox
            // 
            planesComboBox.FormattingEnabled = true;
            planesComboBox.Location = new Point(116, 128);
            planesComboBox.Name = "planesComboBox";
            planesComboBox.Size = new Size(145, 23);
            planesComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 131);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 16;
            label2.Text = "Plan";
            label2.Click += label2_Click;
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(116, 23);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(145, 23);
            descripcionTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 15;
            label1.Text = "Descripción";
            // 
            // hsSemanalesNumericUpDown
            // 
            hsSemanalesNumericUpDown.Location = new Point(126, 59);
            hsSemanalesNumericUpDown.Name = "hsSemanalesNumericUpDown";
            hsSemanalesNumericUpDown.Size = new Size(135, 23);
            hsSemanalesNumericUpDown.TabIndex = 2;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 61);
            label3.Margin = new Padding(3, 0, 3, 20);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 18;
            label3.Text = "Horas Semanales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 96);
            label4.Margin = new Padding(3, 0, 3, 20);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 20;
            label4.Text = "Horas Totales";
            // 
            // hsTotalesNumericUpDown
            // 
            hsTotalesNumericUpDown.Location = new Point(126, 94);
            hsTotalesNumericUpDown.Name = "hsTotalesNumericUpDown";
            hsTotalesNumericUpDown.Size = new Size(135, 23);
            hsTotalesNumericUpDown.TabIndex = 3;
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Bottom;
            cancelarButton.Location = new Point(186, 166);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 6;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            // 
            // aceptarButton
            // 
            aceptarButton.Anchor = AnchorStyles.Bottom;
            aceptarButton.Location = new Point(23, 166);
            aceptarButton.Margin = new Padding(3, 3, 20, 3);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 5;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            // 
            // MateriaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 212);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(label4);
            Controls.Add(hsTotalesNumericUpDown);
            Controls.Add(label3);
            Controls.Add(hsSemanalesNumericUpDown);
            Controls.Add(planesComboBox);
            Controls.Add(label2);
            Controls.Add(descripcionTextBox);
            Controls.Add(label1);
            MaximumSize = new Size(300, 251);
            MinimumSize = new Size(300, 251);
            Name = "MateriaDetalle";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Materia Detalle";
            Load += MateriaDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)hsSemanalesNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)hsTotalesNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox planesComboBox;
        private Label label2;
        private TextBox descripcionTextBox;
        private Label label1;
        private NumericUpDown hsSemanalesNumericUpDown;
        private ErrorProvider errorProvider;
        private Label label4;
        private NumericUpDown hsTotalesNumericUpDown;
        private Label label3;
        private Button cancelarButton;
        private Button aceptarButton;
    }
}