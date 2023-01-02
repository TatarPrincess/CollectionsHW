using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using CollectionComparison;
using static System.Net.Mime.MediaTypeNames;

namespace TheMostFrequentWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileProcessor FileProcessor = new FileProcessor();
            FileProcessor.Download();            

            ArrayPreparer ArrayPreparer = new ArrayPreparer(FileProcessor.path);
            string[] words = ArrayPreparer.Prepare();

            SortedList<string, int> listByValue = new SortedList<string, int>();            

            foreach (string word in words)
            {
                if (!listByValue.ContainsKey(word))
                {
                    listByValue.Add(word, 1);
                }
                else listByValue[word] += 1;
            }

            List<Word> listByQuant = new List<Word>();

            foreach (var w in listByValue)
            {
                
                listByQuant.Add(new Word(w.Key, w.Value));
            }

            listByQuant.Sort(Word.SortWordsByQuantity);
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(listByQuant[i].value + " - " + listByQuant[i].quantity + '\t');
            }
        }
    }
}
