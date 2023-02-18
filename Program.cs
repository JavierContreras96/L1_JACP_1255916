internal class Program
{
    private static void Main(string[] args)
    {
        NewMethod();

        static void NewMethod()
        {
            Console.WriteLine("Ingrese su nombre: ");
            string Nombre = Console.ReadLine();


            Console.WriteLine("Hola mundo, soy Javier Contreras");
            Console.ReadKey();

            /*COMENTARIOS*/

            Console.Write("Hola mundo,");
            Console.Write("Soy Javier Contreras");
            Console.ReadKey();

            Console.Write("Hola mundo ");
            Console.Write("Soy " + Nombre);
            Console.ReadKey();


            Console.WriteLine("MI SEGUNDO PROGRAMA");

            
            string sNombre = Console.ReadLine();
            string sEdad = Console.ReadLine();
            string sCarrera = Console.ReadLine();
            string sCarné = Console.ReadLine();

            Console.WriteLine("Soy " + Nombre);
            Console.WriteLine("Tengo " + sEdad);
            Console.WriteLine("Estudio" + sCarrera);
            Console.WriteLine("Soy carné número" + sCarné);
            
            Console.ReadKey();
        }|else| 
    }
}