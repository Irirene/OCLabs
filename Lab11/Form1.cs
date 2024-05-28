using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab11
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage;
        private double cannyThreshold = 80.0;
        private double cannyThresholdLinking = 40.0;
        private VideoCapture capture;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                sourceImage = new Image<Bgr, byte>(fileName);

                imageBox2.Image = filter(sourceImage).Resize(640, 480, Inter.Linear);
                imageBox1.Image = sourceImage.Resize(640, 480, Inter.Linear);
            }



        }

        private void imageBox1_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cannyThreshold = (double)numericUpDown1.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            cannyThresholdLinking = (double)numericUpDown2.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // инициализация веб-камеры
            capture = new VideoCapture();
            capture.ImageGrabbed += ProcessFrame;
            capture.Start(); // начало обработки видеопотока
            //capture.Stop(); // остановка обработки видеопотока

        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            var frame = new Mat();
            capture.Retrieve(frame); // получение текущего кадра
            Image<Bgr, byte> image = frame.ToImage<Bgr, byte>();
            imageBox1.Image = image.Resize(640, 480, Inter.Linear);
            imageBox2.Image = filter(image).Resize(640, 480, Inter.Linear);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                capture = new VideoCapture(fileName);
                capture.ImageGrabbed += ProcessFrame;
                capture.Start(); // начало обработки видеопотока
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            capture.Stop();
        }

        public Image<Bgr, byte> filter(Image<Bgr, byte> sourceImage)
        {

            Image<Gray, byte> grayImage = sourceImage.Convert<Gray, byte>();
            var tempImage = grayImage.PyrDown();
            var destImage = tempImage.PyrUp();

            Image<Gray, byte> cannyEdges = destImage.Canny(cannyThreshold, cannyThresholdLinking);

            var cannyEdgesBgr = cannyEdges.Convert<Bgr, byte>();
            var resultImage = sourceImage.Sub(cannyEdgesBgr); // попиксельное вычитание
                                                              //обход по каналам
            for (int channel = 0; channel < resultImage.NumberOfChannels; channel++)
                for (int x = 0; x < resultImage.Width; x++)
                    for (int y = 0; y < resultImage.Height; y++) // обход по пискелям
                    {
                        // получение цвета пикселя
                        byte color = resultImage.Data[y, x, channel];
                        if (color <= 50)
                            color = 0;
                        else if (color <= 100)
                            color = 25;
                        else if (color <= 150)
                            color = 180;
                        else if (color <= 200)
                            color = 210;
                        else
                            color = 255;
                        resultImage.Data[y, x, channel] = color; // изменение цвета пикселя
                    }
            return resultImage;
        }
    }
    }
