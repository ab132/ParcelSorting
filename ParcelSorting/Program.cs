namespace ParcelSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            ParcelSorter ps = new ParcelSorter();

            //ps.Box(60, 120, 100, 75);                 //Correct: Fits
            ps.Box(46, 89, 50, 90, 50);                 //Correct: Fits

            //ps.Box(100, 35, 75, 50, 80, 100, 37);     //Fits
            //ps.Box(35, 100, 75, 50, 80, 100, 37);     //Fits

            //ps.Box(70, 50, 60, 60, 55, 90);           //Doesn't fit
        }
    }
}
