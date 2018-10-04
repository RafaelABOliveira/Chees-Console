using System;
using tabuleiro;
using xadrez_console.tabuleiro;
using xadrez;

namespace xadrez_console {
    using System;
    using tabuleiro;
    using xadrez;

    class Program {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}
