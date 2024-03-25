using System;
using System.Diagnostics;

public class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadedVideos;
	public string usn;
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
        foreach(SayaTubeVideo video in uploadedVideos)
        {
            count += video.GetPlayCount() ;
        } 
        return count;
    }

    public void AddVideo(SayaTubeVideo upv)
    {
        Debug.Assert(upv != null);
        Debug.Assert(upv.GetPlayCount() < 100000000);
        uploadedVideos.Add(upv);
        
    }

    public void PrintAllVideoPlayCount()
    {
        for(int i = 0; i < uploadedVideos.Count || i < 8; i++) 
        {
            Console.WriteLine("Video " + (i++) + "judul: " + uploadedVideos[i].ttl + uploadedVideos[i].GetPlayCount());
        }
    }
}
