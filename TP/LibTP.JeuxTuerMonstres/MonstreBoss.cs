using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LibJeux.TuerMonstres
{
    public class MonstreBoss : Personnage
    {
        public MonstreBoss(string pNom, int pPtVie) : base(pNom, pPtVie, ENiveau.BossFinVie)
        {
        }

        protected override void CalculerDegats(int pPtDegats)
        {
            PointDeVie -= pPtDegats;
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
