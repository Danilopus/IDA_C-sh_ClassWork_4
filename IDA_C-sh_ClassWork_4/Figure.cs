using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal class Figure        
    {
        static public List<Figure> figure_list;
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
        foreach (Figure figure in figure_list) 
            { figure.DrawIt(); }
        }
        protected void DrawLine (int x1, int y1, int x2, int y2) 
        { }

    }
}
