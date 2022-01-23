namespace ParcelSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            ParcelSorter ps = new ParcelSorter();
            ps.Box(60, 120, 100, 85);                 //Fits

            ps.Box(100, 35, 110, 102);                //Fits
            ps.Box(100, 35, 75, 50, 80, 100, 37);     //Doesn't fit

            ps.Box(70, 50, 120, 75);                  //Fits
            ps.Box(70, 50, 60, 60, 55, 90);           //Doesn't fit
        }
    }
}
