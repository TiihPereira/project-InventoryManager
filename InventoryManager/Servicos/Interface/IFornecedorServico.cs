using InventoryManager.Classes;

namespace InventoryManager.Servicos.Interface;
public interface IFornecedorServico
{
    public IEnumerable<Fornecedores> SelecionarTodos();
    public IEnumerable<Fornecedores> SelecionarPorCNPJ(string Cnpj);
    public void Delete(int id);
    public Fornecedores Atualizar(Fornecedores fornecedores);
    public Fornecedores? Inserir(Fornecedores fornecedores);


}

