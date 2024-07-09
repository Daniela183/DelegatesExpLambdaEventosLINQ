//aula 190-191
Console.WriteLine("Consultas LINQs\n");

List<string> nomes = new List<string>()
{
    "Ana", "Maria", "Pedro", "Lair", "Hugo"
};

//Sintaxe de consulta
var resultado = (from m in nomes
                 where m.Contains('o')
                 select m).ToArray();

ExibirResultado(resultado);

//Sinatxe de método
Console.WriteLine("\nOutra forma de usar a LINQ\n");
var resultado1 = nomes.Where(n => n.Contains('a')).ToList();

ExibirResultado(resultado1);

Console.ReadKey();

static void ExibirResultado(IEnumerable<string> resultado)
{
    foreach (var item in resultado)
        Console.WriteLine(item);
}