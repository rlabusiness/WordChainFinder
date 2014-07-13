using System;
using System.IO;
using NUnit.Framework;

namespace Dojo.Test
{
    [TestFixture]
    public class WordChainFinderTests
    {
        private WordChainFinder wordChainFinder;
        [SetUp]
        public void Setup()
        {
            wordChainFinder = new WordChainFinder();
        }


        [Test]
        public void TestCatCot()
        {
            // Arrange
            string[] expected = new string[] {
                "cat",
                "cot"
            };

            // Act
            var actual = wordChainFinder.FindWordPath("cat", "cot");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3WordChain()
        {
            // Arrange
            string[] expected = new string[] {
                "cat",
                "cot",
                "dot"
            };

            // Act
            var actual = wordChainFinder.FindWordPath("cat", "dot");

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestTwoWordsAreOneLetterApart()
        {
            // Arrange
            string word1 = "cat";
            string word2 = "cot";

            // Act
            var actual = wordChainFinder.AreOneLetterApart(word1, word2);

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void TestReadingFromFile()
        {
            // Arrange
            var dictionary = File.ReadAllLines(@"C:\Code\Internal\Dojo\words.txt");

            // Act
            var fileContents = wordChainFinder.GetDictionary();

            // Assert
            Assert.AreEqual(dictionary, fileContents);
        }

        [Test]
        public void TestWordExistsFail()
        {
            bool actual = wordChainFinder.IsWordInDictionary("Hellooo");

            Assert.IsFalse(actual);

        }

        [Test]
        public void TestWordExistsTrue()
        {
            bool actual = wordChainFinder.IsWordInDictionary("hello");

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestWordsAreSameSizeFail()
        {
            string wordOne = "cat";
            string wordTwo = "horse";
            bool actual = wordChainFinder.WordsAreSameLength(wordOne,wordTwo);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestWordsAreSameSizeTrue()
        {
            string wordOne = "cat";
            string wordTwo = "dog";
            bool actual = wordChainFinder.WordsAreSameLength(wordOne, wordTwo);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestFindWordPathThrowsExceptionIfWordsAreNotSameLength()
        {
            //Arrange
            string wordOne = "cat";
            string wordTwo = "pony";
            
            //Assert/Act
            Assert.Throws(typeof(WordsNotSameLengthException), 
                () => wordChainFinder.FindWordPath(wordOne, wordTwo) 
            );
        }

        [Test]
        public void TestFindWordPathDoesNotThrowExceptionIfWordsAreSameLength()
        {
            //Arrange
            string wordOne = "cat";
            string wordTwo = "pan";

            //Assert/Act
            wordChainFinder.FindWordPath(wordOne, wordTwo);
        }
    }
}
