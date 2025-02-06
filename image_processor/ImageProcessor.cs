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

                    // Inverser les couleurs
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            Color pixel = original.GetPixel(x, y);
                            Color inverted = Color.FromArgb(pixel.A, 255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                            original.SetPixel(x, y, inverted);
                        }
                    }

                    // Générer le nouveau nom de fichier
                    string directory = AppDomain.CurrentDomain.BaseDirectory;
                    string newFileName = Path.Combine(directory, Path.GetFileNameWithoutExtension(filename) + "_inverse" + Path.GetExtension(filename));

                    // Sauvegarder l'image
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
