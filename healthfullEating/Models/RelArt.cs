using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class RelArt
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string RelName { get; set; }
		public string RelUrl { get; set; }

        public virtual Recipe Recipe { get; set; }

		public RelArt (string Name, string URL)
		{
            this.RelName = Name;
            this.RelUrl = URL;
		}
	}
}

