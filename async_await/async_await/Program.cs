// See https://aka.ms/new-console-template for more information

public class Program
{
    //public static void Main(string[] args)
    //{
    //    var myAsyncClass = new AsyncClass();
    //    myAsyncClass.RetrieveDocsHomePage();
    //    string userName = Console.ReadLine();
    //    Console.WriteLine(userName);
    //}
   

    public static async Task Main(string[] args)
    {
        var myAsyncClass = new AsyncClass();
        int docLength = await myAsyncClass.RetrieveDocsHomePage();
        Console.WriteLine(docLength);
    }
}


public class AsyncClass
{
    public async Task<int> RetrieveDocsHomePage()
    {
        var client = new HttpClient();
        byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/");

        Console.WriteLine($"{nameof(RetrieveDocsHomePage)}: Finished downloading.");

        return content.Length;
    }
}