using Aula;
using System;


namespace AulaPOOCelular
{
     class Program
    {
        static void Main(string[] args)
        {
           Celular iphone = new Celular();

            Console.WriteLine("Digite LIGAR para ligar o celular");
            switch(Console.ReadLine()){
                case "LIGAR":
                    iphone.Ligar();
                    break;
                default:
                    Console.WriteLine("Comando invalido, desligando...");
                    break;
            }

        }
    }
}