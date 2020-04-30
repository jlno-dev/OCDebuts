using System;

namespace LibEntreeSortie
{
    public class ESConsole : EntreeSortie
    {
        public override void AfficherMessage (string pMessage)
        {
            Console.WriteLine(pMessage);
        }

        public override int SaisirEntier()
        {
            string saisie;
            int valSaisie=0;
            do
            {
                saisie = Console.In.ReadLine();
            } while (!int.TryParse(saisie, out valSaisie));
            
            return valSaisie;
        }
    }
}
