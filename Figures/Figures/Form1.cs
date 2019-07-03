using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class Form1 : Form
    {
        private int starterCenterX = 250;
        private int starterCenterY = 100;

        private List<KnownColor> knownColors;

        private List<Figure> figuresList = new List<Figure>();

        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get only Microsoft colors and not the colors defined by the OS theme
            knownColors = Enum.GetValues(typeof(KnownColor)).Cast<KnownColor>().Where(color => !Color.FromKnownColor(color).IsSystemColor).ToList();

            OutputInfo.Text = null;
        }

        private KnownColor GetRandomColor()
        {
            return knownColors[rnd.Next(0, knownColors.Count)];
        }

        private void CreateSquare()
        {
            Color randomColor = Color.FromKnownColor(GetRandomColor());
            int randomSideLength = rnd.Next(20, 31);

            Square square = new Square(this, randomColor, starterCenterX, starterCenterY, randomSideLength);
            square.DrawFigure();
            figuresList.Add(square);

            starterCenterX += 50;
        }

        private void CreateTriangle()
        {
            Color randomColor = Color.FromKnownColor(GetRandomColor());

            Triangle triangle = new Triangle(this, randomColor, starterCenterX, starterCenterY);
            triangle.DrawFigure();
            figuresList.Add(triangle);

            starterCenterX += 50;
        }

        private void CreateCircle()
        {
            Color randomColor = Color.FromKnownColor(GetRandomColor());
            int randomRadius = rnd.Next(10, 21);

            Circle circle = new Circle(this, randomColor, starterCenterX, starterCenterY, randomRadius);
            circle.DrawFigure();
            figuresList.Add(circle);

            starterCenterX += 50;
        }

        private void CreateTrapezium()
        {
            Color randomColor = Color.FromKnownColor(GetRandomColor());

            Trapezium trapezium = new Trapezium(this, randomColor, starterCenterX, starterCenterY);
            trapezium.DrawFigure();
            figuresList.Add(trapezium);

            starterCenterX += 50;
        }

        private void OutputCreatedFiguresInfo()
        {
            foreach (Figure figure in figuresList)
            {
                OutputInfo.Text += figure.OutputFigureInfo() + "\n\n";
            }
        }

        private void GenerateFiguresButton_Click(object sender, EventArgs e)
        {
            OutputInfo.Text = null;
            figuresList.Clear();

            int numbersOfFigures = rnd.Next(1, 16);
            Thread.Sleep(50);

            for (int i = 0; i < numbersOfFigures; i++)
            {
                int randomFigure = rnd.Next(1, 5);

                switch (randomFigure)
                {
                    case 1:
                        CreateSquare();
                        break;
                    case 2:
                        CreateTriangle();
                        break;
                    case 3:
                        CreateCircle();
                        break;
                    case 4:
                        CreateTrapezium();
                        break;
                    default:
                        break;
                }

                Thread.Sleep(50);
            }

            starterCenterX = 250;
            starterCenterY += 100;

            OutputCreatedFiguresInfo();
        }
    }
}
