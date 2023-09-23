using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;




namespace Proyecto_Objetos
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            using (Game game = new Game(1000, 500,"title")) {
                game.Run(60.0);

            }
        }
    }
}
