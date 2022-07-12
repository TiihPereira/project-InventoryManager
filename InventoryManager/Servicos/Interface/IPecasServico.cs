using InventoryManager.Classes;

namespace InventoryManager.Servicos.Interface;
public interface IPecasServico
{
    public IEnumerable<Pecas> SelecionarTodos();
    public IEnumerable<Pecas> SelecionarPorCodigo(int codigo);
    public void Delete(int id);
    public Pecas Atualizar(Pecas fornecedores);
    public Pecas? Inserir(Pecas fornecedores);


}

