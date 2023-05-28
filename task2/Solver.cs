namespace task2
{
    class Solver
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ');
            var wordsDic = WordFrequency(words);
            PrintDictionary(wordsDic);
        }

        public static Dictionary<string,int> WordFrequency(string[] words)
        {
            var wordsDictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordsDictionary.ContainsKey(word))
                {
                    wordsDictionary[word]++;
                }
                else
                {
                    wordsDictionary.Add(word, 1);
                }
            }

            return wordsDictionary
                .OrderBy(v => v.Value)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        public static void PrintDictionary(Dictionary<string,int> dictionary)
        {
            var maxCount = dictionary.Max(v => v.Value);
            var maxWordLength = dictionary.Max(v => v.Key.Length);
            
            dictionary
                .OrderBy(pair => pair.Value)
                .ToList()
                .ForEach(pair =>
                {
                    var underscoresCount = maxWordLength - pair.Key.Length;
                    var relativePart = (double)pair.Value / maxCount;
                    var dotsCount = (int)Math.Round(relativePart * 10, MidpointRounding.AwayFromZero);

                    Console.WriteLine(
                        $"{new string('_', underscoresCount)}" +
                        $"{pair.Key} " +
                        $"{new string('.', dotsCount)}");
                });
        }
    }
}