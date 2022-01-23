using NUnit.Framework;
using System;
using Xunit;

namespace ParcelSortingTests
{
    [TestFixture]
    public class ParcelSortingTests
    {
        [Test]
        public void RunningParcelThroughLine_ShouldReturnFalseIfDoesntFit()
        {
            ParcelSorting.ParcelSorter ps = new ParcelSorting.ParcelSorter();

            var ok = ps.Box(100, 35, 75, 50, 80, 100, 37);

            NUnit.Framework.Assert.That(ok == false);
        }

        [Test]
        public void RunningParcelThroughLine_ShouldReturnTrueIfFits()
        {
            ParcelSorting.ParcelSorter ps = new ParcelSorting.ParcelSorter();

            var ok = ps.Box(60, 120, 100, 85);

            NUnit.Framework.Assert.That(ok == true);
        }
    }
}
