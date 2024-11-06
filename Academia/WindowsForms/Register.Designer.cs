namespace WindowsForms
{
    partial class Register
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
            claveTextBox = new TextBox();
            label9 = new Label();
            nombreTextBox = new TextBox();
            emailTextBox = new TextBox();
            label4 = new Label();
            label1 = new Label();
            fechaNacDateTimePicker = new DateTimePicker();
            telefonoTextBox = new TextBox();
            apellidoTextBox = new TextBox();
            direccionTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            cancelarButton = new Button();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // claveTextBox
            // 
            claveTextBox.Location = new Point(116, 52);
            claveTextBox.Name = "claveTextBox";
            claveTextBox.Size = new Size(145, 23);
            claveTextBox.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 55);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 17;
            label9.Text = "Clave";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(116, 89);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(145, 23);
            nombreTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(116, 17);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(145, 23);
            emailTextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 20);
            label4.Margin = new Padding(3, 0, 3, 20);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 16;
            label4.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 92);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre";
            // 
            // fechaNacDateTimePicker
            // 
            fechaNacDateTimePicker.CustomFormat = "dd/MM/yyyy";
            fechaNacDateTimePicker.Format = DateTimePickerFormat.Custom;
            fechaNacDateTimePicker.Location = new Point(132, 226);
            fechaNacDateTimePicker.MaxDate = new DateTime(2024, 9, 6, 0, 0, 0, 0);
            fechaNacDateTimePicker.Name = "fechaNacDateTimePicker";
            fechaNacDateTimePicker.Size = new Size(129, 23);
            fechaNacDateTimePicker.TabIndex = 7;
            fechaNacDateTimePicker.Value = new DateTime(2024, 9, 6, 0, 0, 0, 0);
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(116, 194);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(145, 23);
            telefonoTextBox.TabIndex = 6;
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(116, 124);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(145, 23);
            apellidoTextBox.TabIndex = 4;
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(116, 159);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(145, 23);
            direccionTextBox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 232);
            label6.Margin = new Padding(3, 0, 3, 20);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 23;
            label6.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 197);
            label5.Margin = new Padding(3, 0, 3, 20);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 21;
            label5.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 162);
            label3.Margin = new Padding(3, 0, 3, 20);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 19;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 127);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 18;
            label2.Text = "Apellido";
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(186, 271);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 27;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(23, 271);
            aceptarButton.Margin = new Padding(3, 3, 20, 3);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 26;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 317);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(fechaNacDateTimePicker);
            Controls.Add(telefonoTextBox);
            Controls.Add(apellidoTextBox);
            Controls.Add(direccionTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(claveTextBox);
            Controls.Add(label9);
            Controls.Add(nombreTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Register";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrarse";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox claveTextBox;
        private Label label9;
        private TextBox nombreTextBox;
        private TextBox emailTextBox;
        private Label label4;
        private Label label1;
        private DateTimePicker fechaNacDateTimePicker;
        private TextBox telefonoTextBox;
        private TextBox apellidoTextBox;
        private TextBox direccionTextBox;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button cancelarButton;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
    }
}