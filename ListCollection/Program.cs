using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace CollectionComparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileProcessor FileProcessor = new FileProcessor();
            FileProcessor.Download();            

            ArrayPreparer ArrayPreparer = new ArrayPreparer(FileProcessor.path);
            string[] words = ArrayPreparer.Prepare();

            LinkedList<string> LinkedList = new LinkedList<string>();
            LinkedListNode<string> prevNode = null;            

            // запускаем новый таймер
            var stopWatchForLinkedList = Stopwatch.StartNew();

            for (int i = 0; i < words.Length; i++)
            {

                if (i == 0)
                {
                    LinkedList.AddFirst(words[i]);
                    prevNode = LinkedList.First;
                }
                else
                {
                    LinkedList.AddAfter(prevNode, words[i]);
                    prevNode = prevNode.Next;
                }
            }
            stopWatchForLinkedList.Stop();
            // смотрим, сколько операция заняла, в миллисекундах
            Console.WriteLine("Время вставки в LinkedList - {0}", stopWatchForLinkedList.Elapsed.TotalMilliseconds);

            List<string> List = new List<string>();
            // запускаем новый таймер
            var stopWatchForList = Stopwatch.StartNew();
            List.InsertRange(0, words);
            stopWatchForList.Stop();

            // смотрим, сколько операция заняла, в миллисекундах
            Console.WriteLine("Время вставки в List - {0}", stopWatchForList.Elapsed.TotalMilliseconds);
        }
    }

    

   
}
