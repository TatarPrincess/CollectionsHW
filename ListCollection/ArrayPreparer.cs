using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

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
                StringBuilder stringBuilder= new StringBuilder(str);
                stringBuilder.Replace('\t', ' '); 
                stringBuilder.Replace('\n', ' ');
                stringBuilder.Replace(',', ' ');
                stringBuilder.Replace('.', ' ');
                stringBuilder.Replace(';', ' ');
                stringBuilder.Replace(':', ' ');
                stringBuilder.Replace('?', ' ');
                stringBuilder.Replace('!', ' ');                

                char[] delimiters = {' '};
                string[] words = stringBuilder.ToString().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                foreach (string w in words)
                { 
                  w.Trim();
                }
                return words;
            }
        }
    }
}
