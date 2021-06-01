using System;
namespace jogador
{
    interface game
    {
       void jogador();  
    }
    public class jogador : game
    {
       void game.jogador()
        {
            Console.WriteLine("jogador press enter");
            Console.ReadKey();
            Console.WriteLine("jogo iniciado");
        }
    }
}