using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace modul5_1302202072
{
	public class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;



		public SayaTubeVideo() { }
		public SayaTubeVideo(string title)
		{
			Debug.Assert(title == null, "judul tidak boleh null");
			Debug.Assert(title.Length > 100, "panjang judul tidak boleh lebih dari 100");
			this.title = title;

			var rand = new Random();
			this.id = rand.Next(10000, 99999);

			this.playCount = 0;
		}
		
		public int getplaycount()
        {
			return this.playCount;
        }
		public void setPlaycount(int x)
        {
			this.playCount = x;
        }

		public string getTitle()
		{
			return this.title;
		}
		public void setTitle(String x)
		{
			this.title = x;
		}

		public void IncreasePlayCount(int a)
		{
			
			try
			{
				if (a > 10000000) throw new Exception("Jumlah input play count melebihi 10.000.000!");
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