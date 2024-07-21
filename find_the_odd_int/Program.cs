string input = Console.ReadLine() ?? "";
input = input.Replace("[", string.Empty);
input = input.Replace("]", string.Empty);
List<string> listInput = input.Split(',').ToList();

Main(listInput);

static void Main(List<string> listInput)
{
    string isOdd = "";
    Dictionary<string,int> intDic = new();
    foreach (string input in listInput){
        if(intDic.ContainsKey(input)){
            intDic[input] = intDic[input] + 1;
        }else{
            intDic.Add(input, 1);
        }
    }
    foreach (KeyValuePair<string, int> dic in intDic){
        if(dic.Value % 2 != 0){
                isOdd = dic.Key;
            }
    }
    Console.WriteLine(isOdd);
} 