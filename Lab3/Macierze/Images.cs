using System;
using System.Collections.Generic;
using System.Text;

namespace Macierze
{
    internal class Images
    {
        public Bitmap Negative(Bitmap source)
        {
            Bitmap bitmap = new Bitmap(source);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    Color negativeColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                    bitmap.SetPixel(i, j, negativeColor);
                }
            }
            return bitmap;
        }
        public Bitmap Gray(Bitmap source)
        {
            Bitmap bitmap = new Bitmap(source);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    int grayValue = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    bitmap.SetPixel(i, j, grayColor);
                }
            }
            return bitmap;
        }
        public Bitmap Thresholding(Bitmap source)
        {
            Bitmap bitmap = new Bitmap(source);
            int threshold = 100; 
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color c = bitmap.GetPixel(i, j);
                    int avg = (c.R + c.G + c.B) / 3;
                    Color newColor = avg >= threshold ? Color.White : Color.Black;
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            return bitmap;
        }
        public Bitmap Tint(Bitmap source)
        {
            Bitmap bitmap = new Bitmap(source);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color c = bitmap.GetPixel(i, j);
                    Color greenColor = Color.FromArgb(c.A, 0, c.G, 0);
                    bitmap.SetPixel(i, j, greenColor);
                }
            }
            return bitmap;
        }
    }
}
