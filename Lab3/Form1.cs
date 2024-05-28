using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Ocl;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage, recImage;
        float sX, sY, sdvig, ang;
        int cenX, cenY, qX, qY, count;
        public Form1()
        {
            InitializeComponent();
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {
           
        }
        private void imageBox1_MouseClick(object sender, MouseEventArgs e)
        {
            imageBox1.MouseClick += new MouseEventHandler(imageBox1_MouseClick);
            int x = (int)(e.Location.X / imageBox1.ZoomScale);
            int y = (int)(e.Location.Y / imageBox1.ZoomScale);

            recImage = sourceImage.Copy();

            Point center = new Point(x, y);
            int radius = 2;
            int thickness = 2;
            var color = new Bgr(Color.Blue).MCvScalar;
            // функция, рисующая на изображении круг с заданными параметрами
            CvInvoke.Circle(recImage, center, radius, color, thickness);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sX = float.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sY = float.Parse(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.Sized(sourceImage, sX,sY);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.Shift(sourceImage, sdvig);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            cenX = int.Parse(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            cenY = int.Parse(textBox6.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.Rotate(sourceImage, ang, cenX, cenY);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.Proec(sourceImage, srcPoints);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            qY = (int)numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            qX = (int)numericUpDown1.Value;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.Refl(sourceImage, qX, qY);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ang = float.Parse(textBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                sourceImage = new Image<Bgr, byte>(fileName);


                srcPoints = null;
                count = 0;
            }

            imageBox1.Image = sourceImage;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sdvig = float.Parse(textBox3.Text);
        }
    }



    public class Photo
    {

        public static Image<Bgr, byte> Sized(Image<Bgr, byte> sourceImage, float sX, float sY)
        {
            // создание нового изображения
            // высота и ширина нового изображения увеличивается в sX и sY раз соответственно
            var resultImage = new Image<Bgr, byte>((int)(sourceImage.Width * sX), (int)(sourceImage.Height * sY));
            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    // вычисление новых координат пикселя
                    int newX = (int)(x * sX);
                    int newY = (int)(y * sY);

                    // копирование пикселя в новое изображение
                    resultImage[newY, newX] = sourceImage[y, x];
                }
            }
            return resultImage;
        }


        public static Image<Bgr, byte> Shift(Image<Bgr, byte> sourceImage, float sd)
        {
            var resultImage = new Image<Bgr, byte>(sourceImage.Size);
            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    // вычисление новых координат пикселя
                    int newX = (int)(x + sd*(sourceImage.Height - y));
                    int newY = (int)y;

                    if (newX >= 0 && newX < sourceImage.Width && newY >= 0 && newY < sourceImage.Height)
                    {
                        // копирование пикселя в новое изображение
                        resultImage[newY, newX] = sourceImage[y, x];
                    }
                }
            }
            return resultImage;
        }


        public static Image<Bgr, byte> Rotate(Image<Bgr, byte> sourceImage, float a, int cX, int cY)
        {
            var resultImage = new Image<Bgr, byte>(sourceImage.Size);
            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    // вычисление новых координат пикселя
                    int newX = (int)(Math.Cos(a)* (x-cX)-Math.Sin(a)*(y-cY)+cX);
                    int newY = (int)(Math.Sin(a) * (x - cX) + Math.Cos(a) * (y - cY) + cY);

                    if (newX >= 0 && newX < sourceImage.Width && newY >= 0 && newY < sourceImage.Height)
                    {
                        // копирование пикселя в новое изображение
                        resultImage[newY, newX] = sourceImage[y, x];
                    }
                }
            }
            return resultImage;
        }


        public static Image<Bgr, byte> Refl(Image<Bgr, byte> sourceImage, int cX, int cY)
        {
            var resultImage = new Image<Bgr, byte>(sourceImage.Size);
            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    // вычисление новых координат пикселя
                    int newX = (int)(x * cX + sourceImage.Width);
                    int newY = (int)(y * cY+ sourceImage.Height);

                    if (newX >= 0 && newX < sourceImage.Width && newY >= 0 && newY < sourceImage.Height)
                    {
                        // копирование пикселя в новое изображение
                        resultImage[newY, newX] = sourceImage[y, x];
                    }
                }
            }
            return resultImage;
        }


        public static Image<Bgr, byte> Proec(Image<Bgr, byte> sourceImage, PointF[] srcPoints)
        {
            
            var destPoints = new PointF[]{  // плоскость, на которую осуществляется проекция, задаётся четыремя точками функция нахождения матрицы гомографической проекции
                new PointF(0, 0),
                new PointF(0, sourceImage.Height - 1),
                new PointF(sourceImage.Width - 1, sourceImage.Height - 1),
                new PointF(sourceImage.Width - 1, 0)
            };
            var homographyMatrix = CvInvoke.GetPerspectiveTransform(srcPoints, destPoints);
            var destImage = new Image<Bgr, byte>(sourceImage.Size);
            CvInvoke.WarpPerspective(sourceImage, destImage, homographyMatrix, destImage.Size);

            return destImage;
        }
       

    }



    }
