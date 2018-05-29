using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingWithCollections
{
    class Program
    {
        private static Random r = new Random();

        static void Main(string[] args)
        {
            //Stack
            #region 1.	Дан файл, в котором записан набор чисел. Переписать в другой файл все числа в обратном порядке.

            /*Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Push(r.Next(0, 100));
     
            }

            foreach (int item in numbers)
            {
                Console.WriteLine(item);

            }

            Stack<int> numbers2 = new Stack<int>(numbers.ToArray());
            numbers2.Reverse();

            Console.WriteLine();

            foreach (int item in numbers2)
            {
                Console.WriteLine(item);

            }*/
            #endregion

            #region 2.	Создать текстовый файл. Распечатать гласные буквы этого файла в обратном порядке.

            /*Stack<char> symbols = new Stack<char>();
            symbols.Push('a');
            symbols.Push('d');
            symbols.Push('w');
            symbols.Push('e');
            symbols.Push('a');
            symbols.Push('i');
            symbols.Push('z');
            symbols.Push('u');
            symbols.Push('q');
            symbols.Push('t');
            symbols.Push('i');

            Stack<char> symbols2 = new Stack<char>();
            string letters = "aoieu";

            foreach (char item in symbols)
            {
                if (letters.Contains(item))
                    symbols2.Push(item);

            }

   
            Stack<char> symbols3 = new Stack<char> (symbols2.ToArray());
            symbols3.Reverse();


            foreach (char item in symbols3)
            {
                Console.WriteLine(item);
            }*/


            #endregion

            //Queue
            #region  
            /*2.	Дан файл, содержащий числа. За один просмотр файла напечатать элементы файла в следующем порядке: 
             сначала все числа, из интервала [a,b], потом все числа, меньшие a, 
             потом все числа, большие b, сохраняя исходный порядок в каждой группе чисел.
            Console.WriteLine();
            Console.WriteLine();

            Queue<int> qe = new Queue<int>();
            qe.Enqueue(5);
            qe.Enqueue(8);
            qe.Enqueue(3);
            qe.Enqueue(1);
            qe.Enqueue(9);
            qe.Enqueue(11);
            qe.Enqueue(2);
            qe.Enqueue(33);

            foreach (int item in qe)
            {
                if (item > 7 && item < 12)

                    Console.Write(item + " ");
            }
            Console.WriteLine();


            foreach (int item in qe)
            {
                if (item < 7)
                    Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (int item in qe)
            {
                if (item < 12)
                    Console.Write(item + " ");
            }
            Console.WriteLine();*/

            #endregion
            #region
            /*5.	Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке:
             сначала все слова, начинающиеся с прописной буквы, потом все слова, начинающиеся со строчной буквы, 
             сохраняя исходный порядок в каждой группе слов.
            Console.WriteLine();
            Queue<string> qq = new Queue<string>();
            qq.Enqueue("Masha");
            qq.Enqueue("plus");
            qq.Enqueue("Sasha");
            qq.Enqueue("equals");
            qq.Enqueue("Porridge");

            foreach (string item in qq)
            {
                if (item == item.ToUpper())
                    Console.WriteLine(item);
            }
            foreach (string item in qq)
            {
                if (item == item.ToLower())
                    Console.WriteLine(item);
            }*/

            #endregion

            //HashTable
            #region Pеализовать простейший каталог музыкальных компакт-дисков
            
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Disk1", "SongCollection1");
            hashtable.Add("Disk2", "SongCollection2");
            hashtable.Add("Disk3", "SongCollection3");
            hashtable.Add("Disk4", "SongCollection4");
            hashtable.Add("Disk5", "SongCollection5");
            hashtable.Add("Disk6", "SongCollection6");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}\n");   
            }
            // ICollection valueColl = hashtable.Values;

            Console.WriteLine("");
            hashtable.Remove("Disk5");


            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}\n");
            }


            hashtable.Add("Disk7", "SongCollection6");
            hashtable.Add("Disk8", "SongCollection6");

            Console.WriteLine("");


            #endregion
        }
    }
}
