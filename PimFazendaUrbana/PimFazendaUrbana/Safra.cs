using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimFazendaUrbana
{
    public class Safra
    {
        public int Id { get; private set; }
        public string Produto { get; private set; }
        public string DtPlantio { get; private set; }
        public string QtdPlantio { get; private set; }
        public string DtColheita { get; private set; }
        public string QtdColhida { get; private set; }

        public Safra() { }
        public Safra(string id, string produto, string qtdPlantio, string dtPlantio, string qtdColhida, string dtColheita)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("ID é obrigatório!");
            }
            if (string.IsNullOrEmpty(produto))
            {
                throw new Exception("Produto é obrigatório!");
            }
            if (string.IsNullOrEmpty(dtPlantio))
            {
                throw new Exception("Data de Plantio é obrigatório!");
            }
            if (string.IsNullOrEmpty(qtdPlantio))
            {
                throw new Exception("Quantidade de Plantio é obrigatório!");
            }
            Id = int.Parse(id);
            Produto = produto;
            DtPlantio = dtPlantio;
            QtdPlantio = qtdPlantio;
            DtColheita = dtColheita;
            QtdColhida = qtdColhida;
        }
    }
}
