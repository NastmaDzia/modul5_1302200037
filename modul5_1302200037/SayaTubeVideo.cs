using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200037
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo() { }

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null);
            Contract.Requires(title.Length <= 200);
            this.title = title;

            var rand = new Random();
            this.id = rand.Next(10000, 99999);

            this.playCount = 0;
        }

        public void IncreasePlayCount(int a)
        {
            Contract.Requires(a <= 25000000);
            try
            {
                if (a > 25000000) throw new Exception("Jumlah input play count melebihi 25.000.000!");
                this.playCount = checked(this.playCount + a);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID\t: {0}", this.id);
            Console.WriteLine("Video Title\t: {0}", this.title);
            Console.WriteLine("Video Playcount\t: {0}\n", this.playCount);

        }
    }
}
