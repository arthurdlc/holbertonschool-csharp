using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

public class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            try
            {
                using (Bitmap original = new Bitmap(filename))
                {
                    int width = original.Width;
                    int height = original.Height;

                    // LockBits pour accès rapide aux pixels
                    BitmapData bitmapData = original.LockBits(
                        new Rectangle(0, 0, width, height),
                        ImageLockMode.ReadWrite,
                        original.PixelFormat
                    );

                    int bytesPerPixel = Image.GetPixelFormatSize(original.PixelFormat) / 8;
                    int stride = bitmapData.Stride;
                    IntPtr scan0 = bitmapData.Scan0;
                    int bytes = Math.Abs(stride) * height;
                    byte[] pixelBuffer = new byte[bytes];

                    System.Runtime.InteropServices.Marshal.Copy(scan0, pixelBuffer, 0, bytes);

                    // Inverser les couleurs (R, G, B) sauf Alpha
                    for (int i = 0; i < bytes; i += bytesPerPixel)
                    {
                        pixelBuffer[i] = (byte)(255 - pixelBuffer[i]);       // Blue
                        pixelBuffer[i + 1] = (byte)(255 - pixelBuffer[i + 1]); // Green
                        pixelBuffer[i + 2] = (byte)(255 - pixelBuffer[i + 2]); // Red
                    }

                    // Copier les données inversées
                    System.Runtime.InteropServices.Marshal.Copy(pixelBuffer, 0, scan0, bytes);
                    original.UnlockBits(bitmapData);

                    // Générer le nouveau nom de fichier
                    string directory = AppDomain.CurrentDomain.BaseDirectory;
                    string newFileName = Path.Combine(directory, Path.GetFileNameWithoutExtension(filename) + "_inverse" + Path.GetExtension(filename));

                    // Sauvegarde
                    original.Save(newFileName, original.RawFormat);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur avec le fichier {filename}: {ex.Message}");
            }
        });
    }
}
