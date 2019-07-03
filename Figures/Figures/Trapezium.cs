using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class Trapezium : Figure
    {
        private Point pointA;
        private Point pointB;
        private Point pointC;
        private Point pointD;

        double sideAB;
        double sideBC;
        double sideCD;
        double sideDA;

        public Trapezium(Form1 form1, Color color, int centerX, int centerY)
        {
            this.form1 = form1;
            this.pen = new Pen(color);
            this.centerX = centerX;
            this.centerY = centerY;
        }

        private Point[] SetPointPositions()
        {
            Random rnd = new Random();
            int trapeziumHeight = rnd.Next(10, 21);

            Point[] points = new Point[4]
            {
                new Point(centerX - rnd.Next(20, 31), centerY + trapeziumHeight),
                new Point(centerX + rnd.Next(20, 31), centerY + trapeziumHeight),
                new Point(centerX + rnd.Next(15, 21), centerY - trapeziumHeight),
                new Point(centerX - rnd.Next(15, 21), centerY - trapeziumHeight)
            };

            pointA = points[0];
            pointB = points[1];
            pointC = points[2];
            pointD = points[3];

            SetSidesLength();
            
            return points;
        }

        private void SetSidesLength()
        {
            // side = sqrt((X2 - X1)^2 + (Y2 - Y1)^2)
            sideAB = Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
            sideBC = Math.Sqrt(Math.Pow(pointC.X - pointB.X, 2) + Math.Pow(pointC.Y - pointB.Y, 2));
            sideCD = Math.Sqrt(Math.Pow(pointD.X - pointC.X, 2) + Math.Pow(pointD.Y - pointC.Y, 2));
            sideDA = Math.Sqrt(Math.Pow(pointA.X - pointD.X, 2) + Math.Pow(pointA.Y - pointD.Y, 2));
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
            return "Figure: Trapezium, square: " + GetSquare() + ", color: " + GetColor() + ", trapezoid height: " + GetTrapezoidHeight();
        }

        public override double GetSquare()
        {
            // S = 1/2 * (A + B) * h
            double square = 0.5 * (sideAB + sideBC) * GetTrapezoidHeight();

            return square;
        }

        private double GetTrapezoidHeight()
        {
            // h = sqrt(C^2 - (((A - B)^2 + C^2 - D^2) / (2 * (A - B))^2)
            double h = Math.Sqrt(sideCD * sideCD - Math.Pow((Math.Pow(sideAB - sideBC, 2) + sideCD * sideCD - sideDA * sideDA) / (2 * (sideAB - sideBC)), 2));

            return h;
        }
    }
}
