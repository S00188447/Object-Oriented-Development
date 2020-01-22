using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1
{


    class Band: IComparable
    {

        public string bandName { get; set; }
        public string yearFormed { get; set; }
        public string Members { get; set; }


        public List<Albums> Albums { get; set; }



        public override string ToString()
        {
            return $" {bandName}";
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public Band(string newbandName, string newyearFormed, string newMembers)
        {
            bandName = newbandName;
            yearFormed = newyearFormed;
            Members = newMembers;
        }

        public abstract class Bands
        {

        }


        public class RockBand : Bands
        {

        }
        public class Popband : Bands
        {

        }

        public class IndieBand : Bands
        {

        }

            


        




    }
}
