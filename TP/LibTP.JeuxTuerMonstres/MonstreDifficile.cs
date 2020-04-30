
namespace LibJeux.TuerMonstres
{
    public class MonstreDifficile : MonstreFacile
    {
        public MonstreDifficile(string pNom, int pPointDeVie ) : base(pNom, pPointDeVie)
        {
            Niveau = ENiveau.Difficile;
        }
        protected override int LancerAttaque(Armes pArme)
        {
            return pArme.Attaquer();
        }

        protected override int LancerEsquive(Armes pArme)
        {
            return pArme.Esquiver();
        }
    }
}
