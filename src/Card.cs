using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFlashCard
{
    internal class Card
    {
        private string[] lhs;
        private string[] rhs;
        public Card(string[] value1, string[] value2)
        {
            lhs = value1;
            rhs = value2;
        }

        public string[] Lhs
            { get { return lhs; } }
        public string[] Rhs
            { get { return rhs; } }
    }
}
