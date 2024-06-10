using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimFazendaUrbana
{
    public class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Funcao { get; private set; }
        public double Salario { get; private set; }

        public Funcionario() { }
        public Funcionario(string id, string nome, string cpf, string funcao, string salario)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("ID é obrigatório!");
            }
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome é obrigatório!");
            }
            if (string.IsNullOrEmpty(cpf))
            {
                throw new Exception("CPF é obrigatório!");
            }
            
            Id = int.Parse(id);
            Nome = nome;
            Cpf = cpf;
            Funcao = funcao;
            Salario = double.Parse(salario);
        }
    }
}
