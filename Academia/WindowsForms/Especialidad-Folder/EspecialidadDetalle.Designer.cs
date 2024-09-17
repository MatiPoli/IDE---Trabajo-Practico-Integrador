namespace WindowsForms.Especialidad_Folder
{
    partial class EspecialidadDetalle
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
            cancelarButton = new Button();
            aceptarButton = new Button();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(116, 17);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(145, 23);
            descripcionTextBox.TabIndex = 1;
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelarButton.Location = new Point(186, 70);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            aceptarButton.Location = new Point(23, 70);
            aceptarButton.Margin = new Padding(3, 3, 20, 3);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 2;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 10;
            label1.Text = "Descripción";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // EspecialidadDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 116);
            Controls.Add(descripcionTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(label1);
            MaximumSize = new Size(300, 155);
            MinimumSize = new Size(300, 155);
            Name = "EspecialidadDetalle";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Especialidad";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionTextBox;
        private Button cancelarButton;
        private Button aceptarButton;
        private Label label1;
        private ErrorProvider errorProvider;
    }
}