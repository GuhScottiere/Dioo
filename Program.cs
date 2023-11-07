using Novembro.Models;

namespace Novembro;

class Program
{
    static void Main(string[] args)
    {
      Pessoa p = new Pessoa();
      p.Nome = "Luiz Gustavo";
      p.Idade =  30;
      p.Sobrenome = "Scottiere";
      p.Apresentar();

      Pessoa p1 = new Pessoa();
      p1.Nome = "Luan";
      p1.Idade = 33;
      p1.Apresentar();
    }
}
