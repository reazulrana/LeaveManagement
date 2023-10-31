using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace ImageLibrary
{
   public class CustomImage
    {
        public static Image ConvertBinaryToImage(byte[] img)
        {


            MemoryStream ms = new MemoryStream(img);

            return Image.FromStream(ms);
        }



public static byte[] ConvertImageToBinary(Image Photo,int width, int height)
        {
            MemoryStream ms = new MemoryStream();



            Image imgByte = new Bitmap(Photo, new Size(width, height));

            imgByte.Save(ms, Photo.RawFormat);



            return ms.GetBuffer();
        }
       
        public static byte[] ConvertImageToBinary(Image Photo, int quality)
        {
           



            return SaveJpeg(Photo, quality);
        }



        public static byte[] SaveJpeg(Image img, int quality)
        {
            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");

            // Encoder parameter for image quality 
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            // JPEG image codec 
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            MemoryStream ms = new MemoryStream();
            img.Save(ms, jpegCodec, encoderParams);
           return  ms.GetBuffer();
        }

        /// <summary> 
        /// Returns the image codec with the given mime type 
        /// </summary> 
        public static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats 
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec 
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];

            return null;
        }


    }
}
