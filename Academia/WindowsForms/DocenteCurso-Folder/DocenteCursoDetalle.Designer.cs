namespace WindowsForms.DocenteCurso_Folder
{
    partial class DocenteCursoDetalle
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
            errorProvider = new ErrorProvider(components);
            label4 = new Label();
            cursosComboBox = new ComboBox();
            label2 = new Label();
            cargoComboBox = new ComboBox();
            label1 = new Label();
            cancelarButton = new Button();
            aceptarButton = new Button();
            docentesComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 61);
            label4.Margin = new Padding(3, 0, 3, 20);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 32;
            label4.Text = "Docente";
            // 
            // cursosComboBox
            // 
            cursosComboBox.FormattingEnabled = true;
            cursosComboBox.ItemHeight = 15;
            cursosComboBox.Location = new Point(116, 23);
            cursosComboBox.Name = "cursosComboBox";
            cursosComboBox.Size = new Size(145, 23);
            cursosComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 26);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 31;
            label2.Text = "Curso";
            // 
            // cargoComboBox
            // 
            cargoComboBox.FormattingEnabled = true;
            cargoComboBox.Items.AddRange(new object[] { "Docente", "Adscripto" });
            cargoComboBox.Location = new Point(116, 93);
            cargoComboBox.Name = "cargoComboBox";
            cargoComboBox.Size = new Size(145, 23);
            cargoComboBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 96);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 34;
            label1.Text = "Cargo";
            // 
            // cancelarButton
            // 
            cancelarButton.Anchor = AnchorStyles.Bottom;
            cancelarButton.Location = new Point(186, 134);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 5;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            // 
            // aceptarButton
            // 
            aceptarButton.Anchor = AnchorStyles.Bottom;
            aceptarButton.Location = new Point(23, 134);
            aceptarButton.Margin = new Padding(3, 3, 20, 3);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 4;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // docentesComboBox
            // 
            docentesComboBox.FormattingEnabled = true;
            docentesComboBox.ItemHeight = 15;
            docentesComboBox.Location = new Point(116, 58);
            docentesComboBox.Name = "docentesComboBox";
            docentesComboBox.Size = new Size(145, 23);
            docentesComboBox.TabIndex = 2;
            // 
            // DocenteCursoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 180);
            Controls.Add(docentesComboBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(cargoComboBox);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(cursosComboBox);
            Controls.Add(label2);
            MaximumSize = new Size(300, 219);
            MinimumSize = new Size(300, 219);
            Name = "DocenteCursoDetalle";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Docente-Curso Detalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider;
        private Label label4;
        private ComboBox cursosComboBox;
        private Label label2;
        private ComboBox cargoComboBox;
        private Label label1;
        private Button cancelarButton;
        private Button aceptarButton;
        private ComboBox docentesComboBox;
    }
}