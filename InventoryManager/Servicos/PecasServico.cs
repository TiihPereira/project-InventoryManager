using InventoryManager.Classes;
using InventoryManager.Repository;
using InventoryManager.Servicos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Servicos;
public class PecasServico : IPecasServico
{
    PecasRepositorio _pecasRepositorio = new PecasRepositorio();
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Pecas? Inserir(Pecas fornecedores)
    {
        if (fornecedores.Codigo == 0)
        {
            throw new Exception("Model não pode ser nullo");
        }

        var result = SelecionarPorCodigo(fornecedores.Codigo);

        if (result is not null)
            return _pecasRepositorio.Insert(fornecedores);

        return null;
    }

    public IEnumerable<Pecas> SelecionarPorCodigo(int Codigo)
    {
        if (Codigo == 0)
        {
            throw new Exception("Model não pode ser nullo");
        }

        return _pecasRepositorio.SelecionarPorCodigo(Codigo);
    }

    public IEnumerable<Pecas> SelecionarTodos()
    {
        return _pecasRepositorio.SelecionarTodos();
    }

    Pecas IPecasServico.Atualizar(Pecas fornecedores)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Pecas> IPecasServico.SelecionarTodos()
    {
        throw new NotImplementedException();
    }
}

