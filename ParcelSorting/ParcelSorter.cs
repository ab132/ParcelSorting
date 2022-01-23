using System;
using System.Linq;

namespace ParcelSorting
{
    public class ParcelSorter
    {
        public bool Box(double b, double l, params double[] widths)
        {
            bool ok = false;

            if (Math.Sqrt(Math.Pow((l / 2f), 2) + Math.Pow(b, 2)) < widths.Min(w => w))
            {
                ok = true;
                Console.WriteLine("fits = {0}", ok);

                return ok;
            }
            
            Console.WriteLine("fits = {0}", ok);
            return ok;
        }
    }
}
