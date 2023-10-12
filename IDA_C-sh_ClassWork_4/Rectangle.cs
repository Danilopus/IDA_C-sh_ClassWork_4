﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IDA_C_sh_ClassWork.Program;
using System.Xml.Linq;

namespace IDA_C_sh_ClassWork
{
    internal class Rectangle : Figure
    {
        public Rectangle(ConsoleColor figure_color)
        { 
            _figure_type = Program.Figure_Type.Rectangle;
            _figure_color = figure_color;
            _dimension1 = 3;
            _dimension2 = 5;
            figure_list.Add(this);
        }

        override public void DrawIt()
        {
            Console.ForegroundColor = _figure_color;

            Console.WriteLine("  *************** ");
            Console.WriteLine("  *             * ");
            Console.WriteLine("  *             * ");
            Console.WriteLine("  *             * ");
            Console.WriteLine("  *             * ");
            Console.WriteLine("  *             * ");
            Console.WriteLine("  *************** ");

            Console.ForegroundColor = ConsoleColor.White;

        }

        

    }
}
