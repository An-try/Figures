using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class Square : Figure
    {
        private int sideLength;

        public Square(Form1 form1, Color color, int centerX, int centerY, int sideLength)
        {
            this.form1 = form1;
            this.pen = new Pen(color);
            this.centerX = centerX;
            this.centerY = centerY;
            this.sideLength = sideLength;
        }

        private Point[] SetPointPositions()
        {
            return new Point[4]
            {
                new Point(centerX - sideLength / 2, centerY + sideLength / 2),
                new Point(centerX + sideLength / 2, centerY + sideLength / 2),
                new Point(centerX + sideLength / 2, centerY - sideLength / 2),
                new Point(centerX - sideLength / 2, centerY - sideLength / 2)
            };
        }

        public override void DrawFigure()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawPolygon(Pens.Black, SetPointPositions());
            graphics.FillPolygon(new SolidBrush(pen.Color), SetPointPositions());
        }

        public override string OutputFigureInfo()
        {
            return "Figure: Square, square: " + GetSquare() + ", color: " + GetColor() + ", side length: " + GetSideLength();
        }

        public override double GetSquare()
        {
            return sideLength * sideLength;
        }

        private double GetSideLength()
        {
            return sideLength;
        }
    }
}
