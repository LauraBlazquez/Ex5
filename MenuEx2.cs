using System;
using UtilsLibrary;
namespace Refactoring
{
    class RefactoringExercise
    {
        public static void Main()
        {
            const string Menu = "a) Validar si un nombre és senar\nb) Calcular la potència d'un nombre\nc) Retornar un valor aleatori\nd) Comptar el nombre de vocals o consonants en un text\ne) Sortir";
            const string Msg = "Donem un número:";
            const string RangMsg = "Donem un limit del rang d'on vols escollir el número aleatori:";
            const string TextMsg = "Donem un text sense signes de puntuació:";
            const string Bye = "Fins aviat!";
            char option;
            int num;

            Console.WriteLine(Menu);
            option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case 'a':
                case 'A':
                    do
                    {
                        Console.WriteLine(Msg);
                        num = Convert.ToInt32(Console.ReadLine());
                    } while (Utils.ValidateNatural(num) == false);
                    Console.WriteLine(Utils.ValidateOdd(num));
                    break;
                case 'b':
                case 'B':
                    int exponent;
                    do
                    {
                        Console.WriteLine(Msg);
                        num = Convert.ToInt32(Console.ReadLine());
                    } while (Utils.ValidateNatural(num) == false);
                    do
                    {
                        Console.WriteLine(Msg);
                        exponent = Convert.ToInt32(Console.ReadLine());
                    } while (Utils.ValidateNatural(exponent) == false);
                    Console.WriteLine("El resultat és: " + Utils.Pow(num, exponent));
                    break;
                case 'c':
                case 'C':
                    int min, max;
                    do
                    {
                        Console.WriteLine(RangMsg);
                        min = Convert.ToInt32(Console.ReadLine());
                    } while (Utils.ValidateNatural(min) == false);
                    do
                    {
                        Console.WriteLine(RangMsg);
                        max = Convert.ToInt32(Console.ReadLine());
                    } while (Utils.ValidateNatural(max) == false);
                    Console.WriteLine(Utils.Randomizer(min, max));
                    break;
                case 'd':
                case 'D':
                    int vowels = 0, cons = 0;
                    string text;
                    Console.WriteLine(TextMsg);
                    text = Console.ReadLine();
                    Utils.CountLetters(text, ref vowels, ref cons);
                    Console.WriteLine("Vocals: {0}\nConsonants: {1}",vowels,cons);
                    break;
                case 'e':
                case 'E':
                    Console.WriteLine(Bye);
                    break;
            }
        }
    }
}