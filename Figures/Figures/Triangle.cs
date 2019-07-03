using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class Triangle : Figure
    {
        private Point pointA;
        private Point pointB;
        private Point pointC;

        double sideAB;
        double sideBC;
        double sideCA;

        public Triangle(Form1 form1, Color color, int centerX, int centerY)
        {
            this.form1 = form1;
            this.pen = new Pen(color);
            this.centerX = centerX;
            this.centerY = centerY;
        }

        private Point[] SetPointPositions()
        {
            Random rnd = new Random();

            Point[] points = new Point[3]
            {
                new Point(centerX + rnd.Next(10, 31), centerY),
                new Point(centerX - rnd.Next(5, 16), centerY + rnd.Next(10, 31)),
                new Point(centerX - rnd.Next(5, 16), centerY - rnd.Next(10, 31))
            };

            pointA = points[0];
            pointB = points[1];
            pointC = points[2];

            SetSidesLength();
            
            return points;
        }

        private void SetSidesLength()
        {
            // side = sqrt((X2 - X1)^2 + (Y2 - Y1)^2)
            sideAB = Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
            sideBC = Math.Sqrt(Math.Pow(pointC.X - pointB.X, 2) + Math.Pow(pointC.Y - pointB.Y, 2));
            sideCA = Math.Sqrt(Math.Pow(pointC.X - pointA.X, 2) + Math.Pow(pointC.Y - pointA.Y, 2));
        }

        public override void DrawFigure()
        {
            Graphics graphics = form1.CreateGraphics();

            Point[] points = SetPointPositions();
            graphics.DrawPolygon(Pens.Black, points);
            graphics.FillPolygon(new SolidBrush(pen.Color), points);
        }

        public override string OutputFigureInfo()
        {
            return "Figure: Triangle, square: " + GetSquare() + ", color: " + GetColor();
        }

        public override double GetSquare()
        {
            // Heron's formula
            // p = (A + B + C) / 2;
            // S = sqrt(p * (p - A) * (p - B) * (p - C));
            
            double p = (sideAB + sideBC + sideCA) / 2;

            double square = Math.Sqrt(p * (p - sideAB) * (p - sideBC) * (p - sideCA));

            return square;
        }
    }
}
