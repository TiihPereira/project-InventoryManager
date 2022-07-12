using InventoryManager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Repositorio.Interfaces
{
    public interface IPecasRepositorio
    {
        public IEnumerable<Pecas> SelecionarTodos();
        public IEnumerable<Pecas> SelecionarPorCodigo(int codigo);
        public void Delete(int id);
        public Pecas Update(Pecas fornecedores);
        public Pecas Insert(Pecas fornecedores);

    }
}
