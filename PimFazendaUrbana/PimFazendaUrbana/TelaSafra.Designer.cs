namespace PimFazendaUrbana
{
    partial class TelaSafra
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
            panel1 = new Panel();
            buttonRemoverSafra = new Button();
            textBoxIdSafra = new TextBox();
            labelIdSafra = new Label();
            textBoxQtdColhida = new TextBox();
            labelQtdColheita = new Label();
            buttonCadastrarPlantio = new Button();
            listViewSafra = new ListView();
            IdPlantio = new ColumnHeader();
            Produto = new ColumnHeader();
            DtPlantio = new ColumnHeader();
            QtdPlantio = new ColumnHeader();
            DtColheita = new ColumnHeader();
            QtdColhida = new ColumnHeader();
            labelDtColheita = new Label();
            buttonEditarPlantio = new Button();
            textBoxDtColheita = new TextBox();
            textBoxDtPlantio = new TextBox();
            textBoxProdutoSafra = new TextBox();
            labelDtPlantio = new Label();
            labelProduto = new Label();
            textBoxQtdPlantio = new TextBox();
            labelQtdPlantio = new Label();
            buttonVoltar = new Button();
            labelSafra = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fundo_login;
            panel1.Controls.Add(buttonRemoverSafra);
            panel1.Controls.Add(textBoxIdSafra);
            panel1.Controls.Add(labelIdSafra);
            panel1.Controls.Add(textBoxQtdColhida);
            panel1.Controls.Add(labelQtdColheita);
            panel1.Controls.Add(buttonCadastrarPlantio);
            panel1.Controls.Add(listViewSafra);
            panel1.Controls.Add(labelDtColheita);
            panel1.Controls.Add(buttonEditarPlantio);
            panel1.Controls.Add(textBoxDtColheita);
            panel1.Controls.Add(textBoxDtPlantio);
            panel1.Controls.Add(textBoxProdutoSafra);
            panel1.Controls.Add(labelDtPlantio);
            panel1.Controls.Add(labelProduto);
            panel1.Controls.Add(textBoxQtdPlantio);
            panel1.Controls.Add(labelQtdPlantio);
            panel1.Location = new Point(29, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 397);
            panel1.TabIndex = 0;
            // 
            // buttonRemoverSafra
            // 
            buttonRemoverSafra.Font = new Font("Segoe UI", 10F);
            buttonRemoverSafra.Location = new Point(631, 323);
            buttonRemoverSafra.Name = "buttonRemoverSafra";
            buttonRemoverSafra.Size = new Size(132, 46);
            buttonRemoverSafra.TabIndex = 14;
            buttonRemoverSafra.Text = "Remover";
            buttonRemoverSafra.UseVisualStyleBackColor = true;
            buttonRemoverSafra.Click += buttonRemoverSafra_Click;
            // 
            // textBoxIdSafra
            // 
            textBoxIdSafra.Location = new Point(26, 281);
            textBoxIdSafra.Name = "textBoxIdSafra";
            textBoxIdSafra.Size = new Size(38, 23);
            textBoxIdSafra.TabIndex = 13;
            // 
            // labelIdSafra
            // 
            labelIdSafra.AutoSize = true;
            labelIdSafra.BackColor = Color.Transparent;
            labelIdSafra.Font = new Font("Segoe UI", 10F);
            labelIdSafra.Location = new Point(26, 263);
            labelIdSafra.Name = "labelIdSafra";
            labelIdSafra.Size = new Size(26, 19);
            labelIdSafra.TabIndex = 12;
            labelIdSafra.Text = "ID:";
            // 
            // textBoxQtdColhida
            // 
            textBoxQtdColhida.Font = new Font("Segoe UI", 9F);
            textBoxQtdColhida.Location = new Point(169, 337);
            textBoxQtdColhida.Name = "textBoxQtdColhida";
            textBoxQtdColhida.Size = new Size(141, 23);
            textBoxQtdColhida.TabIndex = 9;
            // 
            // labelQtdColheita
            // 
            labelQtdColheita.AutoSize = true;
            labelQtdColheita.BackColor = Color.Transparent;
            labelQtdColheita.Font = new Font("Segoe UI", 10F);
            labelQtdColheita.Location = new Point(169, 317);
            labelQtdColheita.Name = "labelQtdColheita";
            labelQtdColheita.Size = new Size(134, 19);
            labelQtdColheita.TabIndex = 4;
            labelQtdColheita.Text = "Quantidade Colhida:";
            // 
            // buttonCadastrarPlantio
            // 
            buttonCadastrarPlantio.Font = new Font("Segoe UI", 10F);
            buttonCadastrarPlantio.Location = new Point(328, 323);
            buttonCadastrarPlantio.Name = "buttonCadastrarPlantio";
            buttonCadastrarPlantio.Size = new Size(132, 46);
            buttonCadastrarPlantio.TabIndex = 11;
            buttonCadastrarPlantio.Text = "Cadastrar Plantio";
            buttonCadastrarPlantio.UseVisualStyleBackColor = true;
            buttonCadastrarPlantio.Click += buttonCadastrarPlantio_Click;
            // 
            // listViewSafra
            // 
            listViewSafra.Columns.AddRange(new ColumnHeader[] { IdPlantio, Produto, DtPlantio, QtdPlantio, DtColheita, QtdColhida });
            listViewSafra.Location = new Point(0, 0);
            listViewSafra.MultiSelect = false;
            listViewSafra.Name = "listViewSafra";
            listViewSafra.Size = new Size(787, 248);
            listViewSafra.TabIndex = 10;
            listViewSafra.UseCompatibleStateImageBehavior = false;
            listViewSafra.View = View.Details;
            listViewSafra.Click += listViewSafra_Click;
            // 
            // IdPlantio
            // 
            IdPlantio.Text = "ID";
            IdPlantio.Width = 45;
            // 
            // Produto
            // 
            Produto.Text = "Produto";
            Produto.Width = 195;
            // 
            // DtPlantio
            // 
            DtPlantio.Text = "Data plantio";
            DtPlantio.TextAlign = HorizontalAlignment.Center;
            DtPlantio.Width = 135;
            // 
            // QtdPlantio
            // 
            QtdPlantio.Text = "Qtd Plantio (Kg)";
            QtdPlantio.TextAlign = HorizontalAlignment.Center;
            QtdPlantio.Width = 135;
            // 
            // DtColheita
            // 
            DtColheita.Text = "Data Colheita";
            DtColheita.TextAlign = HorizontalAlignment.Center;
            DtColheita.Width = 135;
            // 
            // QtdColhida
            // 
            QtdColhida.Text = "Qtd colhida (Kg)";
            QtdColhida.TextAlign = HorizontalAlignment.Center;
            QtdColhida.Width = 135;
            // 
            // labelDtColheita
            // 
            labelDtColheita.AutoSize = true;
            labelDtColheita.BackColor = Color.Transparent;
            labelDtColheita.Font = new Font("Segoe UI", 10F);
            labelDtColheita.Location = new Point(26, 317);
            labelDtColheita.Name = "labelDtColheita";
            labelDtColheita.Size = new Size(114, 19);
            labelDtColheita.TabIndex = 3;
            labelDtColheita.Text = "Data de Colheita:";
            // 
            // buttonEditarPlantio
            // 
            buttonEditarPlantio.Font = new Font("Segoe UI", 10F);
            buttonEditarPlantio.Location = new Point(484, 323);
            buttonEditarPlantio.Name = "buttonEditarPlantio";
            buttonEditarPlantio.Size = new Size(132, 46);
            buttonEditarPlantio.TabIndex = 2;
            buttonEditarPlantio.Text = "Editar / Cadastrar Colheita";
            buttonEditarPlantio.UseVisualStyleBackColor = true;
            buttonEditarPlantio.Click += buttonEditarPlantio_Click;
            // 
            // textBoxDtColheita
            // 
            textBoxDtColheita.Font = new Font("Segoe UI", 9F);
            textBoxDtColheita.Location = new Point(26, 337);
            textBoxDtColheita.Name = "textBoxDtColheita";
            textBoxDtColheita.Size = new Size(118, 23);
            textBoxDtColheita.TabIndex = 8;
            // 
            // textBoxDtPlantio
            // 
            textBoxDtPlantio.Font = new Font("Segoe UI", 9F);
            textBoxDtPlantio.Location = new Point(312, 281);
            textBoxDtPlantio.Name = "textBoxDtPlantio";
            textBoxDtPlantio.Size = new Size(118, 23);
            textBoxDtPlantio.TabIndex = 6;
            // 
            // textBoxProdutoSafra
            // 
            textBoxProdutoSafra.Font = new Font("Segoe UI", 9F);
            textBoxProdutoSafra.Location = new Point(84, 281);
            textBoxProdutoSafra.Name = "textBoxProdutoSafra";
            textBoxProdutoSafra.Size = new Size(206, 23);
            textBoxProdutoSafra.TabIndex = 5;
            // 
            // labelDtPlantio
            // 
            labelDtPlantio.AutoSize = true;
            labelDtPlantio.BackColor = Color.Transparent;
            labelDtPlantio.Font = new Font("Segoe UI", 10F);
            labelDtPlantio.Location = new Point(312, 263);
            labelDtPlantio.Name = "labelDtPlantio";
            labelDtPlantio.Size = new Size(106, 19);
            labelDtPlantio.TabIndex = 1;
            labelDtPlantio.Text = "Data de Plantio:";
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.BackColor = Color.Transparent;
            labelProduto.Font = new Font("Segoe UI", 10F);
            labelProduto.Location = new Point(84, 263);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(62, 19);
            labelProduto.TabIndex = 0;
            labelProduto.Text = "Produto:";
            // 
            // textBoxQtdPlantio
            // 
            textBoxQtdPlantio.Font = new Font("Segoe UI", 9F);
            textBoxQtdPlantio.Location = new Point(452, 281);
            textBoxQtdPlantio.Name = "textBoxQtdPlantio";
            textBoxQtdPlantio.Size = new Size(141, 23);
            textBoxQtdPlantio.TabIndex = 7;
            textBoxQtdPlantio.TextChanged += textBox3_TextChanged;
            // 
            // labelQtdPlantio
            // 
            labelQtdPlantio.AutoSize = true;
            labelQtdPlantio.BackColor = Color.Transparent;
            labelQtdPlantio.Font = new Font("Segoe UI", 10F);
            labelQtdPlantio.Location = new Point(452, 263);
            labelQtdPlantio.Name = "labelQtdPlantio";
            labelQtdPlantio.Size = new Size(141, 19);
            labelQtdPlantio.TabIndex = 2;
            labelQtdPlantio.Text = "Quantidade Plantada:";
            // 
            // buttonVoltar
            // 
            buttonVoltar.Font = new Font("Segoe UI", 10F);
            buttonVoltar.Location = new Point(55, 456);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(132, 44);
            buttonVoltar.TabIndex = 1;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // labelSafra
            // 
            labelSafra.AutoSize = true;
            labelSafra.BackColor = Color.Transparent;
            labelSafra.Font = new Font("Segoe UI", 20F);
            labelSafra.Location = new Point(371, 2);
            labelSafra.Name = "labelSafra";
            labelSafra.Size = new Size(76, 37);
            labelSafra.TabIndex = 2;
            labelSafra.Text = "Safra";
            // 
            // TelaSafra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.papel_de_parede_abstrato_verde_cana_vinil_3_papel_de_parede_abstrato_escuro2;
            ClientSize = new Size(844, 531);
            Controls.Add(labelSafra);
            Controls.Add(buttonVoltar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaSafra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fazenda Urbana";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelProduto;
        private Label labelQtdColheita;
        private Label labelDtColheita;
        private Label labelQtdPlantio;
        private Label labelDtPlantio;
        private TextBox textBoxQtdColhida;
        private TextBox textBoxDtColheita;
        private TextBox textBoxQtdPlantio;
        private TextBox textBoxDtPlantio;
        private TextBox textBoxProdutoSafra;
        private ListView listViewSafra;
        private ColumnHeader Produto;
        private ColumnHeader DtPlantio;
        private ColumnHeader QtdPlantio;
        private ColumnHeader DtColheita;
        private ColumnHeader QtdColhida;
        private Button buttonCadastrarPlantio;
        private Button buttonVoltar;
        private Button buttonEditarPlantio;
        private ColumnHeader IdPlantio;
        private TextBox textBoxIdSafra;
        private Label labelIdSafra;
        private Button buttonRemoverSafra;
        private Label labelSafra;
    }
}