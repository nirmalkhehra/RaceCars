using System.Drawing;

namespace RaceCars.Business.AllPunters
{
    class Matt : Punter, IBettingDetails
    {
        public Matt()
        {
            PunterName = "Matt";
            F1 = "";
            Cash = 50;
            MyColor = Color.DarkSlateBlue;
        }


        public int Won { get; set; }
        public int Lost { get; set; }

        public int TotalBets()
        {
            return Won + Lost;
        }
    }
}
