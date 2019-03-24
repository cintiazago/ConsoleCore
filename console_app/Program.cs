using System;
using GameTOP.Lib;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador1("Ronaldo"),
                new Jogador2()
            );
            jogo.IniciarJogo();
        }
    }   
}
