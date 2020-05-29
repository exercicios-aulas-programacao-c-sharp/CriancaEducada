using System;

/*
[console: CriancaEducada] Solicite que o usuário digite uma frase. Substitua as palavras da lista por uma sequência de símbolos (como #@$%*!&, por exemplo).
chato/chata, bobo/boba, feio/feia, boboca, bocó, tonto/tonta, palerma, paspalho/paspalha, tantã, panaca, pentelho/pentelha, burro/burra, besta
*/

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string fraseFinal;
            
            Console.WriteLine("Me diga o que você pensa sobre o aluno que não faz a lição de casa:");

            frase = Console.ReadLine();

            fraseFinal = frase.ToLower()
                              .Replace("chato", "#@$%*!&")
                              .Replace("chata", "#@$%*!&")
                              .Replace("bobo", "#@$%*!&")
                              .Replace("boba", "#@$%*!&"); 

            Console.WriteLine(fraseFinal); 

        }
    }
}
