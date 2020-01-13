using System;
using System.Drawing;
using System.Windows.Forms;

namespace RaceCars.Business.AllPunters
{
    public abstract class Punter
    {
        public string PunterName { get; set; }
        public string F1 { get; set; }
        public Single Cash { get; set; }
        public Single Bet { get; set; }
        public Label LabelWinner { get; set; }
        public Color MyColor { get; set; }
        public NumericUpDown udBet { get; set; }

    }
}
