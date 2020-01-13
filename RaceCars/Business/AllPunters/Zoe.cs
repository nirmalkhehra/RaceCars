using System.Drawing;

namespace RaceCars.Business.AllPunters
{
    class Zoe : Punter, IBettingDetails
    {
        public Zoe()
        {
            PunterName = "Zoe";
            F1 = "";
            Cash = 50;
            MyColor = Color.LightSeaGreen;
        }


        public int Won { get; set; }
        public int Lost { get; set; }

        public int TotalBets()
        {
            return Won + Lost;
        }
    }
}
