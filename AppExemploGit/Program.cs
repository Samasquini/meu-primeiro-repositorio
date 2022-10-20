Console.WriteLine("---------------------------");
Console.WriteLine("[1] - Saudação.");
Console.WriteLine("---------------------------");

Console.Write("Escolha uma opção: ");
var a = int.TryParse(Console.ReadLine(), out var b);
if(b == 1)
{
    Console.Write("Qual é o seu nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine($"Olá, {nome} !");
}