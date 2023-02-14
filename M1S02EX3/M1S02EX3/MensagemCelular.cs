using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S02EX3
{
    public class MensagemCelular { 
        public int Telefone { get; set; }
        public string Mensagem { get; set; }
        public MensagemCelular(int telefone, string mensagem)
        {
            Mensagem= mensagem;
            Telefone= telefone;
             
        } 
        private void EnviarMensagemaoTelefone ()
        
        {
            
            Console.WriteLine("Método executado pelo console");
            Console.WriteLine($"Telefone: {Telefone}, mensagem: {Mensagem}"); 
        }
        public void Executar (int v)
        {
            
            EnviarMensagemaoTelefone(); 
            Console.WriteLine("Método privado executado na classe"); 
        }

     }
   public class MinhaClasse {

    }
}
