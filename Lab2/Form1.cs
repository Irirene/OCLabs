using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace Lab2
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage, secondImage, thirdImage, resultImage;
        private Image<Hsv, byte> hsvImage;
        private int channelIndex, brightness, contrast, brightness2, contrast2, p;
        private double h, s ,v;
        //Timer timer;
        //int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                sourceImage = new Image<Bgr, byte>(fileName);

                hsvImage = sourceImage.Convert<Hsv, byte>();
            }

            imageBox1.Image = sourceImage.Resize(640, 480, Inter.Linear);
            imageBox2.Image = sourceImage.Split()[channelIndex].Resize(640, 480, Inter.Linear);
            //timer1.Start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            channelIndex = (int)numericUpDown1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //timer1 = new Timer();
            //timer.Tick += new EventHandler(timer1_Tick);
            //timer1.Enabled = true;
            //timer1.Interval = 100; // интервал в миллисекундах
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.BlackWhite(sourceImage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.Sepia(sourceImage);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.Blur(sourceImage);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            brightness = (int)numericUpDown2.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.Brightness(sourceImage, brightness);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           imageBox2.Image = Photo.Contrast(sourceImage, contrast);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            contrast = (int)numericUpDown3.Value;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                secondImage = new Image<Bgr, byte>(fileName);
            }

            //imageBox1.Image = sourceImage.Resize(640, 480, Inter.Linear);
            //imageBox2.Image = sourceImage.Split()[channelIndex].Resize(640, 480, Inter.Linear);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> dopImage = sourceImage.Not();
            imageBox2.Image = dopImage;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> isklImage = sourceImage.Xor(secondImage);
            imageBox2.Image = isklImage;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> peresImage = sourceImage.And(secondImage);
            imageBox2.Image = peresImage;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            h = (double)numericUpDown4.Value;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.cartoonFilter(sourceImage, p);
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            p = (int)numericUpDown9.Value;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.Brightness(sourceImage, brightness2) + Photo.Contrast(sourceImage, contrast2) + Photo.Blur(sourceImage) + sourceImage.And(thirdImage);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            imageBox2.Image = Photo.Hsv(hsvImage, h, s, v);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[,] filterMatrix = new int[3, 3];
            filterMatrix[0, 0] = int.Parse(textBox1.Text);
            filterMatrix[0, 1] = int.Parse(textBox2.Text);
            filterMatrix[0, 2] = int.Parse(textBox3.Text);
            filterMatrix[1, 0] = int.Parse(textBox4.Text);
            filterMatrix[1, 1] = int.Parse(textBox5.Text);
            filterMatrix[1, 2] = int.Parse(textBox6.Text);
            filterMatrix[2, 0] = int.Parse(textBox7.Text);
            filterMatrix[2, 1] = int.Parse(textBox8.Text);
            filterMatrix[2, 2] = int.Parse(textBox9.Text);

            imageBox2.Image = Photo.WindowFilter(sourceImage, filterMatrix);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                thirdImage = new Image<Bgr, byte>(fileName);
            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            brightness2 = (int)numericUpDown7.Value;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            contrast2 = (int)numericUpDown8.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            s = (double)numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            v = (double)numericUpDown6.Value;
        }
    }



    public  class Photo
    {
        public static Image<Gray, byte> BlackWhite(Image<Bgr, byte> sourceImage)
        {
            var grayImage = new Image<Gray, byte>(sourceImage.Size);

            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    grayImage.Data[y, x, 0] = Convert.ToByte(0.299 * sourceImage.Data[y, x, 2] + 0.587 * sourceImage.Data[y, x, 1] + 0.114 * sourceImage.Data[y, x, 0]);

                }
            }
            return grayImage;
        }


        public static Image<Bgr, byte> Sepia(Image<Bgr, byte> sourceImage)
        {
            var sepiaImage = new Image<Bgr, byte>(sourceImage.Size);

            for (int x = 0; x < sourceImage.Width; x++) {
                for (int y = 0; y < sourceImage.Height; y++)
                {

                    Bgr color = sourceImage[y, x];
                    double red = (0.393 * color.Red) + (0.769 * color.Green) + (0.189 * color.Blue);
                    double green = (0.349 * color.Red) + (0.686 * color.Green) + (0.168 * color.Blue);
                    double blue = (0.272 * color.Red) + (0.534 * color.Green) + (0.131 * color.Blue);

                    sepiaImage[y, x] = new Bgr(blue, green, red);
                }
            }
            return sepiaImage;
        }


        public static Image<Bgr, byte> Blur(Image<Bgr, byte> sourceImage)
        {
            var blurImage = new Image<Bgr, byte>(sourceImage.Size);

            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    List<byte> blue = new List<byte>();
                    List<byte> green = new List<byte>();
                    List<byte> red = new List<byte>();

                    for (int i = -4; i < 5; i++)
                    {
                        for (int j = -4; j < 5; j++)
                        {
                            int x1 = x + i;
                            int y1 = y+j;

                            if (x1>=0 && x1< sourceImage.Width && y1 >= 0 && y1 < sourceImage.Height)
                            {
                                Bgr color = sourceImage[y1, x1];
                                blue.Add((byte)color.Blue);
                                green.Add((byte)color.Green);
                                red.Add((byte)color.Red);
                            }
                        }
                    }

                    blue.Sort();
                    green.Sort();
                    red.Sort();

                    byte halfBlue = blue[blue.Count/2];
                    byte halfGreen = green[green.Count/2];
                    byte halfRed = red[red.Count/2];

                    blurImage[y, x] = new Bgr(halfBlue, halfGreen, halfRed);
                }
            }
            return blurImage;
        }

        public static Image<Bgr, byte> Brightness(Image<Bgr, byte> sourceImage, int brightness)
        {
            var brightImage = new Image<Bgr, byte>(sourceImage.Size);

            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {

                    Bgr color = sourceImage[y, x];
                    double red = color.Red + (double)brightness;
                    double green = color.Green + (double)brightness;
                    double blue = color.Blue + (double)brightness;

                    brightImage[y, x] = new Bgr(blue, green, red);
                }
            }
            return brightImage;
        }


        public static Image<Bgr, byte> Contrast(Image<Bgr, byte> sourceImage, int contrast)
        {
            var contrastImage = new Image<Bgr, byte>(sourceImage.Size);

            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {

                    Bgr color = sourceImage[y, x];
                    double red = color.Red * (double)contrast;
                    double green = color.Green * (double)contrast;
                    double blue = color.Blue * (double)contrast;

                    contrastImage[y, x] = new Bgr(blue, green, red);
                }
            }
            return contrastImage;
        }


        public static Image<Bgr, byte> Hsv(Image<Hsv, byte> recImage, double h, double s, double v)
        {
            recImage = recImage.Add(new Hsv(h, s, v));
            Image<Bgr, byte> changeImage = recImage.Convert<Bgr, byte>();
            return changeImage;
        }



        public static Image<Bgr, byte> WindowFilter(Image<Bgr, byte> sourceImage, int[,] filterMatrix)
        {
            var filteredImage = new Image<Bgr, byte>(sourceImage.Size);
            int summ = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    summ += filterMatrix[i+1, j+1];
                }
            }

            for (int x = 1; x < sourceImage.Width - 1; x++)
            {
                for (int y = 1; y < sourceImage.Height - 1 ; y++)
                {
                    //Bgr color = sourceImage[y, x];
                    double red = 0, green = 0, blue = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int x1 = x + i;
                            int y1 = y + j;

                            if (x1 >= 0 && x1 < sourceImage.Width && y1 >= 0 && y1 < sourceImage.Height)
                            {
                                Bgr neighborColor = sourceImage[y1, x1];
                                red += (double)((neighborColor.Red * filterMatrix[i + 1, j + 1])/summ);
                                green += (double)((neighborColor.Green * filterMatrix[i + 1, j + 1])/summ);
                                blue += (double)((neighborColor.Blue * filterMatrix[i + 1, j + 1])/summ);
                            }
                        }
                    }
                    filteredImage[y, x] = new Bgr(blue, green, red);            }
            }
            return filteredImage;
        }

        public static Image<Bgr, byte> cartoonFilter(Image<Bgr, byte> sourceImage, int porog)
        {
            var resultImage = Photo.BlackWhite(Blur(sourceImage));
            var edges = resultImage.Convert<Gray, byte>();
            edges = edges.ThresholdAdaptive(new Gray(porog), AdaptiveThresholdType.MeanC, ThresholdType.Binary, 3, new Gray(0.03));
            var prevImage = sourceImage.And(new Bgr(255, 255, 255), edges);
            Image<Bgr, byte>  cartoonImage = prevImage.Convert<Bgr, byte>();
            return cartoonImage;
        }
    }

}
