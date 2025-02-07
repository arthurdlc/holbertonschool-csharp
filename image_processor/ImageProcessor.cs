using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

class ImageProcessor
{
    /// <summary>
    /// Inverts a list of image(s) in parallel.
    /// </summary>
    /// <param name="filenames">A list of images to invert.</param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, imagePath =>
        {
            using (Bitmap image = new Bitmap(imagePath))
            {
                int width = image.Width;
                int height = image.Height;

                BitmapData bmpData = image.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                int stride = bmpData.Stride;
                int byteCount = stride * height;
                byte[] pixelBuffer = new byte[byteCount];

                Marshal.Copy(bmpData.Scan0, pixelBuffer, 0, byteCount);

                // Utilisation de Span pour améliorer l'accès en mémoire
                Span<byte> spanBuffer = pixelBuffer.AsSpan();
                for (int i = 0; i < byteCount; i += 4)
                {
                    spanBuffer[i] = (byte)(255 - spanBuffer[i]);     // B
                    spanBuffer[i + 1] = (byte)(255 - spanBuffer[i + 1]); // G
                    spanBuffer[i + 2] = (byte)(255 - spanBuffer[i + 2]); // R
                }

                Marshal.Copy(pixelBuffer, 0, bmpData.Scan0, byteCount);
                image.UnlockBits(bmpData);

                string newFilename = $"{System.IO.Path.GetFileNameWithoutExtension(imagePath)}_inverse{System.IO.Path.GetExtension(imagePath)}";
                image.Save(newFilename);
            }
        });
    }
}
