using System.Drawing.Imaging;

namespace eRent.UI.Helpers
{
    public class ImageConverter
    {
        public static byte[] FromImageToByte(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            byte[] imageBytes = ms.ToArray();
            return imageBytes;
        }

        public static Image FromByteToImage(byte[] image)
        {
            var ms = new MemoryStream(image);
            return Image.FromStream(ms);
        }

        public string ImageToBase64(Image image)
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
    }
}
