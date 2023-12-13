using System;

class Program
{
    static void Main()
    {
        bool salir = false;

        do
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Seleccionaste el Ejercicio 1");
                    calculos();
                    break;

                case "2":
                    Console.WriteLine("Seleccionaste el Ejercicio 2");
                    edad();
                    break;

                case "3":
                    Console.WriteLine("Seleccionaste el Ejercicio 3");
                    MostrarInformacionEstudiante();
                    break;
                
                 case "4":
                    Console.WriteLine("Seleccionaste el Ejercicio 4");
                    MostrarInformacionEstudiante_ampliado();
                    break;
                
                 case "5":
                    Console.WriteLine("Seleccionaste el Ejercicio 5");
                    MostrarInformacionEstudianteGraduado();
                    break;
                case "6":
                    Console.WriteLine("Saliendo del programa...");
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                    break;
            }

            // Espera a que el usuario presione una tecla antes de volver al menú
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            Console.Clear(); // Limpia la consola para el próximo ciclo

        } while (!salir);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Menú:");
        Console.WriteLine("1. Ejercicio 1");
        Console.WriteLine("2. Ejercicio 2");
        Console.WriteLine("3. Ejercicio 3");
        Console.WriteLine("4. Ejercicio 4");
        Console.WriteLine("5. Ejercicio 5");
        Console.WriteLine("6. Salir");
        Console.Write("Selecciona una opción: ");
    }

    static void calculos(){
        
        int numero1 = (100); 
        int numero2 = (20);
        Operaciones operaciones = new Operaciones();
        int resultado = operaciones.Sumar(numero1, numero2);

        // Imprimir los números y la respuesta
        Console.WriteLine($"Número 1: {numero1}");
        Console.WriteLine($"Número 2: {numero2}");
        Console.WriteLine($"Resultado: {resultado}"); 

    }
    static void edad(){

        int edad_persona=(19);
        if (edad_persona>=18){
            Console.WriteLine("la persoan es mayor a 18");
        }
        else{

            Console.WriteLine("La persona no es mayor a 18");
        }
    }

     static void MostrarInformacionEstudiante()
    {
        Estudiante estudiante1 = new Estudiante
        {
            Nombre = "Daniel",
            Edad = 29,
            Calificacion = 32
        };

        Console.WriteLine("Información del Estudiante:");
        Console.WriteLine($"Nombre: {estudiante1.Nombre}");
        Console.WriteLine($"Edad: {estudiante1.Edad}");
        Console.WriteLine($"Calificación: {estudiante1.Calificacion}");
    }
    static void MostrarInformacionEstudiante_ampliado()
    {
        Estudiante estudiante2 = new Estudiante
        {
            Nombre = "Alexander",
            Edad = 20,
            Calificacion = 85.5
        };

       estudiante2.ampliado();
    }

 static void MostrarInformacionEstudianteGraduado()
    {
        EstudianteGraduado estudianteGraduado3 = new EstudianteGraduado
        {
            Nombre = "Mateo",
            Edad = 25,
            Calificacion = 92.3,
            Titulo = "Licenciatura en Informática"
        };
        estudianteGraduado3.graduado();
    }

}
public class Operaciones{
 public int Sumar(int a, int b)
    {
        return a + b;
    }
}

public class Estudiante{
    public string Nombre{get;set;} 
    public int Edad{get;set;}
    public double Calificacion{get;set;}
    public void ampliado()
    {
        Console.WriteLine("Información del Estudiante:");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Calificación: {Calificacion}");
    }
    


}

public class EstudianteGraduado:Estudiante{

    public string Titulo{get;set;}
      public void graduado()
    {
        Console.WriteLine("Información del Estudiante:");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Calificación: {Calificacion}");
        Console.WriteLine($"Titulo: {Titulo}");
    }
}

