using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class Posts
	{
		public int ID { get; set; }
		public string Type { get; set; }
		public string Title { get; set; }
		public DateTime Publication { get; set; }
		public string MainImageUrl { get; set; }
		public string Article { get; set; }

		public Posts ()
		{
			
		}
	}
}

