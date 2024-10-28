namespace WindowsForms
{
    partial class PlanDetalle
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
            cancelarButton = new Button();
            aceptarButton = new Button();
            label2 = new Label();
            especialidadesComboBox = new ComboBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
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
            label1.TabIndex = 2;
            label1.Text = "Descripción";
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Bottom;
            cancelarButton.Location = new Point(186, 97);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 4;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.Anchor = AnchorStyles.Bottom;
            aceptarButton.Location = new Point(23, 97);
            aceptarButton.Margin = new Padding(3, 3, 20, 3);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 3;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 61);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 12;
            label2.Text = "Especialidades";
            // 
            // especialidadesComboBox
            // 
            especialidadesComboBox.FormattingEnabled = true;
            especialidadesComboBox.Location = new Point(116, 58);
            especialidadesComboBox.Name = "especialidadesComboBox";
            especialidadesComboBox.Size = new Size(145, 23);
            especialidadesComboBox.TabIndex = 2;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // PlanDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 143);
            Controls.Add(especialidadesComboBox);
            Controls.Add(label2);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(descripcionTextBox);
            Controls.Add(label1);
            Name = "PlanDetalle";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Plan Detalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionTextBox;
        private Label label1;
        private Button cancelarButton;
        private Button aceptarButton;
        private Label label2;
        private ComboBox especialidadesComboBox;
        private ErrorProvider errorProvider;
    }
}