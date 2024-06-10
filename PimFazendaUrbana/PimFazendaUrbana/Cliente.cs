using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimFazendaUrbana
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CpfouCnpj { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public Cliente()
        {

        }

        public Cliente(string id, string nome, string cpfoucnpj, string endereco, string telefone)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("ID é obrigatório!");
            }
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome é obrigatório!");
            }
            if (string.IsNullOrEmpty(cpfoucnpj))
            {
                throw new Exception("CPF ou CNPJ é obrigatório!");
            }
            Id = int.Parse(id);
            Nome = nome;
            CpfouCnpj = cpfoucnpj;
            Endereco = endereco;
            Telefone = telefone;
        }
    }
}
