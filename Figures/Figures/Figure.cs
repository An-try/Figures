using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    abstract class Figure
    {
        public Form1 form1;

        public Pen pen;

        public int centerX;
        public int centerY;
        
        public abstract void DrawFigure();
        public abstract string OutputFigureInfo();
        public abstract double GetSquare();

        public string GetColor()
        {
            return pen.Color.ToString();
        }
    }
}
