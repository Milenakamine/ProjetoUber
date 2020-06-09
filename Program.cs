using System;

namespace ProjetoUber
{
    class Program
    {
        static void Main(string[] args)
        {
                Passageiro milena = new Passageiro();
                System.Console.WriteLine("Digite seu Login");
                string login = Console.ReadLine();

                System.Console.WriteLine("Digite sua Senha");
                string senha = Console.ReadLine();

                 milena.Login(login, senha);
                 if(milena.TokenLogin != ""&& milena.TokenLogin !=null){
                    System.Console.WriteLine("Login autorizado");
                    System.Console.WriteLine(milena.TokenLogin);
                }else{
                    System.Console.WriteLine("Não é possível efetuar login");
                }

                
                Corrida corrida= new Corrida ();
                System.Console.WriteLine("Digite seu local de partida: ");
                string localInicio = Console.ReadLine();
                
                System.Console.WriteLine("Digite seu destino:");
                string localChegada = Console.ReadLine();
                System.Console.WriteLine("Solicitando motorista para " +localChegada );


                
                System.Console.WriteLine("O passageiro está solicitando uber para: " +localChegada+ " de: " +localInicio );
                string Motorista =  Console.ReadLine();
                 if(Motorista =="Aceitar" ){
                    System.Console.WriteLine("O motorista aceitou a corrida para " +localChegada);
             }else{
                    System.Console.WriteLine("O motorista recusou a corrida para: " +localChegada);
                }


      



              


                


        }
    }
}
