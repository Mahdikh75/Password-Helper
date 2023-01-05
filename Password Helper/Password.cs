using PasswordGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Helper
{
    public class Password
    {
        #region Const

        private readonly string[] Letter_Up = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
        private readonly string[] Letter_Low = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m" };
        private readonly string[] Chars = { "*", "#", "@", "$", "%", "!", "~" };

        #endregion

        #region Properties

        private bool number;
        public bool IsNumber
        {
            get { return number; }
            set { number = value; }
        }

        private bool letters_uppercase;
        public bool LettersUppercase
        {
            get { return letters_uppercase; }
            set { letters_uppercase = value; }
        }

        private bool letters_lowercase;
        public bool LettersLowercase
        {
            get { return letters_lowercase; }
            set { letters_lowercase = value; }
        }

        private bool character;
        public bool Character
        {
            get { return character; }
            set { character = value; }
        }

        private string special;
        public string Special
        {
            get { return special; }
            set { special = value; }
        }

        private int Lenght;
        public Password()
        {
        }
        public Password(int lenght)
        {
            Lenght = lenght;
        }
        #endregion

        #region Methods

        public string Pattern(string pattern)
        {
            // Type:Conut, ... | LettersUpper:5,LettersLower:8,Number:5,Character:3 
            StringBuilder strb = new StringBuilder();

            foreach (var item in pattern.Split(","))
            {
                var selector = item.Split(":");
                if (selector.Length == 2)
                {
                    switch (selector[0].ToLower())
                    {
                        case "lettersupper":
                            for (int i = 0; i < int.Parse(selector[1].ToString()); i++)
                            {
                                strb.Append(Letter_Up[(new Random().Next(0, 25))]);
                            }
                            break;
                        case "letterslower":
                            for (int i = 0; i < int.Parse(selector[1].ToString()); i++)
                            {
                                strb.Append(Letter_Low[(new Random().Next(0, 25))]);
                            }
                            break;
                        case "number":
                            string max = string.Empty;
                            string min = "1";
                            for (int i = 0; i < int.Parse(selector[1].ToString()); i++)
                            {
                                max += "9";
                                if (i != 0)
                                    min += "0";
                            }
                            strb.Append(new Random().Next(int.Parse(min), int.Parse(max)));
                            break;
                        case "character":
                            for (int i = 0; i < int.Parse(selector[1].ToString()); i++)
                            {
                                strb.Append(Chars[(new Random().Next(0, 6))]);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            return strb.ToString();
        }

        public string Get()
        {
            PasswordGenerator.Password ps = new PasswordGenerator.Password(Lenght);

            if (IsNumber)
                ps.IncludeNumeric();

            if (LettersUppercase)
                ps.IncludeUppercase();

            if (LettersLowercase)
                ps.IncludeLowercase();

            if (Character)
                ps.IncludeSpecial();

            if (Special.Length > 0)
                ps.IncludeSpecial(Special);

            return ps.Next();
        }

        #endregion

    }
}