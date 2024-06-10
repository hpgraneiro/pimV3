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
    public partial class Estoque : Form
    {
        public List<Produto> Produtos { get; private set; } = new List<Produto>();
        Thread t1;
        public Estoque()
        {
            InitializeComponent();
            ObterProduto();
        }

        private void ObterProduto()
        {
            var repository = new ProdutoRepository();
            Produtos = repository.Get();
            foreach (var item in Produtos)
            {
                ListViewProdutos.Items.Add(new ListViewItem(new string[] { item.Id.ToString(), item.Nome, item.Qtd.ToString(), item.Valor.ToString(), item.Descricao }));
            }
        }

        private void LabelValorItem_Click(object sender, EventArgs e)
        {

        }

        private void Buttonvoltarestoque_Click(object sender, EventArgs e)
        {
            if (Login.Usuario == true)
            {
                this.Close();
                t1 = new Thread(VoltarTelaUsuario);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else if (Login.Comercial == true)
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
        private void VoltarTelaUsuario(object obj)
        {
            Application.Run(new TelaInicialUsuario());
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

        private void ButtonCadastrarItem_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textBoxIDEstoque.Text;
                var nome = TextBoxNomeItem.Text;
                var qtd = TextBoxQuantidade.Text;
                var valor = TextBoxValorItem.Text;
                var descricao = TextBoxDescricaoItem.Text;

                foreach (var item in Produtos)
                {
                    if (item.Id == int.Parse(id))
                    {
                        MessageBox.Show("ID " + id + " já cadastrado no sistema!");
                        return;
                    }
                    if (item.Nome == nome)
                    {
                        MessageBox.Show(nome + " já cadastrado no sistema!");
                        return;
                    }
                }

                var produto = new Produto(id, nome, qtd, valor, descricao);
                Produtos.Add(produto);
                var repository = new ProdutoRepository();
                repository.Add(produto);

                ListViewProdutos.Items.Add(new ListViewItem(new string[] { id, nome, qtd, valor, descricao }));

                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpar()
        {
            textBoxIDEstoque.Clear();
            TextBoxNomeItem.Clear();
            TextBoxQuantidade.Clear();
            TextBoxValorItem.Clear();
            TextBoxDescricaoItem.Clear();
            textBoxIDEstoque.Focus();
        }

        private void ListViewProdutos_Click(object sender, EventArgs e)
        {
            if (ListViewProdutos.SelectedItems.Count > 0)
            {
                textBoxIDEstoque.Text = ListViewProdutos.SelectedItems[0].SubItems[0].Text;
                TextBoxNomeItem.Text = ListViewProdutos.SelectedItems[0].SubItems[1].Text;
                TextBoxQuantidade.Text = ListViewProdutos.SelectedItems[0].SubItems[2].Text;
                TextBoxValorItem.Text = ListViewProdutos.SelectedItems[0].SubItems[3].Text;
                TextBoxDescricaoItem.Text = ListViewProdutos.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void ButtonEditarItem_Click(object sender, EventArgs e)
        {
            if (ListViewProdutos.SelectedItems.Count > 0)
            {
                ListViewProdutos.SelectedItems[0].SubItems[0].Text = textBoxIDEstoque.Text;
                ListViewProdutos.SelectedItems[0].SubItems[1].Text = TextBoxNomeItem.Text;
                ListViewProdutos.SelectedItems[0].SubItems[2].Text = TextBoxQuantidade.Text;
                ListViewProdutos.SelectedItems[0].SubItems[3].Text = TextBoxValorItem.Text;
                ListViewProdutos.SelectedItems[0].SubItems[4].Text = TextBoxDescricaoItem.Text;
               
            }

            var Id = textBoxIDEstoque.Text;
            var Nome = TextBoxNomeItem.Text;
            var Qtd = TextBoxQuantidade.Text;
            var Valor = textBoxIDEstoque.Text;
            var Descricao = TextBoxDescricaoItem.Text;
            var produto = new Produto(Id, Nome, Qtd, Valor, Descricao);           
            var repository = new ProdutoRepository();
            repository.Update(produto);
            Limpar();
        }

        private void buttonRemoverEstoque_Click(object sender, EventArgs e)
        {
            if (ListViewProdutos.SelectedItems.Count > 0)
            {
                ListViewProdutos.Items.Remove(ListViewProdutos.SelectedItems[0]);
            }                      
           
            var repository = new ProdutoRepository();
            var Id = int.Parse(textBoxIDEstoque.Text);
            repository.Delete(Id);
            Limpar();
        }
    }
}
