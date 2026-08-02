using System;
using System.Threading.Tasks;

Console.WriteLine("Asynchronous Programming");

Console.WriteLine("Starting file download...");
Task<string> downloadTask = DownloadFileAsync("https://www.pinterest.com/pin/829225350197468071/");

Console.WriteLine("Asynchronously counting!");
for (int i = 0; i < 5; i++)
{
    await Task.Delay(1000); 
    Console.Write($"{i + 1}/5  ");
}

string filePath = await downloadTask;
Console.WriteLine($"\nDownload completed!");
async Task<string> DownloadFileAsync(string url)
{
    Console.WriteLine($"Downloading file from\n{url}...");
    await Task.Delay(5000); 
    string filePath = "C:\\Users\\shres\\DotNet\\Lab7\\image.jpg"; 
    Console.WriteLine("\nFile downloaded to memory.");
    return filePath;
}
