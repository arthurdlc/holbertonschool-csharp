using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

class ImageProcessor
{
    /// <summary>
    /// Inverts a list of images in parallel.
    /// </summary>
    /// <param name="filenames">A list of images to invert.</param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, imagePath =>
        {
            try
            {
                using (Bitmap image = new Bitmap(imagePath))
                {
                    int width = image.Width;
                    int height = image.Height;

                    BitmapData bmpData = image.LockBits(
                        new Rectangle(0, 0, width, height),
                        ImageLockMode.ReadWrite,
                        PixelFormat.Format32bppArgb);

                    int stride = bmpData.Stride;
                    int byteCount = stride * height;
                    byte[] pixelBuffer = new byte[byteCount];

                    Marshal.Copy(bmpData.Scan0, pixelBuffer, 0, byteCount);

                    // Traitement optimisé avec un accès mémoire rapide
                    for (int i = 0; i < byteCount; i += 4)
                    {
                        pixelBuffer[i] = (byte)(255 - pixelBuffer[i]);       // Blue
                        pixelBuffer[i + 1] = (byte)(255 - pixelBuffer[i + 1]); // Green
                        pixelBuffer[i + 2] = (byte)(255 - pixelBuffer[i + 2]); // Red
                    }

                    Marshal.Copy(pixelBuffer, 0, bmpData.Scan0, byteCount);
                    image.UnlockBits(bmpData);

                    string newFilename = Path.Combine(Directory.GetCurrentDirectory(), 
                        $"{Path.GetFileNameWithoutExtension(imagePath)}_inverse{Path.GetExtension(imagePath)}");

                    image.Save(newFilename, GetImageFormat(imagePath));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing {imagePath}: {ex.Message}");
            }
        });
    }
}
