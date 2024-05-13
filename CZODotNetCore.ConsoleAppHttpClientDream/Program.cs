using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

string jsonStr = await File.ReadAllTextAsync("DreamDictionary.json");
var model = JsonConvert.DeserializeObject<MainDto2>(jsonStr);

//Console.WriteLine(jsonStr);

foreach (var question in model.BlogHeader)
{
    Console.WriteLine(question.BlogId);
}
// JSON to C# ??? package 
// C# to JSON

Console.ReadLine();


public class MainDto2
{
    public Blogheader[] BlogHeader { get; set; }
    public Blogdetail[] BlogDetail { get; set; }
}

public class Blogheader
{
    public int BlogId { get; set; }
    public string BlogTitle { get; set; }
}

public class Blogdetail
{
    public int BlogDetailId { get; set; }
    public int BlogId { get; set; }
    public string BlogContent { get; set; }
}
