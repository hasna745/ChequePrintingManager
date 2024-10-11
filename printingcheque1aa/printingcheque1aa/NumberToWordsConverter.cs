using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interface_user;


namespace WindowsFormsApp5
{
    public static class NumberToWordsConverter
    {
        private static readonly string[] Units = { "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf" };
        private static readonly string[] Teens = { "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf" };
        private static readonly string[] Tens = { "", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt", "quatre-vingt-dix" };

        public static string Convert(int number)
        {
            if (number == 0)
                return Units[0];

            if (number < 0)
                return "moins " + Convert(Math.Abs(number));

            var words = "";

            if ((number / 1000000) > 0)
            {
                words += Convert(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += Convert(number / 1000) + " mille ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += Convert(number / 100) + " cent ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "et ";

                if (number < 10)
                    words += Units[number];
                else if (number < 20)
                    words += Teens[number - 10];
                else
                {
                    words += Tens[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + Units[number % 10];
                }
            }

            return words.Trim();
        }
    }

}


