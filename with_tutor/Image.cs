using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace with_tutor
{
    public class MnistImage
    {
        public int width; // 28
        public int height; // 28
        public double[][] pixels; // 0 (белый) – 255 (черный)
        public MnistImage(int width, int height, double[][] pixels)
        {
            this.width = width;
            this.height = height;
            this.pixels = new double[height][];
            for (int i = 0; i < this.pixels.Length; ++i)
                this.pixels[i] = new double[width];
            for (int i = 0; i < height; ++i)
                for (int j = 0; j < width; ++j)
                    this.pixels[i][j] = pixels[i][j];
        }

        public static void LoadData(string pixelFile, string labelFile, out MnistImage[] Xout, out double[][] dout)
        {
            FileStream ifsPixels = new FileStream(pixelFile, FileMode.Open);
            FileStream ifsLabels = new FileStream(labelFile, FileMode.Open);
            BinaryReader brImages = new BinaryReader(ifsPixels);
            BinaryReader brLabels = new BinaryReader(ifsLabels);

            int magic1 = brImages.ReadInt32(); 
            int numIm = brImages.ReadInt32();
            int numRows = brImages.ReadInt32();
            int numCols = brImages.ReadInt32();

            int magic2 = brLabels.ReadInt32();
            int numLabels = brLabels.ReadInt32();

            int numImages = ReverseBytes(numIm);
            numImages = 6000;
            MnistImage[] result = new MnistImage[numImages];

            double[][] labs = new double[numImages][];
            for (int i = 0; i < labs.Length; ++i)
                labs[i] = new double[10];

            double[][] pixels = new double[28][];
            for (int i = 0; i < pixels.Length; ++i)
                pixels[i] = new double[28];

            for (int mi = 0; mi < numImages; ++mi)
            {
                for (int i = 0; i < 28; ++i) 
                    for (int j = 0; j < 28; ++j)                   
                    {
                        double b = (double)brImages.ReadByte();
                        //pixels[i][j] = b / 255.0 - 0.5;
                        pixels[i][j] = b / 255.0;
                    }
                MnistImage mImage = new MnistImage(28, 28, pixels);
                result[mi] = mImage;
                byte lbl = brLabels.ReadByte(); // получаем маркеры и пиксели 
                labs[mi][lbl] = 1;
            } // по каждому изображению

            ifsLabels.Close();
            ifsPixels.Close();
            brLabels.Close();
            brImages.Close();
            Xout = result;
            dout = labs;
        }

        public static int ReverseBytes(int v) {
            byte[] intAsBytes = BitConverter.GetBytes(v);
            Array.Reverse(intAsBytes);
            return BitConverter.ToInt32(intAsBytes, 0);
        }
    }
}