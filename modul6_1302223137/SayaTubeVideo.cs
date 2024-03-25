using System;
using System.Diagnostics;

public class SayaTubeVideo
{
	private int id;
	public string ttl;
	private int playCount;
	public SayaTubeVideo(string title)
	{
		Debug.Assert(title != null);
		Debug.Assert(title.Length < 201);
		ttl = title;
		playCount = 0;
		Random generator = new Random();
		id = generator.Next(10000, 99999);
		
	}

	public int GetPlayCount()
	{
		return playCount;
	}

	public void IncreasePlayCount(int PC)
	{
		Debug.Assert(PC < 25000000);
		Debug.Assert(PC > 0);
		int uc;
		try
		{
			uc = checked(playCount + PC);
		}
		catch
		{
			Console.WriteLine("PlayCount melebihi kapasitas dan tidak ter-update");
			uc = playCount;
		}
		playCount = uc;
	}

	public void PrintVideoDetails()
	{
        Console.Write("ID: " + id);
        Console.WriteLine(" ");
        Console.Write("Title: " + ttl);
        Console.WriteLine(" ");
        Console.Write("Jumlah putar: " + playCount);
    }

}
