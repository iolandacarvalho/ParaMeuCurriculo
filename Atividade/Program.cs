// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine("=".PadLeft(32, '='));
Console.WriteLine("- CONVERSOR DE BASES NUMÉRICAS -");
Console.WriteLine("=".PadLeft(32, '='));
Console.ResetColor();

Console.WriteLine("\n- Conversões possíveis -\n");
Console.WriteLine("-".PadLeft(24, '-'));
Console.WriteLine("Decimal -> Binário");
Console.WriteLine("Decimal -> Hexadecimal");
Console.WriteLine("Decimal -> Octal");
Console.WriteLine("-".PadLeft(24, '-'));
Console.WriteLine("Binário -> Decimal");
Console.WriteLine("Binário -> Hexadecimal");
Console.WriteLine("Binário -> Octal");
Console.WriteLine("-".PadLeft(24, '-'));
Console.WriteLine("Hexadecimal -> Decimal");
Console.WriteLine("Hexadecimal -> Binário");
Console.WriteLine("Hexadecimal -> Octal");
Console.WriteLine("-".PadLeft(24, '-'));
Console.WriteLine("Octal -> Decimal");
Console.WriteLine("Octal -> Binário");
Console.WriteLine("Octal -> Hexadecimal");
Console.WriteLine("-".PadLeft(24, '-'));

return1:
Console.WriteLine("\nEm qual base numérica está o número que você deseja converter?");
Console.WriteLine("(Informe: 'D' para 'decimal', 'O' para 'octal', 'B' para 'binário' ou 'H' para 'Hexadecimal')\n");
Console.Write("R: ");
string bn1 = Console.ReadLine().ToLower();

switch (bn1)
{
case "d":
    return2:
    Console.Write("\nInforme o número decimal: ");
    if (!int.TryParse(Console.ReadLine(), out int nd))
    {
        Console.WriteLine("\n - Valor inválido. Tente novamente.\n -");
        goto return2;
    }
    else
    {
        return6:
        Console.WriteLine("\nPara qual base numérica você deseja converter esse número decimal?");
        Console.WriteLine("(Informe: 'O' para 'octal', 'B' para 'binário' ou 'H' para 'Hexadecimal')\n");
        Console.Write("R: ");
        string bn2 = Console.ReadLine().ToLower();
        
        switch (bn2)
        {
            case "o":
                int[] restos = new int[30];
                int cont = 0;
                while (nd / 8 < 1)
                {
                    
                }
                break;

            case "b":
                
                break;

            case "h":
                string resultdh = nd.ToString("X");
                Console.WriteLine($"O número decimal {nd} convertido para hexadecimal se torna {resultdh}.");
                Console.WriteLine($"{nd} -> {resultdh}");
                break;

            default:

                goto return6;
                break;
        }
    }
    break;
case "o":
    return3:
    Console.Write("\nInforme o número que você gostaria de converter: ");
    if (!int.TryParse(Console.ReadLine(), out int no))
    {
        Console.WriteLine("\n - Valor inválido. Tente novamente.\n -");
        goto return3;
    }
    else
    {
        return7:
        Console.WriteLine("\nPara qual base numérica você deseja converter esse número octal?");
        Console.WriteLine("(Informe: 'D' para 'decimal', 'B' para 'binário' ou 'H' para 'Hexadecimal')\n");
        Console.Write("R: ");
        string bn2 = Console.ReadLine().ToLower();
        switch (bn2)
        {
            case "d":

                break;

            case "b":

                break;

            case "h":

                break;
                
            default:

                goto return7;
                break;
        }
    }
    break;
case "b":
    return4:
    Console.Write("\nInforme o número que você gostaria de converter: ");
    if (!int.TryParse(Console.ReadLine(), out int nb))
    {
        Console.WriteLine("\n - Valor inválido. Tente novamente.\n -");
        goto return4;
    }
    else
    {
        return8:
        Console.WriteLine("\nPara qual base numérica você deseja converter esse número binário?");
        Console.WriteLine("(Informe: 'D' para 'decimal', 'O' para 'octal' ou 'H' para 'Hexadecimal')\n");
        Console.Write("R: ");
        string bn2 = Console.ReadLine().ToLower();
        switch (bn2)
        {
            case "d":

                break;

            case "o":

                break;

            case "h":

                break;
                
            default:

                goto return8;
                break;
        }
    }
    break;
case "h":
    return5:
    Console.Write("\nInforme o número que você gostaria de converter: ");
    if (!int.TryParse(Console.ReadLine(), out int nh))
    {
        Console.WriteLine("\n - Valor inválido. Tente novamente.\n -");
        goto return5;
    }
    else
    {
        return9:
        Console.WriteLine("\nPara qual base numérica você deseja converter esse número hexadecimal?");
        Console.WriteLine("(Informe: 'D' para 'decimal', 'O' para 'octal' ou 'B' para 'binário')\n");
        Console.Write("R: ");
        string bn2 = Console.ReadLine().ToLower();
        switch (bn2)
        {
            case "d":

                break;

            case "o":

                break;

            case "b":

                break;

            default:

                goto return9;
                break;
        }
    }
    break;
default:
    Console.WriteLine("\n - Valor inválido. Tente novamente.\n -");
    goto return1;
    break;
}
