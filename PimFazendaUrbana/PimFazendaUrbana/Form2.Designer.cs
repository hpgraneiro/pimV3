namespace PimFazendaUrbana
{
    partial class TelaInicialUsuario
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
            ButtonVisualizarEstoque = new Button();
            ButtonDesconectar = new Button();
            SuspendLayout();
            // 
            // ButtonVisualizarEstoque
            // 
            ButtonVisualizarEstoque.BackgroundImage = Properties.Resources.fundo_login;
            ButtonVisualizarEstoque.Font = new Font("Segoe UI", 11F);
            ButtonVisualizarEstoque.Location = new Point(342, 137);
            ButtonVisualizarEstoque.Name = "ButtonVisualizarEstoque";
            ButtonVisualizarEstoque.Size = new Size(152, 48);
            ButtonVisualizarEstoque.TabIndex = 0;
            ButtonVisualizarEstoque.Text = "Visualizar Estoque";
            ButtonVisualizarEstoque.UseVisualStyleBackColor = true;
            ButtonVisualizarEstoque.Click += ButtonVisualizarEstoque_Click;
            // 
            // ButtonDesconectar
            // 
            ButtonDesconectar.BackgroundImage = Properties.Resources.fundo_login;
            ButtonDesconectar.Font = new Font("Segoe UI", 11F);
            ButtonDesconectar.Location = new Point(342, 250);
            ButtonDesconectar.Name = "ButtonDesconectar";
            ButtonDesconectar.Size = new Size(152, 48);
            ButtonDesconectar.TabIndex = 2;
            ButtonDesconectar.Text = "Desconectar";
            ButtonDesconectar.UseVisualStyleBackColor = true;
            ButtonDesconectar.Click += ButtonDesconectar_Click;
            // 
            // TelaInicialUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.papel_de_parede_abstrato_verde_cana_vinil_3_papel_de_parede_abstrato_escuro2;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonDesconectar);
            Controls.Add(ButtonVisualizarEstoque);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TelaInicialUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fazenda Urbana";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonVisualizarEstoque;
        private Button ButtonDesconectar;
    }
}