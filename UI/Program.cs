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
if (landOrExit != null)
{
    Methods m = new Methods();
    if (landOrExit.Equals("l"))
    {
        Console.WriteLine("----------------------");
        Console.WriteLine("Lijst van Landen");
        Console.WriteLine("----------------------");

        using var context = new EFTestContext();
        // 1 - 2
        /*var query = from land in context.Landen
                    orderby land.Naam
                    select land;

        foreach (var land in query)
            Console.WriteLine("{0,-30}{1,-30}{2,-30}{3}", 
                land.ISOLandCode, land.Naam, land.AantalInwoners, land.Oppervlakte);
        */
        m.LijstLAnden();

        //3 
        Console.Write("\n\n\t\t Geef een land code in : ");
       var landcode = Console.ReadLine();

        if (landcode != null)
        {
            var landNaam = m.kizeLand(landcode);
            /*var gekozenLand = from land in context.Landen
                               where land.ISOLandCode == landcode
                               select land;
            if(gekozenLand.Count() != 0) {
                var landNaam = gekozenLand.FirstOrDefault().Naam;
                    Console.WriteLine("----------------------");
                    Console.WriteLine("M E N U  -  {0}  ",landNaam );
                    Console.WriteLine("----------------------");
                

                // 4 

                Console.WriteLine("Lijst <L>anden");
                Console.WriteLine("<W>ijzig Land");
                Console.WriteLine("Lijst <S>teden");
                Console.WriteLine("Lijst T<A>len");
                Console.WriteLine("Stad <T>oevoegen");
                Console.WriteLine("Stad <V>erwijderen");
                Console.WriteLine("e<X>it");
                Console.Write("\n\n\t\t Geef u keuze (LWSATVX)* : ");
            */
                var keuze = m.printRepeate(landNaam); ;
                if (keuze != null)
                {
                    switch (keuze) {

                        case "l": m.LijstLAnden();
                               keuze =  m.printRepeate(landNaam);
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


                    default:
                        Console.WriteLine("Verkeerde keuze");
                        m.printRepeate(landNaam);
                        break;

                    }
                }
                else
                    Console.WriteLine("Kies een letter");


            /*}
            else
                Console.WriteLine("\nGeef een code uit de lijst van landen");*/
        }
        else
            Console.WriteLine("\nU moet een land code geven");

    }
    else if (landOrExit.Equals("x"))
        Environment.Exit(0);
}
else
    Console.WriteLine("U geeft geen keuze");
        





