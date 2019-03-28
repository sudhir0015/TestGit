using System.Collections.Generic;
using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        private WordFrequencyAnalyzer wordFrequencyAnalyzer;
        [SetUp]
        public void init()
        {
             wordFrequencyAnalyzer = new WordFrequencyAnalyzer();
        }

        /// <summary>
        /// Count in space separated string 
        /// </summary>
        [Test]
        public void TestMethod1()
        {
            const int expectedResult = 2;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("a a d f  j y ytuf ytguy ytf 5rt drtcr e tdtfru  ytrf u5 f6 ", "a");
            Assert.AreEqual(expectedResult, actual);
        }

       /// <summary>
       /// Count in space separated string 
       /// </summary>
        [Test]
        public void TestMethod2()
        {
            const int expectedResult = 1;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("a a d f  j y ytuf ytguy ytf 5rt drtcr e tdtfru  ytrf u5 f6 ", "ytuf");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// Blank Text
        /// Count = 0
        /// </summary>
        [Test]
        public void Test()
        {
            const int expectedResult = 0;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord(" ", "a");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// Blank Word
        /// Count - 0
        /// </summary>
        [Test]
        public void TestMethod4()
        {
            const int expectedResult = 0;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("test for blank search word", "");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// Sentence with no words
        /// </summary>
        [Test]
        public void TestMethod5()
        {
            const int expectedResult = 0;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("1234344365758598475", "Test");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// No word and Text
        /// </summary>
        [Test]
        public void TestMethod6()
        {
            const int expectedResult = 0;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("", "");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// 3  Test words  
        /// </summary>
        [Test]
        public void TestMethod7()
        {
            const int expectedResult = 3;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("\test TEST####test181990OOJIOITestbhdsabtestkjnlk$%^&*", "test");
            Assert.AreEqual(expectedResult, actual);
        }


        /// <summary>
        /// Negative test for count 
        /// </summary>
        [Test]
        public void TestMethod8()
        {
            const int expectedResult = 4;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("Test TEST####test181990OOJIOITestbhdsabtestkjnlk$%^&*", "test");
            Assert.AreNotEqual(expectedResult, actual);
        }

        /// <summary>
        /// Blank Test valid word
        /// </summary>
        [Test]
        public void TestMethod9()
        {
            const int expectedResult = 4;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("", "test");
            Assert.AreNotEqual(expectedResult, actual);
        }


        /// <summary>
        /// 2 words having  similar high  frequency 
        /// </summary>
        [Test]
        public void TestMethod10()
        {
            const int expectedResult = 3;
            var actual = wordFrequencyAnalyzer.CalculateHighestFrequency("a a a b b b");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// a lot of separators with 1 word at the end
        /// </summary>
        [Test]
        public void TestMethod11()
        {
            const int expectedResult = 1;
            var actual = wordFrequencyAnalyzer.CalculateHighestFrequency("####@#$%^&*(*&^%$#$%^&*()i");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// single letter word
        /// </summary>
        [Test]
        public void TestMethod12()
        {
            const int expectedResult = 1;
            var actual = wordFrequencyAnalyzer.CalculateHighestFrequency("i");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// lot of separator with word at start
        /// </summary>
        [Test]
        public void TestMethod13()
        {
            const int expectedResult = 1;
            var actual = wordFrequencyAnalyzer.CalculateHighestFrequency("i################");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// Different separators with multi character word in the end
        /// </summary>
        [Test]
        public void TestMethod14()
        {
            const int expectedResult = 1;
            var actual = wordFrequencyAnalyzer.CalculateHighestFrequency("##########iIi");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// 2 unique words 
        /// </summary>
        [Test]
        public void TestMethod15()
        {
            const int expectedResult = 1;
            var actual = wordFrequencyAnalyzer.CalculateHighestFrequency(@"##########iIi$$$$$UNKCDNK()((*____++++++++~~~~");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// Separator separated two words
        /// </summary>
        [Test]
        public void TestMethod16()
        {
            const int expectedResult = 1;
            var actual = wordFrequencyAnalyzer.CalculateHighestFrequency("lkjhgfguiuh90dxgfchjbkl");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// Empty string in newlines
        /// </summary>
        [Test]
        public void TestMethod17()
        {
            const int expectedResult = 0;
            var actual = wordFrequencyAnalyzer.CalculateHighestFrequency("" +
                "" +
                ""+
                ""+ 
                "");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// Blank text and two word as input 
        /// </summary>
        [Test]
        public void TestMethod18()
        {
            const int expectedResult = 0;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("", "test#test");
            Assert.AreEqual(expectedResult, actual);
        }


        /// <summary>
        /// Blank text and two word as input 
        /// </summary>
        [Test]
        public void TestMethod19()
        {
            const int expectedResult = 0;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("", "test test");
            Assert.AreEqual(expectedResult, actual);
        }

        [Test]
        public void TestMethod20()
        {
            IList<WordFrequency> expectedResult = new List<WordFrequency>();
            expectedResult.Add(new WordFrequency("a",3));
            var actual = wordFrequencyAnalyzer.CalculateMostFrequentNWords("a a a", 1);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expectedResult[i].Word, actual[i].Word);
                Assert.AreEqual(expectedResult[i].Frequency, actual[i].Frequency);
            }
        }

        /// <summary>
        /// same frequency 2 words
        /// </summary>
        [Test]
        public void TestMethod21()
        {
            IList<WordFrequency> expectedResult = new List<WordFrequency>();
            expectedResult.Add(new WordFrequency("a", 3));
            expectedResult.Add(new WordFrequency("b", 3));
            var actual = wordFrequencyAnalyzer.CalculateMostFrequentNWords("A a a B b B", 2);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expectedResult[i].Word, actual[i].Word);
                Assert.AreEqual(expectedResult[i].Frequency, actual[i].Frequency);
            }
        }

        /// <summary>
        /// same frequency 2 words,n is 3
        /// </summary>
        [Test]
        public void TestMethod22()
        {
            IList<WordFrequency> expectedResult = new List<WordFrequency>();
            expectedResult.Add(new WordFrequency("a", 3));
            expectedResult.Add(new WordFrequency("b", 3));
            var actual = wordFrequencyAnalyzer.CalculateMostFrequentNWords("A a a B b B", 3);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expectedResult[i].Word, actual[i].Word);
                Assert.AreEqual(expectedResult[i].Frequency, actual[i].Frequency);
            }
        }

        /// <summary>
        /// same frequency 2 words,n is 3
        /// </summary>
        [Test]
        public void TestMethod23()
        {
            IList<WordFrequency> expectedResult = new List<WordFrequency>();
            var actual = wordFrequencyAnalyzer.CalculateMostFrequentNWords("", 3);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expectedResult[i].Word, actual[i].Word);
                Assert.AreEqual(expectedResult[i].Frequency, actual[i].Frequency);
            }
        }

        /// <summary>
        /// Question Test
        /// </summary>
        [Test]
        public void TestMethod24()
        {
            IList<WordFrequency> expectedResult = new List<WordFrequency>();
            expectedResult.Add(new WordFrequency("the", 2));
            expectedResult.Add(new WordFrequency("lake", 1));
            expectedResult.Add(new WordFrequency("over", 1));
            var actual = wordFrequencyAnalyzer.CalculateMostFrequentNWords("the THE lake oVER", 3);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expectedResult[i].Word, actual[i].Word);
                Assert.AreEqual(expectedResult[i].Frequency, actual[i].Frequency);
            }
        }


        /// <summary>
        /// Lot of separators and 1 word at the end
        /// </summary>
        [Test]
        public void TestMethod25()
        {
            IList<WordFrequency> expectedResult = new List<WordFrequency>();
            expectedResult.Add(new WordFrequency("iiii", 1));
            var actual = wordFrequencyAnalyzer.CalculateMostFrequentNWords("#######iiii", 2);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expectedResult[i].Word, actual[i].Word);
                Assert.AreEqual(expectedResult[i].Frequency, actual[i].Frequency);
            }
        }


        /// <summary>
        /// Lot of separators and 1 word at the front
        /// </summary>
        [Test]
        public void TestMethod26()
        {
            IList<WordFrequency> expectedResult = new List<WordFrequency>();
            expectedResult.Add(new WordFrequency("iiii", 1));
            var actual = wordFrequencyAnalyzer.CalculateMostFrequentNWords("iiii#######", 2);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expectedResult[i].Word, actual[i].Word);
                Assert.AreEqual(expectedResult[i].Frequency, actual[i].Frequency);
            }
        }


        /// <summary>
        ///  Checking order
        /// </summary>
        [Test]
        public void TestMethod27()
        {
            IList<WordFrequency> expectedResult = new List<WordFrequency>();
            expectedResult.Add(new WordFrequency("a", 1));
            expectedResult.Add(new WordFrequency("b", 1));
            expectedResult.Add(new WordFrequency("c", 1));
            expectedResult.Add(new WordFrequency("d", 1));
            expectedResult.Add(new WordFrequency("e", 1));
            expectedResult.Add(new WordFrequency("f", 1));
            expectedResult.Add(new WordFrequency("g", 1));
            expectedResult.Add(new WordFrequency("h", 1));
            var actual = wordFrequencyAnalyzer.CalculateMostFrequentNWords("i h g f e d c b a", 8);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expectedResult[i].Word, actual[i].Word);
                Assert.AreEqual(expectedResult[i].Frequency, actual[i].Frequency);
            }
        }



        /// <summary>
        ///  Checking order with different separators
        /// </summary>
        [Test]
        public void TestMethod28()
        {
            IList<WordFrequency> expectedResult = new List<WordFrequency>();
            expectedResult.Add(new WordFrequency("a", 1));
            expectedResult.Add(new WordFrequency("b", 1));
            expectedResult.Add(new WordFrequency("c", 1));
            expectedResult.Add(new WordFrequency("d", 1));
            expectedResult.Add(new WordFrequency("e", 1));
            expectedResult.Add(new WordFrequency("f", 1));
            expectedResult.Add(new WordFrequency("g", 1));
            expectedResult.Add(new WordFrequency("h", 1));
            var actual = wordFrequencyAnalyzer.CalculateMostFrequentNWords("i#h$g%f@#$%^&*e*d*c678b234a", 8);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expectedResult[i].Word, actual[i].Word);
                Assert.AreEqual(expectedResult[i].Frequency, actual[i].Frequency);
            }
        }


        /// <summary>
        ///  Checking order with different separators
        /// </summary>
        [Test]
        public void TestMethod29()
        {
            IList<WordFrequency> expectedResult = new List<WordFrequency>();
            expectedResult.Add(new WordFrequency("a", 1));
            expectedResult.Add(new WordFrequency("b", 1));
            expectedResult.Add(new WordFrequency("c", 1));
            expectedResult.Add(new WordFrequency("d", 1));
            expectedResult.Add(new WordFrequency("e", 1));
            expectedResult.Add(new WordFrequency("f", 1));
            expectedResult.Add(new WordFrequency("g", 1));
            expectedResult.Add(new WordFrequency("h", 1));
            var actual = wordFrequencyAnalyzer.CalculateMostFrequentNWords("   i#h$g%f@#$%^&*e*d*c678b234a" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "" +
                                                                           "", 8);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expectedResult[i].Word, actual[i].Word);
                Assert.AreEqual(expectedResult[i].Frequency, actual[i].Frequency);
            }
        }

        /// <summary>
        /// same word multiple
        /// </summary>
        [Test]
        public void TestMethod30()
        {
            const int expectedResult = 9;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("test TEST Test TEst% test^^^^TEST%$#$test TESt" +
                                                                         " tesT YTEST$%^&*UTEST", "test");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// Presence of escase sequence in string
        /// Count - 0
        /// </summary>
        [Test]
        public void TestMethod31()
        {
            const int expectedResult = 1;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("\test for blank search word", "test");
            Assert.AreEqual(expectedResult, actual);
        }

        /// <summary>
        /// same word multiple times with escape sequence 
        /// </summary>
        [Test]
        public void TestMethod32()
        {
            const int expectedResult = 2;
            var actual = wordFrequencyAnalyzer.CalculateFrequencyForWord("\nest \nEST Test TEst% test^^^^TEST%$#$test TESt" +
                                                                         " tesT YTEST$%^&*UTEST", "nest");
            Assert.AreEqual(expectedResult, actual);
        }
    }
}