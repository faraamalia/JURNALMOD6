using System;
using System.Diagnostics;

public class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadedVideos;
	private string usn;
	public SayaTubeUser(string Username)
    {
        Debug.Assert(Username != null);
        Debug.Assert(Username.Length < 101);
        usn = Username;
        uploadedVideos = new List<SayaTubeVideo>();

    }

	public int GetTotalVideoPlayCount()
    {
        int count = 0;
        foreach()
        return count;
    }

    public void AddVideo(SayaTubeVideo uploadedVideos)
    {
        
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User: " + Username);
        Console.WriteLine("Video 1 judul: " + title)
    }
}
