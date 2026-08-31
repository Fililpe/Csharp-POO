
Console.WriteLine("=== AVISO === \n *NÃO use . como separador*");

Console.WriteLine("Peso: ");

string? entrada1 = Console.ReadLine();
if (entrada1 == null)
{
    Console.WriteLine("Entrada inválida, encerrando...");
    return;
}
double peso = double.Parse(entrada1);

Console.WriteLine("Altura: ");
string? entrada2 = Console.ReadLine();
if (entrada2 == null)
{
    Console.WriteLine("Entrada inválida, encerrando...");
    return;
}
double altura = double.Parse(entrada2);

double imc = peso / (altura * altura);

Console.WriteLine($"o imc do peso: {peso}kg e altura:{altura}m é IMC={imc:f2}");
