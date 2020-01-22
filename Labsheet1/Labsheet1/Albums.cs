using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1
{
    class Albums
    {
        public string albumName { get; set; }
        public string releaseDate { get; set; }
        public string Sales { get; set; }

        public override string ToString()
        {
            return $" {albumName}";
        }

        public Albums(string newalbumName, string newreleaseDate, string newSales)
        {
            albumName = newalbumName;
            releaseDate = newreleaseDate;
            Sales = newSales;
        }
    }
}
