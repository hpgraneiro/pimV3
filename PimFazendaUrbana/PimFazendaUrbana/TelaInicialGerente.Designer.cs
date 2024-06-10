namespace PimFazendaUrbana
{
    partial class TelaInicialGerente
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
            buttonEstoque = new Button();
            buttonClientes = new Button();
            buttonFornecedores = new Button();
            button6 = new Button();
            buttonDesconectar = new Button();
            buttonFuncionario = new Button();
            SuspendLayout();
            // 
            // buttonEstoque
            // 
            buttonEstoque.BackgroundImage = Properties.Resources.fundo_login;
            buttonEstoque.Font = new Font("Segoe UI", 11F);
            buttonEstoque.Location = new Point(72, 102);
            buttonEstoque.Name = "buttonEstoque";
            buttonEstoque.Size = new Size(142, 48);
            buttonEstoque.TabIndex = 1;
            buttonEstoque.Text = "Visualizar Estoque";
            buttonEstoque.UseVisualStyleBackColor = true;
            buttonEstoque.Click += buttonEstoque_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.BackgroundImage = Properties.Resources.fundo_login;
            buttonClientes.Font = new Font("Segoe UI", 11F);
            buttonClientes.Location = new Point(335, 102);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(142, 48);
            buttonClientes.TabIndex = 2;
            buttonClientes.Text = "Visualizar Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonFornecedores
            // 
            buttonFornecedores.BackgroundImage = Properties.Resources.fundo_login;
            buttonFornecedores.Font = new Font("Segoe UI", 11F);
            buttonFornecedores.Location = new Point(335, 293);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(142, 48);
            buttonFornecedores.TabIndex = 4;
            buttonFornecedores.Text = "Visualizar Fornecedores";
            buttonFornecedores.UseVisualStyleBackColor = true;
            buttonFornecedores.Click += buttonFornecedores_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.fundo_login;
            button6.Font = new Font("Segoe UI", 11F);
            button6.Location = new Point(591, 293);
            button6.Name = "button6";
            button6.Size = new Size(142, 48);
            button6.TabIndex = 5;
            button6.Text = "Gerenciar Safra";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // buttonDesconectar
            // 
            buttonDesconectar.BackgroundImage = Properties.Resources.fundo_login;
            buttonDesconectar.Font = new Font("Segoe UI", 11F);
            buttonDesconectar.Location = new Point(72, 293);
            buttonDesconectar.Name = "buttonDesconectar";
            buttonDesconectar.Size = new Size(142, 48);
            buttonDesconectar.TabIndex = 6;
            buttonDesconectar.Text = "Desconectar";
            buttonDesconectar.UseVisualStyleBackColor = true;
            buttonDesconectar.Click += buttonDesconectar_Click;
            // 
            // buttonFuncionario
            // 
            buttonFuncionario.BackgroundImage = Properties.Resources.fundo_login;
            buttonFuncionario.Font = new Font("Segoe UI", 11F);
            buttonFuncionario.Location = new Point(591, 102);
            buttonFuncionario.Name = "buttonFuncionario";
            buttonFuncionario.Size = new Size(142, 48);
            buttonFuncionario.TabIndex = 8;
            buttonFuncionario.Text = "Visualizar Funcionários";
            buttonFuncionario.UseVisualStyleBackColor = true;
            buttonFuncionario.Click += buttonFuncionario_Click;
            // 
            // TelaInicialGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.papel_de_parede_abstrato_verde_cana_vinil_3_papel_de_parede_abstrato_escuro2;
            ClientSize = new Size(808, 462);
            Controls.Add(buttonFuncionario);
            Controls.Add(buttonDesconectar);
            Controls.Add(button6);
            Controls.Add(buttonFornecedores);
            Controls.Add(buttonClientes);
            Controls.Add(buttonEstoque);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaInicialGerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fazenda Urbana";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonEstoque;
        private Button buttonClientes;
        private Button buttonFornecedores;
        private Button button6;
        private Button buttonDesconectar;
        private Button buttonFuncionario;
    }
}