// Calcule a área de um triângulo retângulo, dados base (b) e altura (h). A área é dada pela metade do produto da base pela altura.

double b;
double h;
double area;

Console.WriteLine("----calculadora de área----\n");

Console.Write("Digite a basa do Triângulo: ");
b = Double.Parse(Console.ReadLine()!);

Console.Write("Ddigite a altura do triângulo: ");
h = double.Parse(Console.ReadLine()!);

area = b * h / 2;

Console.WriteLine($"A área do Triângulo é {area} ");
Console.ReadLine();