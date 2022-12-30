using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CollectionComparison
{
    public class ArrayPreparer
    {
        public string path;        

        public ArrayPreparer(string path)
        { 
          this.path = path;
        }

        public string[] Prepare()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string str = sr.ReadToEnd();
                char[] delimiters = { ' ', '\r', '\n' };
                string[] words = str.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                return words;
            }
        }
    }
}
