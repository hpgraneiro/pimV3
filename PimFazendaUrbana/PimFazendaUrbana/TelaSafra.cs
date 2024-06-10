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
    public partial class TelaSafra : Form
    {
        public List<Safra> Safras { get; private set; } = new List<Safra>();
        Thread t1;
        public TelaSafra()
        {
            InitializeComponent();
            ObterSafra();
        }

        private void ObterSafra()
        {
            var repository = new SafraRepository();
            Safras = repository.Get();
            foreach (var item in Safras)
            {
                listViewSafra.Items.Add(new ListViewItem(new string[] { item.Id.ToString(), item.Produto, item.DtPlantio, item.QtdPlantio, item.DtColheita, item.QtdColhida }));
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            if (Login.Agricultor == true)
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
        private void VoltarTelaAgricultor(object obj)
        {
            Application.Run(new TelaInicialAgricultor());
        }
        private void VoltarTelaGerente(object obj)
        {
            Application.Run(new TelaInicialGerente());
        }

        private void buttonCadastrarPlantio_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textBoxIdSafra.Text;
                var produto = textBoxProdutoSafra.Text;
                var dtPlantio = textBoxDtPlantio.Text;
                var qtdPlantio = textBoxQtdPlantio.Text;
                var dtColheita = textBoxDtColheita.Text;
                var qtdColhida = textBoxQtdColhida.Text;

                foreach (var item in Safras)
                {
                    if (item.Id == int.Parse(id))
                    {
                        MessageBox.Show("ID " + id + " já cadastrado no sistema!");
                        return;
                    }
                }

                var safra = new Safra(id, produto, dtPlantio, qtdPlantio, dtColheita, qtdColhida);
                Safras.Add(safra);
                var repository = new SafraRepository();
                repository.Add(safra);

                listViewSafra.Items.Add(new ListViewItem(new string[] { id, produto, qtdPlantio, dtPlantio, qtdColhida, dtColheita }));

                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpar()
        {
            textBoxIdSafra.Clear();
            textBoxProdutoSafra.Clear();
            textBoxDtPlantio.Clear();
            textBoxQtdPlantio.Clear();
            textBoxDtColheita.Clear();
            textBoxQtdColhida.Clear();
            textBoxIdSafra.Focus();
        }

        private void listViewSafra_Click(object sender, EventArgs e)
        {
            if (listViewSafra.SelectedItems.Count > 0)
            {
                textBoxIdSafra.Text = listViewSafra.SelectedItems[0].SubItems[0].Text;
                textBoxProdutoSafra.Text = listViewSafra.SelectedItems[0].SubItems[1].Text;
                textBoxDtPlantio.Text = listViewSafra.SelectedItems[0].SubItems[2].Text;
                textBoxQtdPlantio.Text = listViewSafra.SelectedItems[0].SubItems[3].Text;
                textBoxDtColheita.Text = listViewSafra.SelectedItems[0].SubItems[4].Text;
                textBoxQtdColhida.Text = listViewSafra.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void buttonEditarPlantio_Click(object sender, EventArgs e)
        {
            if (listViewSafra.SelectedItems.Count > 0)
            {
                listViewSafra.SelectedItems[0].SubItems[0].Text = textBoxIdSafra.Text;
                listViewSafra.SelectedItems[0].SubItems[1].Text = textBoxProdutoSafra.Text;
                listViewSafra.SelectedItems[0].SubItems[2].Text = textBoxDtPlantio.Text;
                listViewSafra.SelectedItems[0].SubItems[3].Text = textBoxQtdPlantio.Text;
                listViewSafra.SelectedItems[0].SubItems[4].Text = textBoxDtColheita.Text;
                listViewSafra.SelectedItems[0].SubItems[5].Text = textBoxQtdColhida.Text;               
            }
            var Id = textBoxIdSafra.Text;
            var Produto = textBoxProdutoSafra.Text;
            var DtPlantio = textBoxDtPlantio.Text;
            var QtdPlantio = textBoxQtdPlantio.Text;
            var DtColheita = textBoxDtColheita.Text;
            var QtdColhida = textBoxQtdColhida.Text;
            var safra = new Safra(Id, Produto, DtPlantio, QtdPlantio, DtColheita, QtdColhida);
            var repository = new SafraRepository();
            repository.Update(safra);
            Limpar();
        }

        private void buttonRemoverSafra_Click(object sender, EventArgs e)
        {
            if (listViewSafra.SelectedItems.Count > 0)
            {
                listViewSafra.Items.Remove(listViewSafra.SelectedItems[0]);
            }

            var repository = new SafraRepository();
            var Id = int.Parse(textBoxIdSafra.Text);
            repository.Delete(Id);
            Limpar();
        }
    }
}
