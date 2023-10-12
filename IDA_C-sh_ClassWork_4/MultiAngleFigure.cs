using IDA_C_sh_ClassWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_4
{
    internal class MultiAngleFigure : Figure
    {
        public MultiAngleFigure(ConsoleColor figure_color)
        {
            _figure_type = Program.Figure_Type.MultiAngleFigure;
            _figure_color = figure_color;
            _dimension1 = 3;
            _dimension2 = 5;
            figure_list.Add(this);
        }
        override public void DrawIt()
        {
            Console.ForegroundColor = _figure_color;

            Console.WriteLine("      *******     ");
            Console.WriteLine("    *         *   ");
            Console.WriteLine("  *             * ");
            Console.WriteLine("  *             * ");
            Console.WriteLine("  *             * ");
            Console.WriteLine("    *         *   ");
            Console.WriteLine("      *******     ");

            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
