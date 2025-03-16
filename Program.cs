

/* FIND HOLGER OPGAVE
 * Der skal laves et program der kan udskrive 40 rækker med 40 tilfældige bogstaver i hver række
 * Ét af bogstaverne skal erstattes med et @
 * Spillet handler om at finde @’et
 * 
 * Udvidelser til ekstra udfordring:
 * - Prøv at lege med om det er store eller små bogstaver der skrives
 * - Prøv at skifte farve på bogstaverne
 * - Prøv at lave en måde hvor man kan indtaste en løsning (måske med koordinater)*/


//Giver herunder muligheden for at vælge størrelse på spilleplade.
Console.WriteLine("Indtast ønskede størrelse på spillepladen.");
string spillepladeStørrelseSTR = Console.ReadLine();
Console.WriteLine("Du har valgt størrelsen " + spillepladeStørrelseSTR + " x " + spillepladeStørrelseSTR);



//Holger x-akse
int spillepladeStørrelseINT = Convert.ToInt16(spillepladeStørrelseSTR);
Random rndHolX = new Random();
int tilfældigHolgerX = rndHolX.Next(1, spillepladeStørrelseINT);

//Holger y-akse

Random rndHolY = new Random();
int tilfældigHolgerY = rndHolY.Next(1, spillepladeStørrelseINT);

//Spillepladen 

List<string> holgerLinje = new List<string>();
Random tilfældigInt = new Random();


for (int i = 1; i < spillepladeStørrelseINT + 1; i++)
{
    if (i == tilfældigHolgerY)
    {
        for (int x = 1; x < spillepladeStørrelseINT + 1; x++)
        {

            int tilfældigIntModHolger = tilfældigInt.Next(1, 26);
            if (x == tilfældigHolgerX)
            { holgerLinje.Add("@"); }
            else if (tilfældigIntModHolger == 1)
            { holgerLinje.Add("a"); }
            else if (tilfældigIntModHolger == 2)
            { holgerLinje.Add("b"); }
            else if (tilfældigIntModHolger == 3)
            { holgerLinje.Add("c"); }
            else if (tilfældigIntModHolger == 4)
            { holgerLinje.Add("d"); }
            else if (tilfældigIntModHolger == 5)
            { holgerLinje.Add("e"); }
            else if (tilfældigIntModHolger == 6)
            { holgerLinje.Add("f"); }
            else if (tilfældigIntModHolger == 7)
            { holgerLinje.Add("g"); }
            else if (tilfældigIntModHolger == 8)
            { holgerLinje.Add("h"); }
            else if (tilfældigIntModHolger == 9)
            { holgerLinje.Add("i"); }
            else if (tilfældigIntModHolger == 10)
            { holgerLinje.Add("j"); }
            else if (tilfældigIntModHolger == 11)
            { holgerLinje.Add("k"); }
            else if (tilfældigIntModHolger == 12)
            { holgerLinje.Add("l"); }
            else if (tilfældigIntModHolger == 13)
            { holgerLinje.Add("m"); }
            else if (tilfældigIntModHolger == 14)
            { holgerLinje.Add("n"); }
            else if (tilfældigIntModHolger == 15)
            { holgerLinje.Add("o"); }
            else if (tilfældigIntModHolger == 16)
            { holgerLinje.Add("p"); }
            else if (tilfældigIntModHolger == 17)
            { holgerLinje.Add("q"); }
            else if (tilfældigIntModHolger == 18)
            { holgerLinje.Add("r"); }
            else if (tilfældigIntModHolger == 19)
            { holgerLinje.Add("s"); }
            else if (tilfældigIntModHolger == 20)
            { holgerLinje.Add("t"); }
            else if (tilfældigIntModHolger == 21)
            { holgerLinje.Add("u"); }
            else if (tilfældigIntModHolger == 22)
            { holgerLinje.Add("v"); }
            else if (tilfældigIntModHolger == 23)
            { holgerLinje.Add("w"); }
            else if (tilfældigIntModHolger == 24)
            { holgerLinje.Add("x"); }
            else if (tilfældigIntModHolger == 25)
            { holgerLinje.Add("y"); }
            else if (tilfældigIntModHolger == 26)
            { holgerLinje.Add("z"); }
            else if (tilfældigIntModHolger == 26)
            { holgerLinje.Add("æ"); }


        }
        holgerLinje.ForEach(Console.Write);

        Console.Write(" \n");
        holgerLinje.Clear();


    }
    else
    {
        for (int x = 1; x < spillepladeStørrelseINT + 1; x++)
        {
            int tilfældigIntModHolger = tilfældigInt.Next(1, 26);
            if (tilfældigIntModHolger == 1)
            { holgerLinje.Add("a"); }
            else if (tilfældigIntModHolger == 2)
            { holgerLinje.Add("b"); }
            else if (tilfældigIntModHolger == 3)
            { holgerLinje.Add("c"); }
            else if (tilfældigIntModHolger == 4)
            { holgerLinje.Add("d"); }
            else if (tilfældigIntModHolger == 5)
            { holgerLinje.Add("e"); }
            else if (tilfældigIntModHolger == 6)
            { holgerLinje.Add("f"); }
            else if (tilfældigIntModHolger == 7)
            { holgerLinje.Add("g"); }
            else if (tilfældigIntModHolger == 8)
            { holgerLinje.Add("h"); }
            else if (tilfældigIntModHolger == 9)
            { holgerLinje.Add("i"); }
            else if (tilfældigIntModHolger == 10)
            { holgerLinje.Add("j"); }
            else if (tilfældigIntModHolger == 11)
            { holgerLinje.Add("k"); }
            else if (tilfældigIntModHolger == 12)
            { holgerLinje.Add("l"); }
            else if (tilfældigIntModHolger == 13)
            { holgerLinje.Add("m"); }
            else if (tilfældigIntModHolger == 14)
            { holgerLinje.Add("n"); }
            else if (tilfældigIntModHolger == 15)
            { holgerLinje.Add("o"); }
            else if (tilfældigIntModHolger == 16)
            { holgerLinje.Add("p"); }
            else if (tilfældigIntModHolger == 17)
            { holgerLinje.Add("q"); }
            else if (tilfældigIntModHolger == 18)
            { holgerLinje.Add("r"); }
            else if (tilfældigIntModHolger == 19)
            { holgerLinje.Add("s"); }
            else if (tilfældigIntModHolger == 20)
            { holgerLinje.Add("t"); }
            else if (tilfældigIntModHolger == 21)
            { holgerLinje.Add("u"); }
            else if (tilfældigIntModHolger == 22)
            { holgerLinje.Add("v"); }
            else if (tilfældigIntModHolger == 23)
            { holgerLinje.Add("w"); }
            else if (tilfældigIntModHolger == 24)
            { holgerLinje.Add("x"); }
            else if (tilfældigIntModHolger == 25)
            { holgerLinje.Add("y"); }
            else if (tilfældigIntModHolger == 26)
            { holgerLinje.Add("z"); }
            else if (tilfældigIntModHolger == 26)
            { holgerLinje.Add("æ"); }
        }
        holgerLinje.ForEach(Console.Write);

        Console.Write(" \n");
        holgerLinje.Clear();
    }
}

   



