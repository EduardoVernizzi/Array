
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//string[] nomes = new string[5];
//double[] notas = new double[5];

//for (int i = 0; i < nomes.Length; i++)
//{

//    Console.WriteLine($"Digite o {i+1} nome:  ");
//    string? nome = Console.ReadLine();
//    nomes[i] =nome;

//}

//for (int j = 0; j < notas.Length; j++)
//{

//    Console.WriteLine($"Digite a {j + 1} nota:  ");
//    double nota = Convert.ToDouble(Console.ReadLine());
//    notas[j] = nota;

//}


//foreach (string nome in nomes)
//{

//        Console.WriteLine($"Nomes digitados: {nome}");

//}

//Console.WriteLine("\n\n");

//var somaNotas = 0.0;
//var totalNotas = notas.Count();

//foreach (double nota in notas)
//{
//    somaNotas += nota;
//    Console.WriteLine($" A nota digitada é {nota}");

//}

//Console.WriteLine($"A média aritmética é: {somaNotas/totalNotas}");

//Arrays Bidimensionais

//string[,] alunos = new string[2, 5];



//for (int i = 0; i < alunos.GetLength(0); i++)
//{
//	for (int j = 0; j < alunos.GetLength(1); j++)
//	{

//        Console.WriteLine($"Informe o valor para a posição {i},{j}");
//        alunos[i,j]= Console.ReadLine();

//    }
//}

//Console.WriteLine("\n\nConteúdo do Array alunos: \n");

//for (int i = 0; i < alunos.GetLength(0); i++)
//{
//    for (int j = 0; j < alunos.GetLength(1); j++)
//    {

//        Console.Write($"[{i}, {j}] - {alunos[i,j]}\t");

//    }

//    Console.WriteLine();
//}


//List <t>

List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);

alunos.Add(new Aluno { Nome = "Bia", Nota = 7.75 });
alunos.Add(new Aluno { Nome = "Mario", Nota = 8.95 });

Console.WriteLine("\n\n====Após inclusão====");

ExibirAlunos(alunos);

var aluno1 = alunos.Find(x => x.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

Console.WriteLine("\n\n====Após exclusão de Amanda====");


ExibirAlunos(alunos);


Console.WriteLine("\n\n \t Lista Ordenada");

var listaOrdenada = alunos.OrderBy(n => n.Nome).ToList();

ExibirAlunos(listaOrdenada);

Console.WriteLine("\n\n\tAlunos com nota igual ou maior que 8: ");

var alunoNota8 = alunos.FindAll(n => n.Nota >= 8);

foreach (var item in alunoNota8)
{
    Console.WriteLine($"{item.Nome}\t{item.Nota}");
}






static double ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\n Relação de alunos e notas \n");
    Console.WriteLine("\n Nome \t Notas");


    double somaNota = 0.0;
    int n = alunos.Count;
    foreach (var aluno in alunos)
    {
        Console.Write($"\n{aluno.Nome} \t {aluno.Nota}");

        somaNota += aluno.Nota;
    }

    Console.WriteLine($"\nO somatório das notas é: {somaNota}");
    Console.WriteLine($"A quantidade de alunos é: {alunos.Count()}");
    Console.WriteLine($"A média aritmética é: {Math.Round(somaNota / n, 2)}");
    return somaNota;
}

static bool Procura(string item)
{
    return item.Contains("Amanda");
}

public class Aluno
{
    public string Nome { get; set; } = string.Empty;
    public double Nota { get; set; }

}

public class FonteDados
{
    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
        {

            new Aluno { Nome = "Maria", Nota = 8.75 },
            new Aluno { Nome = "Manuel", Nota = 6.95 },
            new Aluno { Nome = "Amanda", Nota = 7.25 },
            new Aluno { Nome = "Carlos", Nota = 6.55 },
            new Aluno { Nome = "Jaime", Nota = 8.50 },
            new Aluno { Nome = "Debora", Nota = 5.95 },
            new Aluno { Nome = "Alicia", Nota = 9.25 },
            new Aluno { Nome = "Sandra", Nota = 5.55 },
            new Aluno { Nome = "Marta", Nota = 7.85 },
            new Aluno { Nome = "Sueli", Nota = 9.15  },

        };


        return alunos;

        {


        }

    }
}