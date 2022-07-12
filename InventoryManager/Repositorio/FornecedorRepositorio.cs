using Dapper;
using InventoryManager.Classes;
using InventoryManager.Repositorio.dbConnection;
using InventoryManager.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Repository
{
    internal class FornecedorRepositorio : IFornecedorRepositorio
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Fornecedores Insert(Fornecedores fornecedores)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fornecedores> SelecionarPorCNPJ(string Cnpj)
        {
            try
            {
                using (var connection = new SqlConnection(dbConnection.GetConn()))
                {
                    return connection.Query<Fornecedores>($"Select * from Fornecedores where Cnpj = '{ Cnpj }'");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro em buscar fornecedor");
            }
        }

        public IEnumerable<Fornecedores> SelecionarTodos()
        {
            try
            {
                using (var connection = new SqlConnection(dbConnection.GetConn()))
                {
                    return connection.Query<Fornecedores>($"Select * from Fornecedores");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro em buscar fornecedores");
            }
        }

        public Fornecedores Update(Fornecedores fornecedores)
        {
            throw new NotImplementedException();
        }
    }
}
