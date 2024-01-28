using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    internal class Radio
    {
        public float Volume { get; set; }
        public float AumentaVolume()
        {
            Volume += 10;
            return Volume;
        }
        public float DiminuisciVolume()

        { 
            Volume -= 10;
            return Volume;
        }
    }
}
