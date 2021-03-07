using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgeCalculatorService
{

    public class CalculateAge : IService1
    {

        public int calculateDays(int day, int Month, int year)
        {
            DateTime dt = new DateTime(year, Month, day);
            int datetodays = DateTime.Now.Subtract(dt).Days;
            return datetodays;
        }

    }

}
