using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PimFazendaUrbana
{
    public partial class TelaInicialGerente : Form
    {
        Thread t1;
        public TelaInicialGerente()
        {
            InitializeComponent();
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(VoltarTelaLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            Login.Gerente = false;
        }
        private void VoltarTelaLogin(object obj)
        {
            Application.Run(new TelaLogin());
        }

        private void buttonEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirEstoque);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirEstoque(object obj)
        {
            Application.Run(new Estoque());
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirClientes);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirClientes(object obj)
        {
            Application.Run(new TelaClientes());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirTelaSafra);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirTelaSafra(object obj)
        {
            Application.Run(new TelaSafra());
        }

        private void buttonFornecedores_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirTelaFornecedores);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirTelaFornecedores(object obj)
        {
            Application.Run(new TelaFornecedores());
        }

        private void buttonFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirTelaFuncionarios);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirTelaFuncionarios(object obj)
        {
            Application.Run(new TelaFuncionarios());
        }
    }
}
