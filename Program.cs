using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ковалёв_Н.ДЗ_Урок_5
{
    class Mes
    {
        public static string NoMore(string message, int n)
        {
            char[] div = { ' ' };
            string[] parts = message.Split(div);
            string final = String.Empty;
            for (int i = 0; i < parts.Length; i++)
            {
                string word = parts[i];
                if (word.Length <= n)
                {
                    final += word + " ";
                }
            }
            return final;
        }

        public static string Delete(string message, string n)
        {
            char[] div = { ' ' };
            string[] parts = message.Split(div);
            string final = String.Empty;
            for (int i = 0; i < parts.Length; i++)
            {
                string word = parts[i];
                if (!word.EndsWith(n))
                {
                    final += word + " ";
                }
            }
            return final;
        }

        public static string Longest(string message)
        {
            char[] div = { ' ' };
            string[] parts = message.Split(div);
            string lngh = parts[0];
            for (int i = 0; i < parts.Length; i++)
            {
                string word = parts[i];
                if (lngh.Length < word.Length)
                {
                    lngh = word;
                }
            }
            return lngh;
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(LoginCheck("login"));

                Console.WriteLine(Mes.NoMore("привет как дела", 4));

                Console.WriteLine(Mes.Delete("привет как дела", "к"));

                Console.WriteLine(Mes.Longest("привет как дела"));

                Console.ReadKey();
            }

            static bool LoginCheck(string login)
            {
                char firstChar = login[0];
                bool isOk = false;
                if (login.Length >= 2 && login.Length <= 10 && !char.IsNumber(firstChar))
                {
                    for (int i = 0; i < login.Length; i++)
                    {
                        isOk = char.IsLetterOrDigit(login[i]);
                    }
                }
                return isOk;
            }
        }
}
