using System;
using System.Collections.Generic;
using System.Text;

namespace BusCompanySDM
{
    public interface IBusCompany
    {
        double TotalCost(int noOfPassengers, int km);
    }
}
