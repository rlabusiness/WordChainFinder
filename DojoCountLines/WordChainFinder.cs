using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    public class WordChainFinder
    {
        private string[] dictionary;

        public WordChainFinder()
        {
            this.dictionary = GetDictionary();
        }

        private const string filePath = @"C:\Code\Internal\Dojo\words.txt";

        private string[] GetAllPermutations(string start)
        {
            var Permutations = new List<string>();
            return Permutations.ToArray();
        }

        public string[] FindWordPath(string start, string end)
        {
            if (!WordsAreSameLength(start, end))
            {
                throw new WordsNotSameLengthException();
            }

            string[] trimmedDictionary = GetTrimmedDictionary(start.Length);

            

            return new string[] {
                start,
                end
            };
        }

        private string[] GetTrimmedDictionary(int length)
        {
            return dictionary.Where(s => s.Length == length).ToArray();
        }

        public string[] GetDictionary()
        {
            return File.ReadAllLines(filePath);
        }

        public bool IsWordInDictionary(string p)
        {
            return this.dictionary.Contains(p);
        }

        public bool WordsAreSameLength(string wordOne, string wordTwo)
        {
            return wordOne.Length == wordTwo.Length;
        }

        public bool AreOneLetterApart(string word1, string word2)
        {
            int count = 0;
            for (int i = 0; i < word1.Length; i++ )
            {
                if (word1[i] != word2[i])
                {
                    count++;
                }
            }
            return (count == 1);
        }
    }
}
