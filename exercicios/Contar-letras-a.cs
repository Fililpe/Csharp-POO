Console.Write("Informe uma string: ");
string texto = Console.ReadLine() ?? "";

int cont = 0;
for (int i = 0; i < texto.Length; i++)
    if (texto[i] == 'a')
        cont++;

Console.WriteLine($"A string possui {cont} letras 'a'");