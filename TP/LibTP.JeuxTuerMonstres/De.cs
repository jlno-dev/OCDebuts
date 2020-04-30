using System;


namespace LibJeux.TuerMonstres
{
    public static class De
    {
        public static int Lancer(int pNbFaces)
        {
            return new Random().Next(1, pNbFaces);
        }
    }
}
