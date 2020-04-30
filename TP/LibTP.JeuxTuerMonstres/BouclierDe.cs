
namespace LibJeux.TuerMonstres
{
    public class BouclierDe : Armes
    {
        public BouclierDe(int pNbFaces) : base(0, pNbFaces)
        {
        }
        protected override int LancerAttaque()
        {
            return PointAttque;
        }

        protected override int UtiliserEsquive()
        {
            if (De.Lancer(PointEsquive)<=2)
                return 0;
            else
                return -10;
        }
    }
}
