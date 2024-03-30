using System.Diagnostics.Contracts;
using System.Numerics;

namespace modul6_1302220129
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user= new SayaTubeUser("deb");
            SayaTubeVideo video = new SayaTubeVideo("video apa aja");
            SayaTubeVideo video1 = new SayaTubeVideo("video apa aja");
            SayaTubeVideo video2 = new SayaTubeVideo("video apa aja");
            SayaTubeVideo video3 = new SayaTubeVideo("video apa aja");
            SayaTubeVideo video4 = new SayaTubeVideo("video apa aja");
            SayaTubeVideo video5 = new SayaTubeVideo("video apa aja");
            SayaTubeVideo video6 = new SayaTubeVideo("video apa aja");
            SayaTubeVideo video7 = new SayaTubeVideo("video apa aja");
            SayaTubeVideo video8 = new SayaTubeVideo("video apa aja");
            SayaTubeVideo video9 = new SayaTubeVideo("video apa aja");
            user.AddVideo(video);
            user.PrintAllVideoPlaycount();
        }
    }
}
