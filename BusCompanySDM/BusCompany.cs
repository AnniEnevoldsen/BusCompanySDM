using System;
using System.Collections.Generic;
using System.Text;

namespace BusCompanySDM
{
    public class BusCompany : IBusCompany
    {
        /**
         * Initial price is 130. 
         * if km is smaller than 100, or between 100 and 500 or above 500
         * if noOfPassengers traveling between 100-500km is above or below 12.
        */
        public double TotalCost(int noOfPassengers, int km)
        {
            int price = 130;

            if (km >= 100 && km < 500)
            {
                if (noOfPassengers < 12)
                {
                    return 2.75 * km + price;
                }
                return 3.00 * km + price;
            }
            else if (km >= 500)
            {
                return 2.25 * km + price;
            }
            return price + 3.20 * km;
        }
    }
}
