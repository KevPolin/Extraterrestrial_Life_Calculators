using System;
using System.Threading;

namespace DrakeEquationCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Drake Equation Calculator - a simplified Drake Equation Calculator!");
            Thread.Sleep(700);
            Console.WriteLine("The Drake Equation attempts to estimate how many alien civilizations are in a galaxy, using assumptions.");
            Thread.Sleep(700);
            Console.WriteLine("I've tweaked things a bit, for simplicity. If you really want to learn about it, Wikipedia has a nice article.");
            Thread.Sleep(700);
            Console.WriteLine("Let's get your assumptions and see what we come up with!");
            Thread.Sleep(700);
            string letter;
            do
            {
                Drake();
                Console.WriteLine("Press D to try different numbers (or the same, if you're that boring).");
                Console.WriteLine("or any other key to exit!");
                letter = Console.ReadLine();
            }
            while (letter == "D");
        }


        static void Drake()
        {
            Console.WriteLine("How many stars are we assuming for this galaxy, in billions?");
            Console.WriteLine("(The Milky Way is estimated to have 250 billion - so you'd enter 250 for that.)");
            long stars = Convert.ToInt64(Console.ReadLine());
            stars *= 1000000000;
            Console.WriteLine(stars + " stars, got it!");
            Console.WriteLine("What percentage of those stars would you guess have planets? Enter a 2-digit number - for 20% you would just put \"20\")");
            long planetPercent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(planetPercent + "% have stars, we'll assume.");
            long starsWithPlanets = (stars * planetPercent) / 100;
            Console.WriteLine("We've got " + starsWithPlanets + " systems with planets, then.");
            Console.WriteLine("Out of those " + starsWithPlanets + ", what percent do you think COULD support life?");
            long habitablePercent = Convert.ToInt32(Console.ReadLine());
            long habitablePlanets = (starsWithPlanets * habitablePercent) / 100;
            Console.WriteLine("So " + habitablePlanets + " systems where life can exist.");
            Console.WriteLine("With those right ingredients, what percent do you think WILL develop life?");
            long lifePercent = Convert.ToInt32(Console.ReadLine());
            long inhabitedPlanets = (habitablePlanets * lifePercent) / 100;
            Console.WriteLine("Ok, that's " + inhabitedPlanets + " systems where some kind of life emerges.");
            Console.WriteLine("From those " + inhabitedPlanets + " planets with life, what percent do you think will reach sentience?");
            Console.WriteLine("(Ok, sapience - but you're a nerd if you had that objection!)");
            long intelligentPercent = Convert.ToInt32(Console.ReadLine());
            long intelligentPlanets = (inhabitedPlanets * intelligentPercent) / 100;
            Console.WriteLine("Really narrowing it down! " + intelligentPlanets + " species in this galaxy as dumb as the average human Err, smart!");
            Console.WriteLine("What percentage of those " + intelligentPlanets + " species do you think will learn to cooperate in societies, developing civilizations?");
            long civilizedPercent = Convert.ToInt32(Console.ReadLine());
            long civilizedPlanets = (intelligentPlanets * civilizedPercent) / 100;
            if (civilizedPlanets >= 1)
            {
                Console.WriteLine("An optimist I see!");
            }
            else
            {
                Console.WriteLine("Ah, a misanthrope after my own heart!");
            }
            Console.WriteLine("Last question! " + civilizedPlanets + " civilized planets - what percent do you think will be similar enough for us to detect?.");
            long detectablePercent = Convert.ToInt32(Console.ReadLine());
            long detectablePlanets = (civilizedPlanets * detectablePercent) / 100;
            Console.WriteLine("Calculating...");
            Thread.Sleep(600);
            Console.WriteLine("Calculating...");
            Thread.Sleep(500);
            Console.WriteLine("Calculating...");
            Thread.Sleep(400);
            Console.WriteLine("Calculating...");
            Thread.Sleep(300);
            Console.WriteLine("Calculating...");
            Thread.Sleep(200);
            Console.WriteLine("Calculating...");
            Thread.Sleep(100);
            Console.WriteLine("Ok, I've skipped complicated details about whether their signals and our civilizations will overlap - you wouldn't understand it anyway.");
            if (detectablePlanets >= 1)
            {
                Console.WriteLine("Based on your assumptions, there are " + detectablePlanets + " intelligent species in this galaxy. So why haven't we found any?");
            }
            else
            {
                Console.WriteLine("Based on your assumptions, we're alone in this galaxy. It's cool - the aliens wouldn't like you anyway.");
            }
        }
    }
}