namespace PimFazendaUrbana
{
    partial class TelaFornecedores
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
            panelFornecedores = new Panel();
            textBoxIdFornecedor = new TextBox();
            labelIdFornecedor = new Label();
            textBoxTelefoneFornecedor = new TextBox();
            button3 = new Button();
            textBoxCpfouCnpjFornecedor = new TextBox();
            buttonEditarFornecedor = new Button();
            textBoxNomeFornecedor = new TextBox();
            buttonCadastrarFornecedor = new Button();
            labelTelefoneFornecedores = new Label();
            labelCpfouCnpjFornecedores = new Label();
            labelNomeFornecedores = new Label();
            listViewFornecedor = new ListView();
            IdFornecedor = new ColumnHeader();
            NomeFornecedor = new ColumnHeader();
            CpfouCnpjFornecedor = new ColumnHeader();
            TelefoneFornecedor = new ColumnHeader();
            labelFornecedores = new Label();
            buttonVoltar = new Button();
            panelFornecedores.SuspendLayout();
            SuspendLayout();
            // 
            // panelFornecedores
            // 
            panelFornecedores.BackgroundImage = Properties.Resources.fundo_login;
            panelFornecedores.Controls.Add(textBoxIdFornecedor);
            panelFornecedores.Controls.Add(labelIdFornecedor);
            panelFornecedores.Controls.Add(textBoxTelefoneFornecedor);
            panelFornecedores.Controls.Add(button3);
            panelFornecedores.Controls.Add(textBoxCpfouCnpjFornecedor);
            panelFornecedores.Controls.Add(buttonEditarFornecedor);
            panelFornecedores.Controls.Add(textBoxNomeFornecedor);
            panelFornecedores.Controls.Add(buttonCadastrarFornecedor);
            panelFornecedores.Controls.Add(labelTelefoneFornecedores);
            panelFornecedores.Controls.Add(labelCpfouCnpjFornecedores);
            panelFornecedores.Controls.Add(labelNomeFornecedores);
            panelFornecedores.Controls.Add(listViewFornecedor);
            panelFornecedores.Location = new Point(28, 40);
            panelFornecedores.Name = "panelFornecedores";
            panelFornecedores.Size = new Size(761, 348);
            panelFornecedores.TabIndex = 0;
            // 
            // textBoxIdFornecedor
            // 
            textBoxIdFornecedor.Location = new Point(24, 255);
            textBoxIdFornecedor.Name = "textBoxIdFornecedor";
            textBoxIdFornecedor.Size = new Size(64, 23);
            textBoxIdFornecedor.TabIndex = 8;
            // 
            // labelIdFornecedor
            // 
            labelIdFornecedor.AutoSize = true;
            labelIdFornecedor.BackColor = Color.Transparent;
            labelIdFornecedor.Font = new Font("Segoe UI", 10F);
            labelIdFornecedor.Location = new Point(24, 233);
            labelIdFornecedor.Name = "labelIdFornecedor";
            labelIdFornecedor.Size = new Size(26, 19);
            labelIdFornecedor.TabIndex = 7;
            labelIdFornecedor.Text = "ID:";
            // 
            // textBoxTelefoneFornecedor
            // 
            textBoxTelefoneFornecedor.Location = new Point(544, 255);
            textBoxTelefoneFornecedor.Name = "textBoxTelefoneFornecedor";
            textBoxTelefoneFornecedor.Size = new Size(179, 23);
            textBoxTelefoneFornecedor.TabIndex = 6;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(439, 294);
            button3.Name = "button3";
            button3.Size = new Size(151, 36);
            button3.TabIndex = 4;
            button3.Text = "Remover Fornecedor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBoxCpfouCnpjFornecedor
            // 
            textBoxCpfouCnpjFornecedor.Location = new Point(333, 255);
            textBoxCpfouCnpjFornecedor.Name = "textBoxCpfouCnpjFornecedor";
            textBoxCpfouCnpjFornecedor.Size = new Size(171, 23);
            textBoxCpfouCnpjFornecedor.TabIndex = 5;
            // 
            // buttonEditarFornecedor
            // 
            buttonEditarFornecedor.Font = new Font("Segoe UI", 10F);
            buttonEditarFornecedor.Location = new Point(232, 294);
            buttonEditarFornecedor.Name = "buttonEditarFornecedor";
            buttonEditarFornecedor.Size = new Size(151, 36);
            buttonEditarFornecedor.TabIndex = 3;
            buttonEditarFornecedor.Text = "Editar Fornecedor";
            buttonEditarFornecedor.UseVisualStyleBackColor = true;
            buttonEditarFornecedor.Click += buttonEditarFornecedor_Click;
            // 
            // textBoxNomeFornecedor
            // 
            textBoxNomeFornecedor.Location = new Point(129, 255);
            textBoxNomeFornecedor.Name = "textBoxNomeFornecedor";
            textBoxNomeFornecedor.Size = new Size(165, 23);
            textBoxNomeFornecedor.TabIndex = 4;
            // 
            // buttonCadastrarFornecedor
            // 
            buttonCadastrarFornecedor.Font = new Font("Segoe UI", 10F);
            buttonCadastrarFornecedor.Location = new Point(24, 294);
            buttonCadastrarFornecedor.Name = "buttonCadastrarFornecedor";
            buttonCadastrarFornecedor.Size = new Size(151, 36);
            buttonCadastrarFornecedor.TabIndex = 2;
            buttonCadastrarFornecedor.Text = "Cadastrar Fornecedor";
            buttonCadastrarFornecedor.UseVisualStyleBackColor = true;
            buttonCadastrarFornecedor.Click += buttonCadastrarFornecedor_Click;
            // 
            // labelTelefoneFornecedores
            // 
            labelTelefoneFornecedores.AutoSize = true;
            labelTelefoneFornecedores.BackColor = Color.Transparent;
            labelTelefoneFornecedores.Font = new Font("Segoe UI", 10F);
            labelTelefoneFornecedores.Location = new Point(544, 233);
            labelTelefoneFornecedores.Name = "labelTelefoneFornecedores";
            labelTelefoneFornecedores.Size = new Size(76, 19);
            labelTelefoneFornecedores.TabIndex = 3;
            labelTelefoneFornecedores.Text = "Telefone(s):";
            labelTelefoneFornecedores.Click += label3_Click;
            // 
            // labelCpfouCnpjFornecedores
            // 
            labelCpfouCnpjFornecedores.AutoSize = true;
            labelCpfouCnpjFornecedores.BackColor = Color.Transparent;
            labelCpfouCnpjFornecedores.Font = new Font("Segoe UI", 10F);
            labelCpfouCnpjFornecedores.Location = new Point(333, 233);
            labelCpfouCnpjFornecedores.Name = "labelCpfouCnpjFornecedores";
            labelCpfouCnpjFornecedores.Size = new Size(91, 19);
            labelCpfouCnpjFornecedores.TabIndex = 2;
            labelCpfouCnpjFornecedores.Text = "CPF ou CNPJ:";
            // 
            // labelNomeFornecedores
            // 
            labelNomeFornecedores.AutoSize = true;
            labelNomeFornecedores.BackColor = Color.Transparent;
            labelNomeFornecedores.Font = new Font("Segoe UI", 10F);
            labelNomeFornecedores.Location = new Point(129, 233);
            labelNomeFornecedores.Name = "labelNomeFornecedores";
            labelNomeFornecedores.Size = new Size(49, 19);
            labelNomeFornecedores.TabIndex = 1;
            labelNomeFornecedores.Text = "Nome:";
            // 
            // listViewFornecedor
            // 
            listViewFornecedor.Columns.AddRange(new ColumnHeader[] { IdFornecedor, NomeFornecedor, CpfouCnpjFornecedor, TelefoneFornecedor });
            listViewFornecedor.Location = new Point(0, 0);
            listViewFornecedor.Name = "listViewFornecedor";
            listViewFornecedor.Size = new Size(761, 219);
            listViewFornecedor.TabIndex = 0;
            listViewFornecedor.UseCompatibleStateImageBehavior = false;
            listViewFornecedor.View = View.Details;
            listViewFornecedor.Click += listViewFornecedor_Click;
            // 
            // IdFornecedor
            // 
            IdFornecedor.Text = "ID";
            IdFornecedor.Width = 50;
            // 
            // NomeFornecedor
            // 
            NomeFornecedor.Text = "Nome";
            NomeFornecedor.TextAlign = HorizontalAlignment.Center;
            NomeFornecedor.Width = 265;
            // 
            // CpfouCnpjFornecedor
            // 
            CpfouCnpjFornecedor.Text = "CPF / CNPJ";
            CpfouCnpjFornecedor.TextAlign = HorizontalAlignment.Center;
            CpfouCnpjFornecedor.Width = 215;
            // 
            // TelefoneFornecedor
            // 
            TelefoneFornecedor.Text = "Telefone";
            TelefoneFornecedor.TextAlign = HorizontalAlignment.Center;
            TelefoneFornecedor.Width = 225;
            // 
            // labelFornecedores
            // 
            labelFornecedores.AutoSize = true;
            labelFornecedores.BackColor = Color.Transparent;
            labelFornecedores.Font = new Font("Segoe UI", 20F);
            labelFornecedores.Location = new Point(303, 0);
            labelFornecedores.Name = "labelFornecedores";
            labelFornecedores.Size = new Size(176, 37);
            labelFornecedores.TabIndex = 1;
            labelFornecedores.Text = "Fornecedores";
            // 
            // buttonVoltar
            // 
            buttonVoltar.Font = new Font("Segoe UI", 10F);
            buttonVoltar.Location = new Point(67, 409);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(112, 42);
            buttonVoltar.TabIndex = 5;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // TelaFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.papel_de_parede_abstrato_verde_cana_vinil_3_papel_de_parede_abstrato_escuro2;
            ClientSize = new Size(822, 485);
            Controls.Add(buttonVoltar);
            Controls.Add(labelFornecedores);
            Controls.Add(panelFornecedores);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaFornecedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fazenda Urbana";
            panelFornecedores.ResumeLayout(false);
            panelFornecedores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFornecedores;
        private ListView listViewFornecedor;
        private Label labelFornecedores;
        private Label labelTelefoneFornecedores;
        private Label labelCpfouCnpjFornecedores;
        private Label labelNomeFornecedores;
        private TextBox textBoxTelefoneFornecedor;
        private TextBox textBoxCpfouCnpjFornecedor;
        private TextBox textBoxNomeFornecedor;
        private ColumnHeader IdFornecedor;
        private ColumnHeader NomeFornecedor;
        private ColumnHeader CpfouCnpjFornecedor;
        private ColumnHeader TelefoneFornecedor;
        private Button buttonCadastrarFornecedor;
        private Button buttonEditarFornecedor;
        private Button button3;
        private Button buttonVoltar;
        private TextBox textBoxIdFornecedor;
        private Label labelIdFornecedor;
    }
}