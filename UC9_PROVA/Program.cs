int i = 0;
int FT = 0;
int aulas = 0;
int faltas = 0;
string aluno = " ";
double presenca = 0;
double peso1 = 30;
double peso2 = 25;
double peso3 = 35;
double prova1 = 0;
double prova2 = 0;
double prova3 = 0;
double media;
double trab;




for (i = 1; i < 5; i++) {
    Console.Clear();
    
    Console.WriteLine("Informe o nome do aluno: ");
    aluno = Console.ReadLine();
    Console.WriteLine("Numero de aulas dadas: ");
    aulas = int.Parse(Console.ReadLine());
    Console.WriteLine("Numero de faltas: ");
    faltas = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota da " + i + "ª Prova: ");
    prova1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota da " + (i+1) + "ª Prova: ");
    prova2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota da " + (i + 1) + "ª Prova: ");
    prova3 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota do trabalho: ");
    trab = double.Parse(Console.ReadLine());
}

media =(prova1 * peso1 + prova2 * peso2 + prova3 * peso3) / (peso1 + peso2 + peso3);
FT = (faltas * 100) / aulas;
presenca = 100 - FT;

if(media >= 6 && presenca > 25)
{
    Console.WriteLine(aluno + ", Aprovado com " + media.ToString("F") + " de media e " + presenca + " de menção");
}
if (media < 6 && presenca >= 25)
{
    Console.WriteLine(aluno + ", Reprovado por menção com " + media.ToString("F") + " de media");
}
if (media > 6 && presenca < 25)
{
    Console.WriteLine(aluno + ", Reprovado por faltas com " + presenca + " de menção");
}
if (media < 6 && presenca < 25)
{
    Console.WriteLine(aluno + ", Reprovado por menção e faltas com " + media.ToString("F") + " de media e " + presenca + " de menção");
}

Console.WriteLine("Pressione qualquer para continuar");
Console.ReadLine();





