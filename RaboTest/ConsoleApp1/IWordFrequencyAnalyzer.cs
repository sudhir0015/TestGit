using System.Collections.Generic;
namespace Test
{
    public interface IWordFrequencyAnalyzer
    {
        /// <summary>
        /// Returns the highest frequency in the text
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Frequency</returns>
        int CalculateHighestFrequency(string text);

        /// <summary>
        /// Returns the frequency of the specified word in text
        /// </summary>
        /// <param name="text"></param>
        /// <param name="word"></param>
        /// <returns>Frequency of the word</returns>
        int CalculateFrequencyForWord(string text, string word);

        /// <summary>
        /// Return a list of the most frequent n words in
        /// the input text, all the words returned in lower case
        /// </summary>
        /// <param name="text">Input String</param>
        /// <param name="n">The number of words to return frequency for</param>
        /// <returns></returns>
        IList<WordFrequency> CalculateMostFrequentNWords(string text, int n);
    }
}