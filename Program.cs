//Task.Delay(10000).Wait();
//Console.WriteLine("Download File01!");

//Task.Delay(10000).Wait();
//Console.WriteLine("Download File02!");

DownloadFile("File01");
DownloadFile("File02");

Console.WriteLine("Start data input, Enter your name");
string str = Console.ReadLine();
Console.WriteLine(str);

static async void DownloadFile(string fileName)
{
    await Task.Delay(10000);
    Console.WriteLine($"Download {fileName}!");
}