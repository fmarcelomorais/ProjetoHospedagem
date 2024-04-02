using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagem.Models
{
    public class Hospedes
    {
        public List<Pessoa> ListaDePessoas = new List<Pessoa>();

        public void CadastrarHospedes(string nome, string sobrenome)
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = nome,
                Sobrenome = sobrenome
            };

            ListaDePessoas.Add(pessoa);
                
        }
    }
}