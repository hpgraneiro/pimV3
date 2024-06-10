using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PimFazendaUrbana
{
    public partial class TelaLogin : Form
    {
        Thread t1;
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxLogin.Text.Equals("usuario") && textBoxSenha.Text.Equals("usuario")){
                    this.Close();
                    t1 = new Thread(AbrirTelaInicialUsuario);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                    Login.Usuario = true;
                }
                else if (TextBoxLogin.Text.Equals("comercial") && textBoxSenha.Text.Equals("comercial"))
                {
                    this.Close();
                    t1 = new Thread(AbrirTelaInicialComercial);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                    Login.Comercial = true;
                }
                else if (TextBoxLogin.Text.Equals("agricultor") && textBoxSenha.Text.Equals("agricultor"))
                {
                    this.Close();
                    t1 = new Thread(AbrirTelaInicialAgricultor);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                    Login.Agricultor = true;
                }
                else if (TextBoxLogin.Text.Equals("gerente") && textBoxSenha.Text.Equals("gerente"))
                {
                    this.Close();
                    t1 = new Thread(AbrirTelaInicialGerente);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                    Login.Gerente = true;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.",
                                    "Erro!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    TextBoxLogin.Focus();
                    textBoxSenha.Text = "";
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Usuário ou senha incorretos.",
                                ex.Message,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
           /* this.Close();
            t1 = new Thread(AbrirTelaInicialUsuario);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
           */
        }
        private void AbrirTelaInicialUsuario(object obj)
        {
            Application.Run(new TelaInicialUsuario());
        }

        private void AbrirTelaInicialComercial(object obj)
        {
            Application.Run(new TelaInicialComercial());
        }

        private void AbrirTelaInicialAgricultor(object obj)
        {
            Application.Run(new TelaInicialAgricultor());
        }
        private void AbrirTelaInicialGerente(object obj)
        {
            Application.Run(new TelaInicialGerente());
        }

    }
}
