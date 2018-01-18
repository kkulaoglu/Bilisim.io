using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tip tanımıyla gösterimi
            (double lat, double lng, string locationName) tuple = GetCoordinate("istanbul");
            Console.WriteLine(String.Format("{0} koordinatları enlem: {1} - boylam: {2}", tuple.locationName, tuple.lat, tuple.lng));
           
            // var anahtar kelimesi ile kullanımı
            var tupleLoc = GetCoordinate("istanbul");
            Console.WriteLine(String.Format("{0} koordinatları enlem: {1} - boylam: {2}", tupleLoc.locationName, tupleLoc.lat, tupleLoc.lng));

            Console.ReadKey();
        }
        private static (double lat, double lng, string locationName) GetCoordinate(string locationName)
        {
            // https://www.latlong.net/place/istanbul-turkey-2242.html
            return (41.015137, 28.979530, locationName);
        }
    }
}
