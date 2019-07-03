using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class Circle : Figure
    {
        private float radius;

        public Circle(Form1 form1, Color color, int centerX, int centerY, float radius)
        {
            this.form1 = form1;
            this.pen = new Pen(color);
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
        }

        public override void DrawFigure()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(new SolidBrush(pen.Color), centerX - radius, centerY - radius, radius * 2, radius * 2);
        }

        public override string OutputFigureInfo()
        {
            return "Figure: Circle, square: " + GetSquare() + ", color: " + GetColor() + ", radius: " + GetRadius();
        }

        public override double GetSquare()
        {
            return Math.PI * radius * radius; // S = PI * r^2
        }

        private string GetRadius()
        {
            return radius.ToString();
        }
    }
}
