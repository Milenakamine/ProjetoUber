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

                
        }
    }
}
