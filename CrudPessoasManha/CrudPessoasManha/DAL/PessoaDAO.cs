using CrudPessoasManha.Modelo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoasManha.DAL
{
    public class PessoaDAO
    {
        public String mensagem;

        public void CadastrarPessoa(Pessoa pessoa)
        {
            SqlConnection con = Conexao.Conectar();
            if (!Conexao.mensagem.Equals(""))
            {
                this.mensagem = Conexao.mensagem;
                return;
            }
            String sql = "insert into pessoas (nome, rg, cpf) values (@nome, @rg, @cpf)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", pessoa.nome);
            cmd.Parameters.AddWithValue("@rg", pessoa.rg);
            cmd.Parameters.AddWithValue("cpf", pessoa.cpf);
            try
            {
                cmd.ExecuteNonQuery();
                mensagem = "Pessoa cadastrada com sucesso!";
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao cadastrar pessoa " + ex.Message;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        public Pessoa PesquisarPessoaPorId(Pessoa pessoa)
        {
            return pessoa;
        }

        public List<Pessoa> PesquisarPessoaPorNome(Pessoa pessoa)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            return listaPessoas;
        }

        public void EditarPessoa(Pessoa pessoa)
        {

        }

        public void ExcluirPessoa(Pessoa pessoa)
        {

        }
    }
}
