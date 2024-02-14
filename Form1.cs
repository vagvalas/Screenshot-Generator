using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace png_screens
{
    public partial class Form1 : Form
    {
        public static int i = 1;
        private string outputPath;
        private string sourcePath;
        private string selectedPng;
        public static Bitmap GenerateDateImage(string dateString, string timeString)
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
            Bitmap bitmap = new Bitmap(imageWidth, imageHeight);
            
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
                    //bitmap.Save(Path.Combine(outputPath, "date_image.png"), ImageFormat.Png);
                }
            return bitmap;
        }
        public static void MergeImages(string imageBase, string imageMid,Bitmap imageDate, string outputPath)
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
                Bitmap image1 = new Bitmap(imageMid);
                Bitmap image2 = imageDate;
                Bitmap image3 = new Bitmap(imageBase);

                // Set the blending mode to achieve the desired transparency effect
                ColorMatrix colorMatrix = new ColorMatrix();
                colorMatrix.Matrix33 = 1.0f; // Change the value (0.0 to 1.0) to adjust the transparency level
                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                // Draw the images onto the merged image with the specified transparency level
                graphics.DrawImage(image3, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);
                graphics.DrawImage(image1, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);
                graphics.DrawImage(image2, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);
                

                // Dispose the individual images
                image1.Dispose();
                image2.Dispose();
                image3.Dispose();
                
            }

            // Save the merged image as a new PNG file
            mergedImage.Save(Path.Combine(outputPath, $"Final_merge{i}.png"), ImageFormat.Png);
            i++;

            // Dispose the merged image
            mergedImage.Dispose();

        }
        public Form1()
        {
            InitializeComponent();



            
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int imageIndex = 0;
            //Finding irritations by diving the hours and minutes from startHour with endHour
            DateTime startingPoint = startDate.Value.AddHours((int)startHour.Value).AddMinutes((int)startMinute.Value);
            DateTime endingPoint = startDate.Value.AddHours((int)endHour.Value).AddMinutes((int)endMinute.Value);
            TimeSpan timeDifference = endingPoint - startingPoint;

            // Get the total number of minutes
            double minutesDifference = timeDifference.TotalMinutes;
            Debug.WriteLine(minutesDifference);
            double interval = minutesDifference / ((double)numericIrritations.Value - 1);
            for (DateTime currentDate = startDate.Value.Date; currentDate <= endDate.Value.Date; currentDate = currentDate.AddDays(1))
            {
                string dateString = currentDate.ToShortDateString();
                double spacing = 0;
                Debug.WriteLine(currentDate);
                
                
                for (int counterHour = 1; counterHour <= numericIrritations.Value; counterHour++)
                {


                    DateTime currentHour = currentDate.AddHours((int)startHour.Value).AddMinutes((int)startMinute.Value+spacing);
                    string timeString = currentHour.ToString("HH:mm");
                    string imageMiddle = selectedPng;
                    string[] imageFiles = Directory.GetFiles(sourcePath, "*.png");
                    string imageBase = imageFiles[imageIndex];
                    Bitmap dateImage = GenerateDateImage(dateString, timeString);
                    MergeImages(imageBase, imageMiddle, dateImage, outputPath);
                    spacing = spacing +interval;
                    imageIndex++;
                }
            }
        }

        private void outDirectory_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                // Set the initial directory for the dialog
                dialog.SelectedPath = "C:\\";

                // Show the dialog and get the result
                DialogResult result = dialog.ShowDialog();


                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    // The user selected a directory
                    outputPath = dialog.SelectedPath;
                    //Debug.WriteLine(selectedFolder);


                }
            }
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            using (var dialog1 = new FolderBrowserDialog())
            {
                // Set the initial directory for the dialog
                dialog1.SelectedPath = "C:\\";

                // Show the dialog and get the result
                DialogResult result = dialog1.ShowDialog();


                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog1.SelectedPath))
                {
                    // The user selected a directory
                    sourcePath = dialog1.SelectedPath;
                    //Debug.WriteLine(selectedFolder);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pngPicker = new OpenFileDialog();
            pngPicker.Filter = "PNG files (*.png)|*.png"; // Filter to only show .png files

            if (pngPicker.ShowDialog() == DialogResult.OK)
            {
                selectedPng = pngPicker.FileName;
                Debug.WriteLine(selectedPng);
            }
        }
    }
}