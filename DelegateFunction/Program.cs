// aula 184
Console.WriteLine("Delegate Function\n");

Console.Write("Informe um número: ");
double numero = Convert.ToDouble(Console.ReadLine());

Func<double, double> raizQuadrada = x => Math.Sqrt(x);

//Func<double, double> raizQuadrada = delegate (double x)
//{
//    return Math.Sqrt(x);
//};

var resultado = raizQuadrada(numero);

Console.WriteLine("\nA raiz quadrada de " + numero + " é: " + resultado);
Console.WriteLine($"\nA raiz quadrada de {numero} é: {resultado}");
Console.ReadKey();