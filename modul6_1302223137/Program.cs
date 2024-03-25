using System;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo objV = new SayaTubeVideo("Little Women");
        int itr = 1;
        for(int i = 0; i < itr; i++)
        {
            objV.IncreasePlayCount(200000);

        }
        objV.PrintVideoDetails();

        SayaTubeUser objU = new SayaTubeUser("Farah");
        objU.AddVideo(objV);

        SayaTubeVideo objr = new SayaTubeVideo("ABC");
        objU.AddVideo(objr);

        SayaTubeVideo objV2 = new SayaTubeVideo("DEF"); 
        objV2.IncreasePlayCount(20);

        objU.AddVideo(objV2);

        objU.AddVideo(new SayaTubeVideo("GEF"));

        objU.AddVideo(new SayaTubeVideo("Marvel"));

        objU.AddVideo(new SayaTubeVideo("Spongebob"));

        objU.AddVideo(new SayaTubeVideo("afafewwetg"));

        objU.AddVideo(new SayaTubeVideo("yeyedyedyy"));

        objU.AddVideo(new SayaTubeVideo("uioiuupu"));

        Console.WriteLine("Jumlah Count Semua Video: " + objU.GetTotalVideoPlayCount());

        objU.GetTotalVideoPlayCount();
    }
}