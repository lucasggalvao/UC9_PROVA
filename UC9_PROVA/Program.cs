int i = 0;
string aluno;
double aulas = 0;
double faltas = 0;
double prova1;
double prova2;
double prova3;
double trab;




for (i = 1; i < 5; i++) {
    Console.Clear();
    Console.WriteLine("Informe o nome do aluno: ");
    aluno = Console.ReadLine();
    Console.WriteLine("Numero de aulas dadas: ");
    aulas = double.Parse(Console.ReadLine());
    Console.WriteLine("Numero de faltas: ");
    faltas = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota da " + i + "ª Prova: ");
    prova1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota da " + (i+1) + "ª Prova: ");
    prova2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota da " + (i + 1) + "ª Prova: ");
    prova3 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota do trabalho: ");
    trab = double.Parse(Console.ReadLine());
}

    



