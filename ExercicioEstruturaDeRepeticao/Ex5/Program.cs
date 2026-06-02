// See https://aka.ms/new-console-template for more information
int con = 1;
int resul = 1;

Console.WriteLine("Digite a base positivos: ");
int bas= int.Parse(Console.ReadLine());

Console.WriteLine("Digite o expoente positivos: ");
int expo = int.Parse(Console.ReadLine());

while (con <= expo)
{
    resul = bas * resul;
    con++;
}
Console.WriteLine("O resultado é: " + resul);

