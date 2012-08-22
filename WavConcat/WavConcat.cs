using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WavConcat
{
    public class WavConcat
    {
        public struct Effect
        {
            [XmlAttribute("Name")]
            public string Name { get; set; }
            public int Start { get; set; }
            public int End { get; set; }
        }

        [XmlElement("ConcatName")]
        public string Name { get; set; }
        public List<Effect> EffectList { get; set; }

        public WavConcat()
        {
            Name = "";
            EffectList = new List<Effect>();
        }
    }
}