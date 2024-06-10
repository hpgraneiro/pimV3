namespace PimFazendaUrbana
{
    partial class TelaFuncionarios
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
            listViewFuncionario = new ListView();
            IdFuncionario = new ColumnHeader();
            NomeFuncionario = new ColumnHeader();
            CpfFuncionario = new ColumnHeader();
            FuncaoFuncionario = new ColumnHeader();
            SalarioFuncionario = new ColumnHeader();
            buttonRemoverFuncionario = new Button();
            buttonEditarFuncionario = new Button();
            buttonCadastrarFuncionario = new Button();
            textBoxSalarioFuncionario = new TextBox();
            textBoxFuncao = new TextBox();
            textBoxCpfFuncionario = new TextBox();
            textBoxNomeFuncionario = new TextBox();
            textBoxIdFuncionario = new TextBox();
            labelSalarioFuncionario = new Label();
            labelFuncaoFuncionario = new Label();
            labelCpfFuncionario = new Label();
            labelNomeFuncionario = new Label();
            labelIdFuncionario = new Label();
            label1 = new Label();
            buttonVoltar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fundo_login;
            panel1.Controls.Add(listViewFuncionario);
            panel1.Controls.Add(buttonRemoverFuncionario);
            panel1.Controls.Add(buttonEditarFuncionario);
            panel1.Controls.Add(buttonCadastrarFuncionario);
            panel1.Controls.Add(textBoxSalarioFuncionario);
            panel1.Controls.Add(textBoxFuncao);
            panel1.Controls.Add(textBoxCpfFuncionario);
            panel1.Controls.Add(textBoxNomeFuncionario);
            panel1.Controls.Add(textBoxIdFuncionario);
            panel1.Controls.Add(labelSalarioFuncionario);
            panel1.Controls.Add(labelFuncaoFuncionario);
            panel1.Controls.Add(labelCpfFuncionario);
            panel1.Controls.Add(labelNomeFuncionario);
            panel1.Controls.Add(labelIdFuncionario);
            panel1.Location = new Point(28, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 371);
            panel1.TabIndex = 0;
            // 
            // listViewFuncionario
            // 
            listViewFuncionario.Columns.AddRange(new ColumnHeader[] { IdFuncionario, NomeFuncionario, CpfFuncionario, FuncaoFuncionario, SalarioFuncionario });
            listViewFuncionario.Location = new Point(0, 0);
            listViewFuncionario.MultiSelect = false;
            listViewFuncionario.Name = "listViewFuncionario";
            listViewFuncionario.Size = new Size(795, 251);
            listViewFuncionario.TabIndex = 14;
            listViewFuncionario.UseCompatibleStateImageBehavior = false;
            listViewFuncionario.View = View.Details;
            listViewFuncionario.Click += listViewFuncionario_Click;
            // 
            // IdFuncionario
            // 
            IdFuncionario.Text = "ID";
            IdFuncionario.Width = 50;
            // 
            // NomeFuncionario
            // 
            NomeFuncionario.Text = "Nome";
            NomeFuncionario.TextAlign = HorizontalAlignment.Center;
            NomeFuncionario.Width = 270;
            // 
            // CpfFuncionario
            // 
            CpfFuncionario.Text = "CPF";
            CpfFuncionario.TextAlign = HorizontalAlignment.Center;
            CpfFuncionario.Width = 165;
            // 
            // FuncaoFuncionario
            // 
            FuncaoFuncionario.Text = "Função";
            FuncaoFuncionario.TextAlign = HorizontalAlignment.Center;
            FuncaoFuncionario.Width = 160;
            // 
            // SalarioFuncionario
            // 
            SalarioFuncionario.Text = "Salário";
            SalarioFuncionario.TextAlign = HorizontalAlignment.Center;
            SalarioFuncionario.Width = 140;
            // 
            // buttonRemoverFuncionario
            // 
            buttonRemoverFuncionario.Font = new Font("Segoe UI", 10F);
            buttonRemoverFuncionario.Location = new Point(434, 313);
            buttonRemoverFuncionario.Name = "buttonRemoverFuncionario";
            buttonRemoverFuncionario.Size = new Size(153, 37);
            buttonRemoverFuncionario.TabIndex = 13;
            buttonRemoverFuncionario.Text = "Remover Funcionário";
            buttonRemoverFuncionario.UseVisualStyleBackColor = true;
            buttonRemoverFuncionario.Click += buttonRemoverFuncionario_Click;
            // 
            // buttonEditarFuncionario
            // 
            buttonEditarFuncionario.Font = new Font("Segoe UI", 10F);
            buttonEditarFuncionario.Location = new Point(232, 313);
            buttonEditarFuncionario.Name = "buttonEditarFuncionario";
            buttonEditarFuncionario.Size = new Size(153, 37);
            buttonEditarFuncionario.TabIndex = 12;
            buttonEditarFuncionario.Text = "Editar Funcionário";
            buttonEditarFuncionario.UseVisualStyleBackColor = true;
            buttonEditarFuncionario.Click += buttonEditarFuncionario_Click;
            // 
            // buttonCadastrarFuncionario
            // 
            buttonCadastrarFuncionario.Font = new Font("Segoe UI", 10F);
            buttonCadastrarFuncionario.Location = new Point(27, 313);
            buttonCadastrarFuncionario.Name = "buttonCadastrarFuncionario";
            buttonCadastrarFuncionario.Size = new Size(153, 37);
            buttonCadastrarFuncionario.TabIndex = 11;
            buttonCadastrarFuncionario.Text = "Cadastrar Funcionário";
            buttonCadastrarFuncionario.UseVisualStyleBackColor = true;
            buttonCadastrarFuncionario.Click += buttonCadastrarFuncionario_Click;
            // 
            // textBoxSalarioFuncionario
            // 
            textBoxSalarioFuncionario.Location = new Point(650, 276);
            textBoxSalarioFuncionario.Name = "textBoxSalarioFuncionario";
            textBoxSalarioFuncionario.Size = new Size(117, 23);
            textBoxSalarioFuncionario.TabIndex = 10;
            // 
            // textBoxFuncao
            // 
            textBoxFuncao.Location = new Point(481, 276);
            textBoxFuncao.Name = "textBoxFuncao";
            textBoxFuncao.Size = new Size(137, 23);
            textBoxFuncao.TabIndex = 9;
            // 
            // textBoxCpfFuncionario
            // 
            textBoxCpfFuncionario.Location = new Point(307, 276);
            textBoxCpfFuncionario.Name = "textBoxCpfFuncionario";
            textBoxCpfFuncionario.Size = new Size(143, 23);
            textBoxCpfFuncionario.TabIndex = 8;
            // 
            // textBoxNomeFuncionario
            // 
            textBoxNomeFuncionario.Location = new Point(114, 276);
            textBoxNomeFuncionario.Name = "textBoxNomeFuncionario";
            textBoxNomeFuncionario.Size = new Size(155, 23);
            textBoxNomeFuncionario.TabIndex = 7;
            // 
            // textBoxIdFuncionario
            // 
            textBoxIdFuncionario.Location = new Point(27, 276);
            textBoxIdFuncionario.Name = "textBoxIdFuncionario";
            textBoxIdFuncionario.Size = new Size(53, 23);
            textBoxIdFuncionario.TabIndex = 6;
            // 
            // labelSalarioFuncionario
            // 
            labelSalarioFuncionario.AutoSize = true;
            labelSalarioFuncionario.BackColor = Color.Transparent;
            labelSalarioFuncionario.Font = new Font("Segoe UI", 10F);
            labelSalarioFuncionario.Location = new Point(650, 254);
            labelSalarioFuncionario.Name = "labelSalarioFuncionario";
            labelSalarioFuncionario.Size = new Size(52, 19);
            labelSalarioFuncionario.TabIndex = 5;
            labelSalarioFuncionario.Text = "Salário:";
            // 
            // labelFuncaoFuncionario
            // 
            labelFuncaoFuncionario.AutoSize = true;
            labelFuncaoFuncionario.BackColor = Color.Transparent;
            labelFuncaoFuncionario.Font = new Font("Segoe UI", 10F);
            labelFuncaoFuncionario.Location = new Point(481, 254);
            labelFuncaoFuncionario.Name = "labelFuncaoFuncionario";
            labelFuncaoFuncionario.Size = new Size(56, 19);
            labelFuncaoFuncionario.TabIndex = 4;
            labelFuncaoFuncionario.Text = "Função:";
            // 
            // labelCpfFuncionario
            // 
            labelCpfFuncionario.AutoSize = true;
            labelCpfFuncionario.BackColor = Color.Transparent;
            labelCpfFuncionario.Font = new Font("Segoe UI", 10F);
            labelCpfFuncionario.Location = new Point(307, 254);
            labelCpfFuncionario.Name = "labelCpfFuncionario";
            labelCpfFuncionario.Size = new Size(36, 19);
            labelCpfFuncionario.TabIndex = 3;
            labelCpfFuncionario.Text = "CPF:";
            // 
            // labelNomeFuncionario
            // 
            labelNomeFuncionario.AutoSize = true;
            labelNomeFuncionario.BackColor = Color.Transparent;
            labelNomeFuncionario.Font = new Font("Segoe UI", 10F);
            labelNomeFuncionario.Location = new Point(114, 254);
            labelNomeFuncionario.Name = "labelNomeFuncionario";
            labelNomeFuncionario.Size = new Size(49, 19);
            labelNomeFuncionario.TabIndex = 2;
            labelNomeFuncionario.Text = "Nome:";
            // 
            // labelIdFuncionario
            // 
            labelIdFuncionario.AutoSize = true;
            labelIdFuncionario.BackColor = Color.Transparent;
            labelIdFuncionario.Font = new Font("Segoe UI", 10F);
            labelIdFuncionario.Location = new Point(27, 254);
            labelIdFuncionario.Name = "labelIdFuncionario";
            labelIdFuncionario.Size = new Size(26, 19);
            labelIdFuncionario.TabIndex = 1;
            labelIdFuncionario.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(327, 1);
            label1.Name = "label1";
            label1.Size = new Size(167, 37);
            label1.TabIndex = 1;
            label1.Text = "Funcionários";
            // 
            // buttonVoltar
            // 
            buttonVoltar.Font = new Font("Segoe UI", 10F);
            buttonVoltar.Location = new Point(55, 429);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(123, 41);
            buttonVoltar.TabIndex = 2;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // TelaFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.papel_de_parede_abstrato_verde_cana_vinil_3_papel_de_parede_abstrato_escuro2;
            ClientSize = new Size(850, 491);
            Controls.Add(buttonVoltar);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fazenda Urbana";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelFuncaoFuncionario;
        private Label labelCpfFuncionario;
        private Label labelNomeFuncionario;
        private Label labelIdFuncionario;
        private TextBox textBoxSalarioFuncionario;
        private TextBox textBoxFuncao;
        private TextBox textBoxCpfFuncionario;
        private TextBox textBoxNomeFuncionario;
        private TextBox textBoxIdFuncionario;
        private Label labelSalarioFuncionario;
        private Button buttonRemoverFuncionario;
        private Button buttonEditarFuncionario;
        private Button buttonCadastrarFuncionario;
        private Button buttonVoltar;
        private ListView listViewFuncionario;
        private ColumnHeader IdFuncionario;
        private ColumnHeader NomeFuncionario;
        private ColumnHeader CpfFuncionario;
        private ColumnHeader FuncaoFuncionario;
        private ColumnHeader SalarioFuncionario;
    }
}