///(Fernando Pretzantzin)

Console.WriteLine("Registrar prestamo");

// Estas variables deberían venir del sistema principal4
string titulo1 = "Clean Code";
bool prestado1 = false;

Console.WriteLine("Ingrese nombre de usuario");
string usuario = Console.ReadLine();

Console.WriteLine("Ingrese Titulo del libro");
string libro = Console.ReadLine();

if (libro == titulo1)
{
    if (prestado1 == true)
    {
        Console.WriteLine("Advertencia: El libro ya está prestado");
    }
    else
    {
        prestado1 = true;
        Console.WriteLine("Usuario: " + usuario);
        Console.WriteLine("Libro prestado: " + libro);
    }
}
else
{
    Console.WriteLine("El libro no existe");
}//