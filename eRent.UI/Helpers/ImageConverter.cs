﻿using System.Drawing.Imaging;

namespace eRent.UI.Helpers
{
    public class ImageConverter
    {
        public static string FromImageToBase64(Image image)
        {
            string? base64String = null;
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();
                base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public static Image FromByteToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                image.Save("image.jpg", ImageFormat.Jpeg);
                return image;
            }
        }
    }
}
