Console.Write("Informe um inteiro: ");
string entrada = Console.ReadLine() ?? "0";
int n = int.Parse(entrada);

for (int i = 1; i < n; i += 2)
    Console.WriteLine(i);