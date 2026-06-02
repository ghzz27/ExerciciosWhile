// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Digite a tabuada desejada: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("Até qual multiplicador? ");
int limite = int.Parse(Console.ReadLine());

int multiplicador = 1;

while (multiplicador <= limite)
{
    Console.WriteLine($"{numero} * {multiplicador} = {numero * multiplicador} ");
    multiplicador++;
}
