﻿/*Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano.
Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado
(que é 60 pontos).*/
string sep=new string('-',60);
string nome;
int n1,n2,n3;
System.Console.WriteLine("Inserir o nome do aluno:");
nome=Console.ReadLine();
System.Console.WriteLine("Nota do aluno no primeiro trimestre (de 0 a 30):");
n1=int.Parse(Console.ReadLine());
System.Console.WriteLine("Nota do aluno no segundo trimestre (de 0 a 35):");
n2=int.Parse(Console.ReadLine());
System.Console.WriteLine("Nota do aluno no terceiro trimestre (de 0 a 35):");
n3=int.Parse(Console.ReadLine());
System.Console.WriteLine(sep);
int media=(n1+n2+n3)/3;
if(media>60)
{
    System.Console.WriteLine("Aluno Aprovado.");
}
else
{
    System.Console.WriteLine($"Aluno Reprovado.\nFaltou {60-media} pontos para ser aprovado.");
}