using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static modul5_1302202072.SayaTubeVideo;



namespace modul5_1302202072
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            Debug.Assert(username == null, "username tidak boleh null");
            Debug.Assert(username.Length > 100, "panjang username tidak boleh lebih dari 100");
            this.username = username;

            var rand = new Random();
            this.id = rand.Next(10000, 99999);

            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int getTotalVideoPlayCount()
        {
            int totalVideoPlayCount = 0;
            foreach(var video in this.uploadedVideos)
            {
                totalVideoPlayCount = totalVideoPlayCount + video.getplaycount();
            }
            return totalVideoPlayCount;
        }

        public void addVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayvoutn()
        {
            int i = 0;
            foreach (var video in this.uploadedVideos)
            {
                Console.WriteLine("Username\t: "+this.username);
                Console.WriteLine("Judul-{0}\t\t: {1}\n",i+1, video.getTitle());

                i++;
            }
        }
    }
}
