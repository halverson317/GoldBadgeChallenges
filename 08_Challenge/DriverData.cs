using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class DriverData
    {
        //properies set as int will reflect %s rounded up or down to nearest whole number//

        public int SmartCarID { get; set; }
        public int OverSL { get; set; }
        public int Swerve { get; set; }
        public int RollSS { get; set; }
        public int Tailgate { get; set; }

        public DriverData(int smartCarID, int overSL, int swerve, int rollSS, int tailgate)
        {
            SmartCarID = smartCarID;
            OverSL = overSL;
            Swerve = swerve;
            RollSS = rollSS;
            Tailgate = tailgate;

        }

        public DriverData()
        {

        }

    }
}
