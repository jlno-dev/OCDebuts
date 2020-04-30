namespace LibJeux.TuerMonstres
{
    public class Joueur : Personnage
    {
        public Joueur(string pNom, int pPointDeVie) : base(pNom, pPointDeVie, ENiveau.Normal)
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
            PointDeVie += new BouclierDe(6).Esquiver();
        }
    }
}
