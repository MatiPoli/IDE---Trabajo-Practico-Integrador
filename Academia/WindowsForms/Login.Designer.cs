namespace WindowsForms
{
    partial class Login
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
            emailTextBox = new TextBox();
            label3 = new Label();
            claveTextBox = new TextBox();
            registrarseButton = new Button();
            ingresarButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 30);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Sistema Academia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 61);
            label2.Margin = new Padding(0, 0, 0, 3);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(20, 82);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(191, 23);
            emailTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 121);
            label3.Margin = new Padding(0, 0, 0, 3);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Clave";
            // 
            // claveTextBox
            // 
            claveTextBox.Location = new Point(20, 142);
            claveTextBox.Name = "claveTextBox";
            claveTextBox.PasswordChar = '*';
            claveTextBox.Size = new Size(191, 23);
            claveTextBox.TabIndex = 2;
            claveTextBox.UseSystemPasswordChar = true;
            claveTextBox.TextChanged += claveTextBox_TextChanged;
            // 
            // registrarseButton
            // 
            registrarseButton.Location = new Point(20, 188);
            registrarseButton.Name = "registrarseButton";
            registrarseButton.Size = new Size(75, 23);
            registrarseButton.TabIndex = 4;
            registrarseButton.Text = "Registrarse";
            registrarseButton.UseVisualStyleBackColor = true;
            registrarseButton.Click += registrarseButton_Click;
            // 
            // ingresarButton
            // 
            ingresarButton.Location = new Point(136, 188);
            ingresarButton.Name = "ingresarButton";
            ingresarButton.Size = new Size(75, 23);
            ingresarButton.TabIndex = 3;
            ingresarButton.Text = "Ingresar";
            ingresarButton.UseVisualStyleBackColor = true;
            ingresarButton.Click += ingresarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 244);
            Controls.Add(ingresarButton);
            Controls.Add(registrarseButton);
            Controls.Add(claveTextBox);
            Controls.Add(label3);
            Controls.Add(emailTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(250, 283);
            MinimumSize = new Size(250, 283);
            Name = "Login";
            Padding = new Padding(20, 30, 20, 30);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailTextBox;
        private Label label3;
        private TextBox claveTextBox;
        private Button registrarseButton;
        private Button ingresarButton;
        private ErrorProvider errorProvider;
    }
}