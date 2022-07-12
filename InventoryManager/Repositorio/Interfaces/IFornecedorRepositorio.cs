using InventoryManager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Repositorio.Interfaces
{
    public interface IFornecedorRepositorio
    {
        public IEnumerable<Fornecedores> SelecionarTodos();
        public IEnumerable<Fornecedores> SelecionarPorCNPJ(string Cnpj);
        public void Delete(int id);
        public Fornecedores Update(Fornecedores fornecedores);
        public Fornecedores Insert(Fornecedores fornecedores);

    }
}
