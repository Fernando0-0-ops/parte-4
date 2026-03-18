// Sistema de Gestión de Biblioteca

Console.WriteLine("=== SISTEMA DE BIBLIOTECA ===");

// Variables
string titulo = "";
string autor = "";
int año = 0;
string categoria = "";
bool prestado = false;

int opcionMenu;

do
{
    Console.WriteLine("\nMENU");
    Console.WriteLine("1. Registrar libro");
    Console.WriteLine("2. Mostrar libros registrados");
    Console.WriteLine("3. Buscar libro por título");
    Console.WriteLine("4. Registrar préstamo");
    Console.WriteLine("5. Devolver libro");
    Console.WriteLine("6. Salir");
    Console.Write("Seleccione una opción: ");
    opcionMenu = Convert.ToInt32(Console.ReadLine());

    switch (opcionMenu)
    {
        case 1:
            // REGISTRAR LIBRO (tu último código)
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

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: categoria = "Ciencia"; break;
                case 2: categoria = "Literatura"; break;
                case 3: categoria = "Tecnología"; break;
                case 4: categoria = "Historia"; break;
                default: categoria = "Categoría no válida"; break;
            }

            prestado = false;

            Console.WriteLine("\nLibro registrado:");
            Console.WriteLine("Título: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Año: " + año);
            Console.WriteLine("Categoría: " + categoria);
            break;

        case 2:
            // MOSTRAR LIBRO
            Console.WriteLine("\nLista de libros registrados\n");

            if (titulo != "")
            {
                Console.WriteLine("Titulo: " + titulo);
                Console.WriteLine("Autor: " + autor);
                Console.WriteLine("Categoria: " + categoria);
            }
            else
            {
                Console.WriteLine("No hay libros registrados");
            }
            break;

        case 3:
            // BUSCAR LIBRO (con FOR)
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("_Buscador de Libros_");
            Console.Write("Ingrese el título del libro: ");
            string tituloBuscar = Console.ReadLine();

            bool encontrado = false;

            for (int i = 0; i < 1; i++)
            {
                if (tituloBuscar.ToLower() == titulo.ToLower())
                {
                    Console.WriteLine("Libro encontrado");
                    Console.WriteLine("Autor: " + autor);
                    Console.WriteLine("Categoría: " + categoria);
                    encontrado = true;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("El libro no existe en la biblioteca");
            }

            Console.WriteLine("----------------------------------------------------");
            break;

        case 4:
            // REGISTRAR PRÉSTAMO
            Console.WriteLine("Registrar préstamo");

            Console.Write("Ingrese nombre de usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Ingrese título del libro: ");
            string libro = Console.ReadLine();

            if (libro.ToLower() == titulo.ToLower())
            {
                if (prestado == true)
                {
                    Console.WriteLine("Advertencia: El libro ya está prestado");
                }
                else
                {
                    prestado = true;
                    Console.WriteLine("Usuario: " + usuario);
                    Console.WriteLine("Libro prestado: " + libro);
                }
            }
            else
            {
                Console.WriteLine("El libro no existe");
            }
            break;

        case 5:
            // DEVOLVER LIBRO
            Console.WriteLine("Devolver libro");

            Console.Write("Ingrese título del libro: ");
            string devolver = Console.ReadLine();

            if (devolver.ToLower() == titulo.ToLower())
            {
                if (prestado == true)
                {
                    prestado = false;
                    Console.WriteLine("Libro devuelto correctamente");
                }
                else
                {
                    Console.WriteLine("El libro no estaba prestado");
                }
            }
            else
            {
                Console.WriteLine("El libro no existe");
            }
            break;

        case 6:
            Console.WriteLine("Saliendo del sistema...");
            break;

        default:
            Console.WriteLine("Opción inválida");
            break;
    }

} while (opcionMenu != 6);