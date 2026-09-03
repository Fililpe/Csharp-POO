using System.Reflection;
using System.Security.Cryptography;

namespace Aula_04;

class Program
{
    //Crianção do Objetivo fusca da classe Carro 
    static void Main(string[] args)
    {
        //Preenchimento dos atributos do objeto
        Carro fusca = new Carro("Volkswagen", "Fusca", "1300L", 370 );
        Console.WriteLine(fusca.informacaoDescricao());

        Carro Ferrari = new Carro();
        Ferrari.marca = "Ferrari";
        Ferrari.modelo = "F50";
        Ferrari.versao = "50.0";
        Ferrari.velocidadeFinal = 250;
        Console.WriteLine(Ferrari.informacaoDescricao());
    }
}