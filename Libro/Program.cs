string titulo;
string autor;
int año;
int opcion;
string categoria = "";

Console.Write("Ingrese el título del libro: ");
titulo = Console.ReadLine();

Console.Write("Ingrese el autor del libro: ");
autor = Console.ReadLine();

Console.Write("Ingrese el año de publicación: ");
año = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Seleccione la categoría:");
Console.WriteLine("1. Ciencia");
Console.WriteLine("2. Literatura");
Console.WriteLine("3. Tecnología");
Console.WriteLine("4. Historia");

opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        categoria = "Ciencia";
        break;
    case 2:
        categoria = "Literatura";
        break;
    case 3:
        categoria = "Tecnología";
        break;
    case 4:
        categoria = "Historia";
        break;
    default:
        categoria = "Categoría no válida";
        break;
}

Console.WriteLine("\nLibro registrado:");
Console.WriteLine("Título: " + titulo);
Console.WriteLine("Autor: " + autor);
Console.WriteLine("Año: " + año);
Console.WriteLine("Categoría: " + categoria);

