using calculadora.Models;

int opcao = 0;

while (opcao != 5)
{
    Console.WriteLine("\tCALCULADORA PADRAO");
    Console.WriteLine("ESCOLHA UMA DAS OPÇÕES ABAIXO:");
    Console.WriteLine("1 PARA SOMAR");
    Console.WriteLine("2 PARA SUBTRAIR");
    Console.WriteLine("3 PARA DIVIDIR");
    Console.WriteLine("4 PARA MULTIPLICAR");
    Console.WriteLine("5 PARA ENCERRAR");
    Console.Write("Digite uma das opções: ");
    opcao = Int32.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            float x = 0;
            float y = 0;
            Console.Write("Digite o primeiro termo da soma: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo termo da soma: ");
            y = float.Parse(Console.ReadLine());
            CalculadoraPadrao.Somar(x, y);
            break;
        case 2:
            Console.Write("Digite o primeiro termo da subtração: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo termo da subtração: ");
            y = float.Parse(Console.ReadLine());
            CalculadoraPadrao.Subtrair(x, y);
            break;
        case 3:
            Console.Write("Digite o primeiro termo da multiplicação: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo termo da multiplicação: ");
            y = float.Parse(Console.ReadLine());
            CalculadoraPadrao.Multiplicar(x, y);
            break;
        case 4:
            Console.Write("Digite o primeiro termo da divisão: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo termo da divisão: ");
            y = float.Parse(Console.ReadLine());
            CalculadoraPadrao.Dividir(x, y);
            break;
        default:
            if (opcao is not 5 or 0)
            {
                Console.WriteLine("Opção Inválida!");
            }
            break;
    }
}