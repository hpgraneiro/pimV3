using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimFazendaUrbana.Infrastructure
{
    public class ClienteRepository
    {
        public bool Add(Cliente cliente)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.cliente(
	                        id, nome, cpfoucnpj, endereco, telefone)
	                        VALUES (@Id, @Nome, @CpfouCnpj, @Endereco, @Telefone);";
            var result = conn.Connection.Execute(sql: query, param: cliente);

            return result == 1;
        }

        public bool Update(Cliente cliente)
        {
            using var conn = new DbConnection();
            string query = @"UPDATE public.cliente
                            SET nome = @Nome, cpfoucnpj = @CpfouCnpj, endereco = @Endereco, telefone = @Telefone       
                            WHERE id = @Id
                            ";
            var result = conn.Connection.Execute(sql: query, param: cliente);

            return result == 1;
        }

        public bool Delete(int Id)
        {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.cliente 
                            WHERE id = @Id
                            ";
            var result = conn.Connection.Execute(sql: query, param: Id);

            return result == 1;
        }

        public List<Cliente> Get()
        {
            using var conn = new DbConnection(); ;
            string querry = @"SELECT * FROM cliente;";
            var cliente = conn.Connection.Query<Cliente>(sql: querry);

            return cliente.ToList();
        }
    }
}
