namespace LibJeux.TuerMonstres
{
    public class MonstreFacile : Personnage
    {
        public MonstreFacile(string pNom, int pPointDeVie) : base(pNom, pPointDeVie, ENiveau.Facile)
        {

        }
        protected override int LancerAttaque(Armes pArme)
        {
            return pArme.Attaquer();
        }

        protected override int LancerEsquive(Armes pArme)
        {
            return pArme.Esquiver();
        }
        protected override void CalculerDegats(int pPtDegats)
        {

        }
    }
}
