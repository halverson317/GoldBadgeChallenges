using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class OutingRepo
    {
        List<OutingInfo> _outings = new List<OutingInfo>();

        public void AddOutingToList(OutingInfo newOuting)
        {
            _outings.Add(newOuting);
        }

        public List<OutingInfo> GetOutingInfo()
        {
            return _outings;
        }


        //Didnt use//
        public decimal AddTotalCost(decimal totalCostByEvent)
        {
            decimal totalCost = 0m;

            foreach (OutingInfo eventCost in _outings)
            {
                totalCostByEvent += totalCost;
            }
            return totalCost;
        }



        public decimal AddCostofOneType(OutingType type)
        {
            decimal totalTypeCost = 0m;

            foreach (OutingInfo outing in _outings)
            {
                if (outing.OutingType == type)
                    totalTypeCost += outing.TotalCostByEvent;
            }
            return totalTypeCost;


        }
    }
}

