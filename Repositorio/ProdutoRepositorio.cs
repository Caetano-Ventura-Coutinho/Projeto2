using MySql.Data.MySqlClient;
using System.Data;
using PROJETO2.Models;
namespace PROJETO2.Repositorio
{
    public class ProdutoRepositorio (IConfiguration configuration)
    {

        private readonly string _conexaoMySQL = configuration.GetConnectionString("ConexaoMySQL");

        public void AdicionarProduto (Produto produto)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new("Insert Into tbProduto (Nome, Descricao, Preco, Qtd) values (@Nome, @Descricao, @Preco, @Quantidade)", conexao);
                cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);

                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

    }
}
