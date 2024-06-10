using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimFazendaUrbana
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Nome {  get; private set; }
        public int Qtd { get; private set; }
        public double Valor { get; private set; }
        public string Descricao { get; private set; }

        public Produto()
        {

        }
        public Produto(string id, string nome, string qtd, string valor, string descricao)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("ID é obrigatório!");
            }
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome é obrigatório!");
            }
            if (string.IsNullOrEmpty(qtd))
            {
                throw new Exception("Quantidade é obrigatório!");
            }
            if (string.IsNullOrEmpty(valor))
            {
                throw new Exception("Valor é obrigatório!");
            }
            Id = int.Parse(id);
            Nome = nome;
            Qtd = int.Parse(qtd);
            Valor = double.Parse(valor);
            Descricao = descricao;
        }


    }
}
