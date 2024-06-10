using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimFazendaUrbana
{
    public class Fornecedor
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CpfouCnpj { get; private set; }
        public string Telefone { get; private set; }

        public Fornecedor()
        {

        }
        public Fornecedor(string id, string nome, string cpfoucnpj, string telefone)
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
            Telefone = telefone;
        }
    }   
}
