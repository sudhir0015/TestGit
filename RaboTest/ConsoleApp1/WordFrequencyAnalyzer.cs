using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test
{
    public class WordFrequencyAnalyzer : IWordFrequencyAnalyzer
    {

        /// <summary>
        ///  Verify if the given Word is valid 
        /// </summary>
        /// <param name="wordToCheck"></param>
        /// <returns>isWord=returns true if all characters of a word are between a-z and A-Z, else false</returns>
        public bool CheckIsWord(string wordToCheck)
        {
            return  !Regex.IsMatch(wordToCheck, "[^a-zA-Z]");
        }

        /// <summary>
        /// Returns the frequency of the specified word in text
        /// </summary>
        /// <param name="text">The source string</param>
        /// <param name="word">The word to find frequency for</param>
        /// <returns>Frequency of the word</returns>
        public int CalculateFrequencyForWord(string text, string word)
        {
            // Frequency of the word in String
            var count = 0;  

            // checking if the string or word is empty
            // returning 0 if true
            if(string.IsNullOrWhiteSpace(word) || string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }

            // the function return 0 (Zero) value in case of invalid word is given
            if(CheckIsWord(word) == false)
            {
                return 0;
            }

            //converting the string to ignore escape sequence
            text = Regex.Escape(text);

            // in case of a valid word and a valid string , we now will find the frequency
            // of the word in the string(text)
            // Split the string using 'Anything other than a-z and A-Z as separator' and then
            // searching for the occurence of the word in the text ignoring case
            var wordList = Regex.Split(text, "[^a-zA-Z]");

            // Counting the occurence of the word by comparing case insensitive 
            foreach(var aWord in wordList)
            {
                if (string.Equals(aWord, word, StringComparison.CurrentCultureIgnoreCase))
                {
                    count++;
                }
            }
            return count;
        } //End CalculateFrequencyForWord

        /// <summary>
        /// This returns the highest frequency of any word in the text
        /// </summary>
        /// <param name="text">Input String</param>
        /// <returns>highest frequency of any word in the text</returns>
        public int CalculateHighestFrequency(string text)
        {
           
            // if the text is not empty
            if (string.IsNullOrWhiteSpace(text) )
            {
                return 0;
            }

            // Calling the CalculateMostFrequentNWords function for most frequent
            var highestFrequencyWord = CalculateMostFrequentNWords(text, 1);

            // If there is a word in the text
            if (highestFrequencyWord.Count == 0)
            {
                return 0;
            }
            return highestFrequencyWord[0].Frequency;
        }

        /// <summary>
        /// Calculate the n most frequent words in the text 
        /// </summary>
        /// <param name="text">Input String</param>
        /// <param name="n">Top n high frequency words</param>    
        /// <returns IWordFrequency="Having n word and frequency">IList </returns>
        public IList<WordFrequency> CalculateMostFrequentNWords(string text, int n)
        {
            var wordFrequencies = new List<WordFrequency>();

            //If no word was requested
            if (n < 1)
            {
                return wordFrequencies;
            }

            //checking if the string or word is empty
            if (string.IsNullOrWhiteSpace(text))
            {
                return wordFrequencies;
            }

            //converting the string to ignore escape sequence
            text = Regex.Escape(text);

            //splitting the string on anything other than a-z and A-z
            var wordList = Regex.Split(text, "[^a-zA-Z]+");
           
            //finding the N most frequent words
            var results =wordList
                               .Where(x=>(string.IsNullOrWhiteSpace(x)!=true))
                              .GroupBy(x => x.ToLower())
                              .Select(x => new { Count = x.Count(), Word = x.Key })
                              .OrderByDescending(x => x.Count).ThenBy(x=>x.Word)
                              .Take(n);

            //adding the words and their count in the list to return
            foreach (var item in results)
            {
                wordFrequencies.Add(new WordFrequency(item.Word, item.Count));
            }
            return wordFrequencies;
        } 

    } // Class WordFrequencyAnalyzer ends
}//namespace Test closes
