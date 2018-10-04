using BusCompanySDM;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace msTestBusCompany
{
    [TestClass]
    public class UnitTest1
    {
        //Tests if the price is 130 if the bus has driven 0 km
        [TestMethod]
        public void InitialPriceTest1()
        {
            IBusCompany bus = new BusCompany();
            var initPrice = 130;
            Assert.IsTrue(bus.TotalCost(1, 0) == initPrice);
        }

        //tests 1km
        [TestMethod]
        public void DistanceShortTest2()
        {
            IBusCompany bus = new BusCompany();
            var km = 1;
            var ppl = 1;
            var priceprkm = 3.20;

            Assert.IsTrue(bus.TotalCost(ppl, km) == 130 + priceprkm * km);
        }
        //tests 100km
        [TestMethod]
        public void DistanceMediumPersonTest3()
        {
            IBusCompany bus = new BusCompany();

            var km = 100;
            var ppl = 1;
            var priceprkm = 2.75;
            Assert.IsTrue(bus.TotalCost(ppl, km) == 130 + km * priceprkm);
        }
        //tests 100km, 12 ppl
        [TestMethod]
        public void DistanceMediumPeopleTest4()
        {
            IBusCompany bus = new BusCompany();
            var km = 100;
            var ppl = 12;
            var priceprkm = 3;
            Assert.IsTrue(bus.TotalCost(ppl, km) == 130 + km * priceprkm);
        }
        //tests 500km
        [TestMethod]
        public void DistanceLongPersonTest5()
        {
            IBusCompany bus = new BusCompany();
            var km = 500;
            var ppl = 1;
            var priceprkm = 2.25;
            Assert.IsTrue(bus.TotalCost(ppl, km) == 130 + km * priceprkm);
        }
        //tests 500 km 100ppl
        [TestMethod]
        public void DistanceLongPeopleTest6()
        {
            IBusCompany bus = new BusCompany();
            var km = 500;
            var ppl = 100;
            var priceprkm = 2.25;
            Assert.IsTrue(bus.TotalCost(ppl, km) == 130 + km * priceprkm);
        }
    }
}
