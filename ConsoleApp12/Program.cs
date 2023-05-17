using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
class Program
{

    static void Main()
    {
        string json = File.ReadAllText(@"C:\Users\Lenova\Source\Repos\ConsoleApp12\ConsoleApp12\jsconfig1.json");
        var words = JsonConvert.DeserializeObject<List<Word>>(json);
        Functions.Dictionaryy(words);


    }

}
