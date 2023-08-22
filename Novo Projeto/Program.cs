
using Novo_Projeto;
using System;

int num1 = 5;
int num2 = 11, result;

Somador soma;
soma = new Somador();

//Conversor conversor = new Conversor();

//altere a saida para que exiba:
//A soma dos numeros ____ + ____ e ____
result = soma.Soma(num1, num2);

Console.WriteLine($"A soma dos numeros {num1} + { num2} e {result}");

//altere a saida para que exiba:
//A medida ____ metros Corresponde a ___ milimetros
double metros = 1.76;
Console WriteLine("A medida {0} metros corresponde a {1}", metros, Conversor.Metros milimetros(1.76));