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
using System.Drawing.Text;
using PimFazendaUrbana.Infrastructure;

namespace PimFazendaUrbana
{
    public partial class TelaClientes : Form
    {
        Thread t1;
        public List<Cliente> Clientes { get; private set; } = new List<Cliente>();
        public TelaClientes()
        {
            InitializeComponent();
            ObterCliente();
        }
        private void ObterCliente()
        {
            var repository = new ClienteRepository();
            Clientes = repository.Get();
            foreach (var item in Clientes)
            {
                listViewCliente.Items.Add(new ListViewItem(new string[] { item.Id.ToString(), item.Nome, item.CpfouCnpj, item.Endereco, item.Telefone }));
            }
        }

        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textBoxIdCliente.Text;
                var nome = textBoxNomeCliente.Text;
                var cpfoucnpj = textBoxCpfouCnpjCliente.Text;
                var endereco = textBoxEnderecoCliente.Text;
                var telefone = textBoxTelefoneCliente.Text;

                foreach (var item in Clientes)
                {
                    if (item.Id == int.Parse(id))
                    {
                        MessageBox.Show("ID " + id + " já cadastrado no sistema.");
                        return;
                    }
                    if (item.Nome == nome)
                    {
                        MessageBox.Show(nome + " já cadastrado no sistema.");
                        return;
                    }
                    if (item.CpfouCnpj == cpfoucnpj)
                    {
                        MessageBox.Show("CPF ou CNPJ " + cpfoucnpj + " já cadastrado no sistema.");
                        return;
                    }
                }

                var cliente = new Cliente(id, nome, cpfoucnpj, endereco, telefone);
                Clientes.Add(cliente);
                var repository = new ClienteRepository();
                repository.Add(cliente);

                listViewCliente.Items.Add(new ListViewItem(new string[] { id, nome, cpfoucnpj, endereco, telefone }));

                Limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpar()
        {
            textBoxIdCliente.Clear();
            textBoxNomeCliente.Clear();
            textBoxCpfouCnpjCliente.Clear();
            textBoxEnderecoCliente.Clear();
            textBoxTelefoneCliente.Clear();
            textBoxIdCliente.Focus();
        }
        private void buttonVoltarCliente_Click(object sender, EventArgs e)
        {
            if (Login.Comercial == true)
            {
                this.Close();
                t1 = new Thread(VoltarTelaComercial);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else if (Login.Agricultor == true)
            {
                this.Close();
                t1 = new Thread(VoltarTelaAgricultor);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else if (Login.Gerente == true)
            {
                this.Close();
                t1 = new Thread(VoltarTelaGerente);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }
        private void VoltarTelaComercial(object obj)
        {
            Application.Run(new TelaInicialComercial());
        }
        private void VoltarTelaAgricultor(object obj)
        {
            Application.Run(new TelaInicialAgricultor());
        }
        private void VoltarTelaGerente(object obj)
        {
            Application.Run(new TelaInicialGerente());
        }

        private void labelIdCliente_Click(object sender, EventArgs e)
        {

        }

        private void listViewCliente_Click(object sender, EventArgs e)
        {
            if (listViewCliente.SelectedItems.Count > 0)
            {
                textBoxIdCliente.Text = listViewCliente.SelectedItems[0].SubItems[0].Text;
                textBoxNomeCliente.Text = listViewCliente.SelectedItems[0].SubItems[1].Text;
                textBoxCpfouCnpjCliente.Text = listViewCliente.SelectedItems[0].SubItems[2].Text;
                textBoxEnderecoCliente.Text = listViewCliente.SelectedItems[0].SubItems[3].Text;
                textBoxTelefoneCliente.Text = listViewCliente.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            if (listViewCliente.SelectedItems.Count > 0)
            {
                listViewCliente.SelectedItems[0].SubItems[0].Text = textBoxIdCliente.Text;
                listViewCliente.SelectedItems[0].SubItems[1].Text = textBoxNomeCliente.Text;
                listViewCliente.SelectedItems[0].SubItems[2].Text = textBoxCpfouCnpjCliente.Text;
                listViewCliente.SelectedItems[0].SubItems[3].Text = textBoxEnderecoCliente.Text;
                listViewCliente.SelectedItems[0].SubItems[4].Text = textBoxTelefoneCliente.Text;
            }
            var Id = textBoxIdCliente.Text;
            var Nome = textBoxNomeCliente.Text;
            var CpfouCnpj = textBoxCpfouCnpjCliente.Text;
            var Endereco = textBoxEnderecoCliente.Text;
            var Telefone = textBoxTelefoneCliente.Text;
            var cliente = new Cliente(Id, Nome, CpfouCnpj, Endereco, Telefone);
            var repository = new ClienteRepository();
            repository.Update(cliente);
            Limpar();
        }

        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            if (listViewCliente.SelectedItems.Count > 0)
            {
                listViewCliente.Items.Remove(listViewCliente.SelectedItems[0]);
            }
            var repository = new ClienteRepository();
            var Id = int.Parse(textBoxIdCliente.Text);
            repository.Delete(Id);
            Limpar();
        }
    }
}
