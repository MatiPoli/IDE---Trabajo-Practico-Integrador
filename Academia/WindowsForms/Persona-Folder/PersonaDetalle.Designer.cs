namespace WindowsForms
{
    partial class PersonaDetalle
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            aceptarButton = new Button();
            cancelarButton = new Button();
            direccionTextBox = new TextBox();
            apellidoTextBox = new TextBox();
            emailTextBox = new TextBox();
            nombreTextBox = new TextBox();
            telefonoTextBox = new TextBox();
            legajoTextBox = new TextBox();
            fechaNacDateTimePicker = new DateTimePicker();
            errorProvider = new ErrorProvider(components);
            label8 = new Label();
            planesComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 55);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 90);
            label3.Margin = new Padding(3, 0, 3, 20);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 125);
            label4.Margin = new Padding(3, 0, 3, 20);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 160);
            label5.Margin = new Padding(3, 0, 3, 20);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 195);
            label6.Margin = new Padding(3, 0, 3, 20);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 230);
            label7.Margin = new Padding(3, 0, 3, 20);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 6;
            label7.Text = "Legajo";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(23, 315);
            aceptarButton.Margin = new Padding(3, 3, 20, 3);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 8;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(186, 315);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 9;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(116, 87);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(145, 23);
            direccionTextBox.TabIndex = 3;
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(116, 52);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(145, 23);
            apellidoTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(116, 122);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(145, 23);
            emailTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(116, 17);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(145, 23);
            nombreTextBox.TabIndex = 1;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(116, 157);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(145, 23);
            telefonoTextBox.TabIndex = 5;
            // 
            // legajoTextBox
            // 
            legajoTextBox.Location = new Point(116, 227);
            legajoTextBox.Name = "legajoTextBox";
            legajoTextBox.Size = new Size(145, 23);
            legajoTextBox.TabIndex = 7;
            // 
            // fechaNacDateTimePicker
            // 
            fechaNacDateTimePicker.CustomFormat = "dd/MM/yyyy";
            fechaNacDateTimePicker.Format = DateTimePickerFormat.Custom;
            fechaNacDateTimePicker.Location = new Point(132, 189);
            fechaNacDateTimePicker.MaxDate = new DateTime(2024, 9, 6, 0, 0, 0, 0);
            fechaNacDateTimePicker.Name = "fechaNacDateTimePicker";
            fechaNacDateTimePicker.Size = new Size(129, 23);
            fechaNacDateTimePicker.TabIndex = 6;
            fechaNacDateTimePicker.Value = new DateTime(2024, 9, 6, 0, 0, 0, 0);
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 265);
            label8.Margin = new Padding(3, 0, 3, 20);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 10;
            label8.Text = "Plan";
            // 
            // planesComboBox
            // 
            planesComboBox.FormattingEnabled = true;
            planesComboBox.Location = new Point(116, 262);
            planesComboBox.Name = "planesComboBox";
            planesComboBox.Size = new Size(145, 23);
            planesComboBox.TabIndex = 11;
            // 
            // PersonaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(planesComboBox);
            Controls.Add(label8);
            Controls.Add(fechaNacDateTimePicker);
            Controls.Add(legajoTextBox);
            Controls.Add(telefonoTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(apellidoTextBox);
            Controls.Add(direccionTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(300, 400);
            MinimumSize = new Size(300, 400);
            Name = "PersonaDetalle";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Persona";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button aceptarButton;
        private Button cancelarButton;
        private TextBox direccionTextBox;
        private TextBox apellidoTextBox;
        private TextBox emailTextBox;
        private TextBox nombreTextBox;
        private TextBox telefonoTextBox;
        private TextBox legajoTextBox;
        private DateTimePicker fechaNacDateTimePicker;
        private ErrorProvider errorProvider;
        private ComboBox planesComboBox;
        private Label label8;
    }
}