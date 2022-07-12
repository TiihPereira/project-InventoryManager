using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Classes
{
    public class Pecas
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Marca { get; set; }
        public string? Model { get; set; }
        public int Quantidade { get; set; }
        public double ValorCompra { get; set; }
        public double ValorRevenda { get; set; }
        public int IdFornecedor { get; set; }
    }
}
