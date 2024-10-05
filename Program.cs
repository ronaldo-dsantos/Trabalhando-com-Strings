// ToLower (Converter para minúsculo)
Console.Write("Digite seu nome e sobrenome: ");
var nomeCompleto = Console.ReadLine();
Console.WriteLine("ToLower: " + nomeCompleto.ToLower());

// ToUpper (Converter para maiúsculo)
Console.WriteLine("ToUpper: " + nomeCompleto.ToUpper());

// Substring (Acessar uma parte específica de uma cadeia de caracteres)
Console.WriteLine("Substring: " + nomeCompleto.Substring(0, 7)); // 0 = índice que vai começar a seleção, 7 = número de caracteres que serão selecionados 
Console.WriteLine("Substring: " + nomeCompleto.Substring(8)); // 8 = índice que vai começar a seleção, quando o número de caracteres não é informado, ele pega até o final da cadeia de caracteres

// Range (Acessar um intervalo de uma cadeia de caracteres)
var nomeArquivo = "2024_10_04_backup.bak";
var ano = nomeArquivo[..4]; // ..4 = pegar os 4 primeiros caracteres da string
Console.WriteLine(ano);

var extencao = nomeArquivo[^3..]; // ^3.. = pegar os últimos 3 catacteres da string
Console.WriteLine(extencao);

var nome = nomeArquivo[11..^4]; // [11..^4 = pegar a partir da posição 11 e ignorar os últimos 4 caracteres
Console.WriteLine(nome);

var nomeSemExtencao = nomeArquivo[..^4]; // ..^4 pegar todos os caracteres e ignorar os últimos 4 caracteres
Console.WriteLine(nomeSemExtencao);

// Contains (Verifica se contém um determinado valor em uma cadeia de caracteres)
nomeArquivo = "2024_10_04_backup.bak";

if (nomeArquivo.Contains("backup"))
{
  Console.WriteLine("Valor encontrado");
}
else
{
  Console.WriteLine("Valor não encontrado");
}

// Trim, TrimEnd e TrimStart (Elimina caracteres não desejados de sua cadeia de caracteres)
var exemploTrim = "**Ronaldo Domingues**";

Console.WriteLine("Trim: " + exemploTrim.Trim('*')); // Entre aspas simples por se tratar de um único caracter | exemploTrim.Trim() se o caracter a ser removido não for informado, elimina os espaços em branco
Console.WriteLine("TrimStart: " + exemploTrim.TrimStart('*'));
Console.WriteLine("TrimEnd: " + exemploTrim.TrimEnd('*'));

// StartsWith e EndsWith (Verificar se sua cadeia de caracteres começa ou termina com uma determinada palavra)
var exemploWith = "Curso Csharp";

Console.WriteLine("StartsWith: " + exemploWith.StartsWith("Curso")); // Retorna verdadeiro ou falso
Console.WriteLine("EndsWith: " + exemploWith.EndsWith("Csharp"));

// Replace (Substituir um palavra ou frase de uma cadeia de caracteres)
var exemploReplace = "Curso Csharp";

Console.WriteLine(exemploReplace);
Console.WriteLine(exemploReplace.Replace("Csharp", "C#"));

// Length (Tamanho de uma cadeia de caracteres)
var exemploLength = "csharp";

Console.WriteLine(exemploLength);
Console.WriteLine(exemploLength.Length);



