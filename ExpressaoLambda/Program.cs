// aula 181
Console.WriteLine("Expressões Lambdas\n");

List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos");

//método anônimo 
//string resultado = nomes.Find(delegate (string nome)
//{
//    return nome.Equals("Miriam");
//});
string resultado = nomes.Find(nome => nome.Equals("Paulo"));

Console.WriteLine(resultado);

Console.ReadKey();