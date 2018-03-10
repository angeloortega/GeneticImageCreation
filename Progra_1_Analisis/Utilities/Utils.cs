﻿using System;
using System.Collections.Generic;
using System.Drawing;
using Progra_1_Analisis.Model;
using System.Windows.Forms;

namespace Progra_1_Analisis.Utilities
{
    class Utils
    {
        public static  bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if ((c < '0' || c > '9') && c != '.')
                    return false;
            }

            return true;
        }
        public static void generarImagenAleatoria(int cantidad) {
            //random number
            
            Random rand = new Random();
            int width = 32, height = 32;
            Bitmap bmp = new Bitmap(width, height);
            SingletonCache singleton = SingletonCache.Instance;
            List<Imagen> poblacion = new List<Imagen>(cantidad);
            int a = rand.Next(256);
            int r = rand.Next(256);
            int g = rand.Next(256);
            int b = rand.Next(256);
            bool isNotPng = !SingletonCache.Instance.objetivo.id.Contains("png");
            while (cantidad > 0)
            {

                //create random pixels
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //generate random ARGB value
                        a = rand.Next(256);

                        if (isNotPng)
                        {
                            a = 255;
                        }            
                        r = rand.Next(256);
                        g = rand.Next(256);
                        b = rand.Next(256);

                        //set ARGB value
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                poblacion.Add(new Imagen("" + cantidad, bmp));
                cantidad--;
            }
            
            singleton.poblacion = poblacion;
        }
        public static Bitmap cargarImagen()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
        
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap resizedImage = resizeImage(128,128,PadImage(new Bitmap(open.FileName)));
                SingletonCache singleton = SingletonCache.Instance;
                singleton.objetivo = new Imagen("objetivo" + open.FileName.Split('.')[1], resizedImage);
                // display image in picture box  
                return resizedImage;

            }
            return null;
        }
        public static Bitmap resizeImage(int finalHeight, int finalWidth, Bitmap original) {
            float scaleHeight = finalHeight / (float)original.Height;
            float scaleWidth = finalWidth / (float)original.Width;
            float scale = Math.Min(scaleHeight, scaleWidth);
            return new Bitmap(original, (int)(original.Width * scale), (int)(original.Height * scale));
        }

        public static Bitmap PadImage(Bitmap originalImage)
        {
            int largestDimension = Math.Max(originalImage.Height, originalImage.Width);
            Size squareSize = new Size(largestDimension, largestDimension);
            Bitmap squareImage = new Bitmap(squareSize.Width, squareSize.Height);
            using (Graphics graphics = Graphics.FromImage(squareImage))
            {
                graphics.FillRectangle(Brushes.White, 0, 0, squareSize.Width, squareSize.Height);
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                graphics.DrawImage(originalImage, (squareSize.Width / 2) - (originalImage.Width / 2), (squareSize.Height / 2) - (originalImage.Height / 2), originalImage.Width, originalImage.Height);
            }
            return squareImage;
        }
    }
}
