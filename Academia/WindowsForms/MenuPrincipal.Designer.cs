namespace WindowsForms
{
    partial class MenuPrincipal
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
            personasButton = new Button();
            planesButton = new Button();
            SuspendLayout();
            // 
            // personasButton
            // 
            personasButton.Location = new Point(53, 53);
            personasButton.Name = "personasButton";
            personasButton.Size = new Size(108, 23);
            personasButton.TabIndex = 0;
            personasButton.Text = "Listado Personas";
            personasButton.UseVisualStyleBackColor = true;
            personasButton.Click += personasButton_Click;
            // 
            // planesButton
            // 
            planesButton.Location = new Point(54, 82);
            planesButton.Name = "planesButton";
            planesButton.Size = new Size(108, 23);
            planesButton.TabIndex = 1;
            planesButton.Text = "Listado Planes";
            planesButton.UseVisualStyleBackColor = true;
            planesButton.Click += planesButton_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 261);
            Controls.Add(planesButton);
            Controls.Add(personasButton);
            Name = "MenuPrincipal";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button personasButton;
        private Button planesButton;
    }
}