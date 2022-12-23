using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Helper
{
    public class Password
    {
        #region Properties

        private int min_lenght;
        public int MinLenght
        {
            get { return min_lenght; }
            set { min_lenght = value; }
        }

        private int max_lenght;
        public int MaxLenght
        {
            get { return max_lenght; }
            set { max_lenght = value; }
        }


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

        private string[] special;
        public string[] Special
        {
            get { return special; }
            set { special = value; }
        }


        private int count_special;
        public int CountSpecial
        {
            get { return count_special; }
            set { count_special = value; }
        }


        private int count_character;
        public int CountCharacter
        {
            get { return count_character; }
            set { count_character = value; }
        }

        private int count_letters_lowercase;
        public int CountLettersLowercase
        {
            get { return count_letters_lowercase; }
            set { count_letters_lowercase = value; }
        }

        private int count_letters_uppercase;
        public int CountLettersUppercase
        {
            get { return count_letters_uppercase; }
            set { count_letters_uppercase = value; }
        }

        private int count_number;
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

        public object Pattern(string pattern)
        {
            // Task : Pattern {Type:Conut}, | {LettersUpper:5},{lettersLower:8},{number:5},{character:3}...
            return new Object();
        }

        public object Get()
        {
            // Task : Get Password for Properties
            return new Object();
        }

        #endregion

    }
}