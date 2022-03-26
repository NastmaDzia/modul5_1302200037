using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200037
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string Username;

        public SayaTubeUser(String username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.Username = username;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
                total = total + uploadedVideos[i].getPlayCount();

            return total;
        }

        public void AddVideo(SayaTubeVideo a)
        {
            uploadedVideos.Add(a);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + this.Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
                Console.WriteLine("Video " + (i + 1) + " Judul: " + uploadedVideos[i].getTitle());
            Console.WriteLine();
            Console.WriteLine("Total semua playcount : " + GetTotalVideoPlayCount());

        }
    }
}
