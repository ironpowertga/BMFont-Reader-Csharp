using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BmFontReader
{
    

    [XmlRoot("font")]
    public class Font
    {
        [XmlElement("info")]
        public FontInfo Info { get; set; }
    }

    public class FontInfo
    {
        [XmlAttribute("face")]
        public string Face { get; set; }

        [XmlAttribute("size")]
        public Int32 Size { get; set; }

        [XmlAttribute("bold")]
        public Int32 Bold { get; set; }

        [XmlAttribute("italic")]
        public Int32 Italic { get; set; }

        [XmlAttribute("charset")]
        public string CharSet { get; set; }

        [XmlAttribute("stretchH")]
        public Int32 StretchH { get; set; }

        [XmlAttribute("smooth")]
        public Int32 Smooth { get; set; }

        [XmlAttribute("aa")]
        public Int32 SuperSampling { get; set; }

        [XmlAttribute("padding")]
        public string Padding { get; set; }


        [XmlAttribute("spacing")]
        public string Spacing { get; set; }

        [XmlAttribute("outline")]
        public int Outline { get; set; }
    }

    public class FontCommon
    {
        [XmlAttribute("lineHeight")]
        public Int32 LineHeight { get; set; }

        [XmlAttribute("base")]
        public Int32 Base { get; set; }



    }
}
