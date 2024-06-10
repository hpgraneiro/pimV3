namespace PimFazendaUrbana
{
    partial class TelaInicialAgricultor
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
            buttonDesconectar = new Button();
            buttonClientes = new Button();
            buttonEstoque = new Button();
            buttonSafra = new Button();
            SuspendLayout();
            // 
            // buttonDesconectar
            // 
            buttonDesconectar.BackgroundImage = Properties.Resources.fundo_login;
            buttonDesconectar.Font = new Font("Segoe UI", 11F);
            buttonDesconectar.Location = new Point(116, 287);
            buttonDesconectar.Name = "buttonDesconectar";
            buttonDesconectar.Size = new Size(152, 48);
            buttonDesconectar.TabIndex = 0;
            buttonDesconectar.Text = "Desconectar";
            buttonDesconectar.UseVisualStyleBackColor = true;
            buttonDesconectar.Click += buttonDesconectar_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.BackgroundImage = Properties.Resources.fundo_login;
            buttonClientes.Font = new Font("Segoe UI", 11F);
            buttonClientes.Location = new Point(515, 92);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(152, 48);
            buttonClientes.TabIndex = 2;
            buttonClientes.Text = "Visualizar Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonEstoque
            // 
            buttonEstoque.BackgroundImage = Properties.Resources.fundo_login;
            buttonEstoque.Font = new Font("Segoe UI", 11F);
            buttonEstoque.Location = new Point(116, 92);
            buttonEstoque.Name = "buttonEstoque";
            buttonEstoque.Size = new Size(152, 48);
            buttonEstoque.TabIndex = 3;
            buttonEstoque.Text = "Visualizar Estoque";
            buttonEstoque.UseVisualStyleBackColor = true;
            buttonEstoque.Click += buttonEstoque_Click;
            // 
            // buttonSafra
            // 
            buttonSafra.BackgroundImage = Properties.Resources.fundo_login;
            buttonSafra.Font = new Font("Segoe UI", 11F);
            buttonSafra.Location = new Point(515, 287);
            buttonSafra.Name = "buttonSafra";
            buttonSafra.Size = new Size(152, 48);
            buttonSafra.TabIndex = 5;
            buttonSafra.Text = "Gerenciar Safra";
            buttonSafra.UseVisualStyleBackColor = true;
            buttonSafra.Click += buttonSafra_Click;
            // 
            // TelaInicialAgricultor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.papel_de_parede_abstrato_verde_cana_vinil_3_papel_de_parede_abstrato_escuro2;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSafra);
            Controls.Add(buttonEstoque);
            Controls.Add(buttonClientes);
            Controls.Add(buttonDesconectar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaInicialAgricultor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fazenda Urbana";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDesconectar;
        private Button buttonClientes;
        private Button buttonEstoque;
        private Button buttonSafra;
    }
}