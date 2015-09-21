using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    public abstract class XboxGame
    {
        public string Title { get; set; }
        public string ProductKey { get; set; }
        public abstract XboxGame Clone();

        /// <summary>
        /// Returns a product key (E.G ABCDE-QWERQ-ASDTR-ASDQW)
        /// </summary>
        /// <returns></returns>
        public static string ProductKeyGeneration()
        {
            Random r = new Random();
            string productKey = "";

            for (int x = 0; x < 20; x++)
            {
                if (x % 5 == 0 && x != 0)
                {
                    productKey += "-";
                }
                productKey += (char)(r.Next(26) + 65);
            }

            return productKey;
        }
    }
}
