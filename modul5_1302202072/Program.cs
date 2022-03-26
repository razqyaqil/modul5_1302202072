using System;

namespace modul5_1302202072 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user1 = new SayaTubeUser("razqy");
            SayaTubeVideo video1 = new SayaTubeVideo("review film jujutsu kaisen 0 oleh razqy");
            video1.IncreasePlayCount(123123);
            SayaTubeVideo video2 = new SayaTubeVideo("review film mafia oleh razqy");
            video2.IncreasePlayCount(123123);
            SayaTubeVideo video3 = new SayaTubeVideo("review film mafia2 oleh razqy");
            video3.IncreasePlayCount(123123);
            SayaTubeVideo video4 = new SayaTubeVideo("review film batman darknight returns oleh razqy");
            video4.IncreasePlayCount(123123);
            SayaTubeVideo video5 = new SayaTubeVideo("review film shawshank redemption oleh razqy");
            video5.IncreasePlayCount(123123);
            SayaTubeVideo video6 = new SayaTubeVideo("review film deadpool oleh razqy");
            video6.IncreasePlayCount(123123);
            SayaTubeVideo video7 = new SayaTubeVideo("review film deadpool2 oleh razqy");
            video7.IncreasePlayCount(123123);
            SayaTubeVideo video8 = new SayaTubeVideo("review film peaky blinders oleh razqy");
            video8.IncreasePlayCount(123123);
            SayaTubeVideo video9 = new SayaTubeVideo("review film Josee, The tiger and The fish oleh razqy");
            video9.IncreasePlayCount(123123);
            SayaTubeVideo video10 = new SayaTubeVideo("review film Blade Runner oleh razqy");
            video10.IncreasePlayCount(123123);

            user1.addVideo(video1);
            user1.addVideo(video2);
            user1.addVideo(video3);
            user1.addVideo(video4);
            user1.addVideo(video5);
            user1.addVideo(video6);
            user1.addVideo(video7);
            user1.addVideo(video8);
            user1.addVideo(video9);
            user1.addVideo(video10);

            user1.PrintAllVideoPlayvoutn();

            Console.WriteLine("Total viewers:\n"+user1.getTotalVideoPlayCount());

        }
    }
}