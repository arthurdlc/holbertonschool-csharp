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

                    // Inverser uniquement les canaux R, G, B (ne pas toucher à Alpha)
                    for (int i = 0; i < byteCount; i += 4)
                    {
                        pixelBuffer[i] = (byte)(255 - pixelBuffer[i]);       // B
                        pixelBuffer[i + 1] = (byte)(255 - pixelBuffer[i + 1]); // G
                        pixelBuffer[i + 2] = (byte)(255 - pixelBuffer[i + 2]); // R
                        // pixelBuffer[i + 3] => Alpha (on ne le change pas)
                    }

                    Marshal.Copy(pixelBuffer, 0, bmpData.Scan0, byteCount);
                    image.UnlockBits(bmpData);

                    string newFilename = Path.Combine(Directory.GetCurrentDirectory(), 
                        $"{Path.GetFileNameWithoutExtension(imagePath)}_inverse{Path.GetExtension(imagePath)}");

                    // Assurer que le format de sortie est le même que l'original
                    image.Save(newFilename, GetImageFormat(imagePath));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du traitement de {imagePath}: {ex.Message}");
            }
        });
    }

    /// <summary>
    /// Returns the correct ImageFormat based on the file extension.
    /// </summary>
    private static ImageFormat GetImageFormat(string imagePath)
    {
        string extension = Path.GetExtension(imagePath).ToLower();
        return extension switch
        {
            ".png" => ImageFormat.Png,
            ".jpg" => ImageFormat.Bmp,
            ".gif" => ImageFormat.Gif,
            ".tiff" => ImageFormat.Tiff,
            _ => ImageFormat.Jpeg
        };
    }
}
