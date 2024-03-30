using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SayaTubeUser
{
    private int id;
    private List<SayaTubeUser> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
        this.username = username;
        uploadedVideos = new List<SayaTubeUser>();
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (SayaTubeVideo video in uploadedVideos)
        {
            total += video getPlayCount();
        }
        return total;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + this.username);
        for (int i = 1; i < uploadedVideos.Count; i++)
        {
            SayaTubeVideo item = uploadedVideos[i];
            Console.WriteLine("Video " + i + " " + item.getTitle);
        }
    }

}