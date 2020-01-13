using System.Drawing;

namespace RaceCars.Business.AllPunters
{
    class Clark : Punter, IBettingDetails
    {
        public Clark()
        {
            PunterName = "Clark";
            F1 = "";
            Cash = 50;
            MyColor = Color.Maroon;
        }


        public int Won { get; set; }
        public int Lost { get; set; }

        public int TotalBets()
        {
            return Won + Lost;
        }
    }
}
