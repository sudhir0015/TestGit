namespace Test
{
    public class WordFrequency : IWordFrequency
    {
        public string Word { get;  }
        public int Frequency { get; }

        /// <summary>
        /// Constructor : Initialized the word and frequency
        /// </summary>
        /// <param name="word">Word</param> 
        /// <param name="frequency">Frequency</param> 
        public WordFrequency(string word, int frequency)
        {
            Word = word;
            Frequency = frequency;
        }

    }
}
