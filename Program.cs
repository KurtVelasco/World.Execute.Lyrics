using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Execute.Lyrics_Me_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextAnimation.AnimateText("Kurt Velasco", "iS ME:", "RED", 10);
            TextAnimation.SimulateLoading(" Done",500, 20);
            Console.ReadKey();
        }
    }
}
