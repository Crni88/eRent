using System.Drawing.Imaging;

namespace eRent.UI.Helpers
{
    public class ImageConverter
    {
        public static byte[] FromImageToByte(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public static Image FromByteToImage(byte[] image)
        {
            var ms = new MemoryStream(image);
            return Image.FromStream(ms);

        }
    }
}
