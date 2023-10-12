using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal class Figure        
    {
       
        
        static public List<Figure> figure_list = new();
        protected Program.Figure_Type _figure_type;
        protected ConsoleColor _figure_color;
        public char draw_with_char { get; set; } = '*';
        protected int _dimension1 = 0;
        protected int _dimension2 = 0;

        //protected Figure() { }
        //protected List<Figure> figure_list = new List<Figure>();       

        public virtual void DrawIt() { }
        public void DrawAll() 
        {
            Console.WriteLine();
            foreach (Figure figure in figure_list) 
            { figure.DrawIt(); }
        }
        public override string ToString()
        {
            return _figure_color + _figure_type.ToString();
        }


    }
}
