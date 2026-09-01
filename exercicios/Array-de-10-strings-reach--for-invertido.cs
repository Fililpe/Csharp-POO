string[] palavras = new string[10];

for (int i = 0; i < palavras.Length; i++)
    palavras[i] = Console.ReadLine() ?? "";

foreach (string p in palavras)
    Console.WriteLine(p);

for (int i = palavras.Length - 1; i >= 0; i--)
    Console.WriteLine(palavras[i]);