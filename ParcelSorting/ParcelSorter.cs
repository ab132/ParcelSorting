using System;

namespace ParcelSorting
{
    public class ParcelSorter
    {
        public bool Box(double b, double l, params double[] widths)
        {
            bool ok = false;

            if (b > widths[0])
            {
                b = l;
                l = b;
            }

            for (int i = 0; i < widths.Length - 1; i++)
            {
                {
                    if ((Math.Sqrt(Math.Pow(widths[i], 2) - Math.Pow(b, 2)) + Math.Sqrt(Math.Pow(widths[i + 1], 2) - Math.Pow(b, 2))) >= l)
                    {
                        ok = true;
                    }
                }
            }

            if (ok)
            {
                Console.WriteLine("fits = {0}", ok);
            }
            else
            {
                Console.WriteLine("fits = {0}", ok);
            }

            return ok;
        }
    }
}
