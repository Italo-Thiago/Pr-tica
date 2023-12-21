Console.Write("Digite Algo: ");
string nome = Console.ReadLine();

// Qual tipo
Console.WriteLine($"O tipo primitivo desse valor é {nome.GetType()}");

// Tem espaços
Console.WriteLine($"Só tem espaços? {(nome == " " ? "True" : "False")}");

// E número
Console.WriteLine($"E um número? {int.TryParse(nome, out _)}");

// E alfabético
Console.WriteLine($"É alfabético? {nome.All(char.IsLetter)}");

// E alfanúmerico
Console.WriteLine($"É alfanúmerico? {nome.All(char.IsLetterOrDigit)}");

// maiúsculo
Console.WriteLine($"Está em maiúsculo? {nome.All(char.IsUpper)}");

// minusculo
Console.WriteLine($"Está em minúsculo? {nome.All(char.IsLower)}");

// capitalizado
Console.WriteLine($"Esta capitalizado? {char.IsUpper(nome[0]) && nome.Substring(1).All(char.IsLower)}");

