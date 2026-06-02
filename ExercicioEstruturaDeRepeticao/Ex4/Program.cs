// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 1;
double nota = 0, soma = 0, media;

while (i <= 5) { 
    Console.WriteLine($"Digite a nota da prova {i}");
    nota = int.Parse(Console.ReadLine());

    i = i + 1;

    soma += nota;
 

}
media = soma / 5;


Console.WriteLine("A media e igual a: " + media);

if(media >= 6)
{
    Console.WriteLine("Aprovado ");
}
else
{
    Console.WriteLine("Reprovado");
}