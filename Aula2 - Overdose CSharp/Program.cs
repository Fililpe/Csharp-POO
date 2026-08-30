namespace Aula2___Overdose_CSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o seu nome");
        string nome = Console.ReadLine();

        
        Console.WriteLine("Informe o seu sobrenome");
        string sobrenome = Console.ReadLine();
        
        string nomeCompleto = nome + " " + sobrenome;
        
        Console.WriteLine("Informe sua idade: ");
        string idade = Console.ReadLine();
        
        
        
        Console.WriteLine($"Bem vindo, {nomeCompleto}");
        Console.WriteLine($"idade: {idade}");
        
        
        
    }
}