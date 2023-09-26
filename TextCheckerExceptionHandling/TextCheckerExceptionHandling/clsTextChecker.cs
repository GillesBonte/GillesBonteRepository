using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCheckerExceptionHandling
{
    public class TextChecker
    {
        public TextChecker(string text)
        {
            Text = text;
        }

        public string Text { get; set; }

        public void TextCheck()
        {

            foreach (char c in Text)
            {
                if (char.IsDigit(c))
                {
                    throw new ContainsNumberException("String can't contain numbers");
                }
            }

            foreach (char c in Text)
            {
                if ((c == 'f') || (c == 'F'))
                {
                    throw new ContainsLetterFException("String can't contain an 'F'");
                }

            }

            if (Text.Length >= 50) 
            {
                throw new ContainsAlotException("String can't contain more than 50 characters");
            }

        }

    }

}
