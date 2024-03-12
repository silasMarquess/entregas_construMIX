using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDA_ENTREGA.Model
{
    class item_venda
    {
        public int Id_item { get; private set; }
        public string Nome_produto { get; set; }
        public decimal Qtde { get; set; }
        public decimal Valor_unitario { get; set; }
        public decimal SubTotal { get; set; }
        public int MyProperty { get; set; }

        public item_venda()
        {

        }

        public item_venda(int id_item, string nome_produto, decimal qtde, decimal valor_unitario, decimal subTotal)
        {
            Id_item = id_item;
            Nome_produto = nome_produto;
            Qtde = qtde;
            Valor_unitario = valor_unitario;
            SubTotal = subTotal;
        }


        public decimal getSubTotal()
        {
            return Qtde * Valor_unitario;
        }


    }
}
