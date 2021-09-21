using System;
using System.Collections.Generic;
using System.IO;

namespace CharactersAndNumberOfOccurences
{
    
    class Program
    {
        static readonly string textFilePath = "C:\\Users\\odomanciuc\\OneDrive - ENDAVA\\Desktop\\textFile.txt";
        static string textFile = File.ReadAllText(textFilePath);

        //Generic Method
        static void PrintDictionary<T>(T keyValueCollection) where T:class, IDictionary<char, int>
        {
            foreach(var item in keyValueCollection)
            {
                Console.WriteLine(@"Char '{0}' have {1} occurences", item.Key, item.Value);
            }
        }
        static T CountOccurences<T>() where T:class, IDictionary<char, int>, new()
        {
            T keyValueCollection = new T();
            foreach (var chr in textFile)
            {
                if (!keyValueCollection.ContainsKey(chr))
                {
                    keyValueCollection.Add(chr, 1);
                }
                else
                {
                    keyValueCollection[chr]++;
                }
            }
            return keyValueCollection;

        } 

        /*
         //IOC METHOD
        static IDictionary<char, int> CountOccurencesIOC(IDictionary<char, int> _keyValueCollection)
        {
            IDictionary<char, int> keyValueCollection = _keyValueCollection;
            foreach (var chr in textFile)
            {
                if (!keyValueCollection.ContainsKey(chr))
                {
                    keyValueCollection.Add(chr, 1);
                }
                else
                {
                    keyValueCollection[chr]++;
                }
            }
            return keyValueCollection;
        }

        static void PrintDictionaryIOC(IDictionary<char, int> keyValueCollection)
        {
            foreach (var item in keyValueCollection)
            {
                Console.WriteLine(@"Char '{0}' have {1} occurences", item.Key, item.Value);
            }
        }
        */
        static void Main(string[] args)
        {
            //Generic method
            var dictionary = CountOccurences<Dictionary<char, int>>();
            var sortedList = CountOccurences<SortedList<char, int>>();
            var sortedDictionary = CountOccurences<SortedDictionary<char, int>>();

            PrintDictionary<Dictionary<char, int>>(dictionary);
            //PrintDictionary<SortedList<char, int>>(sortedList);
            //PrintDictionary<SortedDictionary<char, int>>(sortedDictionary);
           
           /* 
            IOC METHOD
            var dictionary = CountOccurencesIOC(new Dictionary<char, int>());
            var sortedList = CountOccurencesIOC(new SortedDictionary<char, int>());
            var sortedDictionary = CountOccurencesIOC(new SortedList<char, int>());

            PrintDictionaryIOC(dictionary);
            //PrintDictionaryIOC(sortedList);
            //PrintDictionaryIOC(sortedDictionary);
           */

        }
    }
}
