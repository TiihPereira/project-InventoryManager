using Dapper;
using InventoryManager.Classes;
using InventoryManager.Repositorio.dbConnection;
using InventoryManager.Repositorio.Interfaces;
using System.Data.SqlClient;

namespace InventoryManager.Repository
{
    internal class PecasRepositorio : IPecasRepositorio
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pecas Insert(Pecas fornecedores)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pecas> SelecionarPorCodigo(int nome)
        {
            try
            {
                using (var connection = new SqlConnection(dbConnection.GetConn()))
                {
                    return connection.Query<Pecas>($"Select * from cd_Pecas where Codigo =  '{ nome }'");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro em buscar peça");
            }
        }

        public IEnumerable<Pecas> SelecionarTodos()
        {
            try
            {
                using (var connection = new SqlConnection(dbConnection.GetConn()))
                {
                    return connection.Query<Pecas>($"Select * from cd_Pecas");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro em buscar peça");
            }
        }

        public Pecas Update(Pecas fornecedores)
        {
            throw new NotImplementedException();
        }
    }
}
