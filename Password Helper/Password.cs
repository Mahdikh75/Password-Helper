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
        private readonly string[] Chars = { "*", "#", "@", "$", "%", "!", ".", "~" };

        #endregion

        #region Properties

        protected internal int min_lenght;
        public int MinLenght
        {
            get { return min_lenght; }
            set { min_lenght = value; }
        }

        protected internal int max_lenght;
        public int MaxLenght
        {
            get { return max_lenght; }
            set { max_lenght = value; }
        }


        protected internal bool number;
        public bool IsNumber
        {
            get { return number; }
            set { number = value; }
        }

        protected internal bool letters_uppercase;
        public bool LettersUppercase
        {
            get { return letters_uppercase; }
            set { letters_uppercase = value; }
        }

        protected internal bool letters_lowercase;
        public bool LettersLowercase
        {
            get { return letters_lowercase; }
            set { letters_lowercase = value; }
        }

        protected internal bool character;
        public bool Character
        {
            get { return character; }
            set { character = value; }
        }

        protected internal string[] special;
        public string[] Special
        {
            get { return special; }
            set { special = value; }
        }


        protected internal int count_special;
        public int CountSpecial
        {
            get { return count_special; }
            set { count_special = value; }
        }


        protected internal int count_character;
        public int CountCharacter
        {
            get { return count_character; }
            set { count_character = value; }
        }

        protected internal int count_letters_lowercase;
        public int CountLettersLowercase
        {
            get { return count_letters_lowercase; }
            set { count_letters_lowercase = value; }
        }

        protected internal int count_letters_uppercase;
        public int CountLettersUppercase
        {
            get { return count_letters_uppercase; }
            set { count_letters_uppercase = value; }
        }

        protected internal int count_number;
        public int CountNumber
        {
            get { return count_number; }
            set { count_number = value; }
        }
        #endregion

        #region Ctr
        public Password()
        {
            min_lenght = 4;
            max_lenght = 12;
        }
        public Password(int min, int max)
        {
            min_lenght = min;
            max_lenght = max;
        }

        #endregion

        #region Methods

        public Object Pattern(string pattern)
        {
            // Task : Pattern Type:Conut, ... | LettersUpper:5,LettersLower:8,Number:5,Character:3 
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
                                strb.Append(Chars[(new Random().Next(0, 7))]);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            return strb.ToString();
        }

        public object Get()
        {
            // Task : Get Password for Properties
            return 150;
        }

        #endregion

    }
}