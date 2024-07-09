//aula 178
using Delegates;

Console.WriteLine("Delegates\n");

//DelegateCalculadora calc = DelegateCalculadora(Calculadora.Somar);
//var resultado1 = calc.Invoke(20, 30);
//Console.WriteLine($"Soma = {resultado1}");

var resultado = Calculadora.Somar(10, 40);
Console.WriteLine($"Soma = {resultado}");
Console.WriteLine("\nUsando delegates");
DelegateCalculadora calc = Calculadora.Somar;
var resultado1 = calc(20, 30);
Console.WriteLine($"Soma = {resultado1}");

calc = Calculadora.Dividir;
var resultado2 = calc(20, 30);
Console.WriteLine($"Divisão = {resultado2}");

calc = Calculadora.Subtrair;
var resultado3 = calc(20, 30);
Console.WriteLine($"Subtração = {resultado3}");

calc = Calculadora.Multiplicar;
var resultado4 = calc(20, 30);
Console.WriteLine($"Multiplicação = {resultado4}");

Console.ReadKey();

public delegate float DelegateCalculadora(float x, float y);
