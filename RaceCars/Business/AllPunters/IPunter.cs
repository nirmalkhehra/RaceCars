using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceCars.Business.AllPunters
{
    interface IPunter
    {
        string PunterName { get; set; }
        string F1 { get; set; }

        Single Cash {get; set;}

        Single Bet { get; set; }

        System.Windows.Forms.Label LabelWinner { get; set; }
        Color MyColor { get; set; }

        TextBox txtBet { get; set; }


    }
}
