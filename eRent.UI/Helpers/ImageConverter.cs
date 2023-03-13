using System.Drawing.Imaging;

namespace eRent.UI.Helpers
{
    public class ImageConverter
    {
        public static string FromImageToBase64(Image image)
        {
            try
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error converting image to base64 string: " + ex.Message);
                return "";
            }
            finally
            {
                image.Dispose();
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
