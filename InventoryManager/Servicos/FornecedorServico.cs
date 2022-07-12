using InventoryManager.Classes;
using InventoryManager.Repository;
using InventoryManager.Servicos.Interface;

namespace InventoryManager.Servicos;
public class FornecedorService : IFornecedorServico
{
    FornecedorRepositorio _fornecedorRepositorio = new FornecedorRepositorio();

    public Fornecedores Atualizar(Fornecedores fornecedores)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Fornecedores? Inserir(Fornecedores fornecedores)
    {
        if(String.IsNullOrEmpty(fornecedores.CNPJ))
        {
            throw new Exception("CPNJ não pode ser nullo");
        }

        var result = SelecionarPorCNPJ(fornecedores.CNPJ);

        if (result is not null)
            return _fornecedorRepositorio.Insert(fornecedores);

        return null;
    }

    public IEnumerable<Fornecedores> SelecionarPorCNPJ(string Cnpj)
    {
        if(String.IsNullOrEmpty(Cnpj))
            throw new Exception("CPNJ não pode ser nullo");

        return _fornecedorRepositorio.SelecionarPorCNPJ(Cnpj);
    }

    public IEnumerable<Fornecedores> SelecionarTodos()
    {
        throw new NotImplementedException();
    }
}

