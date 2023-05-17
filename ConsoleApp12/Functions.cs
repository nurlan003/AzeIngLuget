using System.ComponentModel;
using System.Diagnostics.Tracing;

static class Functions
{
    public static void Dictionaryy(List<Word> words)
    {
        while (true)
        {
            Console.ResetColor();

            Console.WriteLine("1-Eng to Aze");
            Console.WriteLine("2-Aze to Ing");
            Console.WriteLine("3-Quiz");
            Console.WriteLine(">>>");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                int a = 0;
                Console.Clear();
                Console.WriteLine("Ing:");
                string IngSoz = Console.ReadLine();
                for (int i = 0; i < words.Count; i++)
                {


                    if (words[i].wordIng == IngSoz)
                    {
                        a++;
                        Console.WriteLine("Aze:");
                        Console.WriteLine(words[i].wordAze);
                        break;
                    }

                }
                if (a>0)
                {

                }
                else
                {
                    Console.WriteLine("Bu soz lugetde yoxdur tercumesini yazin");
                    Console.WriteLine(">>>");
                    string newAzeTrc = Console.ReadLine();
                    Word newWord = new Word(newAzeTrc, IngSoz);
                    words.Add(newWord);

                }


            }
            if (secim == "2")
            {
                int a = 0;
                Console.Clear();
                Console.WriteLine("Aze:");
                string AzeSoz = Console.ReadLine();
                for (int i = 0; i < words.Count; i++)
                {


                    if (words[i].wordIng == AzeSoz)
                    {
                        a++;
                        Console.WriteLine("Ing:");
                        Console.WriteLine(words[i].wordIng);
                        break;
                    }

                }
                if (a>0)
                {

                }
                else
                {
                    Console.WriteLine("Bu soz lugetde yoxdur tercumesini yazin");
                    Console.WriteLine(">>>");
                    string newIngTrc = Console.ReadLine();
                    Word newWord = new Word(AzeSoz, newIngTrc);
                    words.Add(newWord);

                }

            }
            if (secim == "3")
            {
                int dogruCavab = 0;
                int sehvCavab = 0;
                Random random = new Random();
                int[] indexes = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    int randomIndex;
                    bool isUnique;

                    do
                    {
                        Console.ResetColor();

                        randomIndex = random.Next(0, words.Count);
                        isUnique = true;

                        for (int j = 0; j < i; j++)
                        {
                            if (indexes[j] == randomIndex)
                            {
                                isUnique = false;
                                break;
                            }
                        }
                    } while (!isUnique);

                    indexes[i] = randomIndex;

                    Console.ResetColor();

                    Console.WriteLine("Sual" + (i + 1) + ": " + words[randomIndex].wordIng);
                    Console.Write("Aze: ");
                    string azerbaycanca = Console.ReadLine();

                    if (azerbaycanca == words[randomIndex].wordAze)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;   
                        Console.WriteLine("Cavab Dogrudur");
                        dogruCavab+=20;
                       
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Cavab Sehvdir");
                        Console.WriteLine("Dogru cavab: " + words[randomIndex].wordAze);
                        sehvCavab+=20;

                    }

                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Dogru Cavab:{dogruCavab}%");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Yanlis Cavab:{sehvCavab}%");
                Console.ResetColor();




            }

        }
    }
}

