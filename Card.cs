using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEnums
{
    class Card
    {
        public Suits suit { get; private set; }
        public Values value { get; private set; };

        public string Name { get { return $"{value} of {suit}"; } }

        public Card(Values value, Suits suit)
        {
            this.suit = suit;
            this.value = value;
        }
    }
}
