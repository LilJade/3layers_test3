using System;
using Entitiy_layer;
using b_Business_layer;

namespace c_UI_layer
{
    class Program
    {
        static void Main(string[] args)
        {
            Entity_User user = new Entity_User();
            Business_User b_user = new Business_User();

            Console.WriteLine("Bienvenidos a clases de Refuerzo!\n" +
                "Regístrate.\n" +
                "Nombre: ");
            user.Name = Console.ReadLine();

            Console.WriteLine("Edad: ");
            user.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuál es tu color favorito?");
            user.Color = Console.ReadLine();

            if (b_user.mayorEdad(user) == true)
            {
                Console.WriteLine(user.Name + ", actualmente eres mayor de edad.");
            }
            else {
                Console.WriteLine(user.Name + ", actualmente eres menor de edad.");
            }

            Console.WriteLine("Dentro de 10 años tendrás " + b_user.sumarAños(user) + " años.");
        }
    }
}


//DateTime nacimiento = new DateTime(1999, 10, 20); //Fecha de nacimiento
//int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
//Console.WriteLine(edad);