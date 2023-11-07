using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Novembro.Models
{
    public class Pessoa
    { 
        public string Sobrenome { get; set; }
        public string NomeCompleto => $" {Nome} {Sobrenome}";
        private int _idade;
       public int Idade 
       {
         get => _idade;

          set
          {
            if(value <0)
            {
                throw new ArgumentException ("idade não pode ser meno que 0");
            }
            _idade = value;
          }
       }
       public string Nome 
       { 
        get =>
        
             _nome.ToUpper();
             
        
        set
        {
            if(value == "")
            {
                throw new ArgumentException ("o nome nao pode ser vazio");
            }   
            _nome = value;
        } 
      }
        private string _nome ;
       public void Apresentar()
       {
        Console.WriteLine($"Pessoa {NomeCompleto} tem {Idade} anos");
       }
    }
}