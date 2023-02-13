using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana2ex2

{
    public class Fichainscricao /// Criação da class 
    { /// criação da propriedades públicas
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool MenorIdade { get; set; }

        private decimal custoReal; 
        /// Construtor com parâmetros
        public Fichainscricao(int id, string nome, DateTime dataNascimento, bool menorIdade)
        {
            /// Preencher as variáveis com os parâmetros do construtor
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            MenorIdade = menorIdade;

        }
        // Novo método que vai preencher a variável custoReal com o valor do parâmetro recebido (custoRealNovo)
        public void CalcularCustoReal(decimal custoRealNovo) { 
        custoReal= custoRealNovo;
             
            Console.WriteLine($"Código {Id}, Nome {Nome}, Data de nascimento {DataNascimento} menor de idade: {MenorIdade}");
        }

    }
} 