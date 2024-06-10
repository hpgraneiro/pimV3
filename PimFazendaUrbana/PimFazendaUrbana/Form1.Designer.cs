namespace PimFazendaUrbana
{
    partial class TelaLogin
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
            panel1 = new Panel();
            textBoxSenha = new TextBox();
            ButtonLogar = new Button();
            TextBoxLogin = new TextBox();
            LabelSenha = new Label();
            LabelLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fundo_login;
            panel1.Controls.Add(textBoxSenha);
            panel1.Controls.Add(ButtonLogar);
            panel1.Controls.Add(TextBoxLogin);
            panel1.Controls.Add(LabelSenha);
            panel1.Controls.Add(LabelLogin);
            panel1.Location = new Point(196, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 406);
            panel1.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Font = new Font("Segoe UI", 12F);
            textBoxSenha.Location = new Point(110, 204);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(244, 29);
            textBoxSenha.TabIndex = 5;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // ButtonLogar
            // 
            ButtonLogar.Location = new Point(178, 291);
            ButtonLogar.Name = "ButtonLogar";
            ButtonLogar.Size = new Size(87, 29);
            ButtonLogar.TabIndex = 4;
            ButtonLogar.Text = "Logar";
            ButtonLogar.UseVisualStyleBackColor = true;
            ButtonLogar.Click += ButtonLogar_Click;
            // 
            // TextBoxLogin
            // 
            TextBoxLogin.Font = new Font("Segoe UI", 12F);
            TextBoxLogin.Location = new Point(110, 84);
            TextBoxLogin.Name = "TextBoxLogin";
            TextBoxLogin.Size = new Size(244, 29);
            TextBoxLogin.TabIndex = 3;
            // 
            // LabelSenha
            // 
            LabelSenha.AutoSize = true;
            LabelSenha.BackColor = Color.Transparent;
            LabelSenha.Font = new Font("Segoe UI", 12F);
            LabelSenha.Location = new Point(48, 207);
            LabelSenha.Name = "LabelSenha";
            LabelSenha.Size = new Size(56, 21);
            LabelSenha.TabIndex = 1;
            LabelSenha.Text = "Senha:";
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.BackColor = Color.Transparent;
            LabelLogin.Font = new Font("Segoe UI", 12F);
            LabelLogin.Location = new Point(48, 87);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(52, 21);
            LabelLogin.TabIndex = 0;
            LabelLogin.Text = "Login:";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.papel_de_parede_abstrato_verde_cana_vinil_3_papel_de_parede_abstrato_escuro2;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fazenda Urbana";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TextBoxLogin;
        private Label LabelSenha;
        private Label LabelLogin;
        private Button ButtonLogar;
        private TextBox textBoxSenha;
    }
}
