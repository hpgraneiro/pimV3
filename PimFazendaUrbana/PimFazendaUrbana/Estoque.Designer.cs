namespace PimFazendaUrbana
{
    partial class Estoque
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
            LabelEstoque = new Label();
            ButtonCadastrarItem = new Button();
            ButtonEditarItem = new Button();
            ButtonVoltarEstoque = new Button();
            panel1 = new Panel();
            buttonRemoverEstoque = new Button();
            textBoxIDEstoque = new TextBox();
            labelIDEstoque = new Label();
            TextBoxDescricaoItem = new TextBox();
            ListViewProdutos = new ListView();
            IdItem = new ColumnHeader();
            NomeItem = new ColumnHeader();
            QtdItem = new ColumnHeader();
            ValorItem = new ColumnHeader();
            DecricaoItem = new ColumnHeader();
            LabelNomeItem = new Label();
            TextBoxNomeItem = new TextBox();
            LabelDescricaoItem = new Label();
            LabelQuantidadeItem = new Label();
            TextBoxValorItem = new TextBox();
            TextBoxQuantidade = new TextBox();
            LabelValorItem = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelEstoque
            // 
            LabelEstoque.AutoSize = true;
            LabelEstoque.BackColor = Color.Transparent;
            LabelEstoque.Font = new Font("Segoe UI", 20F);
            LabelEstoque.Location = new Point(348, 2);
            LabelEstoque.Name = "LabelEstoque";
            LabelEstoque.Size = new Size(112, 37);
            LabelEstoque.TabIndex = 0;
            LabelEstoque.Text = "Estoque";
            // 
            // ButtonCadastrarItem
            // 
            ButtonCadastrarItem.Font = new Font("Segoe UI", 10F);
            ButtonCadastrarItem.Location = new Point(25, 318);
            ButtonCadastrarItem.Name = "ButtonCadastrarItem";
            ButtonCadastrarItem.Size = new Size(110, 38);
            ButtonCadastrarItem.TabIndex = 1;
            ButtonCadastrarItem.Text = "Cadastrar item";
            ButtonCadastrarItem.UseVisualStyleBackColor = true;
            ButtonCadastrarItem.Click += ButtonCadastrarItem_Click;
            // 
            // ButtonEditarItem
            // 
            ButtonEditarItem.Font = new Font("Segoe UI", 10F);
            ButtonEditarItem.Location = new Point(167, 318);
            ButtonEditarItem.Name = "ButtonEditarItem";
            ButtonEditarItem.Size = new Size(110, 38);
            ButtonEditarItem.TabIndex = 2;
            ButtonEditarItem.Text = "Editar item";
            ButtonEditarItem.UseVisualStyleBackColor = true;
            ButtonEditarItem.Click += ButtonEditarItem_Click;
            // 
            // ButtonVoltarEstoque
            // 
            ButtonVoltarEstoque.Font = new Font("Segoe UI", 11F);
            ButtonVoltarEstoque.Location = new Point(54, 437);
            ButtonVoltarEstoque.Name = "ButtonVoltarEstoque";
            ButtonVoltarEstoque.Size = new Size(110, 44);
            ButtonVoltarEstoque.TabIndex = 3;
            ButtonVoltarEstoque.Text = "Voltar";
            ButtonVoltarEstoque.UseVisualStyleBackColor = true;
            ButtonVoltarEstoque.Click += Buttonvoltarestoque_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fundo_login;
            panel1.Controls.Add(buttonRemoverEstoque);
            panel1.Controls.Add(ButtonCadastrarItem);
            panel1.Controls.Add(textBoxIDEstoque);
            panel1.Controls.Add(ButtonEditarItem);
            panel1.Controls.Add(labelIDEstoque);
            panel1.Controls.Add(TextBoxDescricaoItem);
            panel1.Controls.Add(ListViewProdutos);
            panel1.Controls.Add(LabelNomeItem);
            panel1.Controls.Add(TextBoxNomeItem);
            panel1.Controls.Add(LabelDescricaoItem);
            panel1.Controls.Add(LabelQuantidadeItem);
            panel1.Controls.Add(TextBoxValorItem);
            panel1.Controls.Add(TextBoxQuantidade);
            panel1.Controls.Add(LabelValorItem);
            panel1.Location = new Point(29, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 371);
            panel1.TabIndex = 4;
            // 
            // buttonRemoverEstoque
            // 
            buttonRemoverEstoque.Font = new Font("Segoe UI", 10F);
            buttonRemoverEstoque.Location = new Point(306, 318);
            buttonRemoverEstoque.Name = "buttonRemoverEstoque";
            buttonRemoverEstoque.Size = new Size(110, 38);
            buttonRemoverEstoque.TabIndex = 11;
            buttonRemoverEstoque.Text = "Remover Item";
            buttonRemoverEstoque.UseVisualStyleBackColor = true;
            buttonRemoverEstoque.Click += buttonRemoverEstoque_Click;
            // 
            // textBoxIDEstoque
            // 
            textBoxIDEstoque.Location = new Point(25, 278);
            textBoxIDEstoque.Name = "textBoxIDEstoque";
            textBoxIDEstoque.Size = new Size(38, 23);
            textBoxIDEstoque.TabIndex = 10;
            // 
            // labelIDEstoque
            // 
            labelIDEstoque.AutoSize = true;
            labelIDEstoque.BackColor = Color.Transparent;
            labelIDEstoque.Font = new Font("Segoe UI", 10F);
            labelIDEstoque.Location = new Point(25, 256);
            labelIDEstoque.Name = "labelIDEstoque";
            labelIDEstoque.Size = new Size(26, 19);
            labelIDEstoque.TabIndex = 9;
            labelIDEstoque.Text = "ID:";
            // 
            // TextBoxDescricaoItem
            // 
            TextBoxDescricaoItem.Font = new Font("Segoe UI", 9F);
            TextBoxDescricaoItem.Location = new Point(506, 278);
            TextBoxDescricaoItem.Name = "TextBoxDescricaoItem";
            TextBoxDescricaoItem.Size = new Size(265, 23);
            TextBoxDescricaoItem.TabIndex = 8;
            // 
            // ListViewProdutos
            // 
            ListViewProdutos.Columns.AddRange(new ColumnHeader[] { IdItem, NomeItem, QtdItem, ValorItem, DecricaoItem });
            ListViewProdutos.Location = new Point(3, 0);
            ListViewProdutos.MultiSelect = false;
            ListViewProdutos.Name = "ListViewProdutos";
            ListViewProdutos.Size = new Size(789, 240);
            ListViewProdutos.TabIndex = 6;
            ListViewProdutos.UseCompatibleStateImageBehavior = false;
            ListViewProdutos.View = View.Details;
            ListViewProdutos.Click += ListViewProdutos_Click;
            // 
            // IdItem
            // 
            IdItem.Text = "ID";
            IdItem.Width = 50;
            // 
            // NomeItem
            // 
            NomeItem.Text = "Nome";
            NomeItem.TextAlign = HorizontalAlignment.Center;
            NomeItem.Width = 260;
            // 
            // QtdItem
            // 
            QtdItem.Text = "Qtd (Kg)";
            QtdItem.TextAlign = HorizontalAlignment.Center;
            QtdItem.Width = 90;
            // 
            // ValorItem
            // 
            ValorItem.Text = "Valor (R$)";
            ValorItem.TextAlign = HorizontalAlignment.Center;
            ValorItem.Width = 120;
            // 
            // DecricaoItem
            // 
            DecricaoItem.Text = "Descrição";
            DecricaoItem.TextAlign = HorizontalAlignment.Center;
            DecricaoItem.Width = 260;
            // 
            // LabelNomeItem
            // 
            LabelNomeItem.AutoSize = true;
            LabelNomeItem.BackColor = Color.Transparent;
            LabelNomeItem.Font = new Font("Segoe UI", 10F);
            LabelNomeItem.Location = new Point(86, 256);
            LabelNomeItem.Name = "LabelNomeItem";
            LabelNomeItem.Size = new Size(49, 19);
            LabelNomeItem.TabIndex = 0;
            LabelNomeItem.Text = "Nome:";
            // 
            // TextBoxNomeItem
            // 
            TextBoxNomeItem.Font = new Font("Segoe UI", 9F);
            TextBoxNomeItem.Location = new Point(86, 278);
            TextBoxNomeItem.Name = "TextBoxNomeItem";
            TextBoxNomeItem.Size = new Size(147, 23);
            TextBoxNomeItem.TabIndex = 3;
            // 
            // LabelDescricaoItem
            // 
            LabelDescricaoItem.AutoSize = true;
            LabelDescricaoItem.BackColor = Color.Transparent;
            LabelDescricaoItem.Font = new Font("Segoe UI", 10F);
            LabelDescricaoItem.Location = new Point(506, 256);
            LabelDescricaoItem.Name = "LabelDescricaoItem";
            LabelDescricaoItem.Size = new Size(70, 19);
            LabelDescricaoItem.TabIndex = 7;
            LabelDescricaoItem.Text = "Descrição:";
            // 
            // LabelQuantidadeItem
            // 
            LabelQuantidadeItem.AutoSize = true;
            LabelQuantidadeItem.BackColor = Color.Transparent;
            LabelQuantidadeItem.Font = new Font("Segoe UI", 10F);
            LabelQuantidadeItem.Location = new Point(257, 256);
            LabelQuantidadeItem.Name = "LabelQuantidadeItem";
            LabelQuantidadeItem.Size = new Size(84, 19);
            LabelQuantidadeItem.TabIndex = 1;
            LabelQuantidadeItem.Text = "Quantidade:";
            // 
            // TextBoxValorItem
            // 
            TextBoxValorItem.Font = new Font("Segoe UI", 9F);
            TextBoxValorItem.Location = new Point(382, 278);
            TextBoxValorItem.Name = "TextBoxValorItem";
            TextBoxValorItem.Size = new Size(100, 23);
            TextBoxValorItem.TabIndex = 5;
            // 
            // TextBoxQuantidade
            // 
            TextBoxQuantidade.Font = new Font("Segoe UI", 9F);
            TextBoxQuantidade.Location = new Point(257, 278);
            TextBoxQuantidade.Name = "TextBoxQuantidade";
            TextBoxQuantidade.Size = new Size(100, 23);
            TextBoxQuantidade.TabIndex = 4;
            // 
            // LabelValorItem
            // 
            LabelValorItem.AutoSize = true;
            LabelValorItem.BackColor = Color.Transparent;
            LabelValorItem.Font = new Font("Segoe UI", 10F);
            LabelValorItem.Location = new Point(382, 256);
            LabelValorItem.Name = "LabelValorItem";
            LabelValorItem.Size = new Size(43, 19);
            LabelValorItem.TabIndex = 2;
            LabelValorItem.Text = "Valor:";
            LabelValorItem.Click += LabelValorItem_Click;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.papel_de_parede_abstrato_verde_cana_vinil_3_papel_de_parede_abstrato_escuro2;
            ClientSize = new Size(851, 493);
            Controls.Add(panel1);
            Controls.Add(ButtonVoltarEstoque);
            Controls.Add(LabelEstoque);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Estoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fazenda Urbana";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelEstoque;
        private Button ButtonCadastrarItem;
        private Button ButtonEditarItem;
        private Button ButtonVoltarEstoque;
        private Panel panel1;
        private Label LabelValorItem;
        private Label LabelQuantidadeItem;
        private Label LabelNomeItem;
        private TextBox TextBoxValorItem;
        private TextBox TextBoxQuantidade;
        private TextBox TextBoxNomeItem;
        private ListView ListViewProdutos;
        private ColumnHeader NomeItem;
        private ColumnHeader QtdItem;
        private ColumnHeader ValorItem;
        private TextBox TextBoxDescricaoItem;
        private Label LabelDescricaoItem;
        private ColumnHeader DecricaoItem;
        private ColumnHeader IdItem;
        private TextBox textBoxIDEstoque;
        private Label labelIDEstoque;
        private Button buttonRemoverEstoque;
    }
}