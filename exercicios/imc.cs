Console.Write("Peso (kg): ");
string entrada = Console.ReadLine() ?? "";
double peso = double.Parse(entrada);

Console.Write("Altura (m): ");
entrada = Console.ReadLine() ?? "";
double altura = double.Parse(entrada);

double imc = peso / (altura * altura);

Console.WriteLine($"O IMC de uma pessoa com peso {peso} e altura {altura} é {imc}");