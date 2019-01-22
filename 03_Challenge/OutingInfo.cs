using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{   
    public enum OutingType { Golf, Bowling, AmmusmentPark, Concert}

    public class OutingInfo
    {
        public OutingType OutingType { get; set; }
        public int NumberOfPeople { get; set; }
        public string Date { get; set; }
        public decimal TotalCostPerPerson { get; set; }
        public decimal TotalCostByEvent { get; set; }

        public OutingInfo(OutingType outingType, int numberOfPeople, string date, decimal totalCostPerPerson, decimal totalCostByEvent)
        {
            OutingType = outingType;
            NumberOfPeople = numberOfPeople;
            Date = date;
            TotalCostPerPerson = totalCostPerPerson;
            TotalCostByEvent = totalCostByEvent;
                
        }

        public OutingInfo()
        {

        }
    }
}
