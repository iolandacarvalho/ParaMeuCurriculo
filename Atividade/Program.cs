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

return5:
Console.WriteLine("\nEm qual base numérica está o número que você deseja converter?");
Console.WriteLine("(Informe: 'D' para 'decimal', 'O' para 'octal', 'B' para 'binário' ou 'H' para 'Hexadecimal')\n");
Console.Write("R: ");
string bn1 = Console.ReadLine().ToLower();

if (bn1 == "d")
{
    return1:
    Console.Write("\nInforme o número que você gostaria de converter: ");
    if (!int.TryParse(Console.ReadLine(), out int n))
    {
        Console.WriteLine("\n - Valor inválido. Tente novamente.\n -");
        goto return1;
    }
    else
    {
        Console.WriteLine("\nPara qual base numérica você deseja converter esse número decimal?");
        Console.WriteLine("(Informe: 'D' para 'decimal', 'O' para 'octal', 'B' para 'binário' ou 'H' para 'Hexadecimal')\n");
        Console.Write("R: ");
        string bn2 = Console.ReadLine().ToLower();
    }
}
else if (bn1 == "o")
{
    return2:
    Console.Write("\nInforme o número que você gostaria de converter: ");
    if (!int.TryParse(Console.ReadLine(), out int n))
    {
        Console.WriteLine("\n - Valor inválido. Tente novamente.\n -");
        goto return2;
    }
    else
    {
        Console.WriteLine("\nPara qual base numérica você deseja converter esse número octal?");
        Console.WriteLine("(Informe: 'D' para 'decimal', 'O' para 'octal', 'B' para 'binário' ou 'H' para 'Hexadecimal')\n");
        Console.Write("R: ");
        string bn2 = Console.ReadLine().ToLower();
    }
}
else if (bn1 == "b")
{
    return3:
    Console.Write("\nInforme o número que você gostaria de converter: ");
    if (!int.TryParse(Console.ReadLine(), out int n))
    {
        Console.WriteLine("\n - Valor inválido. Tente novamente.\n -");
        goto return3;
    }
    else
    {
        Console.WriteLine("\nPara qual base numérica você deseja converter esse número binário?");
        Console.WriteLine("(Informe: 'D' para 'decimal', 'O' para 'octal', 'B' para 'binário' ou 'H' para 'Hexadecimal')\n");
        Console.Write("R: ");
        string bn2 = Console.ReadLine().ToLower();
    }
}
else if (bn1 == "h")
{
    return4:
    Console.Write("\nInforme o número que você gostaria de converter: ");
    if (!int.TryParse(Console.ReadLine(), out int n))
    {
        Console.WriteLine("\n - Valor inválido. Tente novamente.\n -");
        goto return4;
    }
    else
    {
        Console.WriteLine("\nPara qual base numérica você deseja converter esse número hexadecimal?");
        Console.WriteLine("(Informe: 'D' para 'decimal', 'O' para 'octal', 'B' para 'binário' ou 'H' para 'Hexadecimal')\n");
        Console.Write("R: ");
        string bn2 = Console.ReadLine().ToLower();
    }
}
else
{
    Console.WriteLine("\n - Valor inválido. Tente novamente.\n -");
    goto return5;
}
