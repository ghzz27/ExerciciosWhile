// See https://aka.ms/new-console-template for more information
int numP;
Console.WriteLine("Hello, World!");
Console.WriteLine("Digite um numero positivo maior que 20: ");
numP = int.Parse(Console.ReadLine());

while(numP != 0)
{
    if (numP % 3 == 0)
    {
        Console.WriteLine(numP);
    }
    numP = numP - 1;
}

