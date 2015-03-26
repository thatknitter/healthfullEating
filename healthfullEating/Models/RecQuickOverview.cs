using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class RecQuickOverview
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string QuickOver { get; set; }

        public virtual Recipe Recipe { get; set; }

		public RecQuickOverview (string Overview)
		{
            this.QuickOver = Overview;
		}

	}
}

