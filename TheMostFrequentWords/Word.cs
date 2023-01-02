using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMostFrequentWords
{
    public class Word
    {
        public string value;
        public int quantity = 0;

        public Word(string value, int quantity) 
        {
          this.value = value;
          this.quantity = quantity;
        }

        public static int SortWordsByQuantity(Word first, Word second)
        {
            if (first.quantity > second.quantity) return -1;
            if (first.quantity == second.quantity) return 0;
            if (first.quantity < second.quantity) return 1;
            return -1;            
        }
    }
}
