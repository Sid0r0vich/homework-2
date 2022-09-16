using System.Text.RegularExpressions;

namespace Task3
{
    public class Task3
    {
/*
 * Перед выполнением заданий рекомендуется просмотреть туториал по регулярным выражениям:
 * https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/regular-expression-language-quick-reference
 */

/*
 * Задание 3.1. Проверить, содержит ли заданная строка только цифры?
 */
        internal static bool AllDigits(string s) => new Regex(@"^\d+$").IsMatch(s);

/*
 * Задание 3.2. Проверить, содержит ли заданная строка подстроку, состоящую
 * из букв abc в указанном порядке, но в произвольном регистре?
 */
        internal static bool ContainsABC(string s) => new Regex(@"([A,a][B,b][C,c])+", RegexOptions.None).IsMatch(s);

        /*
         * Задание 3.3. Найти первое вхождение подстроки, состоящей только из цифр,
         * и вернуть её в качестве результата. Вернуть пустую строку, если вхождения нет.
         */
        internal static string FindDigitalSubstring(string s)
        {
            MatchCollection reg = new Regex(@"\d+").Matches(s);
            if (reg.Count > 0) return reg[0].ToString();

            return "";
        }

        /*
         * Задание 3.4. Заменить все вхождения подстрок строки S, состоящих только из цифр,
         * на заданную строку S1.
         */
        internal static string HideDigits(string s, string s1) => Regex.Replace(s, @"\d+", s1);

        public static void Main(string[] args)
        {
            Console.WriteLine(AllDigits("1109"));
            Console.WriteLine(ContainsABC("abcabC"));
            Console.WriteLine(FindDigitalSubstring("55x55"));
            Console.WriteLine(HideDigits("44x44","55"));
        }
    }
}