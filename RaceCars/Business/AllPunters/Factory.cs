namespace RaceCars.Business.AllPunters
{
    public static class Factory
    {
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0: return new Matt();
                case 1: return new Clark();
                case 2: return new Zoe();

                default: return null;
            }
        }
    }
}
