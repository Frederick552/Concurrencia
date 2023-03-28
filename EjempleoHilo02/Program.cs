
public class EjemploHilo02
{
   public static void Main()
    {
        // Instancias el objeto thread / hilo y 
        // colocamos el delegado que corresponde
        Thread hilo1 = new Thread(Mensaje);
        hilo1.Start();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Mensaje desde main");
        Thread hilo2 = new Thread(Mensaje);
        hilo2.Start(6);
    }

    //Creamos el metodo que se ejecutara en el segundo hilo
    // Debe cincidir con el delegado

    private static void Mensaje(object? obj)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Mensaje desde el hilo");
    }

    // Este metodo se ejecuta en el segundo hilo
    // Y recibe un parametro del exterior
    private static void MensajeConParametro(object? obj)
    {
        int p = Convert.ToInt32(obj);
        Console.WriteLine("Mensaje con parametro {0}{1}", p);
    }
   


}

