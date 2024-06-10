using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimFazendaUrbana.Infrastructure
{
    public class ProdutoRepository
    {
        public bool Add(Produto produto)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.produto(
	                        id, nome, quantidade, valor, descricao)
	                        VALUES (@Id, @Nome, @Qtd, @Valor, @Descricao);";
            var result = conn.Connection.Execute(sql:  query, param: produto);

            return result == 1;
        }

        public bool Update(Produto produto)
        {
            using var conn = new DbConnection();
            string query = @"UPDATE public.produto 
                            SET nome = @Nome, quantidade = @Qtd, valor = @Valor, descricao = @Descricao       
                            WHERE id = @Id
                            ";
            var result = conn.Connection.Execute(sql: query, param: produto);

            return result == 1;
        }

        public bool Delete(int Id)
        {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.produto 
                            WHERE id = @Id
                            ";
            var result = conn.Connection.Execute(sql: query, param: Id);

            return result == 1;
        }

        public List<Produto> Get() 
        {
            using var conn = new DbConnection(); ;
            string querry = @"SELECT * FROM produto;";
            var produto = conn.Connection.Query<Produto>(sql: querry);

            return produto.ToList();
        }


    }
}
