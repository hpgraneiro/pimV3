namespace PimFazendaUrbana
{
    partial class TelaInicialComercial
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
            ButtonDesconectar = new Button();
            ButtonClientes = new Button();
            ButtonVisualizarEstoque = new Button();
            SuspendLayout();
            // 
            // ButtonDesconectar
            // 
            ButtonDesconectar.BackgroundImage = Properties.Resources.fundo_login;
            ButtonDesconectar.Font = new Font("Segoe UI", 11F);
            ButtonDesconectar.Location = new Point(329, 333);
            ButtonDesconectar.Name = "ButtonDesconectar";
            ButtonDesconectar.Size = new Size(152, 48);
            ButtonDesconectar.TabIndex = 3;
            ButtonDesconectar.Text = "Desconectar";
            ButtonDesconectar.UseVisualStyleBackColor = true;
            ButtonDesconectar.Click += ButtonDesconectar_Click;
            // 
            // ButtonClientes
            // 
            ButtonClientes.BackgroundImage = Properties.Resources.fundo_login;
            ButtonClientes.Font = new Font("Segoe UI", 11F);
            ButtonClientes.Location = new Point(329, 75);
            ButtonClientes.Name = "ButtonClientes";
            ButtonClientes.Size = new Size(152, 48);
            ButtonClientes.TabIndex = 5;
            ButtonClientes.Text = "Visualizar Clientes";
            ButtonClientes.UseVisualStyleBackColor = true;
            ButtonClientes.Click += ButtonClientes_Click;
            // 
            // ButtonVisualizarEstoque
            // 
            ButtonVisualizarEstoque.BackgroundImage = Properties.Resources.fundo_login;
            ButtonVisualizarEstoque.Font = new Font("Segoe UI", 11F);
            ButtonVisualizarEstoque.Location = new Point(329, 201);
            ButtonVisualizarEstoque.Name = "ButtonVisualizarEstoque";
            ButtonVisualizarEstoque.Size = new Size(152, 48);
            ButtonVisualizarEstoque.TabIndex = 6;
            ButtonVisualizarEstoque.Text = "Visualizar Estoque";
            ButtonVisualizarEstoque.UseVisualStyleBackColor = true;
            ButtonVisualizarEstoque.Click += ButtonVisualizarEstoque_Click;
            // 
            // TelaInicialComercial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.papel_de_parede_abstrato_verde_cana_vinil_3_papel_de_parede_abstrato_escuro2;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonVisualizarEstoque);
            Controls.Add(ButtonClientes);
            Controls.Add(ButtonDesconectar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaInicialComercial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fazenda Urbana";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonDesconectar;
        private Button ButtonClientes;
        private Button ButtonVisualizarEstoque;
    }
}