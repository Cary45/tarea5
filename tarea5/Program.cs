var respuesta = "S";

while (respuesta.ToUpper() != "N")
{
    //1-Borrar pantalla
    Console.Clear();

    //2-Pedir el nombre de la persona
    Console.WriteLine("Buen dia! Ingrese su nombre:");
    var nombre = Console.ReadLine();

    //3-Saludar con un texto "¡Hola [nombreIngresado]!"
    Console.WriteLine("¡Hola " + nombre + "!");

    //4-Preguntar si desea continuar
    Console.WriteLine("Desea continuar? S/N");

    respuesta = Console.ReadLine();

    if (respuesta.ToUpper() == "N")
    {
        Console.WriteLine("Programa terminado correctamente");
    }else if (respuesta.ToUpper() != "N" && respuesta.ToUpper() != "S")
    {

        Console.WriteLine("Opcion no valida");
    }
}

