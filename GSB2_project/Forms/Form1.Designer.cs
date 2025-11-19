namespace GSB2_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxLoginEmail = new TextBox();
            textBoxLoginPassword = new TextBox();
            buttonLogin = new Button();
            Email = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxLoginEmail
            // 
            textBoxLoginEmail.Location = new Point(316, 115);
            textBoxLoginEmail.Name = "textBoxLoginEmail";
            textBoxLoginEmail.Size = new Size(125, 27);
            textBoxLoginEmail.TabIndex = 0;
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.Location = new Point(317, 190);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Size = new Size(125, 27);
            textBoxLoginPassword.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(317, 260);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(124, 29);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Connexion";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(316, 82);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 3;
            Email.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 167);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Mot de passe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Email);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxLoginPassword);
            Controls.Add(textBoxLoginEmail);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLoginEmail;
        private TextBox textBoxLoginPassword;
        private Button buttonLogin;
        private Label Email;
        private Label label1;
    }
}
