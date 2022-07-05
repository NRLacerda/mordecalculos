namespace Mordekalculos;

class Mordekalculadora1
{
    static bool Main(string[] arg)
    {
        //=================================================== 
        //           "A MATEMÁTICA SE MANTÉM ETERNA!"
        //            Mordekaiser, O revenã de ferro
        //===================================================
        //                    DECLARAÇÕES
        //===================================================

        int n1, n2, resultado;
        string nome, r1,a , b, c, d;

        //===================================================

        Console.WriteLine("Olá meu guerreiro, como é seu nome?");
#pragma warning disable CS8600 
        nome = Console.ReadLine();
        // CS8600 = Função para remover nulidade da variável
#pragma warning restore CS8600
        Console.Write("Tudo bem ");
        Console.Write(nome);
        Console.Write("?");
        Console.WriteLine(" Vamos fazer um cálculo ? (digite '1' para sim ou '0' para não");

#pragma warning disable CS8600 
        r1 = Console.ReadLine();

#pragma warning restore CS8600 
        if (r1 == "0")
        {
            Console.Write("");
            Console.Write("Até a próxima, guerreiro! ");
            Console.Write("");

            System.Environment.Exit(1);
        }
        else (r1 == "1")
        {
            Console.WriteLine("Qual tipo de cálculo deseja fazer?");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {n1} + {n2} = " + (n1 + n2));
                    break;
                case "b":
                    Console.WriteLine($"Your result: {n1} - {n2} = " + (n1 - n2));
                    break;
                case "c":
                    Console.WriteLine($"Your result: {n1} * {n2} = " + (n1 * n2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {n1} / {n2} = " + (n1 / n2));
                    break;
            }

        // Inserir caixa de seleção de tipo de cálculo
        Console.WriteLine("Deseja mais algo?");
        Console.WriteLine("Digite '1' para sim ou '0' para não");
    }
}