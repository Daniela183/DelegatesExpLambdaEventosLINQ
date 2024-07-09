//aula 183
Console.WriteLine("Delegate Action\n");

Console.Write("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

Action<int> dobra = x => Console.WriteLine($"O dobro do valor informado é: {x * 2}");
dobra(numero);

Console.ReadKey();

