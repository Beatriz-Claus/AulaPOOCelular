using System;

namespace Aula
{
    public class Celular
    {
        //propriedades
        public string modelo= "Iphone";
        public string tipo="11";


         
        public bool ligado= false;

        public void Ligar(){
            Console.WriteLine("Ligando celular");
            ligado=true;
            while(ligado){
                Console.WriteLine("1- ENVIAR MENSAGEM \n2- FAZER LIGAÇAO \n3- DESLIGAR");
                char resposta= char.Parse(Console.ReadLine());
                switch(resposta){
                    case '1':
                        Console.WriteLine("Digite sua mensagem:");
                        Mensagem(Console.ReadLine());
                        break;
                    case '2':
                        Console.WriteLine("Digite o numero para ligaçao");
                        Ligar(Console.ReadLine());
                        break;
                    case '3':
                        
                        Desligar();
                        break;

                    default:
                        Console.WriteLine("Comando invalido");
                        break;
                }
            };
        }

      


        public void Desligar(){
            Console.WriteLine("Desligando");
            ligado=false;
        }


        public void Mensagem(string msg){
            Console.WriteLine("Sua mensagem :{0}",msg);   
        }
        public void Ligar(string numb){
            Console.WriteLine("Ligando para: {0}",numb);
        }
        
        
    }
}
