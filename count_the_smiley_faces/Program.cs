string input = Console.ReadLine() ?? "";
input = input.Replace("['", string.Empty);
input = input.Replace("']", string.Empty);
List<string> listInput = input.Split("', '").ToList();

Main(listInput);

static void Main(List<string> listInput)
{
    int faces = 0;
    foreach (string input in listInput)
    {
        if (input.IndexOf(':') == 0 || input.IndexOf(';') == 0)
        {
            if (input.Count() > 2 && input.IndexOf('-') != 1 && input.IndexOf('~') != 1)
            {
                continue;
            }
            if (input.IndexOf(')') == input.Count() - 1 || input.IndexOf('D') == input.Count() - 1)
            {
                faces++;
            }
        }
    }
    Console.WriteLine(faces);
}