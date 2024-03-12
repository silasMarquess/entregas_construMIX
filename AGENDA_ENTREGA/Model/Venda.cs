using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDA_ENTREGA.Model
{
    class Venda
    {
        public int Id { get; private set; }
        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }
        public List<item_venda> Lista { get; private set; }


        public Venda()
        {

        }

        public Venda(int id, DateTime data, decimal valorTotal)
        {
            Id = id;
            Data = data;
            ValorTotal = valorTotal;
        }

        public void AddListaItem(List<item_venda> lista)
        {
            this.Lista = lista;
        }
    }
}
