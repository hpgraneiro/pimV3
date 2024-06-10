using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimFazendaUrbana.Infrastructure
{
    public class SafraRepository
    {
        public bool Add(Safra safra)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.safra
	                        VALUES (@Id, @Produto, @DtPlantio, @QtdPlantio, @DtColheita, @QtdColhida);";
            var result = conn.Connection.Execute(sql: query, param: safra);

            return result == 1;
        }

        public bool Update(Safra safra)
        {
            using var conn = new DbConnection();
            string query = @"UPDATE public.safra 
                            SET produto = @Produto, ""dtPlantio"" = @DtPlantio, ""qtdPlantio"" = @QtdPlantio, ""dtColheita"" = @DtColheita, ""qtdColhida"" = @QtdColhida      
                            WHERE id = @Id
                            ";
            var result = conn.Connection.Execute(sql: query, param: safra);

            return result == 1;
        }

        public bool Delete(int Id)
        {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.safra
                            WHERE id = @Id
                            ";
            var result = conn.Connection.Execute(sql: query, param: Id);

            return result == 1;
        }

        public List<Safra> Get()
        {
            using var conn = new DbConnection(); ;
            string querry = @"SELECT * FROM public.safra;";
            var safra = conn.Connection.Query<Safra>(sql: querry);

            return safra.ToList();
        }
    }
}

                            