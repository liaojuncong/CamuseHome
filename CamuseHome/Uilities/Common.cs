using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome.Uilities
{
    public class Common
    {
        public static byte[] GetPicture(string path)
        {
            byte[] bytes = null;
            if (File.Exists(path))
            {
                Bitmap bitmap = new Bitmap(path);
                using (MemoryStream ms = new MemoryStream())
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    bytes = ms.GetBuffer();
                }
            }
            return bytes;
        }
    }
}
