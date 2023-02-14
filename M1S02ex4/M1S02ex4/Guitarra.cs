using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S02ex4
{
    public class Guitarra
    {
        
        public string AfinacaoAtual { get; set; }
        private static string Afinacao = "SOL"; 
        static Guitarra () 
        {
        }
        private void TomAfinado (string afinacao)
        {
        Afinacao = afinacao;
            Console.WriteLine($"A guitarra está com afinação em {afinacao}"); 
        }
        public void tocar(string afinacao, string afinacaoAtual)
        {
            Afinacao = afinacao; 
            AfinacaoAtual = afinacaoAtual;
            TomAfinado(afinacao);
        }
    }
}
