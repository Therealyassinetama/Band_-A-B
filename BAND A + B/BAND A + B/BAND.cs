using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAND_A___B
{
    class BAND
    {
        public string naam { get; set; }
        //public string genre { get; set; } wordt nergens gebruikt...
        public double uurtarief { get; set; }
        // public int bandleden { get; set; } wordt nergens gebruikt?

        public double optreden (double uur)
        {
            return uurtarief * uur;
        }

        public double songwriting(string song)
        {
            if(song.Length >= 7)
            {
                return uurtarief + 9.9;
            }
            else
            {
                return uurtarief;
            }
        }
    }
}
