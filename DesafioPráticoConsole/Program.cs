using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesafioPraticoConsole;
internal class Program
{
    static void Main() 
    {
        //Exercicio1();
        //Exercicio2();
        // Exercicio3();
        //Exercicio4();
        //Exercicio5();
        Exercicio6();
    }

    static void Exercicio1()
    {
        Console.WriteLine("Digite um nome:");
        var Nome = Console.ReadLine();
        Console.WriteLine($"Olá, {Nome}! Seja muito bem-vindo!");
    }

    static void Exercicio2()
    { 
        Console.WriteLine("Informe um nome:");
        string Nome = Console.ReadLine();
        Console.WriteLine("Informe o sobrenome:");
        string Sobrenome = Console.ReadLine();
        Console.WriteLine(Nome + " " + Sobrenome);
    }

    static void Exercicio3()
    {
        Console.WriteLine("Digite o primeiro valor:");
        double Valor1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        double Valor2 = Convert.ToDouble(Console.ReadLine()); 
        
        var Soma = Valor1 + Valor2;
        Console.WriteLine("Soma = " + Soma);
        
        var Subtracao = Valor1 - Valor2;
        Console.WriteLine("Subtração = " + Subtracao);

        var Multiplicacao = Valor1 * Valor2;
        Console.WriteLine("Multiplicação = " + Multiplicacao);

        if (Valor2 != 0)
        {
            var divisao = Valor1 / Valor2;
            Console.WriteLine("Divisão = " + divisao);
        }
        else
        {
            Console.WriteLine("O Segundo valor deve ser diferente de zero.");
        }

        var Media = (Valor1 + Valor2) / 2;
        Console.WriteLine("Média = " + Media);
    }

    static void Exercicio4()
    {
        Console.WriteLine("Digite uma palavra, para exibir a quantidade de caracteres:");
        var Palavra = Console.ReadLine();
        int QuantidadeCaracteres = Palavra.Replace(" ", "").Length;
        Console.WriteLine("Quantidade de caracteres = " + QuantidadeCaracteres);
    }

    static void Exercicio5()
    {
        Console.WriteLine("Informe a placa do veículo:");
        string placaVeiculo = Console.ReadLine();

        if (ValidarPlaca(placaVeiculo))
        {
            Console.WriteLine("A placa é válida!");
        }
        else
        {
            Console.WriteLine("A placa não é válida!");
        }      
    }

    static bool ValidarPlaca(string placa)
    {
        placa = placa.Trim().ToUpper();
        if (placa.Length != 7)
            return false;

        for (int i = 0; i < 3; i++)
        {
            if (!Char.IsLetter(placa[i]))
                return false;
        }

        for (int i = 3; i < 7; i++)
        {
            if (!Char.IsDigit(placa[i]))
                return false;
        }

        return true;
    }

    static void Exercicio6()
    {
        DateTime agora = DateTime.Now;

        Console.WriteLine("Escolha o formato de exibição da data:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato dd/MM/yyyy");
        Console.WriteLine("3 - Apenas a hora (formato 24h)");
        Console.WriteLine("4 - Data com o mês por extenso");

        Console.Write("Digite a opção desejada (1 a 4): ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR")));
                break;
            case "2":
                Console.WriteLine(agora.ToString("dd/MM/yyyy"));
                break;
            case "3":
                Console.WriteLine(agora.ToString("HH:mm"));
                break;
            case "4":
                Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}