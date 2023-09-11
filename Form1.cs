using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.InteropServices;

namespace png_screens
{
    public partial class Form1 : Form
    {
        public static void GenerateDateImage(string dateString, string timeString, string outputPath)
        {
            // Set the desired font name
            string fontName = "Segoe UI Semilight";
            // Get the system's default font and size for the date display
            //Font systemFont = SystemFonts.SmallCaptionFont;
            //float systemFontSize = systemFont.Size;

            // Calculate the font size for the desired image height
            int imageWidth = 1920;
            int imageHeight = 1080;
            //float fontSize = Math.Min(imageWidth / (dateString.Length * 0.7f), imageHeight / 2.5f) * (systemFontSize / 16f);
            float fontSize = 9;

            // Create a Bitmap object with desired width and height
            using (Bitmap bitmap = new Bitmap(imageWidth, imageHeight))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // Set the background color
                    graphics.Clear(Color.Transparent);

                    // Set the font and text color
                    Font font = new Font(fontName, fontSize, FontStyle.Regular);
                    //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    //graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

                    //int paddingRight = 0;  // Pixel value for right padding
                    //int paddingBottom = 0;

                    //SizeF stringSize = graphics.MeasureString(dateString, font);
                    //Debug.WriteLine(stringSize);
                    //float x = imageWidth - stringSize.Width - paddingRight - 10;
                    //float y = imageHeight - stringSize.Height - paddingBottom - 10;
                    //Debug.WriteLine(x);
                    //Debug.WriteLine(y);
                    
                    float x = 1819-2;
                    float y = 1046-4;
                    PointF startingPoint1 = new PointF(x, y);
                    x = 1803-2;
                    y = 1064-4;
                    PointF startingPoint2 = new PointF(x, y);

                    graphics.DrawString(timeString, font, Brushes.White, startingPoint1);
                    graphics.DrawString(dateString, font, Brushes.White, startingPoint2);

                    // Save the image to the specified output path
                    bitmap.SetResolution(96, 96);
                    bitmap.Save(outputPath, ImageFormat.Png);
                }
            }
        }
        public static void MergeImages(string imageF, string imageS)
        {
            // Define the width and height of the images
            int width = 1920;
            int height = 1080;

            // Create a new bitmap to hold the merged images
            Bitmap mergedImage = new Bitmap(width, height);

            // Create a graphics object from the merged image
            using (Graphics graphics = Graphics.FromImage(mergedImage))
            {
                // Set the background color of the merged image
                graphics.Clear(Color.Transparent);

                // Load the individual images to be merged
                Bitmap image1 = new Bitmap(imageF);
                Bitmap image2 = new Bitmap(imageS);
                //Bitmap image3 = new Bitmap("image3.png");

                // Set the blending mode to achieve the desired transparency effect
                ColorMatrix colorMatrix = new ColorMatrix();
                colorMatrix.Matrix33 = 1.0f; // Change the value (0.0 to 1.0) to adjust the transparency level
                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                // Draw the images onto the merged image with the specified transparency level
                graphics.DrawImage(image1, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);
                graphics.DrawImage(image2, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);
                //graphics.DrawImage(image3, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

                // Dispose the individual images
                image1.Dispose();
                image2.Dispose();
                //image3.Dispose();
            }

            // Save the merged image as a new PNG file
            mergedImage.Save("merged_image.png", ImageFormat.Png);

            // Dispose the merged image
            mergedImage.Dispose();

        }
        public Form1()
        {
            InitializeComponent();



            // Create a method to generate the image from a date string



            // Usage
            string dateString = "01/06/2023";
            string timeString = "13:34";
            string outputPath = "date_image.png";
            string imageF = "image1.png";
            string imageS = "date_image.png";

            GenerateDateImage(dateString, timeString, outputPath);
            MergeImages(imageF, imageS);


        }
    }
}