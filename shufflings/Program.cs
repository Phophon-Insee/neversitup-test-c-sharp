string input = Console.ReadLine() ?? "";

Main(input);

static void Main(string inputWord)
{
    List<char> listWord = inputWord.ToCharArray().ToList();
    List<string> shufflings = new(){inputWord};

    for (int i = 0; i < inputWord.Count(); i++)
        {
            for (int j = 0; j < inputWord.Count()-1; j++){
                char temporalyChar  = listWord[j];
                listWord[j] = listWord[j+1];
                listWord[j+1] = temporalyChar;
                string newWord = string.Join("", listWord);
                if(!shufflings.Contains(newWord)){
                    shufflings.Add(string.Join("", listWord));
                }
            }
        }

    string print = string.Join("', '", shufflings);
    Console.WriteLine("[ '" + print + "' ]");
} 