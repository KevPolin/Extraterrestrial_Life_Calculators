using System;

//The Drake Equation
//“How many communicative civilizations are there currently in our galaxy?”

//N = R∗ × fp × ne × fl × fi × fc × L

//The Drake Equation is calculated by multiplying the following:
//1)     R* - stars made in the Milky Way galaxy in one year,
//2)     Fp - the fraction of stars that have planets,
//3)     Ne - the fraction of those planets where life can exist,
//4)     FL - the fraction of those planets where life does exist,
//5)     FI - the fraction of those planets where intelligent life exists,
//6)     FC - the fraction of those intelligent aliens who develop technology that is able to communicate outside of their own planet,
//7)     L - number of years an intelligent, communicating civilization lasts.

//Here is an example from one astrobiologist:
//1)     R* = 10 (astronomers know roughly 10 stars are made per year)
//2)     Fp = 100 % (nearly all stars have planets)
//3)     N3 = 25 % (life can exist in very harsh environments - it would make sense that life could exist on a number of planets)
//4)     FL = 100 % (if life can exist, it will)
//5)     FI = 1 % (not all life will become intelligent)
//6)     FC = 50 % (most intelligent life will be able to invent communication technology such as radio)
//7)     L = 1,000,000 years (intelligent life will exist for a long time)

Console.WriteLine("****************************************************************");
Console.WriteLine("    Drake Equation Calculations with Monte Carlo simulation     ");
Console.WriteLine("****************************************************************");
Console.WriteLine(" ");
Console.WriteLine("Equation: N = R∗ × fp × ne × fl × fi × fc × L");
Console.WriteLine(" ");
Console.WriteLine("N = How many communicative civilizations are there currently in our galaxy");
Console.WriteLine("Stars made in the Milky Way galaxy in one year: between 1 and 20");
Console.WriteLine("Fraction of stars that have planets: between 20% and 100%");
Console.WriteLine("Fraction of those planets where life can exist: between 10% and 30%");
Console.WriteLine("Fraction of those planets where life does exist: between 50% and 100%");
Console.WriteLine("Fraction of those planets where intelligent life exists: 1%");
Console.WriteLine("Fraction of those intelligent aliens who develop technology that is able to communicate outside of their own planet: between 10% and 50%");
Console.WriteLine("Number of years an intelligent, communicating civilization lasts: between 1,000 and 10,000,000 years");
Console.WriteLine(" ");
int n = 1000000;     //change the number of loops
Console.WriteLine("Number of calculations to  be performed: {0}", n.ToString("#,###,##0"));
double sum = 0;

Random random = new Random();
{
    // values of all variable used here are subject to debate, numbers here are for indication only
    for (int i = 1; i <= n; i++)
    {
        /* R* */ int star = random.Next(1, 20);
        /* Fp */ double fraction_star = random.Next(2, 10) * 0.1;
        /* Ne */ double habitable = random.Next(1, 3) * 0.1;
        /* FL */ double life = random.Next(5, 10) * 0.1;
        /* FI */ double life_intelligent = 0.01;
        /* FC */ double communication = random.Next(1, 5) * 0.1;
        /* L  */ int civilization_span = random.Next(1000, 10000000);

        double result = star * fraction_star * habitable * life * life_intelligent * communication * civilization_span;
        sum = sum + result;

        //Console.WriteLine("Calculation Number: {0}", i);
        //Console.WriteLine(" ");
        //Console.WriteLine("R* = {0}", star);
        //Console.WriteLine("Fp = {0}", fraction_star);
        //Console.WriteLine("Ne = {0}", habitable);
        //Console.WriteLine("FL = {0}", life);
        //Console.WriteLine("FI = {0}", life_intelligent);
        //Console.WriteLine("FC = {0}", communication);
        //Console.WriteLine("L = {0}", civilization_span);
        //Console.WriteLine(" ");
        //Console.WriteLine("Esitmated communicating civilizations in our galaxy = {0}", result.ToString("#,###,##0"));
        //Console.WriteLine("---------------------------------------------------------------------------");
        //Console.WriteLine(" ");

        if (i % 10000 == 0)
        {
            Console.WriteLine("Calculations performed so far: {0}", i.ToString("#,###,##0"));
        }

    }

    double average = sum / n;
    Console.WriteLine(" ");
    Console.WriteLine("Average = {0}", average.ToString("#,###,##0"));
}