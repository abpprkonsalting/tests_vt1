using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            this.phrase = phrase;
        }
        public string sortAlphabetically()
        {
            this.ordered = String.Concat(phrase.OrderBy(c => c));
            return ordered;
        }
    }
}
