using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            XboxGame xg = new Halo("Halo 4") { ProductKey = "00000-00000-00000-00000" }; // ORIGINAL COPY OF HALO
            XboxGame xg2 = new FinalFantasy("Final Fantasy X") { ProductKey = "00000-00000-00000-00000" }; // ORIGINAL COPY
            XboxGame gameCopy;

            for (int x = 0; x < 5; x++)
            {
                Thread.Sleep(2000);
                gameCopy = xg.Clone();
                gameCopy.ProductKey = XboxGame.ProductKeyGeneration();
                Console.WriteLine("Game Title: {0} Product Key: {1}", gameCopy.Title, gameCopy.ProductKey);

                Thread.Sleep(2000);
                gameCopy = xg2.Clone();
                gameCopy.ProductKey = XboxGame.ProductKeyGeneration();
                Console.WriteLine("Game Title: {0} Product Key: {1}", gameCopy.Title, gameCopy.ProductKey);
            }

            Console.ReadKey();

        }
    }
}
