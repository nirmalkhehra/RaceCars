using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceCars.Business.AllPunters
{
    interface IBettingDetails
    {
        int Won { get; set; }
        int Lost { get; set; }

        int TotalBets();
    }
}
