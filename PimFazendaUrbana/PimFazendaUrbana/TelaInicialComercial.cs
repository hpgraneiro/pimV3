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
    public partial class TelaInicialComercial : Form
    {
        Thread t1;
        public TelaInicialComercial()
        {
            InitializeComponent();
        }

        private void ButtonDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(VoltarTelaLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            Login.Comercial = false;
        }

        private void VoltarTelaLogin(object obj)
        {
            Application.Run(new TelaLogin());
        }

        private void ButtonVisualizarEstoque_Click(object sender, EventArgs e)
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

        private void ButtonClientes_Click(object sender, EventArgs e)
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
    }
}
