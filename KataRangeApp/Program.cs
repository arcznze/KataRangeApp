Console.WriteLine("Escribe un rango:");
string input = Console.ReadLine();
string sinput;
string resultado;
bool booleano;

Console.WriteLine("¿Qué desea hacer?");
Console.WriteLine("1. Get all points.");
Console.WriteLine("2. Get endpoints.");
Console.WriteLine("3. Contains.");
Console.WriteLine("4. Contains a range.");
Console.WriteLine("5. Equals.");
int opcion = int.Parse(Console.ReadLine());

KataRange.Range r1 = new KataRange.Range(input);

switch (opcion)
{
    case 1:
        resultado = r1.GetAllPoint(input);
        Console.WriteLine(resultado);
        break;
    case 2:
        resultado = r1.endPoints(input);
        Console.WriteLine(resultado);
        break;
    case 3:
        Console.WriteLine("Escriba un intervalo: ");
        sinput = Console.ReadLine();
        booleano = r1.Contains(input, sinput);
        Console.WriteLine(booleano);
        break;
    case 4:
        Console.WriteLine("Escriba un segundo rango: ");
        sinput = Console.ReadLine();
        booleano = r1.ContainsRange(input, sinput);
        Console.WriteLine(booleano);
        break;
    case 5:
        Console.WriteLine("Escriba un segundo rango a comparar: ");
        sinput = Console.ReadLine();
        booleano = r1.Equals(input, sinput);
        Console.WriteLine(booleano);
        break;
    default:
        Console.WriteLine("No ingresó una opción válida.");
        break;
}

