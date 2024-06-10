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
using PimFazendaUrbana.Infrastructure;

namespace PimFazendaUrbana
{
    public partial class TelaFornecedores : Form
    {
        public List<Fornecedor> Fornecedores { get; private set; } = new List<Fornecedor>();
        Thread t1;
        public TelaFornecedores()
        {
            InitializeComponent();
            ObterFornecedor();
        }
        private void ObterFornecedor()
        {
            var repository = new FornecedorRepository();
            Fornecedores = repository.Get();
            foreach (var item in Fornecedores)
            {
                listViewFornecedor.Items.Add(new ListViewItem(new string[] { item.Id.ToString(), item.Nome, item.CpfouCnpj, item.Telefone }));
            }            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(VoltarTelaGerente);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void VoltarTelaGerente(object obj)
        {
            Application.Run(new TelaInicialGerente());
        }

        private void buttonCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textBoxIdFornecedor.Text;
                var nome = textBoxNomeFornecedor.Text;
                var cpfoucnpj = textBoxCpfouCnpjFornecedor.Text;
                var telefone = textBoxTelefoneFornecedor.Text;

                foreach (var item in Fornecedores)
                {
                    if (item.Id == int.Parse(id))
                    {
                        MessageBox.Show("ID " + id + " já cadastrado no sistema.");
                        return;
                    }
                    if (item.Nome == nome)
                    {
                        MessageBox.Show("Nome " + nome + " já cadastrado no sistema.");
                        return;
                    }
                    if (item.CpfouCnpj == cpfoucnpj)
                    {
                        MessageBox.Show("CPF ou CNPJ " + cpfoucnpj + " já cadastrado no sistema.");
                        return;
                    }
                }

                var fornecedor = new Fornecedor(id, nome, cpfoucnpj, telefone);
                Fornecedores.Add(fornecedor);
                var repository = new FornecedorRepository();
                repository.Add(fornecedor);

                listViewFornecedor.Items.Add(new ListViewItem(new string[] { id, nome, cpfoucnpj, telefone }));

                Limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpar()
        {
            textBoxIdFornecedor.Clear();
            textBoxNomeFornecedor.Clear();
            textBoxCpfouCnpjFornecedor.Clear();
            textBoxTelefoneFornecedor.Clear();
            textBoxIdFornecedor.Focus();
        }

        private void listViewFornecedor_Click(object sender, EventArgs e)
        {
            if (listViewFornecedor.SelectedItems.Count > 0)
            {
                textBoxIdFornecedor.Text = listViewFornecedor.SelectedItems[0].SubItems[0].Text;
                textBoxNomeFornecedor.Text = listViewFornecedor.SelectedItems[0].SubItems[1].Text;
                textBoxCpfouCnpjFornecedor.Text = listViewFornecedor.SelectedItems[0].SubItems[2].Text;
                textBoxTelefoneFornecedor.Text = listViewFornecedor.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void buttonEditarFornecedor_Click(object sender, EventArgs e)
        {
            if (listViewFornecedor.SelectedItems.Count > 0)
            {
                listViewFornecedor.SelectedItems[0].SubItems[0].Text = textBoxIdFornecedor.Text;
                listViewFornecedor.SelectedItems[0].SubItems[1].Text = textBoxNomeFornecedor.Text;
                listViewFornecedor.SelectedItems[0].SubItems[2].Text = textBoxCpfouCnpjFornecedor.Text;
                listViewFornecedor.SelectedItems[0].SubItems[3].Text = textBoxTelefoneFornecedor.Text;
            }
            var Id = textBoxIdFornecedor.Text;
            var Nome = textBoxNomeFornecedor.Text;
            var CpfouCnpj = textBoxCpfouCnpjFornecedor.Text;
            var Telefone = textBoxTelefoneFornecedor.Text;
            var fornecedor = new Fornecedor(Id, Nome, CpfouCnpj, Telefone);
            var repository = new FornecedorRepository();
            repository.Update(fornecedor);
            Limpar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewFornecedor.SelectedItems.Count > 0)
            {
                listViewFornecedor.Items.Remove(listViewFornecedor.SelectedItems[0]);
            }

            var repository = new FornecedorRepository();
            var Id = int.Parse(textBoxIdFornecedor.Text);
            repository.Delete(Id);
            Limpar();
        }
    }
}
