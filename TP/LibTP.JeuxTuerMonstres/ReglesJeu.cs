namespace LibJeux.TuerMonstres
{
    static public class ReglesJeu
    {
        static public void GererAttaque(Personnage pAttaquant, Armes pArmeAttaquant, Personnage pDefenseur, Armes pArmeDef)
        {
            int degatsAttaque;
            if ( pAttaquant is Joueur)
            {
                if (pAttaquant.Attaquer(pArmeAttaquant) >= pDefenseur.Esquiver(pArmeDef))
                {
                    pDefenseur.PerdreVie();
                }
            }
            else
            {
                if ((degatsAttaque=pAttaquant.Attaquer(pArmeAttaquant)) > pDefenseur.Esquiver(pArmeDef))
                    pDefenseur.SubirDegats(degatsAttaque);
                if (pAttaquant.Niveau == ENiveau.Difficile)
                {
                    pDefenseur.SubirDegats(pAttaquant.Attaquer(new SortDe(6)));
                }
            }
        }

        static public void GererAttaqueBoss(Personnage pAttaquant, Armes pArmeAttaquant, Personnage pDefenseur, Armes pArmeDef)
        {
            int degatsAttaque = pAttaquant.Attaquer(pArmeAttaquant);
            if (degatsAttaque > pDefenseur.Esquiver(pArmeDef))
                pDefenseur.SubirDegats(degatsAttaque);
        }
    }
}
