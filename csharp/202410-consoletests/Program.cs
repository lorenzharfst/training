using Words;
using System;

class Training
{
	static void Main(string[] args)
	{
		Word currentWord = new Word() { url = "https://www.dwds.de/wb/Mahnmal", name = "Mahnmal" };
		Console.WriteLine($"Word of the day: {currentWord.name}. URL: {currentWord.url}");
	}
}
