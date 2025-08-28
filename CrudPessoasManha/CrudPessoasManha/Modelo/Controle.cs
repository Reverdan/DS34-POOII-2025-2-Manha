using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoasManha.Modelo
{
    public class Controle
    {
        public String mensagem;

        public void CadastrarPessoa(List<String> listaDadosPessoa)
        {

        }

        public Pessoa PesquisarPessoaPorId(String identificacao)
        {
            Pessoa pessoa = new Pessoa();
            return pessoa;
        }

        public List<Pessoa> PesquisarPessoaPorNome(String nome)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            return listaPessoas;
        }

        public void EditarPessoa(List<String> listaDadosPessoa)
        {

        }

        public void ExcluirPessoa(String identificacao)
        {

        }
    }
}
