// See https://aka.ms/new-console-template for more information

using System.Collections;
using FunctionConsole.functions;

var person = new PersonName();

var meuArray = new ArrayList(); // Todos os tipos de dados
meuArray.Add("Marcelo");
meuArray.Add("Oliveira");
meuArray.Add(46);

var arrayTipado = new int[3] {0, 2, 8};

Console.WriteLine((string) meuArray[1] + ",");
Console.WriteLine((string) meuArray[0]);

Array.Resize(ref arrayTipado, 20);

arrayTipado[19] = 20;

Console.WriteLine(arrayTipado);

foreach (var dados in meuArray)
{
    Console.WriteLine(dados);
}
foreach (var dados in arrayTipado)
{
    Console.WriteLine(dados);
}
Console.WriteLine(person);