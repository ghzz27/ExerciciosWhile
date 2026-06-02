// See https://aka.ms/new-console-template for more information
int Inferior, Superior, soma=0;

Console.WriteLine("Digite o limite inferior: ");
Inferior = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o limite superior: ");
Superior = int.Parse(Console.ReadLine());

if (Inferior >= Superior)
{
    Console.WriteLine("Numero invalido");
}
else
{
    while (Inferior <= Superior)
    {
        soma = soma + Inferior;
        Inferior++;
    }

    Console.WriteLine($"A soma dos números é: {soma} ");
}







