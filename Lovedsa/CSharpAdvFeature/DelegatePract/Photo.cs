using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvFeature.DelegatePract
{
    public class Photo
    {
        public string Color { get; set; }
        public string Contrast { get; set; }

        public string Resolution { get; set; }

        public static Photo LoadPhoto(string path)
        {
            return new Photo();
        }
    }
}
