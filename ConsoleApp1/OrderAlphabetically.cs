using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testsVT
{
    internal class OrderAlphabetically
    {
        private string phrase { get; set; } = "";
        private string ordered { get; set; }

        public OrderAlphabetically(string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
            {
                throw new Exception("La frase no puede ser vacia");
            }
            Regex rg = new Regex("^[ a-zA-Z]+$");
            if (!rg.IsMatch(phrase))
            {
                throw new Exception("Caracteres no permitidos en la frase");
            }

            this.phrase = phrase;
        }
        public string sortAlphabetically()
        {
            var words = phrase.Split(' ');
            this.ordered = String.Concat(phrase.OrderBy(c => c)).Trim();
            var index = -1;
            foreach (var word in words)
            {
                index += word.Length + 1;
                this.ordered = this.ordered.Insert(index, " ");
            }
            return ordered;
        }
    }
}
