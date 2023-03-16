using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities;

public class Methods
{

    EFTestContext context;
    public Methods()
    {
        this.context = new EFTestContext();

    }
    public void LijstLAnden()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine("Lijst van Landen");
        Console.WriteLine("----------------------");
        var query = from land in context.Landen
                    orderby land.Naam
                    select land;

        foreach (var land in query)
            Console.WriteLine("{0,-30}{1,-30}{2,-30}{3}",
                land.ISOLandCode, land.Naam, land.AantalInwoners, land.Oppervlakte);
        
       
    }

    public string GeefLandCode()
    {
        Console.Write("\n\n\t\t Geef een land code in : ");
        var landcode = Console.ReadLine();
        if (landcode != null)
        {
            NaamVanLand(landcode);
            return landcode;
        }
        else
            Console.WriteLine("\nGeef een code uit de lijst van landen");
        return "\nGeef een code uit de lijst van landen";
    }

    public string NaamVanLand(string landcode)
    {

        var gekozenLand = context.Landen.FirstOrDefault(l => l.ISOLandCode == landcode);
        string landNaam;
       
        if(gekozenLand != null)
        {
            landNaam = gekozenLand.Naam;
            return landNaam;

        }

            GeefLandCode();
            Console.WriteLine("Er is geen land met dit code , kies uit het lijst");
            return "";
            
        }
        

    

    public void ListStaden(string landNaam)
    {
        var Land = context.Landen.Include("staden")
                   .FirstOrDefault(c => c.Naam == landNaam);


            Console.WriteLine("----------------------");
            Console.WriteLine("Lijst van Steden");
            Console.WriteLine("----------------------");
        if (Land.staden.Count > 0)
        {
            foreach (var stad in Land.staden)
                Console.WriteLine(stad.Naam);
        }
        else
            Console.WriteLine("");

    }

    public void ListTalen(string landNaam)
    {
        var Land = context.Landen.Include("Talen")
                   .FirstOrDefault(c => c.Naam == landNaam);


        Console.WriteLine("----------------------");
        Console.WriteLine("Lijst van Talen");
        Console.WriteLine("----------------------");
        if (Land.Talen.Count > 0) { 
            foreach (var taal in Land.Talen)
                Console.WriteLine(taal.NaamTaal);
        }
        Console.WriteLine("");

    }

    public void WijzigLand(string landNaam)
    {
        var Land = context.Landen.FirstOrDefault(c => c.Naam == landNaam);
        Console.WriteLine("Gegevens land {0}",landNaam);
        Console.WriteLine("\t\tAantal inwoners:  {0}", Land.AantalInwoners);
        Console.WriteLine("\t\tOppervlakte:  {0}", Land.Oppervlakte);

        try
        {
            Console.Write("Wijzig aantal inwoners (<Enter> = niet wijzegen) : ");

            int inwoners = int.Parse(Console.ReadLine());
            Console.Write("Wijzig oppervlakte (<Enter> = niet wijzegen) : ");
            float oppervlakte = float.Parse(Console.ReadLine());

            if (inwoners != 0 && oppervlakte != 0)
            {
                Land.AantalInwoners = inwoners;
                Land.Oppervlakte = oppervlakte;

                context.SaveChanges();
            }

        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
        
    }

    public void StadToevoegen(string landNaam)
    {
        Console.Write("Geef de naam van een nieuwe stad : ");
        var nieuweStad = Console.ReadLine();
        if(nieuweStad != null)
        {
            var Land = context.Landen.FirstOrDefault(c => c.Naam == landNaam);
            context.Staden.Add(new Stad { Naam = nieuweStad, IsoLandCode = Land.ISOLandCode });
            context.SaveChanges();
            printRepeate(Land.Naam);
        }

    }

    public void StadVerdwijnen(string landNaam)
    {
        Console.WriteLine("kies een stad : ");
        Console.WriteLine("-----------------------------");
        var Land = context.Landen.Include("staden").FirstOrDefault(c => c.Naam == landNaam);
        List<Stad> staden = Land.staden.ToList();
        int index = 0;
        if (staden.Count > 0)
        {
            index++;
            foreach (var stad in staden)
            {
                Console.WriteLine("{0,-10} {1}", index, stad.Naam);
                index++;
            }
            index= 0;
            Console.WriteLine("\n Geef het volgnummer uit de lijst ");
            if (int.TryParse(Console.ReadLine(), out int volgnummer))
            {
                if (volgnummer <= staden.Count)
                {
                    Console.WriteLine("Verwijderen van stad {0}", staden[volgnummer - 1].Naam);
                    Land.staden.Remove(staden[volgnummer - 1]);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Schrijve een getal van {0} tot {1}", 1, staden.Count);
                }
            }
            else
            { Console.WriteLine("Je moet een correcte getal invoegen"); }
        }else
        { Console.WriteLine("Dit land heeft geen staden"); }


    }

    public string printRepeate(string landNaam)
    {
        Console.WriteLine("\n\n----------------------");
        Console.WriteLine("M E N U  -  {0}  ", landNaam);
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
        
        string keuze = Console.ReadLine();
        if (keuze != null)
        {
            return keuze;
        }
        else
            return "\n\n\t\t Geef u keuze (LWSATVX)* : ";
        ;

    }

}

