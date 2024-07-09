//aula 180
Console.WriteLine("Métodos/Funções Anônimas\n");

List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos");

//string resultado = nomes.Find(VerificarNomeLista);
//Console.WriteLine(resultado);
string resultado = nomes.Find(delegate (string nome)
{
    return nome.Equals("Miriam");
});

Imprimir imprimir = delegate (int valor)
{
    Console.WriteLine($"Método Anônimo: {valor}");
};

imprimir(100);
imprimir(200);

Console.ReadKey();

//static bool VerificarNomeLista(string nome)
//{
//    Console.WriteLine($"Consultando nome na lista: {nome}");
//    return nome.Equals("Miriam");
//}

public delegate void Imprimir(int valor);