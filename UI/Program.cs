using Model.Entities;


Console.WriteLine("========================");
Console.WriteLine("Landen , Steden en Talen");

Console.WriteLine("========================\n\n");



Console.WriteLine("----------------------");
Console.WriteLine("M E N U  -  Geen land gekozen");
Console.WriteLine("----------------------");


Console.WriteLine("Lijst <L>anden");
Console.WriteLine("e<X>it\n");
Console.Write("\t\t Geef u keuze (LX)* : ");

var landOrExit = Console.ReadLine();
while(landOrExit != "")
{
    Methods m = new Methods();
    if(!landOrExit.Equals("x"))
    {
       
        if (landOrExit.Equals("l"))
        {
            m.LijstLAnden();


            var landcode = m.GeefLandCode();

            if (landcode != null)
            {
                var landNaam = m.NaamVanLand(landcode);
                
                var keuze = m.printRepeate(landNaam); ;
                while (keuze != null)
                {
                    switch (keuze)
                    {

                        case "l":
                            m.LijstLAnden();
                            landcode = m.GeefLandCode();
                            landNaam = m.NaamVanLand(landcode);
                            keuze = m.printRepeate(landNaam);
                            break;

                        case "s":
                            m.ListStaden(landNaam);
                            keuze = m.printRepeate(landNaam);
                            break;

                        case "a":
                            m.ListTalen(landNaam);
                            keuze = m.printRepeate(landNaam);
                            break;

                        case "w":
                            m.WijzigLand(landNaam);
                            keuze = m.printRepeate(landNaam);
                            break;

                        case "t":
                            m.StadToevoegen(landNaam);
                            keuze = m.printRepeate(landNaam);
                            break;

                        case "v":
                            m.StadVerdwijnen(landNaam);
                            keuze = m.printRepeate(landNaam);
                            break;

                        case "x":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Verkeerde keuze");
                            keuze = m.printRepeate(landNaam);
                            break;

                    }
                }
                
                    Console.WriteLine("Kies een letter");
                    Environment.Exit(0);

               
            }
            else
                Console.WriteLine("\nU moet een land code uit het lijst geven");

        }
    }else
        Environment.Exit(0);
    
}
    Console.WriteLine("U geeft geen keuze (kies uit (L-X))");
        





