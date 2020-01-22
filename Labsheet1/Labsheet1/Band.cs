using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1
{


    class Band
    {

        public string bandName { get; set; }
        public string yearFormed { get; set; }
        public string Members { get; set; }


        public override string ToString()
        {
            return $" {bandName}";
        }

        public Band(string newbandName, string newyearFormed, string newMembers)
        {
            bandName = newbandName;
            yearFormed = newyearFormed;
            Members = newMembers;
        }





    }
}
