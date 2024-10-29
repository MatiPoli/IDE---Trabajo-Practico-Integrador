namespace WindowsForms.Comision_Folder
{
    partial class ComisionDetalle
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
            descripcionTextBox = new TextBox();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            label2 = new Label();
            anioNumericUpDown = new NumericUpDown();
            planesComboBox = new ComboBox();
            label4 = new Label();
            cancelarButton = new Button();
            aceptarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)anioNumericUpDown).BeginInit();
            SuspendLayout();
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
            label1.TabIndex = 4;
            label1.Text = "Descripción";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 61);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 34;
            label2.Text = "Año";
            // 
            // anioNumericUpDown
            // 
            anioNumericUpDown.Location = new Point(116, 59);
            anioNumericUpDown.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            anioNumericUpDown.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            anioNumericUpDown.Name = "anioNumericUpDown";
            anioNumericUpDown.Size = new Size(145, 23);
            anioNumericUpDown.TabIndex = 2;
            anioNumericUpDown.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // planesComboBox
            // 
            planesComboBox.FormattingEnabled = true;
            planesComboBox.ItemHeight = 15;
            planesComboBox.Location = new Point(116, 93);
            planesComboBox.Name = "planesComboBox";
            planesComboBox.Size = new Size(145, 23);
            planesComboBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 96);
            label4.Margin = new Padding(3, 0, 3, 20);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 36;
            label4.Text = "Plan";
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Bottom;
            cancelarButton.Location = new Point(186, 132);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 5;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.Anchor = AnchorStyles.Bottom;
            aceptarButton.Location = new Point(23, 132);
            aceptarButton.Margin = new Padding(3, 3, 20, 3);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 4;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // ComisionDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 178);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(planesComboBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(anioNumericUpDown);
            Controls.Add(descripcionTextBox);
            Controls.Add(label1);
            MaximumSize = new Size(300, 217);
            MinimumSize = new Size(300, 217);
            Name = "ComisionDetalle";
            Padding = new Padding(20);
            Text = "Comision Detalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)anioNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionTextBox;
        private Label label1;
        private ErrorProvider errorProvider;
        private Label label2;
        private NumericUpDown anioNumericUpDown;
        private ComboBox planesComboBox;
        private Label label4;
        private Button cancelarButton;
        private Button aceptarButton;
    }
}