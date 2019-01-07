using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotterySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int plays = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int fiveb = 0;
            int moneyspent = 0;
            int wins = 0;
            int twob = 0;

            int counter = 50;
            while (counter == 50)
            {
                int draw1 = rnd.Next(1, 50);  // numbers 1 to 49
                int draw2 = rnd.Next(1, 50);  // numbers 1 to 49
                if (draw2 == draw1)
                {
                    int temp2 = rnd.Next(1, 50);
                    draw2 = temp2;
                }
                int draw3 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((draw3 == draw2) || (draw3 == draw1))
                {
                    int temp3 = rnd.Next(1, 50);
                    draw3 = temp3;
                }
                int draw4 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((draw4 == draw3) || (draw4 == draw3) || (draw4 == draw1))
                {
                    int temp4 = rnd.Next(1, 50);
                    draw4 = temp4;
                }
                int draw5 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((draw5 == draw4) || (draw5 == draw3) || (draw5 == draw2) || (draw5 == draw1))
                {
                    int temp5 = rnd.Next(1, 50);
                    draw5 = temp5;
                }
                int draw6 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((draw6 == draw5) || (draw6 == draw4) || (draw6 == draw3) || (draw6 == draw2) || (draw6 == draw1))
                {
                    int temp6 = rnd.Next(1, 50);
                    draw6 = temp6;
                }

                int bonus = rnd.Next(1, 50);  // numbers 1 to 49

                if ((bonus == draw6) || (bonus == draw5) || (bonus == draw4) || (bonus == draw3) || (bonus == draw2) || (bonus == draw1))
                {
                    int bonustemp = rnd.Next(1, 50);
                    bonus = bonustemp;
                }

                //-----

                int m1 = rnd.Next(1, 50);  // numbers 1 to 49
                int m2 = rnd.Next(1, 50);  // numbers 1 to 49
                if (m2 == m1)
                {
                    int tempm2 = rnd.Next(1, 50);
                    m2 = tempm2;
                }
                int m3 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((m3 == m2) || (m3 == m1))
                {
                    int tempm3 = rnd.Next(1, 50);
                    m3 = tempm3;
                }
                int m4 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((m4 == m3) || (m4 == m3) || (m4 == m1))
                {
                    int tempm4 = rnd.Next(1, 50);
                    m4 = tempm4;
                }
                int m5 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((m5 == m4) || (m5 == m3) || (m5 == m2) || (m5 == m1))
                {
                    int tempm5 = rnd.Next(1, 50);
                    m5 = tempm5;
                }
                int m6 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((m6 == m5) || (m6 == m4) || (m6 == m3) || (m6 == m2) || (m6 == m1))
                {
                    int tempm6 = rnd.Next(1, 50);
                    m6 = tempm6;
                }

                //----

                plays += 1;
                moneyspent += 3;
                Console.Write("x");
                int handcounter = 0;
                int bonuscounter = 0;

                int hand1 = rnd.Next(1, 50);  // numbers 1 to 49
                int hand2 = rnd.Next(1, 50);  // numbers 1 to 49
                if (hand2 == draw1)
                {
                    int temp2 = rnd.Next(1, 50);
                    hand2 = temp2;
                }
                int hand3 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((hand3 == hand2) || (hand3 == hand1))
                {
                    int temp3 = rnd.Next(1, 50);
                    hand3 = temp3;
                }
                int hand4 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((hand4 == hand3) || (hand4 == hand3) || (hand4 == hand1))
                {
                    int temp4 = rnd.Next(1, 50);
                    hand4 = temp4;
                }
                int hand5 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((hand5 == hand4) || (hand5 == hand3) || (hand5 == hand2) || (hand5 == hand1))
                {
                    int temp5 = rnd.Next(1, 50);
                    hand5 = temp5;
                }
                int hand6 = rnd.Next(1, 50);  // numbers 1 to 49

                if ((hand6 == hand5) || (hand6 == hand4) || (hand6 == hand3) || (hand6 == hand2) || (hand6 == hand1))
                {
                    int temp6 = rnd.Next(1, 50);
                    hand6 = temp6;
                }

                if ((hand1 == draw1) || (hand1 == draw2) || (hand1 == draw3) || (hand1 == draw4) || (hand1 == draw5) || (hand1 == draw6)) handcounter += 1;
                if ((hand2 == draw1) || (hand2 == draw2) || (hand2 == draw3) || (hand2 == draw4) || (hand2 == draw5) || (hand2 == draw6)) handcounter += 1;
                if ((hand3 == draw1) || (hand3 == draw2) || (hand3 == draw3) || (hand3 == draw4) || (hand3 == draw5) || (hand3 == draw6)) handcounter += 1;
                if ((hand4 == draw1) || (hand4 == draw2) || (hand4 == draw3) || (hand4 == draw4) || (hand4 == draw5) || (hand4 == draw6)) handcounter += 1;
                if ((hand5 == draw1) || (hand5 == draw2) || (hand5 == draw3) || (hand5 == draw4) || (hand5 == draw5) || (hand5 == draw6)) handcounter += 1;
                if ((hand6 == draw1) || (hand6 == draw2) || (hand6 == draw3) || (hand6 == draw4) || (hand6 == draw5) || (hand6 == draw6)) handcounter += 1;
                if ((bonus == draw1) || (bonus == draw2) || (bonus == draw3) || (bonus == draw4) || (bonus == draw5) || (bonus == draw6)) bonuscounter += 1;

                /*
                if ((hand1 == draw1) || (hand1 == draw2) || (hand1 == draw3) || (hand1 == draw4) || (hand1 == draw5) || (hand1 == draw6)) handcounter += 1;
                if ((hand2 == draw1) || (hand2 == draw2) || (hand2 == draw3) || (hand2 == draw4) || (hand2 == draw5) || (hand2 == draw6)) handcounter += 1;
                if ((hand3 == draw1) || (hand3 == draw2) || (hand3 == draw3) || (hand3 == draw4) || (hand3 == draw5) || (hand3 == draw6)) handcounter += 1;
                if ((hand4 == draw1) || (hand4 == draw2) || (hand4 == draw3) || (hand4 == draw4) || (hand4 == draw5) || (hand4 == draw6)) handcounter += 1;
                if ((hand5 == draw1) || (hand5 == draw2) || (hand5 == draw3) || (hand5 == draw4) || (hand5 == draw5) || (hand5 == draw6)) handcounter += 1;
                if ((hand6 == draw1) || (hand6 == draw2) || (hand6 == draw3) || (hand6 == draw4) || (hand6 == draw5) || (hand6 == draw6)) handcounter += 1;
                if ((bonus == draw1) || (bonus == draw2) || (bonus == draw3) || (bonus == draw4) || (bonus == draw5) || (bonus == draw6)) bonuscounter += 1; */ //Change to million

                if (handcounter == 6)
                {
                    counter += 1;
                    wins += 7000000;
                    Console.Write("O");
                }

                if ((handcounter == 5) && (bonuscounter == 1))
                {
                    fiveb += 1;
                    //counter += 1;
                    wins += 75537;
                    Console.Write("O");
                }


                if ((handcounter == 5) && (bonuscounter == 0))
                {
                    five += 1;
                    //counter += 1;
                    wins += 1833;
                    Console.Write("O");
                }

                if (handcounter == 4)
                {
                    four += 1;
                    //counter += 1;
                    wins += 72;
                    Console.Write("O");
                }
                if (handcounter == 3)
                {
                    three += 1;
                    // counter += 1;
                    wins += 10;
                    Console.Write("O");
                }
                if ((handcounter == 2) && (bonuscounter == 0))
                {
                    two += 1;
                    //counter += 1;
                }

                if ((handcounter == 2) && (bonuscounter == 1))
                {
                    twob += 1;
                    //counter += 1;
                    wins += 5;
                }

                bonuscounter = 0;
                handcounter = 0;
            }
            Console.WriteLine("\n");
            Console.WriteLine(moneyspent + " dollars was spent");
            Console.WriteLine(wins + " dollars was won");
            Console.WriteLine("Tickets that won 2/6: " + two);
            Console.WriteLine("Tickets that won 2/6 and Bonus: " + twob);
            Console.WriteLine("Tickets that won 3/6: " + three);
            Console.WriteLine("Tickets that won 4/6: " + four);
            Console.WriteLine("Tickets that won 5/6: " + five);
            Console.WriteLine("Tickets that won 5/6 and bonus: " + fiveb);
            Console.WriteLine("Tickets bought " + plays);
            Console.ReadKey();
        }
    }
}
