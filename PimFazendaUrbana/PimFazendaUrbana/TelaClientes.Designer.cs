namespace PimFazendaUrbana
{
    partial class TelaClientes
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
            panelClientes = new Panel();
            buttonRemoverCliente = new Button();
            labelIdCliente = new Label();
            buttonCadastrarCliente = new Button();
            textBoxIdCliente = new TextBox();
            buttonEditarCliente = new Button();
            listViewCliente = new ListView();
            idCliente = new ColumnHeader();
            NomeCliente = new ColumnHeader();
            CpfouCnpjCliente = new ColumnHeader();
            EnderecoCliente = new ColumnHeader();
            TelefoneCliente = new ColumnHeader();
            textBoxTelefoneCliente = new TextBox();
            textBoxEnderecoCliente = new TextBox();
            textBoxCpfouCnpjCliente = new TextBox();
            textBoxNomeCliente = new TextBox();
            labelTelefoneCLiente = new Label();
            label3 = new Label();
            labelCpfouCnpjCliente = new Label();
            labelNomeCliente = new Label();
            buttonVoltarCliente = new Button();
            labelCliente = new Label();
            panelClientes.SuspendLayout();
            SuspendLayout();
            // 
            // panelClientes
            // 
            panelClientes.BackgroundImage = Properties.Resources.fundo_login;
            panelClientes.Controls.Add(buttonRemoverCliente);
            panelClientes.Controls.Add(labelIdCliente);
            panelClientes.Controls.Add(buttonCadastrarCliente);
            panelClientes.Controls.Add(textBoxIdCliente);
            panelClientes.Controls.Add(buttonEditarCliente);
            panelClientes.Controls.Add(listViewCliente);
            panelClientes.Controls.Add(textBoxTelefoneCliente);
            panelClientes.Controls.Add(textBoxEnderecoCliente);
            panelClientes.Controls.Add(textBoxCpfouCnpjCliente);
            panelClientes.Controls.Add(textBoxNomeCliente);
            panelClientes.Controls.Add(labelTelefoneCLiente);
            panelClientes.Controls.Add(label3);
            panelClientes.Controls.Add(labelCpfouCnpjCliente);
            panelClientes.Controls.Add(labelNomeCliente);
            panelClientes.Location = new Point(27, 45);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(795, 376);
            panelClientes.TabIndex = 0;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.Font = new Font("Segoe UI", 10F);
            buttonRemoverCliente.Location = new Point(356, 320);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(127, 38);
            buttonRemoverCliente.TabIndex = 11;
            buttonRemoverCliente.Text = "Remover Cliente";
            buttonRemoverCliente.UseVisualStyleBackColor = true;
            buttonRemoverCliente.Click += buttonRemoverCliente_Click;
            // 
            // labelIdCliente
            // 
            labelIdCliente.AutoSize = true;
            labelIdCliente.BackColor = Color.Transparent;
            labelIdCliente.Font = new Font("Segoe UI", 10F);
            labelIdCliente.Location = new Point(19, 259);
            labelIdCliente.Name = "labelIdCliente";
            labelIdCliente.Size = new Size(26, 19);
            labelIdCliente.TabIndex = 12;
            labelIdCliente.Text = "ID:";
            labelIdCliente.Click += labelIdCliente_Click;
            // 
            // buttonCadastrarCliente
            // 
            buttonCadastrarCliente.Font = new Font("Segoe UI", 10F);
            buttonCadastrarCliente.Location = new Point(19, 320);
            buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            buttonCadastrarCliente.Size = new Size(127, 38);
            buttonCadastrarCliente.TabIndex = 8;
            buttonCadastrarCliente.Text = "Cadastrar Cliente";
            buttonCadastrarCliente.UseVisualStyleBackColor = true;
            buttonCadastrarCliente.Click += buttonCadastrarCliente_Click;
            // 
            // textBoxIdCliente
            // 
            textBoxIdCliente.Location = new Point(19, 281);
            textBoxIdCliente.Name = "textBoxIdCliente";
            textBoxIdCliente.Size = new Size(38, 23);
            textBoxIdCliente.TabIndex = 11;
            // 
            // buttonEditarCliente
            // 
            buttonEditarCliente.Font = new Font("Segoe UI", 10F);
            buttonEditarCliente.Location = new Point(187, 320);
            buttonEditarCliente.Name = "buttonEditarCliente";
            buttonEditarCliente.Size = new Size(127, 38);
            buttonEditarCliente.TabIndex = 9;
            buttonEditarCliente.Text = "Editar Cliente";
            buttonEditarCliente.UseVisualStyleBackColor = true;
            buttonEditarCliente.Click += buttonEditarCliente_Click;
            // 
            // listViewCliente
            // 
            listViewCliente.Columns.AddRange(new ColumnHeader[] { idCliente, NomeCliente, CpfouCnpjCliente, EnderecoCliente, TelefoneCliente });
            listViewCliente.Location = new Point(0, 0);
            listViewCliente.MultiSelect = false;
            listViewCliente.Name = "listViewCliente";
            listViewCliente.Size = new Size(795, 244);
            listViewCliente.TabIndex = 9;
            listViewCliente.UseCompatibleStateImageBehavior = false;
            listViewCliente.View = View.Details;
            listViewCliente.Click += listViewCliente_Click;
            // 
            // idCliente
            // 
            idCliente.Text = "ID";
            idCliente.Width = 40;
            // 
            // NomeCliente
            // 
            NomeCliente.Text = "Nome";
            NomeCliente.TextAlign = HorizontalAlignment.Center;
            NomeCliente.Width = 240;
            // 
            // CpfouCnpjCliente
            // 
            CpfouCnpjCliente.Text = "CPF / CNPJ";
            CpfouCnpjCliente.TextAlign = HorizontalAlignment.Center;
            CpfouCnpjCliente.Width = 130;
            // 
            // EnderecoCliente
            // 
            EnderecoCliente.Text = "Endereço";
            EnderecoCliente.TextAlign = HorizontalAlignment.Center;
            EnderecoCliente.Width = 250;
            // 
            // TelefoneCliente
            // 
            TelefoneCliente.Text = "Telefone(s)";
            TelefoneCliente.TextAlign = HorizontalAlignment.Center;
            TelefoneCliente.Width = 130;
            // 
            // textBoxTelefoneCliente
            // 
            textBoxTelefoneCliente.Font = new Font("Segoe UI", 9F);
            textBoxTelefoneCliente.Location = new Point(632, 281);
            textBoxTelefoneCliente.Name = "textBoxTelefoneCliente";
            textBoxTelefoneCliente.Size = new Size(149, 23);
            textBoxTelefoneCliente.TabIndex = 7;
            // 
            // textBoxEnderecoCliente
            // 
            textBoxEnderecoCliente.Font = new Font("Segoe UI", 9F);
            textBoxEnderecoCliente.Location = new Point(443, 281);
            textBoxEnderecoCliente.Name = "textBoxEnderecoCliente";
            textBoxEnderecoCliente.Size = new Size(169, 23);
            textBoxEnderecoCliente.TabIndex = 6;
            // 
            // textBoxCpfouCnpjCliente
            // 
            textBoxCpfouCnpjCliente.Font = new Font("Segoe UI", 9F);
            textBoxCpfouCnpjCliente.Location = new Point(289, 281);
            textBoxCpfouCnpjCliente.Name = "textBoxCpfouCnpjCliente";
            textBoxCpfouCnpjCliente.Size = new Size(134, 23);
            textBoxCpfouCnpjCliente.TabIndex = 5;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Font = new Font("Segoe UI", 9F);
            textBoxNomeCliente.Location = new Point(76, 281);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(194, 23);
            textBoxNomeCliente.TabIndex = 4;
            // 
            // labelTelefoneCLiente
            // 
            labelTelefoneCLiente.AutoSize = true;
            labelTelefoneCLiente.BackColor = Color.Transparent;
            labelTelefoneCLiente.Font = new Font("Segoe UI", 10F);
            labelTelefoneCLiente.Location = new Point(632, 259);
            labelTelefoneCLiente.Name = "labelTelefoneCLiente";
            labelTelefoneCLiente.Size = new Size(76, 19);
            labelTelefoneCLiente.TabIndex = 3;
            labelTelefoneCLiente.Text = "Telefone(s):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(443, 259);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 2;
            label3.Text = "Endereço:";
            // 
            // labelCpfouCnpjCliente
            // 
            labelCpfouCnpjCliente.AutoSize = true;
            labelCpfouCnpjCliente.BackColor = Color.Transparent;
            labelCpfouCnpjCliente.Font = new Font("Segoe UI", 10F);
            labelCpfouCnpjCliente.Location = new Point(289, 259);
            labelCpfouCnpjCliente.Name = "labelCpfouCnpjCliente";
            labelCpfouCnpjCliente.Size = new Size(91, 19);
            labelCpfouCnpjCliente.TabIndex = 1;
            labelCpfouCnpjCliente.Text = "CPF ou CNPJ:";
            // 
            // labelNomeCliente
            // 
            labelNomeCliente.AutoSize = true;
            labelNomeCliente.BackColor = Color.Transparent;
            labelNomeCliente.Font = new Font("Segoe UI", 10F);
            labelNomeCliente.Location = new Point(76, 259);
            labelNomeCliente.Name = "labelNomeCliente";
            labelNomeCliente.Size = new Size(49, 19);
            labelNomeCliente.TabIndex = 0;
            labelNomeCliente.Text = "Nome:";
            // 
            // buttonVoltarCliente
            // 
            buttonVoltarCliente.Font = new Font("Segoe UI", 11F);
            buttonVoltarCliente.Location = new Point(46, 438);
            buttonVoltarCliente.Name = "buttonVoltarCliente";
            buttonVoltarCliente.Size = new Size(127, 43);
            buttonVoltarCliente.TabIndex = 10;
            buttonVoltarCliente.Text = "Voltar";
            buttonVoltarCliente.UseVisualStyleBackColor = true;
            buttonVoltarCliente.Click += buttonVoltarCliente_Click;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.BackColor = Color.Transparent;
            labelCliente.Font = new Font("Segoe UI", 20F);
            labelCliente.Location = new Point(348, 2);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(111, 37);
            labelCliente.TabIndex = 10;
            labelCliente.Text = "Clientes";
            // 
            // TelaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.papel_de_parede_abstrato_verde_cana_vinil_3_papel_de_parede_abstrato_escuro2;
            ClientSize = new Size(848, 493);
            Controls.Add(labelCliente);
            Controls.Add(buttonVoltarCliente);
            Controls.Add(panelClientes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fazenda Urbana";
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelClientes;
        private Label labelTelefoneCLiente;
        private Label label3;
        private Label labelCpfouCnpjCliente;
        private Label labelNomeCliente;
        private TextBox textBoxTelefoneCliente;
        private TextBox textBoxEnderecoCliente;
        private TextBox textBoxCpfouCnpjCliente;
        private TextBox textBoxNomeCliente;
        private Button buttonCadastrarCliente;
        private Button buttonEditarCliente;
        private Button buttonVoltarCliente;
        private ListView listViewCliente;
        private Label labelCliente;
        private ColumnHeader NomeCliente;
        private ColumnHeader CpfouCnpjCliente;
        private ColumnHeader EnderecoCliente;
        private ColumnHeader TelefoneCliente;
        private ColumnHeader idCliente;
        private TextBox textBoxIdCliente;
        private Label labelIdCliente;
        private Button buttonRemoverCliente;
    }
}