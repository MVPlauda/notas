internal class program
{
    private static void Main(string[] args)
    {
        float nota1, nota2, nota3, nota4, soma, media;

        Console.Write("Digite a nota do primeiro bimestre: ");
        nota1 = float.Parse(Console.ReadLine());
        Console.Write("Digite a nota do segundo bimestre: ");
        nota2 = float.Parse(Console.ReadLine());
        Console.Write("Digite a nota do terceiro bimestre: ");
        nota3 = float.Parse(Console.ReadLine());
        Console.Write("Digite a nota do quarto bimestre: ");
        nota4 = float.Parse(Console.ReadLine());


        soma = nota1 + nota2 + nota3 + nota4;
        media = soma / 4;

        Console.Write($"a media dos quarto bimestres é: {media}");

    }
}

