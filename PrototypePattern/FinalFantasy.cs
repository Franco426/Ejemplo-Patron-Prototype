using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    public class FinalFantasy: XboxGame
    {
        public FinalFantasy(string title)
        {
            Title = title;
        }

        public override XboxGame Clone()
        {
            return (FinalFantasy)this.MemberwiseClone();
        }
    }
}
