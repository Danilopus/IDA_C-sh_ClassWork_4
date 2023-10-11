using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal class Circle : Figure
    {
        override public void DrawIt()
        {
          Console.ForegroundColor = _figure_color;

            Console.WriteLine("         *        ");
            Console.WriteLine("      *     *     ");
            Console.WriteLine("   *           *   ");
            Console.WriteLine("                   ");
            Console.WriteLine(" *               *  ");
            Console.WriteLine("                    ");
            Console.WriteLine("   *           *    ");
            Console.WriteLine("      *     *      ");
            Console.WriteLine("         *         ");

            Console.ForegroundColor = ConsoleColor.White;

        }
        public Circle(ConsoleColor figure_color) 
        {
            _figure_type = Program.Figure_Type.Circle;
            _figure_color = figure_color;
            figure_list.Add(this);
            _dimension1 = 5;
        }
    }
}
