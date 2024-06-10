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
    public partial class TelaFuncionarios : Form
    {
        Thread t1;
        public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();
        public TelaFuncionarios()
        {
            InitializeComponent();
            ObterFuncionario();
        }

        private void ObterFuncionario()
        {
            var repository = new FuncionarioRepository();
            Funcionarios = repository.Get();
            foreach (var item in Funcionarios)
            {
                listViewFuncionario.Items.Add(new ListViewItem(new string[] { item.Id.ToString(), item.Nome, item.Cpf, item.Funcao, item.Salario.ToString() }));
            }
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

        private void Limpar()
        {
            textBoxIdFuncionario.Clear();
            textBoxNomeFuncionario.Clear();
            textBoxCpfFuncionario.Clear();
            textBoxFuncao.Clear();
            textBoxSalarioFuncionario.Clear();
            textBoxIdFuncionario.Focus();
        }


        private void buttonCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textBoxIdFuncionario.Text;
                var nome = textBoxNomeFuncionario.Text;
                var cpf = textBoxCpfFuncionario.Text;
                var funcao = textBoxFuncao.Text;
                var salario = textBoxSalarioFuncionario.Text;

                foreach (var item in Funcionarios)
                {
                    if (item.Id == int.Parse(id))
                    {
                        MessageBox.Show("ID " + id + " já cadastrado no sistema!");
                        return;
                    }
                    if (item.Cpf == cpf)
                    {
                        MessageBox.Show("CPF " + cpf + " já cadastrado no sistema!");
                        return;
                    }
                }

                var funcionario = new Funcionario(id, nome, cpf, funcao, salario);
                Funcionarios.Add(funcionario);
                var repository = new FuncionarioRepository();
                repository.Add(funcionario);

                listViewFuncionario.Items.Add(new ListViewItem(new string[] { id, nome, cpf, funcao, salario }));

                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewFuncionario_Click(object sender, EventArgs e)
        {
            if (listViewFuncionario.SelectedItems.Count > 0)
            {
                textBoxIdFuncionario.Text = listViewFuncionario.SelectedItems[0].SubItems[0].Text;
                textBoxNomeFuncionario.Text = listViewFuncionario.SelectedItems[0].SubItems[1].Text;
                textBoxCpfFuncionario.Text = listViewFuncionario.SelectedItems[0].SubItems[2].Text;
                textBoxFuncao.Text = listViewFuncionario.SelectedItems[0].SubItems[3].Text;
                textBoxSalarioFuncionario.Text = listViewFuncionario.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void buttonEditarFuncionario_Click(object sender, EventArgs e)
        {
                if (listViewFuncionario.SelectedItems.Count > 0)
                {
                    listViewFuncionario.SelectedItems[0].SubItems[0].Text = textBoxIdFuncionario.Text;
                    listViewFuncionario.SelectedItems[0].SubItems[1].Text = textBoxNomeFuncionario.Text;
                    listViewFuncionario.SelectedItems[0].SubItems[2].Text = textBoxCpfFuncionario.Text;
                    listViewFuncionario.SelectedItems[0].SubItems[3].Text = textBoxFuncao.Text;
                    listViewFuncionario.SelectedItems[0].SubItems[4].Text = textBoxSalarioFuncionario.Text;                    
                }
            var Id = textBoxIdFuncionario.Text;
            var Nome = textBoxNomeFuncionario.Text;
            var Cpf = textBoxCpfFuncionario.Text;
            var Funcao = textBoxFuncao.Text;
            var Salario = textBoxSalarioFuncionario.Text;
            var funcionario = new Funcionario(Id, Nome, Cpf, Funcao, Salario);
            var repository = new FuncionarioRepository();
            repository.Update(funcionario);
            Limpar();
        }

        private void buttonRemoverFuncionario_Click(object sender, EventArgs e)
        {
            if (listViewFuncionario.SelectedItems.Count > 0)
            {
                listViewFuncionario.Items.Remove(listViewFuncionario.SelectedItems[0]);
            }

            var repository = new FuncionarioRepository();
            var Id = int.Parse(textBoxIdFuncionario.Text);
            repository.Delete(Id);
            Limpar();
        }
    }
}
