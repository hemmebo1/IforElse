using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace if_och_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i >= 0)
            {
                i++;
                //välja uppgift
                Console.WriteLine("");
                Console.WriteLine("Vilken uppgift vill du göra: ");
                Console.WriteLine(" 1 (Mönsterdjup) \n 2 (Brickan) \n 3 (Största Talet) \n 4 (Delbarhet med 7) \n 5 (Namn och Ålder) \n 6 (Svar på två Nummer) \n 7 (Celcius till Fahrenheit) \n 8 (Omgretsen på en Cirkel) \n 9 (räkna till 100) \n 10 (Nedräkning från 20) \n 11 (Ojämna tal till 50) \n 12 (Start, Stop) \n 13 (TryItOut Namn Nummer)  \n 99 (guess numbergame) \n 100 (Blackjack (inprogress)) \n 1000 (Nevena Loopar uppgift) \n 0 (Exit Program)");
                Console.Write("Välj en av dessa Uppgifterna: ");
                int uppgift = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (uppgift == 1)
                {
                    //uppgift 1
                    Console.Write("säg ditt f*cking mönsterdjup, din kriminela jävel: ");
                    double nummer = double.Parse(Console.ReadLine());

                    if (nummer < 1.6)
                    {
                        Console.WriteLine("det är olagligt du ska in i finkan");

                    }

                    else if (nummer > 1.6)
                    {
                        Console.WriteLine("det är lagligt men jag håller mitt öga på dig");
                    }
                }

                else if (uppgift == 2)
                {
                    //uppgift 2 
                    Console.Write("Hur ung är du då lillen?: ");
                    int ålder = int.Parse(Console.ReadLine());

                    if (ålder < 12)
                    {
                        Console.WriteLine("Goo goo gaa ga, här är din vitta bricka");
                    }

                    else if (ålder > 13 && ålder < 18)
                    {
                        Console.WriteLine("usch du är tonåring, ta en grön spyfärgad bricka");
                    }

                    else if (ålder > 19 && ålder < 25)
                    {
                        Console.WriteLine("Du är fin ta en röd bricka");
                    }
                    else if (ålder > 26 && ålder < 99)
                    {
                        Console.WriteLine("Ok, boomer ta en blå bricka");
                    }
                    else
                    {
                        Console.WriteLine("ooj, du måste ha gått fel, kyrkogården är på andra sidan gatan");
                    }
                }

                else if (uppgift == 3)
                {
                    //uppgift 3
                    Console.Write("Mata in ett tal: ");
                    decimal tal1 = decimal.Parse(Console.ReadLine());

                    Console.Write("Mata in ännu ett tal: ");
                    decimal tal2 = decimal.Parse(Console.ReadLine());

                    if (tal1 > tal2)
                    {
                        Console.WriteLine("första talet är störst: " + tal1);
                    }
                    else if (tal2 > tal1)
                    {
                        Console.WriteLine("andra talet är störst: " + tal2);
                    }
                    else
                    {
                        Console.WriteLine("talen är lika stora, grattis!");
                    }
                }

                else if (uppgift == 4)
                {
                    //uppgift 4
                    Console.Write("säg ett tal som är fint: ");
                    int dela = int.Parse(Console.ReadLine());

                    if (dela % 7 == 0)
                    {
                        Console.WriteLine("talet är jämnt och delabart med 7");
                    }
                    else
                    {
                        Console.WriteLine($"talet är inte jämnt delbart med 7, resten blir {dela % 7}");
                    }
                }

                else if (uppgift == 5)
                {
                    //Ditt namn och ålder
                    Console.Write("Whats, your name sire: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Thats a nice name " + name);
                    Console.Write("May I know  your age: ");
                    double age = double.Parse(Console.ReadLine());
                    double cal = age + 50;
                    Console.WriteLine("Did U know that in 50 years you will be " + cal + ", " + name);
                }

                else if (uppgift == 6)
                {
                    //Svar på två nummer
                    Console.Write("Hello, Mr. Sir, can you say a nummer: ");
                    double tal = double.Parse(Console.ReadLine());
                    Console.Write("Säg ett till nummer: ");
                    double tal2 = double.Parse(Console.ReadLine());
                    double x = tal * tal2;
                    double div = tal / tal2;
                    double summa = tal + tal2;
                    Console.WriteLine($"summa av dina tal är: {summa} ");
                    Console.WriteLine($"Divisionen av dina tal är: {div}");
                    Console.WriteLine($"Produkten av dina tal är: {x}");
                }

                else if (uppgift == 7)
                {
                    //Celcius till Fahrenheit
                    Console.Write("Hur många grader celcius är det ute: ");
                    double cel = double.Parse(Console.ReadLine());
                    double svar = 1.8 * cel + 32;
                    Console.WriteLine($"Det blir {svar} fahrenheit");
                }

                else if (uppgift == 8)
                {
                    //Omgretsen på en cirkel
                    Console.Write("Hur lång är radien i cm på din cirkel: ");
                    double radie = double.Parse(Console.ReadLine());
                    double svar2 = 2 * radie * Math.PI;
                    double area = radie * radie * Math.PI;
                    Console.WriteLine($"Omgretsen på Cirkeln är {svar2} och dens area är {area}");
                }

                else if (uppgift == 9)
                {
                    for (int y = 1; y <= 100; y++)
                    {
                        Console.WriteLine(y);
                    }
                }

                else if (uppgift == 10)
                {
                    int m = 20;
                    for (int n = 1; n <= 20; n++)
                    {
                        Console.WriteLine(m);
                        m -= 1;
                    }
                }


                //Ojämna tal till 50
                else if (uppgift == 11)
                {
                    byte ojämna = 0;
                    for (int n = 2; n <= 27; n++)
                    {
                        Console.WriteLine(ojämna);
                        ojämna += 2;
                    }

                    

                }

                //alla For övningar grejer
                else if (uppgift == 12)
                {
                                                        
                    Console.WriteLine("mata in start");
                    int start = int.Parse(Console.ReadLine());

                    Console.WriteLine("mata in stopp");
                    int stopp = int.Parse(Console.ReadLine());

                    Console.WriteLine("mata in steg");
                    int steg = int.Parse(Console.ReadLine());
                                                         
                    for (int p = start; p <= stopp; p += steg)
                    {
                        Console.WriteLine(p);

                        Console.ReadLine();
                    }
                }

                //Try it Out Namn och Nummer
                else if (uppgift == 13)
                {
                    double firstNumber, secondNumber;
                    string userName;

                    Console.WriteLine("Enter your name:");

                    userName = Console.ReadLine();
                    Console.WriteLine($"Welcome {userName}!");
                    
                    Console.WriteLine("Now give me a number:");
                    firstNumber = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Now give me another number:");
                    secondNumber = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " +
                    $"{firstNumber + secondNumber}.");

                    Console.WriteLine($"The result of subtracting {secondNumber} from " +
                    $"{firstNumber} is {firstNumber - secondNumber}.");

                    Console.WriteLine($"The product of {firstNumber} and {secondNumber} " +
                    $"is {firstNumber * secondNumber}.");

                    Console.WriteLine($"The result of dividing {firstNumber} by " +
                    $"{secondNumber} is {firstNumber / secondNumber}.");

                    Console.WriteLine($"The remainder after dividing {firstNumber} by " +
                    $"{secondNumber} is {firstNumber % secondNumber}.");

                    Console.ReadKey();

                }


                //Nevena Genomgång
                else if (uppgift == 1000)
                {
                    int r = 0;
                    while (r <= 10)
                    {
                        r++;
                        //välja uppgift
                        Console.WriteLine("");
                        Console.WriteLine("Vilken uppgift vill du göra: ");
                        Console.WriteLine(" 1 (Win.Fack) \n 2 (Pyramid) \n 3 (Gubbe) \n 4 (DamVm Fråga) \n 0 (Return to previous list");
                        Console.Write("Välj en av dessa Uppgifterna: ");
                        int uppgift1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        //Allt Krascha
                        if (uppgift1 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();

                            Console.WriteLine("Blue Screen of Death :)");
                            Console.WriteLine("You are Screwed!");
                        }

                        else if (uppgift1 == 2)
                        {
                            Console.WriteLine("         /\\");
                            Console.WriteLine("        /  \\");
                            Console.WriteLine("       /    \\");
                            Console.WriteLine("      /      \\");
                            Console.WriteLine("     /        \\");
                            Console.WriteLine("    /          \\");
                            Console.WriteLine("   /            \\");
                            Console.WriteLine("  /              \\");
                            Console.WriteLine(" /                \\");
                            Console.WriteLine("/__________________\\");

                        }

                        else if (uppgift1 == 3)
                        {
                            Console.WriteLine("   O");
                            Console.WriteLine("  /|\\");
                            Console.WriteLine("   |");
                            Console.WriteLine("  / \\");
                            
                        }

                        else if (uppgift1 == 4)
                        {
                            Console.WriteLine("Vilka Fan Dam VM 2015: ");    
                            string svar = Console.ReadLine().ToLower();

                            if (svar == "usa")
                            {
                                Console.WriteLine("Rätt");
                            }

                            else if (svar == "Usa")
                            {
                                Console.WriteLine("Rätt");    
                            }
                            else if (svar == "USA")
                            {
                                Console.WriteLine("Rätt");
                            }
                            else
                            {
                                Console.WriteLine("FEL, Din Sexist!");
                            }
                        }

                        else if (uppgift1 == 0)
                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("wowowo, sakta i backarna så många uppgifter har jag ej");
                        }

                    }

                }


                //guessgame
                else if (uppgift == 99)
                {
                    Random numbergame = new Random();
                    int number2guess = numbergame.Next(0, 10);


                    for (int y = 0; y <= 100; y++)
                    {

                        Console.Write("Guess the number, its between 0-10: ");
                        int guess = int.Parse(Console.ReadLine());

                        if (guess == number2guess)
                        {
                            Console.WriteLine("Congrats you are good at guessing " + guess + "was the right guess");
                            break;
                        }

                        else if (guess != number2guess)
                        {
                            Console.WriteLine(guess + " was the wrong answer ");
                        }

                    }
                    }

                

                //blackjack
                else if (uppgift == 100)
                {
                    Random kort1 = new Random();
                    int förstakortet = kort1.Next(1, 10);
                    Random kort2 = new Random();
                    int andrakortet = kort2.Next(1, 10);
                    Console.WriteLine(förstakortet);
                    Console.WriteLine(andrakortet);
                    Console.WriteLine("Hit or Stay");
                    string hitorstay = Console.ReadLine();

                    if (hitorstay == "hit")
                    {
                        Random kort3 = new Random();
                        double tredjekortet = kort3.Next(1, 10);
                        Console.WriteLine(tredjekortet);
                    }
                    
                    else if (hitorstay == "stay")
                    {
                        if (förstakortet + andrakortet >= 22)
                        {
                            Console.WriteLine("You lose, Loser!");
                        }

                        else if (förstakortet + andrakortet == 21)
                        {
                            Console.WriteLine("You win, Winner!");
                        }

                        else
                        {
                            Console.WriteLine("Dealer Wins");
                        }
                    }

                }


                 else if (uppgift == 0)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("wowowo, sakta i backarna så många uppgifter har jag ej");
                }
            }        
            }

    }
}
