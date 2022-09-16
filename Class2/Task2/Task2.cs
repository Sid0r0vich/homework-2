using System.Text;

namespace Task2
{
    public class Task2
    {

/*
 * В этих заданиях * рекомендуется всюду использовать класс StringBuilder.
 * Документация: https://docs.microsoft.com/ru-ru/dotnet/api/system.text.stringbuilder?view=net-6.0
 */

/*
 * Задание 2.1. Дана непустая строка S и целое число N (> 0). Вернуть строку, содержащую символы
 * строки S, между которыми вставлено по N символов «*» (звездочка).
 */
        internal static string FillWithAsterisks(string s, int n)
        {
            string join = new string('*', n);

            return string.Join(join,s.ToCharArray());
        }

/*
 * Задание 2.2. Сформировать таблицу квадратов чисел от 1 до заданного числа N.
 * Например, для N=4 должна получиться следующая строка:

1  1
2  4
3  9
4 16

 * Обратите внимание на выравнивание: числа в первом столбце выравниваются по левому краю,
 * а числа во втором -- по правому, причём между числами должен оставаться как минимум один
 * пробел. В решении можно использовать функции Pad*.
 */
        internal static string TabulateSquares(int n)
        {
            int l = (n.ToString() + Math.Pow(n, 2).ToString()).Length + 1;
            string res = "1" + new string(' ', l-2) + '1';

            for (int i = 2; i <= n; i++)
            {
                res += "\n" + i.ToString() + Math.Pow(i, 2).ToString().PadLeft(l-i.ToString().Length);
            }

            return res;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(FillWithAsterisks("abc", 2));
            Console.WriteLine(TabulateSquares(100));
        }
    }
}