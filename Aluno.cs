class Aluno
{
    public string sep=new string('-',60);
    public string nome;
    public int n1,n2,n3;
    public void CalcularNota()
    {
        int soma=n1+n2+n3;
        if(soma>60)
        {
            System.Console.WriteLine($"O aluno {nome} está aprovado.");
        }
        else
        {
            System.Console.WriteLine($"O aluno {nome} está reprovado.\nFaltou {60-soma} pontos para ser aprovado.\n{sep}");
        }
    }
    public void InserirN1()
    {
        System.Console.WriteLine("Nota do aluno no primeiro trimestre (de 0 a 30):");
        n1=int.Parse(Console.ReadLine());
        if(n1>=0&&n1<=30)
        {
            InserirN2();
        }
        else
        {
            System.Console.WriteLine($"Inserção incorreta, insira novamente dentro do valor estipulado.\n{sep}");
            InserirN1();
        }
    }
    public void InserirN2()
    {
        System.Console.WriteLine("Nota do aluno no segundo trimestre (de 0 a 35):");
        n2=int.Parse(Console.ReadLine());
        if(n2>=0&&n2<=35)
        {
            InserirN3();
        }
        else
        {
            System.Console.WriteLine($"Inserção incorreta, insira novamente dentro do valor estipulado.\n{sep}");
            InserirN2();
        }
    }
    public void InserirN3()
    {
        System.Console.WriteLine("Nota do aluno no terceiro trimestre (de 0 a 35):");
        n3=int.Parse(Console.ReadLine());
        if(n3>=0&&n3<=35)
        {
            System.Console.WriteLine(sep);
            CalcularNota();
            Environment.Exit(0);
        }
        else
        {
            System.Console.WriteLine($"Inserção incorreta, insira novamente dentro do valor estipulado.\n{sep}");
            InserirN3();
        }
    }
}