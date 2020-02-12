using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            AnonymousQuery();
            //GetFilesLamda();      
        }

        private static void GetFilesLamda()
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();
            var query = files
                .Where(f => f.Length > 10000)
                .OrderBy(f => f.Length).ThenBy(f => f.Name)
                .Select(f => new MyFileInfo
                {
                    Name = f.Name,
                    Length = f.Length,
                    CreationTime = f.CreationTime
                });
        }

        private static void AnonymousQuery()
        {

            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query =
                from item in files
                where item.Length > 1000
                orderby item.Length, item.Name
                select new
                {
                    Name = item.Name,
                    Length = item.Length,
                    CreationTime = item.CreationTime
                };

            Console.Write("Filename\tSize\t\tCreation Date");

            foreach (var item in query)
            {
                Console.WriteLine(
                    "{0} \t{1} bytes, \t{2}",
                    item.Name, item.Length, item.CreationTime);

                //Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

    public class MyFileInfo
    {
        public string Name { get; set; }
        public long Length { get; set; }
        public DateTime CreationTime { get; set; }

        public override string ToString()
        {
            return string.Format("{0,-30}{1:F0} MB\t{2}", Name, Length / 1000, CreationTime);
        }
    }

    //<tabcontrol tabstripplacement = "Top">

    //    <Tabitem header = "Exercise 1">
    //    <Grid>

    //    <grid.rowdefintion>
    //    rowdefinition.height = "10*"/>
    //       rowdefinition.height = "30*"/>

    //    </Grid>

    //    button.content = "Query 1" name = "btnexercise1" click = "btn excerice _ click" (press tab to create method)
    //    grid,row = "0" width = "75" height = "20"/>

    //    datagrid grid.row ="!" x:Name= "asb" margine = "10"/>
    //        </Grid>
    //        </Tabitem>

}
