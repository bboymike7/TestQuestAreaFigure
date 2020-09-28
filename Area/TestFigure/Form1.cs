using System;
using System.Windows.Forms;

namespace TestFigure
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //квадрат
            if (textFigure.Text == "Cube")
            {
                if (double.TryParse(storona1.Text, out double proverka))
                {
                    label3.Visible = true;
                    result.Visible = true;

                    double i = Convert.ToDouble(storona1.Text);

                    AreaFigure CalculateCube = new AreaFigure();
                    result.Text = CalculateCube.CalculateCubeArea(i).ToString();
                }
            }
            //круг
            else if (textFigure.Text == "Circle")
            {
                if (double.TryParse(storona1.Text, out double proverka))
                {
                    label3.Visible = true;
                    result.Visible = true;

                    double r = Convert.ToDouble(storona1.Text);
                    AreaFigure CalculateCircle = new AreaFigure();
                    result.Text = CalculateCircle.CalculateCircleArea(r).ToString();
                }
            }

            //треугольник
            else if (textFigure.Text == "Triangle")
            {
                if (double.TryParse(storona1.Text, out double proverka))
                {
                    label3.Visible = true;
                    result.Visible = true;

                    double aSide = Convert.ToDouble(storona1.Text);
                    double bSide = Convert.ToDouble(storona1.Text);
                    double cSide = Convert.ToDouble(storona1.Text);
                    AreaFigure CalculateTriangle = new AreaFigure();
                    result.Text = CalculateTriangle.CalculateTriangleArea(aSide, bSide, cSide).ToString();
                }
            }

            else if (textFigure.Text == "")
            {
                MessageBox.Show("Введите название фигуры!");
            }

            else
            {
                MessageBox.Show("Введите корректное название фигуры!");
            }
        }

        private void proverkaText_Click(object sender, EventArgs e)
        {
            if (textFigure.Text == "Cube")
            {
                storona1.Visible = true;
                label2.Visible = true;
                button1.Visible = true;
            }

            else if (textFigure.Text == "Circle")
            {
                storona1.Visible = true;
                label2.Visible = true;
                button1.Visible = true;
            }

            else if (textFigure.Text == "Triangle")
            {
                storona1.Visible = true;
                storona2.Visible = true;
                storona3.Visible = true;
                label2.Visible = true;
                button1.Visible = true;
            }

            else if (textFigure.Text == "")
            {
                MessageBox.Show("Введите название фигуры!");
            }

            else
            {
                MessageBox.Show("Введите корректное название фигуры!");
            }
        }
    }
}
