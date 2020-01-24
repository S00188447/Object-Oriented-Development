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
        public DateTime releaseDate { get; set; }
        public int Sales { get; set; }

        public override string ToString()
        {
            return $" {albumName}";
        }

        public Albums(string newalbumName, DateTime newreleaseDate, int newSales)
        {

            albumName = newalbumName;
            releaseDate = newreleaseDate;
            Sales = newSales;

            

        }

        
    }
}
