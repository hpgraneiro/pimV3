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
    public partial class TelaInicialAgricultor : Form
    {
        Thread t1;
        public TelaInicialAgricultor()
        {
            InitializeComponent();
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(VoltarTelaLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            Login.Agricultor = false;
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

        private void buttonSafra_Click(object sender, EventArgs e)
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
    }
}
