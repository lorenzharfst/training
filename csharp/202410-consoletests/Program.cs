using Words;
using System;

public class Shape
{
	public virtual void Draw()
	{
		Console.WriteLine("Here would happen the core act of drawing.");
	}
	public virtual void Inform()
	{
		Console.WriteLine("Here we inform the user of the process finishing.");
	}
}

public class Circle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("Specifically drawing a circle.");
		base.Draw();
		base.Inform();
		Inform();
	}
}

class Training
{
	static void Main(string[] args)
	{
		Word currentWord = new Word() { url = "https://www.dwds.de/wb/Mahnmal", name = "Mahnmal" };
		Console.WriteLine($"Word of the day: {currentWord.name}. URL: {currentWord.url}");

		Circle circle = new Circle();
		circle.Draw();
	}
}
