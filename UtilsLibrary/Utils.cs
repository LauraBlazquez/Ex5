namespace UtilsLibrary
{
    public class Utils
    {
        public static string ValidateOdd(int num)
        {
            const int Module = 2;
            if (num % Module == 0) return "No és senar";
            return "És senar";
        }
        public static int Pow(int num, int exponent)
        {
            int result = num;
            if (exponent == 0) return 1;
            for (int i = 1; i < exponent; i++) result *= num;
            return result;
        }
        public static int Randomizer(int min, int max) 
        {
            var random = new Random();
            return random.Next(min, max+1);
        }
        public static void CountLetters(string text,ref int vowels, ref int cons)
        {
            text = text.ToLower();
            text = text.Replace('á', 'a');
            text = text.Replace('à', 'a');
            text = text.Replace('è', 'e');
            text = text.Replace('é', 'e');
            text = text.Replace('í', 'i');
            text = text.Replace('ò', 'o');
            text = text.Replace('ó', 'o');
            text = text.Replace('ú', 'u');

            foreach (char letter in text) 
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') vowels++;
                else if (letter != ' ') cons++;
            }
        }
        public static bool ValidateNatural(int num)
        {
            if (num < 0) return false;
            return true;
        }
    }
}
