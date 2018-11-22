using BusCompanySDM;
using System;
using Xunit;

namespace TestBusCompanyXUNIT
{
    public class UnitTest1
    {

        //tests 500 km 100ppl
        [Fact]
        public void DistanceLongPeopleTest6XUNIT()
        {
            IBusCompany bus = new BusCompany();
            var km = 500;
            var ppl = 100;
            var priceprkm = 2.25;
            Assert.True(bus.TotalCost(ppl, km) == 130 + km * priceprkm);
        }
    }
}
